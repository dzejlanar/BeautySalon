using BeautySalon.Model.Requests;
using BeautySalon.Model.ViewModels;
using BeautySalon.WinUI.Properties;
using BeautySalon.WinUI.Service;
using System.ComponentModel;

namespace BeautySalon.WinUI.Forms.Service
{
    public partial class frmAddService : Form
    {
        private readonly ApiService _categoryService = new ApiService("ServiceCategory");
        private readonly ApiService _serviceService = new ApiService("Service");
        private ServiceVM? _service = null;

        public frmAddService(ServiceVM? service = null)
        {
            InitializeComponent();

            if (service != null)
                _service = service;

            cmbCategory.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        private async void frmAddService_Load(object sender, EventArgs e)
        {
            await loadServiceCategories();

            if (_service != null)
            {

                lbl_Header.Text = "Edit service";
                txtName.Text = _service.Name;
                txtDuration.Text = _service.Duration.ToString();
                txtPrice.Text = _service.Price.ToString();
                rtbDescription.Text = _service.Description;
                cmbCategory.SelectedText = _service.CategoryName;
                cmbCategory.SelectedValue = _service.CategoryId;
            }
        }

        private async Task loadServiceCategories()
        {
            var result = await _categoryService.GetAll<List<ServiceCategoryVM>>();

            cmbCategory.DataSource = result;
            cmbCategory.DisplayMember = "Name";
            cmbCategory.ValueMember = "CategoryId";
        }

        private async void btnSave_Click(object sender, EventArgs e)
        {
            if (ValidateChildren())
            {
                ServiceUpsertRequest request = new ServiceUpsertRequest()
                {
                    Name = txtName.Text,
                    CategoryId = int.Parse(cmbCategory.SelectedValue.ToString()),
                    Description = rtbDescription.Text,
                    Price = decimal.Parse(txtPrice.Text),
                    Duration = double.Parse(txtDuration.Text)
                };

                if (_service == null)
                {
                    try
                    {
                        await _serviceService.Insert<ServiceVM>(request);
                    }
                    catch
                    {
                        return;
                    }
                }
                else
                {
                    try
                    {
                        await _serviceService.Update<ServiceVM>(_service.ServiceId, request);
                    } 
                    catch
                    {
                        return;
                    }
                    MessageBox.Show(Resources.EditSuccessful, string.Empty, MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                frmServiceList frmServiceList = new frmServiceList();
                FormMaker.createForm(frmServiceList, this);
            }
        }

        private void txtName_Validating(object sender, CancelEventArgs e)
        {
            Validator.requiredFieldTxt(txtName, e, errorProvider, Resources.RequiredField);
        }

        private void txtDescription_Validating(object sender, CancelEventArgs e)
        {
            Validator.validateRichTxt(rtbDescription, e, errorProvider, Resources.RequiredField);
        }

        private void cmbCategory_Validating(object sender, CancelEventArgs e)
        {
            Validator.requiredComboBox(cmbCategory, e, errorProvider, Resources.RequiredField);
        }
        private void txtPrice_Validating(object sender, CancelEventArgs e)
        {
            Validator.requiredFieldTxtNumber(txtPrice, e, errorProvider, Resources.RequiredField);
        }

        private void txtDuration_Validating(object sender, CancelEventArgs e)
        {
            Validator.requiredFieldTxtNumber(txtDuration, e, errorProvider, Resources.RequiredField);
        }
    }
}

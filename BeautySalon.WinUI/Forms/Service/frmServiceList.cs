using BeautySalon.Model.SearchObjects;
using BeautySalon.Model.ViewModels;
using BeautySalon.WinUI.Service;

namespace BeautySalon.WinUI.Forms.Service
{
    public partial class frmServiceList : Form
    {
        public ApiService service { get; set; } = new ApiService("Service");

        public frmServiceList()
        {
            InitializeComponent();
            dgvServices.AutoGenerateColumns = false;
        }

        private async void frmServiceList_Load(object sender, EventArgs e)
        {
            await loadServices();
        }

        private async Task loadServices(ServiceSearchObject? searchObject = null)
        {
            var servicesList = await service.GetAll<List<ServiceVM>>(searchObject);
            dgvServices.DataSource = servicesList;
        }

        private void dgvServices_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var senderGrid = (DataGridView)sender;

            if (senderGrid.Columns[e.ColumnIndex] is DataGridViewButtonColumn && e.RowIndex >= 0)
            {
                int rowIndex = senderGrid.CurrentCell.RowIndex;
                var item = senderGrid.Rows[rowIndex].DataBoundItem as ServiceVM;

                frmAddService frmAddService = new frmAddService(item);
                FormMaker.createForm(frmAddService, this);
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            frmAddService frmAddService = new frmAddService();
            FormMaker.createForm(frmAddService, this);
        }

        private async void tb_Search_TextChanged(object sender, EventArgs e)
        {
            var searchObject = new ServiceSearchObject
            {
                NameGT = tb_Search.Text
            };

            await loadServices(searchObject);
        }
    }
}

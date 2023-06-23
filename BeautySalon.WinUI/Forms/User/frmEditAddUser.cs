using BeautySalon.Model.Requests;
using BeautySalon.Model.ViewModels;
using BeautySalon.WinUI.Properties;
using BeautySalon.WinUI.Service;
using System.ComponentModel;
using System.Data;

namespace BeautySalon.WinUI.Forms.User
{
    public partial class frmEditAddUser : Form
    {
        private UserVM? _user = null;
        private ApiService userService = new ApiService("User");
        private ApiService roleService = new ApiService("Role");

        public frmEditAddUser(UserVM? user = null)
        {
            InitializeComponent();

            if (user != null)
                _user = user;

            cmb_Gender.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        private async void frmEditAddUser_Load(object sender, EventArgs e)
        {
            populateGenderCmb();
            await loadRoles();

            if (_user != null)
            {
                lbl_Header.Text = "Edit user";
                tb_Username.Enabled = false;
                tb_Username.Text = _user.Username;

                tb_EmailAddress.Enabled = false;
                tb_EmailAddress.Text = _user.Email;

                tb_FirstName.Text = _user.FirstName;
                tb_LastName.Text = _user.LastName;
                cmb_Gender.SelectedIndex = cmb_Gender.FindStringExact(_user.Gender);
                dtp_DateOfBirth.Value = _user.DateOfBirth;
                tb_Address.Text = _user.Address;
                cb_IsActive.Checked = _user.IsActive;

                for (int i = 0; i < clb_Roles.Items.Count; i++)
                {
                    if (_user.RoleNames.Contains(clb_Roles.GetItemText(clb_Roles.Items[i])))
                        clb_Roles.SetItemChecked(i, true);
                }
            }
        }

        private void populateGenderCmb()
        {
            var genderList = new List<string>
            {
                "Male",
                "Female"
            };

            cmb_Gender.DataSource = genderList;
        }

        private async Task loadRoles()
        {
            var result = await roleService.GetAll<List<RoleVM>>();

            clb_Roles.DataSource = result;
            clb_Roles.DisplayMember = "RoleName";
        }

        private async void btn_Save_Click(object sender, EventArgs e)
        {
            if (ValidateChildren())
            {
                var roleList = clb_Roles.CheckedItems.Cast<RoleVM>().ToList();
                var roleIdList = roleList.Select(r => r.RoleId).ToList();

                if (_user != null)
                {
                    var request = new UserUpdateRequest
                    {
                        FirstName = tb_FirstName.Text,
                        LastName = tb_LastName.Text,
                        IsActive = cb_IsActive.Checked,
                        Gender = cmb_Gender.Text,
                        DateOfBirth = dtp_DateOfBirth.Value,
                        RoleIds = roleIdList
                    };

                    if (!string.IsNullOrWhiteSpace(tb_Password.Text))
                    {
                        request.Password = tb_Password.Text;
                        request.PasswordConfirmation = tb_PasswordConfirmation.Text;
                    }

                    if (!string.IsNullOrWhiteSpace(tb_Address.Text))
                        request.Address = tb_Address.Text;

                    try
                    {
                        await userService.Update<UserVM>(_user.UserId, request);
                    }
                    catch
                    {
                        return;
                    }

                    if (ApiService.username != null && ApiService.username.Equals(_user.Username) && !string.IsNullOrWhiteSpace(tb_Password.Text))
                    {
                        ApiService.password = tb_Password.Text;
                    }

                    MessageBox.Show(Resources.EditSuccessful, string.Empty, MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    var request = new UserInsertRequest
                    {
                        Email = tb_EmailAddress.Text,
                        Username = tb_Username.Text,
                        FirstName = tb_FirstName.Text,
                        LastName = tb_LastName.Text,
                        Password = tb_Password.Text,
                        PasswordConfirmation = tb_PasswordConfirmation.Text,
                        Address = tb_Address.Text,
                        RoleIds = roleIdList,
                        IsActive = cb_IsActive.Checked,
                        Gender = cmb_Gender.Text,
                        DateOfBirth = dtp_DateOfBirth.Value,
                    };

                    try
                    {
                        await userService.Insert<UserVM>(request);
                    } 
                    catch
                    {
                        return;
                    }
                }

                frmUserList frmUserList = new frmUserList();
                FormMaker.createForm(frmUserList, this);
            }
        }

        private void tb_Username_Validating(object sender, CancelEventArgs e)
        {
            Validator.requiredFieldTxt(tb_Username, e, errorProvider, Resources.RequiredField);
        }

        private void tb_EmailAddress_Validating(object sender, CancelEventArgs e)
        {
            Validator.requiredFieldTxt(tb_EmailAddress, e, errorProvider, Resources.RequiredField);
        }

        private void tb_FirstName_Validating(object sender, CancelEventArgs e)
        {
            Validator.requiredFieldTxt(tb_FirstName, e, errorProvider, Resources.RequiredField);
        }

        private void tb_LastName_Validating(object sender, CancelEventArgs e)
        {
            Validator.requiredFieldTxt(tb_LastName, e, errorProvider, Resources.RequiredField);
        }

        private void cmb_Gender_Validating(object sender, CancelEventArgs e)
        {
            Validator.requiredComboBox(cmb_Gender, e, errorProvider, Resources.RequiredField);
        }

        private void tb_Password_Validating(object sender, CancelEventArgs e)
        {
            if (_user == null)
                Validator.passwordValidator(tb_Password, e, errorProvider, Resources.PasswordError);
            else
                Validator.passwordLengthValidator(tb_Password, e, errorProvider, Resources.PasswordLengthError);
        }

        private void tb_PasswordConfirmation_Validating(object sender, CancelEventArgs e)
        {
            if (_user == null || tb_Password.Text.Length > 0)
                Validator.requiredFieldTxt(tb_PasswordConfirmation, e, errorProvider, Resources.RequiredField);
        }  
    }
}

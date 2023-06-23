using BeautySalon.Model.ViewModels;
using BeautySalon.WinUI.Service;
using System.ComponentModel;

namespace BeautySalon.WinUI.Forms
{
    public partial class frmLogin : Form
    {
        private readonly ApiService service = new ApiService("User");
        public frmLogin()
        {
            InitializeComponent();
        }

        private async void btn_Login_ClickAsync(object sender, EventArgs e)
        {
            ApiService.username = txtUsername.Text;
            ApiService.password = txtPassword.Text;
            try
            {
                if (ValidateChildren())
                {

                    var users = await service.GetAll<IEnumerable<UserVM>>();
                    ApiService.authenticatedUser = users?.FirstOrDefault(user => user.Username == ApiService.username);

                    var userRoles = new List<string>();
                    if (ApiService.authenticatedUser != null)
                    {
                        ApiService.authenticatedUser.UserRoles.ToList().ForEach(ur => userRoles.Add(ur.Role.RoleName));

                        if (!userRoles.Contains("Admin"))
                        {
                            MessageBox.Show("Access Denied!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        else
                        {
                            var frmParent = new frmParent();
                            this.Hide();
                            frmParent.Show();
                        }
                    }
                    else
                    {
                        MessageBox.Show("Access Denied!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch
            {
                MessageBox.Show("Incorrect user credentials.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtUsername_Validating(object sender, CancelEventArgs e)
        {
            Validator.requiredFieldTxt(sender as TextBox, e, errorProvider, "Username is required.");
        }

        private void txtPassword_Validating(object sender, CancelEventArgs e)
        {
            Validator.requiredFieldTxt(sender as TextBox, e, errorProvider, "Password is required.");
        }
    }
}

using BeautySalon.WinUI.Forms.Service;
using BeautySalon.WinUI.Forms.User;
using BeautySalon.WinUI.Service;

namespace BeautySalon.WinUI.Forms
{
    public partial class frmParent : Form
    {
        public frmParent()
        {
            InitializeComponent();
        }

        private void btnServices_Click(object sender, EventArgs e)
        {
            frmServiceList frmServiceList = new frmServiceList();

            FormMaker.createFormFromParent(frmServiceList, this, rightPanel);
        }

        private void btnReservations_Click(object sender, EventArgs e)
        {

        }

        private void btnTransactions_Click(object sender, EventArgs e)
        {

        }

        private void btnUsers_Click(object sender, EventArgs e)
        {
            frmUserList frmUserList = new frmUserList();

            FormMaker.createFormFromParent(frmUserList, this, rightPanel);
        }

        private void btnReports_Click(object sender, EventArgs e)
        {

        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            ApiService.username = null;
            ApiService.password = null;

            frmLogin frmLogin = new frmLogin();

            Close();
            frmLogin.Show();
        }
    }
}

using BeautySalon.Model.SearchObjects;
using BeautySalon.Model.ViewModels;
using BeautySalon.WinUI.Service;

namespace BeautySalon.WinUI.Forms.User
{
    public partial class frmUserList : Form
    {
        public ApiService service { get; set; } = new ApiService("User");
        private string searchType { get; set; } = "Name";

        public frmUserList()
        {
            InitializeComponent();
            dgvUsers.AutoGenerateColumns = false;
        }

        private async void frmUserList_Load(object sender, EventArgs e)
        {
            await loadUsers();
        }

        private async Task loadUsers(UserSearchObject? searchObject = null)
        {
            var usersList = await service.GetAll<List<UserVM>>(searchObject);
            dgvUsers.DataSource = usersList;
        }

        private async void tb_Search_TextChanged(object sender, EventArgs e)
        {
            var searchObject = new UserSearchObject();
            if (searchType == "Name")
            {
                searchObject = new UserSearchObject
                {
                    FirstLastNameGT = tb_Search.Text
                };
            }

            if (searchType == "Email")
            {
                searchObject = new UserSearchObject
                {
                    Email = tb_Search.Text
                };
            }

            await loadUsers(searchObject);
        }

        private void rb_Email_CheckedChanged(object sender, EventArgs e)
        {
            searchType = "Email";
        }

        private void rb_Name_CheckedChanged(object sender, EventArgs e)
        {
            searchType = "Name";
        }

        private void dgvUsers_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            var item = dgvUsers.SelectedRows[0].DataBoundItem as UserVM;

            frmEditAddUser frmEditAddUser = new frmEditAddUser(item);
            FormMaker.createForm(frmEditAddUser, this);
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            frmEditAddUser frmEditAddUser = new frmEditAddUser();
            FormMaker.createForm(frmEditAddUser, this);
        }
    }
}

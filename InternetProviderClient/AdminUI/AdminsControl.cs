using System.Windows.Forms;
using Service.AdminService;
using Service.DataBaseControllers;

namespace InternetProviderClient.AdminUI
{
    public partial class AdminsControl : UserControl
    {
        public AdminsControl()
        {
            InitializeComponent();
            LoadData();
        }

        private async void LoadData()
        {
            table.DataSource = await new DataBase().GetListAsync(new AdminController());
        }

        private void btnAdd_Click(object sender, System.EventArgs e)
        {
            var regAdminForm = new AdminEditingForm();

            if(regAdminForm.ShowDialog(this) is DialogResult.OK)
            {
                var adminEditing = new AdminEditing(regAdminForm);
                adminEditing.Add();
            }
        }

        private void btnRemove_Click(object sender, System.EventArgs e)
        {
           if(MessageBox.Show("Объект будет удален безвозвратно.\nВы уверены?","Уведомление", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) is DialogResult.Yes)
            {
                new DataBase().Remove(table.GetEntityId(), new AdminController());
            }
        }

        private async void btnEdit_Click(object sender, System.EventArgs e)
        {
            var regAdminForm = new AdminEditingForm();
            regAdminForm.groupBox3.Enabled = false;

            var admin = await new DataBase().GetEntityByName(table.GetEntityId(), new AdminController());
            regAdminForm.FullingFields(admin.FirstName, admin.SecondName, admin.MiddleName, admin.Phone);

            if (regAdminForm.ShowDialog(this) is DialogResult.OK)
            {
                var adminEditing = new AdminEditing(regAdminForm);
                adminEditing.Edit(admin);
            }
        }
    }
}

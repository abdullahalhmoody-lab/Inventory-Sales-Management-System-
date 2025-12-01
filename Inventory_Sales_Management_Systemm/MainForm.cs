using System;
using System.Windows.Forms;

namespace Inventory_Sales_Management_Systemm
{
    public partial class MainForm : Form
    {
        // سيتم تعبئتها من LoginForm
        public string CurrentUser { get; set; }
        public string UserRole { get; set; }

        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            // عرض اسم المستخدم في أسفل الصفحة
            lblUserInfo.Text = $"المستخدم: {CurrentUser} | الصلاحية: {UserRole}";

            // التحكم بالصلاحيات حسب الدور
           // ApplyPermissions();
        }

        //private void ApplyPermissions()
        //{
        //    if (UserRole == "Sales")
        //    {
        //        menuReports.Enabled = false;
        //        menuPersonnelManagement.Enabled = false;
        //    }
        //    else if (UserRole == "Manager")
        //    {
        //        menuPersonnelManagement.Enabled = false;
        //    }
        //    // Admin له جميع الصلاحيات
        //}

        private void menuProducts_Click(object sender, EventArgs e)
        {
            ProductsForm frm = new ProductsForm();
            frm.StartPosition = FormStartPosition.CenterScreen;
            frm.Show();
        }

        private void menuCustomers_Click(object sender, EventArgs e)
        {
            CustomersForm frm = new CustomersForm();
            frm.StartPosition = FormStartPosition.CenterScreen;
            frm.Show();
        }

        private void menuSales_Click(object sender, EventArgs e)
        {
            SalesForm frm = new SalesForm();
            frm.StartPosition = FormStartPosition.CenterScreen;
            frm.Show();
        }

        private void menuReports_Click(object sender, EventArgs e)
        {
            ReportsForm frm = new ReportsForm();
            frm.StartPosition = FormStartPosition.CenterScreen;
            frm.Show();
        }

        private void menuPersonnelManagement_Click(object sender, EventArgs e)
        {
            EmployeeManagementForm frm = new EmployeeManagementForm();
            frm.StartPosition = FormStartPosition.CenterScreen;
            frm.Show();
        }

        private void menuLogout_Click(object sender, EventArgs e)
        {
            this.Hide();
            LoginForm login = new LoginForm();
            login.StartPosition = FormStartPosition.CenterScreen;
            login.Show();
        }
    }
}

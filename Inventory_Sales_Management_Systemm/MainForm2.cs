using System;
using System.Windows.Forms;

namespace Inventory_Sales_Management_Systemm
{
    public partial class MainForm2 : Form
    {
        // سيتم تعبئتها من LoginForm
        public string CurrentUser { get; set; }
        public string UserRole { get; set; }

        public MainForm2()
        {
            InitializeComponent();
        }

        private void MainForm2_Load(object sender, EventArgs e)
        {
           // lblUserInfo.Text = $"المستخدم: {CurrentUser} | الصلاحية: {UserRole}";

            // التحكم بالصلاحيات حسب الدور
            //ApplyPermissions();
            // عرض اسم المستخدم والصلاحية
        }

        // زر المنتجات
        private void menuProducts2_Click(object sender, EventArgs e)
        {
            this.Hide();
            ProductsForm frm = new ProductsForm();
            frm.PreviousForm = "MainForm2";
            frm.StartPosition = FormStartPosition.CenterScreen;
            frm.Show();
        }

        // زر العملاء
        private void menuCustomers2_Click(object sender, EventArgs e)
        {
            this.Hide();
            CustomersForm frm = new CustomersForm();
            frm.StartPosition = FormStartPosition.CenterScreen;
            frm.Show();
        }

        // زر المبيعات
        private void menuSales2_Click(object sender, EventArgs e)
        {
            this.Hide();
            SalesForm frm = new SalesForm();
            frm.StartPosition = FormStartPosition.CenterScreen;
            frm.Show();
        }

        // زر التقارير
        private void menuReports2_Click(object sender, EventArgs e)
        {
            this.Hide();
            ReportsForm frm = new ReportsForm();
            frm.PreviousForm = "MainForm2";
            frm.StartPosition = FormStartPosition.CenterScreen;
            frm.Show();
        }

        // زر تسجيل الخروج (button5)
        //private void button5_Click(object sender, EventArgs e)
        //{
        //    this.Hide();
        //    LoginForm login = new LoginForm();
        //    login.StartPosition = FormStartPosition.CenterScreen;
        //    login.Show();
        //}

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void menuCustomers2_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            CustomersForm frm = new CustomersForm();
            frm.PreviousForm = "MainForm2";
            frm.StartPosition = FormStartPosition.CenterScreen;
            frm.Show();
        }

        private void menuReports2_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            ReportsForm frm = new ReportsForm();
            frm.PreviousForm = "MainForm2";
            frm.StartPosition = FormStartPosition.CenterScreen;
            frm.Show(); 
        }

        private void menuSales2_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            SalesForm frm = new SalesForm();
            frm.PreviousForm = "MainForm2";
            frm.StartPosition = FormStartPosition.CenterScreen;
            frm.Show();
        }

        private void button5_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            LoginForm login = new LoginForm();
            login.StartPosition = FormStartPosition.CenterScreen;
            login.Show();
        }
    }
}

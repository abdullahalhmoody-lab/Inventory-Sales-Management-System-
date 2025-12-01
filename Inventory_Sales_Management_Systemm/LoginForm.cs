using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Inventory_Sales_Management_Systemm
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        // زر تسجيل الدخول
        private void btnLogin_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text.Trim();
            string password = txtPassword.Text.Trim();

            if (username == "" || password == "")
            {
                MessageBox.Show("الرجاء إدخال اسم المستخدم وكلمة المرور");
                return;
            }

            // تشفير كلمة المرور
            string hashedPassword = SecurityHelper.HashPassword(password);

            // 1) التحقق أولاً من جدول UsersLogin (المدير)
            string queryAdmin = @"
        SELECT Username, RoleId 
        FROM UsersLogin
        WHERE Username = @u AND Password = @p";

            DataTable adminDT = DBHelper.ExecuteDataTable(queryAdmin,
                new SqlParameter("@u", username),
                new SqlParameter("@p", hashedPassword));

            if (adminDT.Rows.Count == 1)
            {
                // دخول المدير
                MainForm main = new MainForm();
                main.CurrentUser = username;
                main.UserRole = "Admin";
                this.Hide();
                main.Show();
                return;
            }

            // 2) التحقق ثانياً من جدول Employees (الموظفين)
            string queryEmp = @"
        SELECT Username, RoleId 
        FROM Employees
        WHERE Username = @u AND Password = @p AND State = 'Active'";

            DataTable empDT = DBHelper.ExecuteDataTable(queryEmp,
                new SqlParameter("@u", username),
                new SqlParameter("@p", hashedPassword));

            if (empDT.Rows.Count == 1)
            {
                int role = Convert.ToInt32(empDT.Rows[0]["RoleId"]);

                MainForm2 main2 = new MainForm2();
                main2.CurrentUser = username;

                if (role == 2) main2.UserRole = "Seller";
                else if (role == 3) main2.UserRole = "Manager";
                else main2.UserRole = "Employee";

                this.Hide();
                main2.Show();
                return;
            }

            // إذا لم نجد المستخدم في أي جدول
            MessageBox.Show("⚠ اسم المستخدم أو كلمة المرور غير صحيحة");
        }

        private void txtUsername_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
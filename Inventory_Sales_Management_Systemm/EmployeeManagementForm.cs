using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Inventory_Sales_Management_Systemm
{
    public partial class EmployeeManagementForm : Form
    {
        int selectedId = 0;

        // ⭐ متغير لمعرفة الصفحة التي جاء منها المستخدم
        public string PreviousForm { get; set; }

        public EmployeeManagementForm()
        {
            InitializeComponent();
        }

        
        // عند تحميل الفورم
        private void EmployeeManagementForm_Load(object sender, EventArgs e)
        {
            LoadRoles();
            LoadEmployees();
        }

        
        // الرجوع الذكي
        
        private void button1_Click(object sender, EventArgs e)
        {
            if (PreviousForm == "MainForm")
            {
                MainForm main = new MainForm();
                main.StartPosition = FormStartPosition.CenterScreen;
                main.Show();
            }
            else if (PreviousForm == "MainForm2")
            {
                MainForm2 main2 = new MainForm2();
                main2.StartPosition = FormStartPosition.CenterScreen;
                main2.Show();
            }

            this.Close();
        }

        
        // تحميل الصلاحيات
       
        private void LoadRoles()
        {
            string query = "SELECT RoleId, RoleName FROM Roles";
            DataTable dt = DBHelper.ExecuteDataTable(query);

            cmbRole.DataSource = dt;
            cmbRole.DisplayMember = "RoleName";
            cmbRole.ValueMember = "RoleId";
            cmbRole.SelectedIndex = -1;
        }

       
        // تحميل الموظفين
       
        private void LoadEmployees()
        {
            string query =
                @"SELECT Employees.EmpId, Employees.Username, Employees.Password,
                         Roles.RoleName, Employees.CreatedAt, Employees.State
                  FROM Employees
                  JOIN Roles ON Roles.RoleId = Employees.RoleId
                  ORDER BY EmpId DESC";

            DataTable dt = DBHelper.ExecuteDataTable(query);

            dgvEmployees.Rows.Clear();

            foreach (DataRow row in dt.Rows)
            {
                dgvEmployees.Rows.Add(
                    row["EmpId"],
                    row["Username"],
                    row["Password"],
                    row["RoleName"],
                    row["CreatedAt"],
                    row["State"]
                );
            }
        }

        
        // اختيار عنصر من الجدول
        private void dgvEmployees_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            selectedId = Convert.ToInt32(dgvEmployees.Rows[e.RowIndex].Cells[0].Value);

            txtUsername.Text = dgvEmployees.Rows[e.RowIndex].Cells[1].Value.ToString();
            txtPassword.Text = "";
            cmbRole.Text = dgvEmployees.Rows[e.RowIndex].Cells[3].Value.ToString();
        }

        
        // زر جديد
        
        private void btnNew_Click_1(object sender, EventArgs e)
        {
            selectedId = 0;
            txtUsername.Text = "";
            txtPassword.Text = "";
            cmbRole.SelectedIndex = -1;
        }

        
        // بحث
        
        private void btnSearch_Click(object sender, EventArgs e)
        {
            string name = txtUsername.Text.Trim();

            if (name == "")
            {
                MessageBox.Show("ادخل اسم المستخدم للبحث");
                return;
            }

            string query =
                @"SELECT Employees.EmpId, Employees.Username, Employees.Password,
                         Roles.RoleName, Employees.CreatedAt, Employees.State
                  FROM Employees
                  JOIN Roles ON Roles.RoleId = Employees.RoleId
                  WHERE Employees.Username LIKE @u";

            DataTable dt = DBHelper.ExecuteDataTable(query,
                new SqlParameter("@u", "%" + name + "%"));

            dgvEmployees.Rows.Clear();

            foreach (DataRow row in dt.Rows)
            {
                dgvEmployees.Rows.Add(
                    row["EmpId"],
                    row["Username"],
                    row["Password"],
                    row["RoleName"],
                    row["CreatedAt"],
                    row["State"]
                );
            }
        }

       
        // إضافة موظف
       
        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (txtUsername.Text.Trim() == "" ||
                txtPassword.Text.Trim() == "" ||
                cmbRole.SelectedIndex < 0)
            {
                MessageBox.Show("الرجاء تعبئة جميع الحقول");
                return;
            }

            string username = txtUsername.Text.Trim();
            string password = txtPassword.Text.Trim();
            string hashed = SecurityHelper.HashPassword(password);

            string query =
                @"INSERT INTO Employees (Username, Password, RoleId, CreatedAt, State)
                  VALUES (@u, @p, @r, GETDATE(), 'Active')";

            DBHelper.ExecuteCommand(query,
                new SqlParameter("@u", username),
                new SqlParameter("@p", hashed),
                new SqlParameter("@r", cmbRole.SelectedValue));

            MessageBox.Show(" تم إضافة الموظف بنجاح");
            LoadEmployees();
        }

        
        // تحديث بيانات الموظف
        
        private void btnSave_Click(object sender, EventArgs e)
        {
            if (selectedId == 0)
            {
                MessageBox.Show("اختر موظف للتعديل");
                return;
            }

            string username = txtUsername.Text.Trim();

            string query =
                @"UPDATE Employees
                  SET Username = @u, RoleId = @r
                  WHERE EmpId = @id";

            DBHelper.ExecuteCommand(query,
                new SqlParameter("@u", username),
                new SqlParameter("@r", cmbRole.SelectedValue),
                new SqlParameter("@id", selectedId));

            MessageBox.Show(" تم تعديل الموظف");
            LoadEmployees();
        }

        
        // حذف الموظف
        
        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (selectedId == 0)
            {
                MessageBox.Show("لم يتم تحديد موظف");
                return;
            }

            if (MessageBox.Show("هل تريد حذف الموظف؟", "تأكيد", MessageBoxButtons.YesNo)
                == DialogResult.No)
                return;

            string query = "DELETE FROM Employees WHERE EmpId=@id";

            DBHelper.ExecuteCommand(query, new SqlParameter("@id", selectedId));

            MessageBox.Show(" تم حذف الموظف بنجاح");

            LoadEmployees();
        }

        
    }
}

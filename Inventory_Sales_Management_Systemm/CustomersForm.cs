using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Inventory_Sales_Management_Systemm
{
    public partial class CustomersForm : Form
    {
        int selectedId = 0; // حفظ رقم العميل المختار

        // ⭐ متغير لمعرفة من أين دخل المستخدم
        public string PreviousForm { get; set; }

        public CustomersForm()
        {
            InitializeComponent();
        }

        // =====================================================
        // تحميل الصفحة
        // =====================================================
        private void CustomersForm_Load(object sender, EventArgs e)
        {
            LoadCustomers();
        }

        // =====================================================
        // الرجوع الذكي حسب الصفحة السابقة
        // =====================================================
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

        // =====================================================
        // تحميل بيانات العملاء إلى الجدول
        // =====================================================
        private void LoadCustomers()
        {
            string query = "SELECT * FROM Customers ORDER BY CustomerId DESC";
            DataTable dt = DBHelper.ExecuteDataTable(query);

            gridCustomers.Rows.Clear();

            foreach (DataRow row in dt.Rows)
            {
                gridCustomers.Rows.Add(
                    row["CustomerId"],
                    row["FullName"],
                    row["Email"],
                    row["Phone"]
                );
            }
        }

        // =====================================================
        // زر إضافة عميل
        // =====================================================
        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (txtFullName.Text.Trim() == "")
            {
                MessageBox.Show("الرجاء إدخال اسم العميل");
                return;
            }

            string query = @"INSERT INTO Customers (FullName, Phone, Email)
                             VALUES (@name, @phone, @email)";

            DBHelper.ExecuteCommand(query,
                new SqlParameter("@name", txtFullName.Text),
                new SqlParameter("@phone", txtPhone.Text),
                new SqlParameter("@email", txtEmail.Text)
            );

            MessageBox.Show("✔ تم إضافة العميل بنجاح");
            ClearInputs();
            LoadCustomers();
        }

        // =====================================================
        // زر تعديل البيانات
        // =====================================================
        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (selectedId == 0)
            {
                MessageBox.Show("الرجاء اختيار عميل أولاً");
                return;
            }

            string query = @"UPDATE Customers 
                             SET FullName=@name, Phone=@phone, Email=@email
                             WHERE CustomerId=@id";

            DBHelper.ExecuteCommand(query,
                new SqlParameter("@name", txtFullName.Text),
                new SqlParameter("@phone", txtPhone.Text),
                new SqlParameter("@email", txtEmail.Text),
                new SqlParameter("@id", selectedId)
            );

            MessageBox.Show("✔ تم تعديل بيانات العميل");

            ClearInputs();
            LoadCustomers();
        }

        // =====================================================
        // زر حذف
        // =====================================================
        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (selectedId == 0)
            {
                MessageBox.Show("الرجاء اختيار عميل للحذف");
                return;
            }

            if (MessageBox.Show("هل تريد حذف العميل؟", "تأكيد", MessageBoxButtons.YesNo) == DialogResult.No)
                return;

            string query = @"DELETE FROM Customers WHERE CustomerId=@id";

            DBHelper.ExecuteCommand(query,
                new SqlParameter("@id", selectedId)
            );

            MessageBox.Show("✔ تم حذف العميل");

            ClearInputs();
            LoadCustomers();
        }

        // =====================================================
        // عند الضغط على صف داخل الجدول
        // =====================================================
        private void gridCustomers_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                selectedId = Convert.ToInt32(gridCustomers.Rows[e.RowIndex].Cells[0].Value);

                txtFullName.Text = gridCustomers.Rows[e.RowIndex].Cells[1].Value.ToString();
                txtEmail.Text = gridCustomers.Rows[e.RowIndex].Cells[2].Value.ToString();
                txtPhone.Text = gridCustomers.Rows[e.RowIndex].Cells[3].Value.ToString();
            }
        }

        // =====================================================
        // البحث
        // =====================================================
        private void textSearch_TextChanged(object sender, EventArgs e)
        {
            string keyword = textSearch.Text;

            string query = @"SELECT * FROM Customers
                             WHERE FullName LIKE @k 
                                OR Phone LIKE @k 
                                OR Email LIKE @k";

            DataTable dt = DBHelper.ExecuteDataTable(query,
                new SqlParameter("@k", "%" + keyword + "%")
            );

            gridCustomers.Rows.Clear();

            foreach (DataRow row in dt.Rows)
            {
                gridCustomers.Rows.Add(
                    row["CustomerId"],
                    row["FullName"],
                    row["Email"],
                    row["Phone"]
                );
            }
        }

        // =====================================================
        // تنظيف الحقول
        // =====================================================
        private void ClearInputs()
        {
            selectedId = 0;
            txtFullName.Text = "";
            txtPhone.Text = "";
            txtEmail.Text = "";
        }
    }
}

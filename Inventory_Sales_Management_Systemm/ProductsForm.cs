using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Inventory_Sales_Management_Systemm
{
    public partial class ProductsForm : Form
    {
        SqlConnection con = new SqlConnection(
        @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=InventoryDB1;Integrated Security=True");

        // ⭐ متغير لتحديد من أين جاء المستخدم
        public string PreviousForm { get; set; }

        public ProductsForm()
        {
            InitializeComponent();
        }

        private void ProductsForm_Load(object sender, EventArgs e)
        {
            LoadProducts();
        }

        // زر الرجوع حسب الصفحة السابقة
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

        
        // تحميل المنتجات
        private void LoadProducts()
        {
            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("SELECT * FROM Products ORDER BY ProductId DESC", con);
                SqlDataReader dr = cmd.ExecuteReader();

                gridProducts.Rows.Clear();

                while (dr.Read())
                {
                    gridProducts.Rows.Add(
                        dr["ProductId"],
                        dr["ProductName"],
                        dr["BuyPrice"],
                        dr["SalePrice"],
                        dr["Quantity"]
                    );
                }

                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading products: " + ex.Message);
                con.Close();
            }
        }

        // إضافة منتج جديد
        
        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (txtName.Text.Trim() == "" || numBuy.Value <= 0 || numSale.Value <= 0 || numQty.Value < 0)
            {
                MessageBox.Show("الرجاء تعبئة كل البيانات بشكل صحيح", "خطأ");
                return;
            }

            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand(
                    "INSERT INTO Products (ProductName, BuyPrice, SalePrice, Quantity) VALUES (@n, @b, @s, @q)", con);

                cmd.Parameters.AddWithValue("@n", txtName.Text);
                cmd.Parameters.AddWithValue("@b", numBuy.Value);
                cmd.Parameters.AddWithValue("@s", numSale.Value);
                cmd.Parameters.AddWithValue("@q", numQty.Value);

                cmd.ExecuteNonQuery();
                con.Close();

                LoadProducts();
                ClearInputs();

                MessageBox.Show("تمت إضافة المنتج بنجاح");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error adding product: " + ex.Message);
                con.Close();
            }
        }

        // تعبئة الحقول عند الضغط على صف
        int selectedId = 0;

        private void gridProducts_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            selectedId = int.Parse(gridProducts.Rows[e.RowIndex].Cells[0].Value.ToString());

            txtName.Text = gridProducts.Rows[e.RowIndex].Cells[1].Value.ToString();
            numBuy.Value = Convert.ToDecimal(gridProducts.Rows[e.RowIndex].Cells[2].Value);
            numSale.Value = Convert.ToDecimal(gridProducts.Rows[e.RowIndex].Cells[3].Value);
            numQty.Value = Convert.ToDecimal(gridProducts.Rows[e.RowIndex].Cells[4].Value);
        }

        // تعديل المنتج
        
        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (selectedId == 0)
            {
                MessageBox.Show("الرجاء اختيار منتج من الجدول");
                return;
            }

            if (txtName.Text.Trim() == "" || numBuy.Value <= 0 || numSale.Value <= 0 || numQty.Value < 0)
            {
                MessageBox.Show("الرجاء إدخال بيانات صحيحة");
                return;
            }

            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand(
                    "UPDATE Products SET ProductName=@n, BuyPrice=@b, SalePrice=@s, Quantity=@q WHERE ProductId=@id", con);

                cmd.Parameters.AddWithValue("@n", txtName.Text);
                cmd.Parameters.AddWithValue("@b", numBuy.Value);
                cmd.Parameters.AddWithValue("@s", numSale.Value);
                cmd.Parameters.AddWithValue("@q", numQty.Value);
                cmd.Parameters.AddWithValue("@id", selectedId);

                cmd.ExecuteNonQuery();
                con.Close();

                LoadProducts();
                ClearInputs();

                MessageBox.Show("تم تعديل المنتج بنجاح");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error updating product: " + ex.Message);
                con.Close();
            }
        }

        // حذف المنتج
        
        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (selectedId == 0)
            {
                MessageBox.Show("الرجاء اختيار منتج لحذفه");
                return;
            }

            if (MessageBox.Show("هل أنت متأكد من حذف المنتج؟", "تحذير",
                MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.No) return;

            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("DELETE FROM Products WHERE ProductId=@id", con);
                cmd.Parameters.AddWithValue("@id", selectedId);
                cmd.ExecuteNonQuery();
                con.Close();

                LoadProducts();
                ClearInputs();

                MessageBox.Show("تم حذف المنتج");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error deleting: " + ex.Message);
                con.Close();
            }
        }

        // =====================================================
        // بحث مباشر
        // =====================================================
        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand(
                    "SELECT * FROM Products WHERE ProductName LIKE @search", con);
                cmd.Parameters.AddWithValue("@search", "%" + txtSearch.Text + "%");

                SqlDataReader dr = cmd.ExecuteReader();

                gridProducts.Rows.Clear();

                while (dr.Read())
                {
                    gridProducts.Rows.Add(
                        dr["ProductId"],
                        dr["ProductName"],
                        dr["BuyPrice"],
                        dr["SalePrice"],
                        dr["Quantity"]
                    );
                }

                con.Close();
            }
            catch
            {
                con.Close();
            }
        }

        // =====================================================
        // تنظيف الحقول
        // =====================================================
        private void ClearInputs()
        {
            txtName.Clear();
            numBuy.Value = 0;
            numSale.Value = 0;
            numQty.Value = 0;
            selectedId = 0;
        }
    }
}

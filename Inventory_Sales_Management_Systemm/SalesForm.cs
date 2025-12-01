using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Inventory_Sales_Management_Systemm
{
    public partial class SalesForm : Form
    {
        decimal totalInvoice = 0;

        public string PreviousForm { get; set; }

        public SalesForm()
        {
            InitializeComponent();
        }

        private void SalesForm_Load(object sender, EventArgs e)
        {
            LoadCustomers();
            LoadProducts();
        }

        private void LoadCustomers()
        {
            string query = "SELECT CustomerId, FullName FROM Customers";
            DataTable dt = DBHelper.ExecuteDataTable(query);

            cboCustomer.DataSource = dt;
            cboCustomer.DisplayMember = "FullName";
            cboCustomer.ValueMember = "CustomerId";
        }

        private void LoadProducts()
        {
            string query = "SELECT ProductId, ProductName FROM Products";
            DataTable dt = DBHelper.ExecuteDataTable(query);

            cboProduct.DataSource = dt;
            cboProduct.DisplayMember = "ProductName";
            cboProduct.ValueMember = "ProductId";
        }

        
        // إضافة للسلة
        
        private void btnAddToCart_Click(object sender, EventArgs e)
        {
            string customerName = cboCustomer.Text;
            int customerId = Convert.ToInt32(cboCustomer.SelectedValue);
            int productId = Convert.ToInt32(cboProduct.SelectedValue);
            int qty = Convert.ToInt32(numQty.Value);

            DataTable dt = DBHelper.ExecuteDataTable(
                "SELECT ProductName, SalePrice, Quantity FROM Products WHERE ProductId=@id",
                new SqlParameter("@id", productId));

            if (dt.Rows.Count == 0)
                return;

            string name = dt.Rows[0]["ProductName"].ToString();
            decimal price = Convert.ToDecimal(dt.Rows[0]["SalePrice"]);
            int stockQty = Convert.ToInt32(dt.Rows[0]["Quantity"]);
            decimal total = qty * price;

            if (qty > stockQty)
            {
                MessageBox.Show(" الكمية غير متوفرة");
                return;
            }

            // دمج المنتج مع نفس العميل فقط
            foreach (DataGridViewRow row in gridCart.Rows)
            {
                int existedProd = Convert.ToInt32(row.Cells["colProductId"].Value);
                string existedCustomer = row.Cells["colCustomerName"].Value.ToString();

                if (existedProd == productId && existedCustomer == customerName)
                {
                    int oldQty = Convert.ToInt32(row.Cells["colQty"].Value);
                    int newQty = oldQty + qty;

                    if (newQty > stockQty)
                    {
                        MessageBox.Show(" لا توجد كمية كافية");
                        return;
                    }

                    row.Cells["colQty"].Value = newQty;
                    row.Cells["colTotal"].Value = newQty * price;

                    lblTotal.Text = "الإجمالي: " + CalculateTotal().ToString("0.00");
                    return;
                }
            }

            // إضافة صف جديد (الترتيب الصحيح 100%)
            gridCart.Rows.Add(
                productId,        // colProductId
                customerName,     // colCustomerName
                name,             // colProductName
                qty,              // colQty
                price,            // colPrice
                total,            // colTotal
                "حذف"             // colDelete
            );

            lblTotal.Text = "الإجمالي: " + CalculateTotal().ToString("0.00");
        }

        // حذف من السلة
        private void gridCart_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == gridCart.Columns["colDelete"].Index)
            {
                gridCart.Rows.RemoveAt(e.RowIndex);
                lblTotal.Text = "الإجمالي: " + CalculateTotal().ToString("0.00");
            }
        }

        private decimal CalculateTotal()
        {
            decimal sum = 0;

            foreach (DataGridViewRow row in gridCart.Rows)
            {
                if (row.Cells["colTotal"].Value != null &&
                    decimal.TryParse(row.Cells["colTotal"].Value.ToString(), out decimal v))
                {
                    sum += v;
                }
            }
            return sum;
        }

        // حفظ الفاتورة
        private void btnSave_Click(object sender, EventArgs e)
        {
            if (gridCart.Rows.Count == 0)
            {
                MessageBox.Show("السلة فارغة!");
                return;
            }

            int customerId = Convert.ToInt32(cboCustomer.SelectedValue);

            string insertInvoiceQuery = @"
                INSERT INTO Invoices (CustomerId, InvoiceDate, TotalAmount)
                VALUES (@customerId, GETDATE(), @total);
                SELECT SCOPE_IDENTITY();";

            object result = DBHelper.ExecuteScalar(insertInvoiceQuery,
                new SqlParameter("@customerId", customerId),
                new SqlParameter("@total", CalculateTotal()));

            int invoiceId = Convert.ToInt32(result);

            foreach (DataGridViewRow row in gridCart.Rows)
            {
                int productId = Convert.ToInt32(row.Cells["colProductId"].Value);
                int qty = Convert.ToInt32(row.Cells["colQty"].Value);
                decimal price = Convert.ToDecimal(row.Cells["colPrice"].Value);
                decimal total = Convert.ToDecimal(row.Cells["colTotal"].Value);

                string insertItemQuery = @"
                    INSERT INTO InvoiceItems (InvoiceId, ProductId, Qty, Price, Total)
                    VALUES (@inv, @prod, @qty, @price, @total)";

                DBHelper.ExecuteCommand(insertItemQuery,
                    new SqlParameter("@inv", invoiceId),
                    new SqlParameter("@prod", productId),
                    new SqlParameter("@qty", qty),
                    new SqlParameter("@price", price),
                    new SqlParameter("@total", total));

                string updateStock = "UPDATE Products SET Quantity = Quantity - @q WHERE ProductId=@p";

                DBHelper.ExecuteCommand(updateStock,
                    new SqlParameter("@q", qty),
                    new SqlParameter("@p", productId));
            }

            MessageBox.Show(" تم حفظ الفاتورة بنجاح!");

            gridCart.Rows.Clear();
            lblTotal.Text = "الإجمالي: 000";
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

        private void cboCustomer_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}

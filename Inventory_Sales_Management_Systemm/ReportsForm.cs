using iTextSharp.text;
using iTextSharp.text.pdf;
using System;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Windows.Forms;

namespace Inventory_Sales_Management_Systemm
{
    public partial class ReportsForm : Form
    {
        string connectionString = @"Server=(localdb)\MSSQLLocalDB;Database=InventoryDB1;Integrated Security=True;";

        //  متغير لمعرفة من أين دخل المستخدم
        public string PreviousForm { get; set; }

        public ReportsForm()
        {
            InitializeComponent();
        }

        private void ReportsForm_Load(object sender, EventArgs e)
        {
            dtFrom.Value = DateTime.Now.AddDays(-7);
            dtTo.Value = DateTime.Now;
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            //تحميل الفواتير
            LoadInvoices();
        }

        private void LoadInvoices()
        {
            gridInvoices.Rows.Clear();
            decimal total = 0;

            using (SqlConnection con = new SqlConnection(connectionString))
            {
                string query = @"
             SELECT I.InvoiceId, I.InvoiceDate, C.FullName, P.ProductName,
                   IT.Qty, IT.Price, IT.Total
                   FROM InvoiceItems IT
                   INNER JOIN Invoices I ON IT.InvoiceId = I.InvoiceId
                   INNER JOIN Customers C ON I.CustomerId = C.CustomerId
                   INNER JOIN Products P ON IT.ProductId = P.ProductId
                   WHERE I.InvoiceDate BETWEEN @d1 AND @d2";

                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@d1", dtFrom.Value);
                cmd.Parameters.AddWithValue("@d2", dtTo.Value);

                con.Open();
                SqlDataReader rd = cmd.ExecuteReader();

                while (rd.Read())
                {
                    gridInvoices.Rows.Add(
                        rd["InvoiceId"],
                        rd["InvoiceDate"],
                        rd["FullName"],
                        rd["ProductName"],
                        rd["Qty"],
                        rd["Price"],
                        rd["Total"]
                    );

                    total += Convert.ToDecimal(rd["Total"]);
                }
                con.Close();

                lblTotal.Text = total.ToString("0.00");
            }
        }

        private void btnExportPdf_Click(object sender, EventArgs e)
        {
            try
            {
                ExportPdf();
                MessageBox.Show("تم تصدير الملف بنجاح ✔", "نجاح", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("خطأ أثناء التصدير\n" + ex.Message);
            }
        }

        private void ExportPdf()
        {
            if (gridInvoices.Rows.Count == 0)
            {
                MessageBox.Show("لا توجد بيانات لتصديرها!");
                return;
            }

            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "PDF File|*.pdf";
            sfd.FileName = "Sales_Report.pdf";

            if (sfd.ShowDialog() != DialogResult.OK)
                return;

            string fontPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "arial.ttf");
            BaseFont bf = BaseFont.CreateFont(fontPath, BaseFont.IDENTITY_H, BaseFont.EMBEDDED);
            iTextSharp.text.Font font = new iTextSharp.text.Font(bf, 12);

            Document doc = new Document(PageSize.A4, 10, 10, 10, 10);
            PdfWriter.GetInstance(doc, new FileStream(sfd.FileName, FileMode.Create));
            doc.Open();

            Paragraph title = new Paragraph("تقرير المبيعات / Sales Report", new iTextSharp.text.Font(bf, 16, iTextSharp.text.Font.BOLD));
            title.Alignment = Element.ALIGN_CENTER;
            doc.Add(title);
            doc.Add(new Paragraph("\n"));

            PdfPTable table = new PdfPTable(gridInvoices.Columns.Count);
            table.WidthPercentage = 100;
            table.RunDirection = PdfWriter.RUN_DIRECTION_RTL;

            foreach (DataGridViewColumn col in gridInvoices.Columns)
            {
                PdfPCell cell = new PdfPCell(new Phrase(col.HeaderText, font));
                cell.BackgroundColor = BaseColor.LIGHT_GRAY;
                cell.HorizontalAlignment = Element.ALIGN_CENTER;
                table.AddCell(cell);
            }

            foreach (DataGridViewRow row in gridInvoices.Rows)
            {
                foreach (DataGridViewCell cell in row.Cells)
                {
                    table.AddCell(new Phrase(cell.Value?.ToString(), font));
                }
            }

            doc.Add(table);

            doc.Add(new Paragraph("\nالإجمالي: " + lblTotal.Text, font));

            doc.Close();
        }

        private void gridInvoices_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        
        //  الرجوع حسب الصلاحيات
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
    }
}

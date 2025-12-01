using System;
using System.Windows.Forms;

namespace Inventory_Sales_Management_Systemm
{
    partial class ReportsForm
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code
        private void InitializeComponent()
        {
            this.lblFrom = new System.Windows.Forms.Label();
            this.lblTo = new System.Windows.Forms.Label();
            this.lblSalesTotalText = new System.Windows.Forms.Label();
            this.dtFrom = new System.Windows.Forms.DateTimePicker();
            this.dtTo = new System.Windows.Forms.DateTimePicker();
            this.btnLoad = new System.Windows.Forms.Button();
            this.gridInvoices = new System.Windows.Forms.DataGridView();
            this.colInvoiceId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCustomer = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colProduct = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colQty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblTotal = new System.Windows.Forms.Label();
            this.btnExportPdf = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.gridInvoices)).BeginInit();
            this.SuspendLayout();
            // 
            // lblFrom
            // 
            this.lblFrom.AutoSize = true;
            this.lblFrom.BackColor = System.Drawing.Color.Gold;
            this.lblFrom.Font = new System.Drawing.Font("Tahoma", 10.2F);
            this.lblFrom.Location = new System.Drawing.Point(664, 78);
            this.lblFrom.Name = "lblFrom";
            this.lblFrom.Size = new System.Drawing.Size(38, 21);
            this.lblFrom.TabIndex = 9;
            this.lblFrom.Text = ":من";
            // 
            // lblTo
            // 
            this.lblTo.AutoSize = true;
            this.lblTo.BackColor = System.Drawing.Color.Gold;
            this.lblTo.Font = new System.Drawing.Font("Tahoma", 10.2F);
            this.lblTo.Location = new System.Drawing.Point(283, 78);
            this.lblTo.Name = "lblTo";
            this.lblTo.Size = new System.Drawing.Size(42, 21);
            this.lblTo.TabIndex = 8;
            this.lblTo.Text = ":الى";
            // 
            // lblSalesTotalText
            // 
            this.lblSalesTotalText.AutoSize = true;
            this.lblSalesTotalText.BackColor = System.Drawing.Color.Gold;
            this.lblSalesTotalText.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold);
            this.lblSalesTotalText.Location = new System.Drawing.Point(697, 420);
            this.lblSalesTotalText.Name = "lblSalesTotalText";
            this.lblSalesTotalText.Size = new System.Drawing.Size(149, 21);
            this.lblSalesTotalText.TabIndex = 1;
            this.lblSalesTotalText.Text = ":اجمالي المبيعات";
            // 
            // dtFrom
            // 
            this.dtFrom.Location = new System.Drawing.Point(415, 78);
            this.dtFrom.Name = "dtFrom";
            this.dtFrom.Size = new System.Drawing.Size(200, 24);
            this.dtFrom.TabIndex = 7;
            // 
            // dtTo
            // 
            this.dtTo.Location = new System.Drawing.Point(45, 78);
            this.dtTo.Name = "dtTo";
            this.dtTo.Size = new System.Drawing.Size(200, 24);
            this.dtTo.TabIndex = 6;
            // 
            // btnLoad
            // 
            this.btnLoad.BackColor = System.Drawing.Color.Gold;
            this.btnLoad.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
            this.btnLoad.Location = new System.Drawing.Point(88, 120);
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Size = new System.Drawing.Size(173, 47);
            this.btnLoad.TabIndex = 5;
            this.btnLoad.Text = "عرض التقرير";
            this.btnLoad.UseVisualStyleBackColor = false;
            this.btnLoad.Click += new System.EventHandler(this.btnLoad_Click);
            // 
            // gridInvoices
            // 
            this.gridInvoices.BackgroundColor = System.Drawing.Color.White;
            this.gridInvoices.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridInvoices.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colInvoiceId,
            this.colDate,
            this.colCustomer,
            this.colProduct,
            this.colQty,
            this.colPrice,
            this.colTotal});
            this.gridInvoices.Location = new System.Drawing.Point(12, 173);
            this.gridInvoices.Name = "gridInvoices";
            this.gridInvoices.ReadOnly = true;
            this.gridInvoices.RowHeadersWidth = 51;
            this.gridInvoices.Size = new System.Drawing.Size(833, 244);
            this.gridInvoices.TabIndex = 2;
            this.gridInvoices.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridInvoices_CellContentClick);
            // 
            // colInvoiceId
            // 
            this.colInvoiceId.HeaderText = "رقم الفاتورة";
            this.colInvoiceId.MinimumWidth = 6;
            this.colInvoiceId.Name = "colInvoiceId";
            this.colInvoiceId.ReadOnly = true;
            this.colInvoiceId.Width = 70;
            // 
            // colDate
            // 
            this.colDate.HeaderText = "تاريخ الفاتورة";
            this.colDate.MinimumWidth = 6;
            this.colDate.Name = "colDate";
            this.colDate.ReadOnly = true;
            this.colDate.Width = 150;
            // 
            // colCustomer
            // 
            this.colCustomer.HeaderText = "اسم العميل";
            this.colCustomer.MinimumWidth = 6;
            this.colCustomer.Name = "colCustomer";
            this.colCustomer.ReadOnly = true;
            this.colCustomer.Width = 150;
            // 
            // colProduct
            // 
            this.colProduct.HeaderText = "المنتج";
            this.colProduct.MinimumWidth = 6;
            this.colProduct.Name = "colProduct";
            this.colProduct.ReadOnly = true;
            this.colProduct.Width = 125;
            // 
            // colQty
            // 
            this.colQty.HeaderText = "الكمية";
            this.colQty.MinimumWidth = 6;
            this.colQty.Name = "colQty";
            this.colQty.ReadOnly = true;
            this.colQty.Width = 80;
            // 
            // colPrice
            // 
            this.colPrice.HeaderText = "سعر الوحدة";
            this.colPrice.MinimumWidth = 6;
            this.colPrice.Name = "colPrice";
            this.colPrice.ReadOnly = true;
            this.colPrice.Width = 80;
            // 
            // colTotal
            // 
            this.colTotal.HeaderText = "الإجمالي";
            this.colTotal.MinimumWidth = 6;
            this.colTotal.Name = "colTotal";
            this.colTotal.ReadOnly = true;
            this.colTotal.Width = 120;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Tahoma", 16.2F, System.Drawing.FontStyle.Bold);
            this.lblTitle.Location = new System.Drawing.Point(340, 10);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(108, 34);
            this.lblTitle.TabIndex = 10;
            this.lblTitle.Text = "التقارير";
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Font = new System.Drawing.Font("Tahoma", 10.2F);
            this.lblTotal.Location = new System.Drawing.Point(655, 424);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(42, 21);
            this.lblTotal.TabIndex = 0;
            this.lblTotal.Text = "0.00";
            // 
            // btnExportPdf
            // 
            this.btnExportPdf.BackColor = System.Drawing.Color.Gold;
            this.btnExportPdf.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.btnExportPdf.Location = new System.Drawing.Point(480, 120);
            this.btnExportPdf.Name = "btnExportPdf";
            this.btnExportPdf.Size = new System.Drawing.Size(110, 47);
            this.btnExportPdf.TabIndex = 11;
            this.btnExportPdf.Text = "تصدير PDF";
            this.btnExportPdf.UseVisualStyleBackColor = false;
            this.btnExportPdf.Click += new System.EventHandler(this.btnExportPdf_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.button1.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(700, 10);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(141, 23);
            this.button1.TabIndex = 12;
            this.button1.Text = "القائيمة الرئيسية >";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // ReportsForm
            // 
            this.BackgroundImage = global::Inventory_Sales_Management_Systemm.Properties.Resources.التقارير;
            this.ClientSize = new System.Drawing.Size(853, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnExportPdf);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.lblSalesTotalText);
            this.Controls.Add(this.gridInvoices);
            this.Controls.Add(this.btnLoad);
            this.Controls.Add(this.dtTo);
            this.Controls.Add(this.dtFrom);
            this.Controls.Add(this.lblTo);
            this.Controls.Add(this.lblFrom);
            this.Controls.Add(this.lblTitle);
            this.Name = "ReportsForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ReportsForm";
            this.Load += new System.EventHandler(this.ReportsForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridInvoices)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion

        private System.Windows.Forms.Label lblFrom;
        private System.Windows.Forms.Label lblTo;
        private System.Windows.Forms.Label lblSalesTotalText;
        private System.Windows.Forms.DateTimePicker dtFrom;
        private System.Windows.Forms.DateTimePicker dtTo;
        private System.Windows.Forms.Button btnLoad;
        private System.Windows.Forms.DataGridView gridInvoices;
        private System.Windows.Forms.DataGridViewTextBoxColumn colInvoiceId;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCustomer;
        private System.Windows.Forms.DataGridViewTextBoxColumn colProduct;
        private System.Windows.Forms.DataGridViewTextBoxColumn colQty;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTotal;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Button btnExportPdf;
        private Button button1;
    }
}

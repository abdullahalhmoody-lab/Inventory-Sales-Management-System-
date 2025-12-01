using System;

namespace Inventory_Sales_Management_Systemm
{
    partial class SalesForm
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.lblCustomer = new System.Windows.Forms.Label();
            this.lblProduct = new System.Windows.Forms.Label();
            this.labQty = new System.Windows.Forms.Label();
            this.cboCustomer = new System.Windows.Forms.ComboBox();
            this.cboProduct = new System.Windows.Forms.ComboBox();
            this.numQty = new System.Windows.Forms.NumericUpDown();
            this.btnAddToCart = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.gridCart = new System.Windows.Forms.DataGridView();
            this.colProductId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCustomerName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colProductName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colQty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDelete = new System.Windows.Forms.DataGridViewButtonColumn();
            this.lblTotal = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numQty)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridCart)).BeginInit();
            this.SuspendLayout();
            // 
            // lblCustomer
            // 
            this.lblCustomer.AutoSize = true;
            this.lblCustomer.BackColor = System.Drawing.Color.LightYellow;
            this.lblCustomer.Font = new System.Drawing.Font("Tahoma", 10.2F);
            this.lblCustomer.Location = new System.Drawing.Point(708, 61);
            this.lblCustomer.Name = "lblCustomer";
            this.lblCustomer.Size = new System.Drawing.Size(55, 21);
            this.lblCustomer.TabIndex = 10;
            this.lblCustomer.Text = "العميل";
            // 
            // lblProduct
            // 
            this.lblProduct.AutoSize = true;
            this.lblProduct.BackColor = System.Drawing.Color.LightYellow;
            this.lblProduct.Font = new System.Drawing.Font("Tahoma", 10.2F);
            this.lblProduct.Location = new System.Drawing.Point(710, 114);
            this.lblProduct.Name = "lblProduct";
            this.lblProduct.Size = new System.Drawing.Size(53, 21);
            this.lblProduct.TabIndex = 9;
            this.lblProduct.Text = "المنتج";
            // 
            // labQty
            // 
            this.labQty.AutoSize = true;
            this.labQty.BackColor = System.Drawing.Color.LightYellow;
            this.labQty.Font = new System.Drawing.Font("Tahoma", 10.2F);
            this.labQty.Location = new System.Drawing.Point(301, 61);
            this.labQty.Name = "labQty";
            this.labQty.Size = new System.Drawing.Size(54, 21);
            this.labQty.TabIndex = 8;
            this.labQty.Text = "الكمية";
            // 
            // cboCustomer
            // 
            this.cboCustomer.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboCustomer.Location = new System.Drawing.Point(486, 58);
            this.cboCustomer.Name = "cboCustomer";
            this.cboCustomer.Size = new System.Drawing.Size(200, 24);
            this.cboCustomer.TabIndex = 7;
            this.cboCustomer.SelectedIndexChanged += new System.EventHandler(this.cboCustomer_SelectedIndexChanged);
            // 
            // cboProduct
            // 
            this.cboProduct.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboProduct.Location = new System.Drawing.Point(486, 115);
            this.cboProduct.Name = "cboProduct";
            this.cboProduct.Size = new System.Drawing.Size(200, 24);
            this.cboProduct.TabIndex = 6;
            // 
            // numQty
            // 
            this.numQty.Location = new System.Drawing.Point(151, 58);
            this.numQty.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numQty.Name = "numQty";
            this.numQty.Size = new System.Drawing.Size(120, 24);
            this.numQty.TabIndex = 5;
            this.numQty.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // btnAddToCart
            // 
            this.btnAddToCart.BackColor = System.Drawing.Color.SaddleBrown;
            this.btnAddToCart.Font = new System.Drawing.Font("Tahoma", 10.2F);
            this.btnAddToCart.ForeColor = System.Drawing.Color.Black;
            this.btnAddToCart.Location = new System.Drawing.Point(151, 115);
            this.btnAddToCart.Name = "btnAddToCart";
            this.btnAddToCart.Size = new System.Drawing.Size(120, 30);
            this.btnAddToCart.TabIndex = 4;
            this.btnAddToCart.Text = "إضافة للسلة";
            this.btnAddToCart.UseVisualStyleBackColor = false;
            this.btnAddToCart.Click += new System.EventHandler(this.btnAddToCart_Click);
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.SaddleBrown;
            this.btnSave.Font = new System.Drawing.Font("Tahoma", 10.2F);
            this.btnSave.ForeColor = System.Drawing.Color.Black;
            this.btnSave.Location = new System.Drawing.Point(615, 407);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(120, 35);
            this.btnSave.TabIndex = 3;
            this.btnSave.Text = "حفظ الفاتورة";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // gridCart
            // 
            this.gridCart.AllowUserToAddRows = false;
            this.gridCart.BackgroundColor = System.Drawing.Color.LightYellow;
            this.gridCart.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridCart.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colProductId,
            this.colCustomerName,
            this.colProductName,
            this.colQty,
            this.colPrice,
            this.colTotal,
            this.colDelete});
            this.gridCart.Location = new System.Drawing.Point(2, 151);
            this.gridCart.Name = "gridCart";
            this.gridCart.RowHeadersWidth = 51;
            this.gridCart.Size = new System.Drawing.Size(834, 250);
            this.gridCart.TabIndex = 2;
            this.gridCart.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridCart_CellContentClick);
            // 
            // colProductId
            // 
            this.colProductId.HeaderText = "ID";
            this.colProductId.MinimumWidth = 6;
            this.colProductId.Name = "colProductId";
            this.colProductId.Width = 60;
            // 
            // colCustomerName
            // 
            this.colCustomerName.HeaderText = "اسم العميل";
            this.colCustomerName.MinimumWidth = 6;
            this.colCustomerName.Name = "colCustomerName";
            this.colCustomerName.Width = 125;
            // 
            // colProductName
            // 
            this.colProductName.HeaderText = "اسم المنتج";
            this.colProductName.MinimumWidth = 6;
            this.colProductName.Name = "colProductName";
            this.colProductName.Width = 200;
            // 
            // colQty
            // 
            this.colQty.HeaderText = "الكمية";
            this.colQty.MinimumWidth = 6;
            this.colQty.Name = "colQty";
            this.colQty.Width = 70;
            // 
            // colPrice
            // 
            this.colPrice.HeaderText = "سعر الواحدة";
            this.colPrice.MinimumWidth = 6;
            this.colPrice.Name = "colPrice";
            this.colPrice.Width = 120;
            // 
            // colTotal
            // 
            this.colTotal.HeaderText = "الإجمالي";
            this.colTotal.MinimumWidth = 6;
            this.colTotal.Name = "colTotal";
            this.colTotal.Width = 115;
            // 
            // colDelete
            // 
            this.colDelete.HeaderText = "حذف";
            this.colDelete.MinimumWidth = 6;
            this.colDelete.Name = "colDelete";
            this.colDelete.Text = "حذف";
            this.colDelete.UseColumnTextForButtonValue = true;
            this.colDelete.Width = 115;
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.BackColor = System.Drawing.Color.SaddleBrown;
            this.lblTotal.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold);
            this.lblTotal.Location = new System.Drawing.Point(126, 414);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(129, 21);
            this.lblTotal.TabIndex = 1;
            this.lblTotal.Text = "الإجمالي: 0.00";
            this.lblTotal.Click += new System.EventHandler(this.lblTotal_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.LightYellow;
            this.label5.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Bold);
            this.label5.Location = new System.Drawing.Point(360, 10);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(89, 28);
            this.label5.TabIndex = 0;
            this.label5.Text = "الفواتير";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.button1.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(714, 10);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(132, 23);
            this.button1.TabIndex = 11;
            this.button1.Text = "القائمة لرئيسية>";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // SalesForm
            // 
            this.BackgroundImage = global::Inventory_Sales_Management_Systemm.Properties.Resources.مبيعات_اون_لاين;
            this.ClientSize = new System.Drawing.Size(848, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.gridCart);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnAddToCart);
            this.Controls.Add(this.numQty);
            this.Controls.Add(this.cboProduct);
            this.Controls.Add(this.cboCustomer);
            this.Controls.Add(this.labQty);
            this.Controls.Add(this.lblProduct);
            this.Controls.Add(this.lblCustomer);
            this.Name = "SalesForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SalesForm";
            this.Load += new System.EventHandler(this.SalesForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numQty)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridCart)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void lblTotal_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        #endregion

        private System.Windows.Forms.Label lblCustomer;
        private System.Windows.Forms.Label lblProduct;
        private System.Windows.Forms.Label labQty;

        private System.Windows.Forms.ComboBox cboCustomer;
        private System.Windows.Forms.ComboBox cboProduct;
        private System.Windows.Forms.NumericUpDown numQty;

        private System.Windows.Forms.Button btnAddToCart;
        private System.Windows.Forms.Button btnSave;

        private System.Windows.Forms.DataGridView gridCart;

        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridViewTextBoxColumn colProductId;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCustomerName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colProductName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colQty;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTotal;
        private System.Windows.Forms.DataGridViewButtonColumn colDelete;
    }
}

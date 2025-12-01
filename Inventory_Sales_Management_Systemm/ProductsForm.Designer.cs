namespace Inventory_Sales_Management_Systemm
{
    partial class ProductsForm
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
            this.labelTitle = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.lblBuy = new System.Windows.Forms.Label();
            this.lblSale = new System.Windows.Forms.Label();
            this.lblQty = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.numBuy = new System.Windows.Forms.NumericUpDown();
            this.numSale = new System.Windows.Forms.NumericUpDown();
            this.numQty = new System.Windows.Forms.NumericUpDown();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.gridProducts = new System.Windows.Forms.DataGridView();
            this.colId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colBuy = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSale = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colQty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numBuy)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numSale)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numQty)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridProducts)).BeginInit();
            this.SuspendLayout();
            // 
            // labelTitle
            // 
            this.labelTitle.AutoSize = true;
            this.labelTitle.Font = new System.Drawing.Font("Tahoma", 14F, System.Drawing.FontStyle.Bold);
            this.labelTitle.Location = new System.Drawing.Point(320, 9);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(168, 29);
            this.labelTitle.TabIndex = 0;
            this.labelTitle.Text = "إدارة المنتجات";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.BackColor = System.Drawing.Color.Gold;
            this.lblName.Font = new System.Drawing.Font("Tahoma", 10F);
            this.lblName.Location = new System.Drawing.Point(177, 54);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(91, 21);
            this.lblName.TabIndex = 1;
            this.lblName.Text = "اسم المنتج";
            // 
            // lblBuy
            // 
            this.lblBuy.AutoSize = true;
            this.lblBuy.BackColor = System.Drawing.Color.Gold;
            this.lblBuy.Font = new System.Drawing.Font("Tahoma", 10F);
            this.lblBuy.Location = new System.Drawing.Point(177, 87);
            this.lblBuy.Name = "lblBuy";
            this.lblBuy.Size = new System.Drawing.Size(91, 21);
            this.lblBuy.TabIndex = 2;
            this.lblBuy.Text = "سعر الشراء";
            // 
            // lblSale
            // 
            this.lblSale.AutoSize = true;
            this.lblSale.BackColor = System.Drawing.Color.Gold;
            this.lblSale.Font = new System.Drawing.Font("Tahoma", 10F);
            this.lblSale.Location = new System.Drawing.Point(177, 117);
            this.lblSale.Name = "lblSale";
            this.lblSale.Size = new System.Drawing.Size(78, 21);
            this.lblSale.TabIndex = 3;
            this.lblSale.Text = "سعر البيع";
            // 
            // lblQty
            // 
            this.lblQty.AutoSize = true;
            this.lblQty.BackColor = System.Drawing.Color.Gold;
            this.lblQty.Font = new System.Drawing.Font("Tahoma", 10F);
            this.lblQty.Location = new System.Drawing.Point(177, 147);
            this.lblQty.Name = "lblQty";
            this.lblQty.Size = new System.Drawing.Size(54, 21);
            this.lblQty.TabIndex = 4;
            this.lblQty.Text = "الكمية";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(30, 51);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(124, 24);
            this.txtName.TabIndex = 5;
            // 
            // numBuy
            // 
            this.numBuy.DecimalPlaces = 2;
            this.numBuy.Location = new System.Drawing.Point(30, 87);
            this.numBuy.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.numBuy.Name = "numBuy";
            this.numBuy.Size = new System.Drawing.Size(120, 24);
            this.numBuy.TabIndex = 6;
            // 
            // numSale
            // 
            this.numSale.DecimalPlaces = 2;
            this.numSale.Location = new System.Drawing.Point(30, 117);
            this.numSale.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.numSale.Name = "numSale";
            this.numSale.Size = new System.Drawing.Size(120, 24);
            this.numSale.TabIndex = 7;
            // 
            // numQty
            // 
            this.numQty.Location = new System.Drawing.Point(30, 147);
            this.numQty.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.numQty.Name = "numQty";
            this.numQty.Size = new System.Drawing.Size(120, 24);
            this.numQty.TabIndex = 8;
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(489, 105);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(307, 24);
            this.txtSearch.TabIndex = 9;
            this.txtSearch.Text = "بحث...";
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.Gold;
            this.btnAdd.Location = new System.Drawing.Point(697, 51);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(90, 30);
            this.btnAdd.TabIndex = 10;
            this.btnAdd.Text = "إضافة";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.BackColor = System.Drawing.Color.Gold;
            this.btnEdit.Location = new System.Drawing.Point(585, 51);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(90, 30);
            this.btnEdit.TabIndex = 11;
            this.btnEdit.Text = "تعديل";
            this.btnEdit.UseVisualStyleBackColor = false;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.Gold;
            this.btnDelete.Location = new System.Drawing.Point(489, 51);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(90, 30);
            this.btnDelete.TabIndex = 12;
            this.btnDelete.Text = "حذف";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // gridProducts
            // 
            this.gridProducts.BackgroundColor = System.Drawing.Color.SkyBlue;
            this.gridProducts.ColumnHeadersHeight = 29;
            this.gridProducts.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colId,
            this.colName,
            this.colBuy,
            this.colSale,
            this.colQty});
            this.gridProducts.Location = new System.Drawing.Point(64, 315);
            this.gridProducts.Name = "gridProducts";
            this.gridProducts.RowHeadersWidth = 51;
            this.gridProducts.RowTemplate.Height = 26;
            this.gridProducts.Size = new System.Drawing.Size(655, 209);
            this.gridProducts.TabIndex = 13;
            this.gridProducts.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridProducts_CellClick);
            // 
            // colId
            // 
            this.colId.HeaderText = "ID";
            this.colId.MinimumWidth = 6;
            this.colId.Name = "colId";
            this.colId.Width = 50;
            // 
            // colName
            // 
            this.colName.HeaderText = "اسم المنتج";
            this.colName.MinimumWidth = 6;
            this.colName.Name = "colName";
            this.colName.Width = 200;
            // 
            // colBuy
            // 
            this.colBuy.HeaderText = "سعر الشراء";
            this.colBuy.MinimumWidth = 6;
            this.colBuy.Name = "colBuy";
            this.colBuy.Width = 130;
            // 
            // colSale
            // 
            this.colSale.HeaderText = "سعر البيع";
            this.colSale.MinimumWidth = 6;
            this.colSale.Name = "colSale";
            this.colSale.Width = 130;
            // 
            // colQty
            // 
            this.colQty.HeaderText = "الكمية";
            this.colQty.MinimumWidth = 6;
            this.colQty.Name = "colQty";
            this.colQty.Width = 90;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.button1.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(687, 14);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(144, 23);
            this.button1.TabIndex = 14;
            this.button1.Text = "القائمة الرئيسية >";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // ProductsForm
            // 
            this.BackgroundImage = global::Inventory_Sales_Management_Systemm.Properties.Resources._784f8475_aa63_49e2_bf36_2f45b65d057c;
            this.ClientSize = new System.Drawing.Size(832, 550);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.labelTitle);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.lblBuy);
            this.Controls.Add(this.lblSale);
            this.Controls.Add(this.lblQty);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.numBuy);
            this.Controls.Add(this.numSale);
            this.Controls.Add(this.numQty);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.gridProducts);
            this.Name = "ProductsForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ProductsForm";
            this.Load += new System.EventHandler(this.ProductsForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numBuy)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numSale)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numQty)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridProducts)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblBuy;
        private System.Windows.Forms.Label lblSale;
        private System.Windows.Forms.Label lblQty;

        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.NumericUpDown numBuy;
        private System.Windows.Forms.NumericUpDown numSale;
        private System.Windows.Forms.NumericUpDown numQty;

        private System.Windows.Forms.TextBox txtSearch;

        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnDelete;

        private System.Windows.Forms.DataGridView gridProducts;

        private System.Windows.Forms.DataGridViewTextBoxColumn colId;
        private System.Windows.Forms.DataGridViewTextBoxColumn colName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colBuy;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSale;
        private System.Windows.Forms.DataGridViewTextBoxColumn colQty;
        private System.Windows.Forms.Button button1;
    }
}

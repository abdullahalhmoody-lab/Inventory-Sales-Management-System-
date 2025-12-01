namespace Inventory_Sales_Management_Systemm
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuProducts = new System.Windows.Forms.ToolStripMenuItem();
            this.menuCustomers = new System.Windows.Forms.ToolStripMenuItem();
            this.menuSales = new System.Windows.Forms.ToolStripMenuItem();
            this.menuReports = new System.Windows.Forms.ToolStripMenuItem();
            this.menuLogout = new System.Windows.Forms.ToolStripMenuItem();
            this.menuPersonnelManagement = new System.Windows.Forms.ToolStripMenuItem();
            this.lblUserInfo = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuProducts,
            this.menuCustomers,
            this.menuSales,
            this.menuReports,
            this.menuLogout,
            this.menuPersonnelManagement});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 36);
            this.menuStrip1.TabIndex = 0;
            // 
            // menuProducts
            // 
            this.menuProducts.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.menuProducts.Name = "menuProducts";
            this.menuProducts.Size = new System.Drawing.Size(99, 32);
            this.menuProducts.Text = "المنتجات";
            this.menuProducts.Click += new System.EventHandler(this.menuProducts_Click);
            // 
            // menuCustomers
            // 
            this.menuCustomers.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.menuCustomers.Name = "menuCustomers";
            this.menuCustomers.Size = new System.Drawing.Size(82, 32);
            this.menuCustomers.Text = "العملاء";
            this.menuCustomers.Click += new System.EventHandler(this.menuCustomers_Click);
            // 
            // menuSales
            // 
            this.menuSales.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.menuSales.Name = "menuSales";
            this.menuSales.Size = new System.Drawing.Size(99, 32);
            this.menuSales.Text = "المبيعات";
            this.menuSales.Click += new System.EventHandler(this.menuSales_Click);
            // 
            // menuReports
            // 
            this.menuReports.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.menuReports.ForeColor = System.Drawing.SystemColors.InfoText;
            this.menuReports.Name = "menuReports";
            this.menuReports.Size = new System.Drawing.Size(85, 32);
            this.menuReports.Text = "التقارير";
            this.menuReports.Click += new System.EventHandler(this.menuReports_Click);
            // 
            // menuLogout
            // 
            this.menuLogout.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.menuLogout.BackColor = System.Drawing.Color.Crimson;
            this.menuLogout.Name = "menuLogout";
            this.menuLogout.Size = new System.Drawing.Size(141, 32);
            this.menuLogout.Text = "تسجيل الخروج";
            this.menuLogout.Click += new System.EventHandler(this.menuLogout_Click);
            // 
            // menuPersonnelManagement
            // 
            this.menuPersonnelManagement.AutoToolTip = true;
            this.menuPersonnelManagement.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.menuPersonnelManagement.Name = "menuPersonnelManagement";
            this.menuPersonnelManagement.Size = new System.Drawing.Size(148, 32);
            this.menuPersonnelManagement.Text = "إدارة الموظفين";
            this.menuPersonnelManagement.Click += new System.EventHandler(this.menuPersonnelManagement_Click);
            // 
            // lblUserInfo
            // 
            this.lblUserInfo.AutoSize = true;
            this.lblUserInfo.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblUserInfo.Location = new System.Drawing.Point(24, 448);
            this.lblUserInfo.Name = "lblUserInfo";
            this.lblUserInfo.Size = new System.Drawing.Size(109, 23);
            this.lblUserInfo.TabIndex = 1;
            this.lblUserInfo.Text = "المستخدم: ---";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Inventory_Sales_Management_Systemm.Properties.Resources.مبيعات_اون_لاين;
            this.ClientSize = new System.Drawing.Size(800, 480);
            this.Controls.Add(this.lblUserInfo);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "الصفحة الرئيسية";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem menuProducts;
        private System.Windows.Forms.ToolStripMenuItem menuCustomers;
        private System.Windows.Forms.ToolStripMenuItem menuSales;
        private System.Windows.Forms.ToolStripMenuItem menuReports;
        private System.Windows.Forms.ToolStripMenuItem menuPersonnelManagement;
        private System.Windows.Forms.ToolStripMenuItem menuLogout;
        private System.Windows.Forms.Label lblUserInfo;
    }
}

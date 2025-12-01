namespace Inventory_Sales_Management_Systemm
{
    partial class MainForm2
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
            this.menuProducts2 = new System.Windows.Forms.Button();
            this.menuCustomers2 = new System.Windows.Forms.Button();
            this.menuSales2 = new System.Windows.Forms.Button();
            this.menuReports2 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // menuProducts2
            // 
            this.menuProducts2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.menuProducts2.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuProducts2.Location = new System.Drawing.Point(35, 12);
            this.menuProducts2.Name = "menuProducts2";
            this.menuProducts2.Size = new System.Drawing.Size(111, 37);
            this.menuProducts2.TabIndex = 0;
            this.menuProducts2.Text = "المنتجات";
            this.menuProducts2.UseVisualStyleBackColor = false;
            this.menuProducts2.Click += new System.EventHandler(this.menuProducts2_Click);
            // 
            // menuCustomers2
            // 
            this.menuCustomers2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.menuCustomers2.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuCustomers2.Location = new System.Drawing.Point(165, 14);
            this.menuCustomers2.Name = "menuCustomers2";
            this.menuCustomers2.Size = new System.Drawing.Size(108, 37);
            this.menuCustomers2.TabIndex = 1;
            this.menuCustomers2.Text = "العملاء";
            this.menuCustomers2.UseVisualStyleBackColor = false;
            this.menuCustomers2.Click += new System.EventHandler(this.menuCustomers2_Click_1);
            // 
            // menuSales2
            // 
            this.menuSales2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.menuSales2.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuSales2.Location = new System.Drawing.Point(299, 16);
            this.menuSales2.Name = "menuSales2";
            this.menuSales2.Size = new System.Drawing.Size(102, 35);
            this.menuSales2.TabIndex = 2;
            this.menuSales2.Text = "المبيعات ";
            this.menuSales2.UseVisualStyleBackColor = false;
            this.menuSales2.Click += new System.EventHandler(this.menuSales2_Click_1);
            // 
            // menuReports2
            // 
            this.menuReports2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.menuReports2.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuReports2.Location = new System.Drawing.Point(421, 16);
            this.menuReports2.Name = "menuReports2";
            this.menuReports2.Size = new System.Drawing.Size(103, 35);
            this.menuReports2.TabIndex = 3;
            this.menuReports2.Text = "التقارير ";
            this.menuReports2.UseVisualStyleBackColor = false;
            this.menuReports2.Click += new System.EventHandler(this.menuReports2_Click_1);
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.Silver;
            this.button5.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.Location = new System.Drawing.Point(639, 12);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(159, 37);
            this.button5.TabIndex = 4;
            this.button5.Text = "تسجيل الخروج";
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.button5_Click_1);
            // 
            // MainForm2
            // 
            this.BackgroundImage = global::Inventory_Sales_Management_Systemm.Properties.Resources.La_importancia_de_las_imégenes_en_ecommerce_830x575;
            this.ClientSize = new System.Drawing.Size(823, 525);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.menuReports2);
            this.Controls.Add(this.menuSales2);
            this.Controls.Add(this.menuCustomers2);
            this.Controls.Add(this.menuProducts2);
            this.Name = "MainForm2";
            this.Load += new System.EventHandler(this.MainForm2_Load);
            this.ResumeLayout(false);

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
        private System.Windows.Forms.Button menuProducts2;
        private System.Windows.Forms.Button menuCustomers2;
        private System.Windows.Forms.Button menuSales2;
        private System.Windows.Forms.Button menuReports2;
        private System.Windows.Forms.Button button5;
    }
}

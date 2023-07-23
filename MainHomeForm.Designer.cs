namespace Restaurant_Order_Tracking
{
    partial class MainHomeForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainHomeForm));
            this.pnlsideBar = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pnlSideButtonMarker = new System.Windows.Forms.Panel();
            this.btnOrders = new System.Windows.Forms.Button();
            this.btnCustomerPortal = new System.Windows.Forms.Button();
            this.btnHome = new System.Windows.Forms.Button();
            this.pnlHeadBorder = new System.Windows.Forms.Panel();
            this.lblcloseApp = new System.Windows.Forms.Label();
            this.home1 = new Restaurant_Order_Tracking.Home();
            this.orders1 = new Restaurant_Order_Tracking.Orders();
            this.customerPortal1 = new Restaurant_Order_Tracking.CustomerPortal();
            this.pnlsideBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.pnlHeadBorder.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlsideBar
            // 
            this.pnlsideBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.pnlsideBar.Controls.Add(this.pictureBox1);
            this.pnlsideBar.Controls.Add(this.pnlSideButtonMarker);
            this.pnlsideBar.Controls.Add(this.btnOrders);
            this.pnlsideBar.Controls.Add(this.btnCustomerPortal);
            this.pnlsideBar.Controls.Add(this.btnHome);
            this.pnlsideBar.Location = new System.Drawing.Point(0, -1);
            this.pnlsideBar.Name = "pnlsideBar";
            this.pnlsideBar.Size = new System.Drawing.Size(253, 533);
            this.pnlsideBar.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(30, 13);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(191, 152);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // pnlSideButtonMarker
            // 
            this.pnlSideButtonMarker.BackColor = System.Drawing.Color.Tan;
            this.pnlSideButtonMarker.Location = new System.Drawing.Point(0, 165);
            this.pnlSideButtonMarker.Name = "pnlSideButtonMarker";
            this.pnlSideButtonMarker.Size = new System.Drawing.Size(12, 86);
            this.pnlSideButtonMarker.TabIndex = 2;
            // 
            // btnOrders
            // 
            this.btnOrders.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnOrders.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnOrders.FlatAppearance.BorderSize = 0;
            this.btnOrders.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOrders.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOrders.ForeColor = System.Drawing.Color.Tan;
            this.btnOrders.Location = new System.Drawing.Point(0, 381);
            this.btnOrders.Name = "btnOrders";
            this.btnOrders.Size = new System.Drawing.Size(246, 86);
            this.btnOrders.TabIndex = 2;
            this.btnOrders.Text = "ORDERS";
            this.btnOrders.UseVisualStyleBackColor = false;
            this.btnOrders.Click += new System.EventHandler(this.btnOrders_Click);
            // 
            // btnCustomerPortal
            // 
            this.btnCustomerPortal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnCustomerPortal.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnCustomerPortal.FlatAppearance.BorderSize = 0;
            this.btnCustomerPortal.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCustomerPortal.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCustomerPortal.ForeColor = System.Drawing.Color.Tan;
            this.btnCustomerPortal.Location = new System.Drawing.Point(0, 275);
            this.btnCustomerPortal.Name = "btnCustomerPortal";
            this.btnCustomerPortal.Size = new System.Drawing.Size(246, 86);
            this.btnCustomerPortal.TabIndex = 1;
            this.btnCustomerPortal.Text = "CUSTOMER PORTAL";
            this.btnCustomerPortal.UseVisualStyleBackColor = false;
            this.btnCustomerPortal.Click += new System.EventHandler(this.btnCustomerPortal_Click);
            // 
            // btnHome
            // 
            this.btnHome.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnHome.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnHome.FlatAppearance.BorderSize = 0;
            this.btnHome.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHome.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHome.ForeColor = System.Drawing.Color.Tan;
            this.btnHome.Location = new System.Drawing.Point(0, 171);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(246, 86);
            this.btnHome.TabIndex = 0;
            this.btnHome.Text = "HOME";
            this.btnHome.UseVisualStyleBackColor = false;
            this.btnHome.Click += new System.EventHandler(this.btnHome_Click);
            // 
            // pnlHeadBorder
            // 
            this.pnlHeadBorder.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.pnlHeadBorder.Controls.Add(this.lblcloseApp);
            this.pnlHeadBorder.Location = new System.Drawing.Point(242, -1);
            this.pnlHeadBorder.Name = "pnlHeadBorder";
            this.pnlHeadBorder.Size = new System.Drawing.Size(704, 39);
            this.pnlHeadBorder.TabIndex = 1;
            // 
            // lblcloseApp
            // 
            this.lblcloseApp.AutoSize = true;
            this.lblcloseApp.BackColor = System.Drawing.Color.Transparent;
            this.lblcloseApp.Font = new System.Drawing.Font("Copperplate Gothic Bold", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblcloseApp.ForeColor = System.Drawing.Color.Sienna;
            this.lblcloseApp.Location = new System.Drawing.Point(660, 6);
            this.lblcloseApp.Name = "lblcloseApp";
            this.lblcloseApp.Size = new System.Drawing.Size(31, 26);
            this.lblcloseApp.TabIndex = 5;
            this.lblcloseApp.Text = "X";
            this.lblcloseApp.Click += new System.EventHandler(this.label1_Click);
            this.lblcloseApp.MouseHover += new System.EventHandler(this.lblcloseApp_MouseHover);
            // 
            // home1
            // 
            this.home1.BackColor = System.Drawing.Color.Tan;
            this.home1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.home1.Location = new System.Drawing.Point(243, 31);
            this.home1.MaximumSize = new System.Drawing.Size(700, 500);
            this.home1.MinimumSize = new System.Drawing.Size(700, 500);
            this.home1.Name = "home1";
            this.home1.Size = new System.Drawing.Size(700, 500);
            this.home1.TabIndex = 4;
            // 
            // orders1
            // 
            this.orders1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("orders1.BackgroundImage")));
            this.orders1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.orders1.Location = new System.Drawing.Point(242, 32);
            this.orders1.MaximumSize = new System.Drawing.Size(700, 500);
            this.orders1.MinimumSize = new System.Drawing.Size(700, 500);
            this.orders1.Name = "orders1";
            this.orders1.Size = new System.Drawing.Size(700, 500);
            this.orders1.TabIndex = 3;
            // 
            // customerPortal1
            // 
            this.customerPortal1.BackColor = System.Drawing.Color.Tan;
            this.customerPortal1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("customerPortal1.BackgroundImage")));
            this.customerPortal1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.customerPortal1.ForeColor = System.Drawing.Color.Black;
            this.customerPortal1.Location = new System.Drawing.Point(243, 31);
            this.customerPortal1.MaximumSize = new System.Drawing.Size(700, 500);
            this.customerPortal1.MinimumSize = new System.Drawing.Size(700, 500);
            this.customerPortal1.Name = "customerPortal1";
            this.customerPortal1.Size = new System.Drawing.Size(700, 500);
            this.customerPortal1.TabIndex = 2;
            // 
            // MainHomeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(941, 531);
            this.Controls.Add(this.pnlHeadBorder);
            this.Controls.Add(this.pnlsideBar);
            this.Controls.Add(this.home1);
            this.Controls.Add(this.orders1);
            this.Controls.Add(this.customerPortal1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MainHomeForm";
            this.Load += new System.EventHandler(this.MainHomeForm_Load);
            this.pnlsideBar.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.pnlHeadBorder.ResumeLayout(false);
            this.pnlHeadBorder.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlsideBar;
        private System.Windows.Forms.Panel pnlHeadBorder;
        private System.Windows.Forms.Button btnHome;
        private System.Windows.Forms.Button btnOrders;
        private System.Windows.Forms.Button btnCustomerPortal;
        private System.Windows.Forms.Panel pnlSideButtonMarker;
        private System.Windows.Forms.PictureBox pictureBox1;
        private CustomerPortal customerPortal1;
        private Orders orders1;
        private Home home1;
        private System.Windows.Forms.Label lblcloseApp;
    }
}


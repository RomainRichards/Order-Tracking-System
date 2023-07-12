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
            this.pnlsideBar = new System.Windows.Forms.Panel();
            this.pnlHeadBorder = new System.Windows.Forms.Panel();
            this.btnHome = new System.Windows.Forms.Button();
            this.btnCustomerPortal = new System.Windows.Forms.Button();
            this.btnOrders = new System.Windows.Forms.Button();
            this.pnlSideButtonMarker = new System.Windows.Forms.Panel();
            this.pnlsideBar.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlsideBar
            // 
            this.pnlsideBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.pnlsideBar.Controls.Add(this.pnlSideButtonMarker);
            this.pnlsideBar.Controls.Add(this.btnOrders);
            this.pnlsideBar.Controls.Add(this.btnCustomerPortal);
            this.pnlsideBar.Controls.Add(this.btnHome);
            this.pnlsideBar.Location = new System.Drawing.Point(0, -1);
            this.pnlsideBar.Name = "pnlsideBar";
            this.pnlsideBar.Size = new System.Drawing.Size(246, 623);
            this.pnlsideBar.TabIndex = 0;
            // 
            // pnlHeadBorder
            // 
            this.pnlHeadBorder.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.pnlHeadBorder.Location = new System.Drawing.Point(242, -1);
            this.pnlHeadBorder.Name = "pnlHeadBorder";
            this.pnlHeadBorder.Size = new System.Drawing.Size(861, 43);
            this.pnlHeadBorder.TabIndex = 1;
            // 
            // btnHome
            // 
            this.btnHome.BackColor = System.Drawing.Color.Transparent;
            this.btnHome.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnHome.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHome.ForeColor = System.Drawing.Color.Tan;
            this.btnHome.Location = new System.Drawing.Point(0, 165);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(246, 86);
            this.btnHome.TabIndex = 0;
            this.btnHome.Text = "HOME";
            this.btnHome.UseVisualStyleBackColor = false;
            this.btnHome.Click += new System.EventHandler(this.btnHome_Click);
            // 
            // btnCustomerPortal
            // 
            this.btnCustomerPortal.BackColor = System.Drawing.Color.Transparent;
            this.btnCustomerPortal.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCustomerPortal.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCustomerPortal.ForeColor = System.Drawing.Color.Tan;
            this.btnCustomerPortal.Location = new System.Drawing.Point(0, 269);
            this.btnCustomerPortal.Name = "btnCustomerPortal";
            this.btnCustomerPortal.Size = new System.Drawing.Size(246, 86);
            this.btnCustomerPortal.TabIndex = 1;
            this.btnCustomerPortal.Text = "CUSTOME PORTAL";
            this.btnCustomerPortal.UseVisualStyleBackColor = false;
            this.btnCustomerPortal.Click += new System.EventHandler(this.btnCustomerPortal_Click);
            // 
            // btnOrders
            // 
            this.btnOrders.BackColor = System.Drawing.Color.Transparent;
            this.btnOrders.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnOrders.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOrders.ForeColor = System.Drawing.Color.Tan;
            this.btnOrders.Location = new System.Drawing.Point(0, 375);
            this.btnOrders.Name = "btnOrders";
            this.btnOrders.Size = new System.Drawing.Size(246, 86);
            this.btnOrders.TabIndex = 2;
            this.btnOrders.Text = "ORDERS";
            this.btnOrders.UseVisualStyleBackColor = false;
            this.btnOrders.Click += new System.EventHandler(this.btnOrders_Click);
            // 
            // pnlSideButtonMarker
            // 
            this.pnlSideButtonMarker.BackColor = System.Drawing.Color.Tan;
            this.pnlSideButtonMarker.Location = new System.Drawing.Point(0, 165);
            this.pnlSideButtonMarker.Name = "pnlSideButtonMarker";
            this.pnlSideButtonMarker.Size = new System.Drawing.Size(12, 86);
            this.pnlSideButtonMarker.TabIndex = 2;
            // 
            // MainHomeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1103, 622);
            this.Controls.Add(this.pnlHeadBorder);
            this.Controls.Add(this.pnlsideBar);
            this.Name = "MainHomeForm";
            this.pnlsideBar.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlsideBar;
        private System.Windows.Forms.Panel pnlHeadBorder;
        private System.Windows.Forms.Button btnHome;
        private System.Windows.Forms.Button btnOrders;
        private System.Windows.Forms.Button btnCustomerPortal;
        private System.Windows.Forms.Panel pnlSideButtonMarker;
    }
}


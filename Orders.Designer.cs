namespace Restaurant_Order_Tracking
{
    partial class Orders
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Orders));
            this.lblNextOrd = new System.Windows.Forms.Label();
            this.btnserveOrd = new System.Windows.Forms.Button();
            this.txtbxNextCust = new System.Windows.Forms.TextBox();
            this.dataGVOrders = new System.Windows.Forms.DataGridView();
            this.btntotOrd = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGVOrders)).BeginInit();
            this.SuspendLayout();
            // 
            // lblNextOrd
            // 
            this.lblNextOrd.AutoSize = true;
            this.lblNextOrd.BackColor = System.Drawing.Color.Tan;
            this.lblNextOrd.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNextOrd.ForeColor = System.Drawing.Color.Black;
            this.lblNextOrd.Location = new System.Drawing.Point(56, 75);
            this.lblNextOrd.Name = "lblNextOrd";
            this.lblNextOrd.Size = new System.Drawing.Size(108, 19);
            this.lblNextOrd.TabIndex = 23;
            this.lblNextOrd.Text = "Next Order :";
            // 
            // btnserveOrd
            // 
            this.btnserveOrd.BackColor = System.Drawing.Color.Tan;
            this.btnserveOrd.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnserveOrd.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnserveOrd.ForeColor = System.Drawing.Color.Black;
            this.btnserveOrd.Location = new System.Drawing.Point(419, 377);
            this.btnserveOrd.Name = "btnserveOrd";
            this.btnserveOrd.Size = new System.Drawing.Size(116, 52);
            this.btnserveOrd.TabIndex = 22;
            this.btnserveOrd.Text = "Serve Order";
            this.btnserveOrd.UseVisualStyleBackColor = false;
            this.btnserveOrd.Click += new System.EventHandler(this.btnserveOrd_Click);
            // 
            // txtbxNextCust
            // 
            this.txtbxNextCust.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbxNextCust.Location = new System.Drawing.Point(183, 73);
            this.txtbxNextCust.Name = "txtbxNextCust";
            this.txtbxNextCust.ReadOnly = true;
            this.txtbxNextCust.Size = new System.Drawing.Size(451, 26);
            this.txtbxNextCust.TabIndex = 20;
            // 
            // dataGVOrders
            // 
            this.dataGVOrders.BackgroundColor = System.Drawing.Color.White;
            this.dataGVOrders.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGVOrders.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGVOrders.GridColor = System.Drawing.Color.Tan;
            this.dataGVOrders.Location = new System.Drawing.Point(60, 121);
            this.dataGVOrders.Name = "dataGVOrders";
            this.dataGVOrders.ReadOnly = true;
            this.dataGVOrders.RowHeadersWidth = 51;
            this.dataGVOrders.RowTemplate.Height = 24;
            this.dataGVOrders.Size = new System.Drawing.Size(572, 230);
            this.dataGVOrders.TabIndex = 19;
            // 
            // btntotOrd
            // 
            this.btntotOrd.BackColor = System.Drawing.Color.Tan;
            this.btntotOrd.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btntotOrd.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btntotOrd.ForeColor = System.Drawing.Color.Black;
            this.btntotOrd.Location = new System.Drawing.Point(161, 377);
            this.btntotOrd.Name = "btntotOrd";
            this.btntotOrd.Size = new System.Drawing.Size(105, 51);
            this.btntotOrd.TabIndex = 24;
            this.btntotOrd.Text = "Total Orders";
            this.btntotOrd.UseVisualStyleBackColor = false;
            this.btntotOrd.Click += new System.EventHandler(this.btntotOrd_Click);
            // 
            // Orders
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Controls.Add(this.btntotOrd);
            this.Controls.Add(this.lblNextOrd);
            this.Controls.Add(this.btnserveOrd);
            this.Controls.Add(this.txtbxNextCust);
            this.Controls.Add(this.dataGVOrders);
            this.MinimumSize = new System.Drawing.Size(700, 500);
            this.Name = "Orders";
            this.Size = new System.Drawing.Size(700, 500);
            ((System.ComponentModel.ISupportInitialize)(this.dataGVOrders)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNextOrd;
        private System.Windows.Forms.Button btnserveOrd;
        private System.Windows.Forms.TextBox txtbxNextCust;
        private System.Windows.Forms.DataGridView dataGVOrders;
        private System.Windows.Forms.Button btntotOrd;
    }
}

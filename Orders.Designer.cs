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
            this.richtxtordServe = new System.Windows.Forms.RichTextBox();
            this.richtxtordMade = new System.Windows.Forms.RichTextBox();
            this.btnMkOrd = new System.Windows.Forms.Button();
            this.btnservOrd = new System.Windows.Forms.Button();
            this.richtxtOrderHolder = new System.Windows.Forms.RichTextBox();
            this.lblordTaken = new System.Windows.Forms.Label();
            this.lblordMade = new System.Windows.Forms.Label();
            this.lblordserv = new System.Windows.Forms.Label();
            this.richtxtnextOrd = new System.Windows.Forms.RichTextBox();
            this.lblnextOrd = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // richtxtordServe
            // 
            this.richtxtordServe.Location = new System.Drawing.Point(628, 107);
            this.richtxtordServe.Name = "richtxtordServe";
            this.richtxtordServe.Size = new System.Drawing.Size(246, 327);
            this.richtxtordServe.TabIndex = 1;
            this.richtxtordServe.Text = "";
            // 
            // richtxtordMade
            // 
            this.richtxtordMade.Location = new System.Drawing.Point(451, 102);
            this.richtxtordMade.Name = "richtxtordMade";
            this.richtxtordMade.Size = new System.Drawing.Size(140, 327);
            this.richtxtordMade.TabIndex = 2;
            this.richtxtordMade.Text = "";
            // 
            // btnMkOrd
            // 
            this.btnMkOrd.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMkOrd.Location = new System.Drawing.Point(386, 463);
            this.btnMkOrd.Name = "btnMkOrd";
            this.btnMkOrd.Size = new System.Drawing.Size(132, 44);
            this.btnMkOrd.TabIndex = 3;
            this.btnMkOrd.Text = "Make Order";
            this.btnMkOrd.UseVisualStyleBackColor = true;
            this.btnMkOrd.Click += new System.EventHandler(this.btnMkOrd_Click);
            // 
            // btnservOrd
            // 
            this.btnservOrd.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnservOrd.Location = new System.Drawing.Point(686, 463);
            this.btnservOrd.Name = "btnservOrd";
            this.btnservOrd.Size = new System.Drawing.Size(132, 44);
            this.btnservOrd.TabIndex = 4;
            this.btnservOrd.Text = "Serve Order";
            this.btnservOrd.UseVisualStyleBackColor = true;
            // 
            // richtxtOrderHolder
            // 
            this.richtxtOrderHolder.Location = new System.Drawing.Point(7, 61);
            this.richtxtOrderHolder.Name = "richtxtOrderHolder";
            this.richtxtOrderHolder.Size = new System.Drawing.Size(891, 390);
            this.richtxtOrderHolder.TabIndex = 5;
            this.richtxtOrderHolder.Text = "";
            // 
            // lblordTaken
            // 
            this.lblordTaken.AutoSize = true;
            this.lblordTaken.BackColor = System.Drawing.Color.White;
            this.lblordTaken.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblordTaken.ForeColor = System.Drawing.Color.Black;
            this.lblordTaken.Location = new System.Drawing.Point(93, 80);
            this.lblordTaken.Name = "lblordTaken";
            this.lblordTaken.Size = new System.Drawing.Size(117, 19);
            this.lblordTaken.TabIndex = 6;
            this.lblordTaken.Text = "Orders Taken";
            // 
            // lblordMade
            // 
            this.lblordMade.AutoSize = true;
            this.lblordMade.BackColor = System.Drawing.Color.White;
            this.lblordMade.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblordMade.ForeColor = System.Drawing.Color.Black;
            this.lblordMade.Location = new System.Drawing.Point(436, 80);
            this.lblordMade.Name = "lblordMade";
            this.lblordMade.Size = new System.Drawing.Size(167, 19);
            this.lblordMade.TabIndex = 7;
            this.lblordMade.Text = "Orders Being Made";
            // 
            // lblordserv
            // 
            this.lblordserv.AutoSize = true;
            this.lblordserv.BackColor = System.Drawing.Color.White;
            this.lblordserv.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblordserv.ForeColor = System.Drawing.Color.Black;
            this.lblordserv.Location = new System.Drawing.Point(667, 80);
            this.lblordserv.Name = "lblordserv";
            this.lblordserv.Size = new System.Drawing.Size(176, 19);
            this.lblordserv.TabIndex = 8;
            this.lblordserv.Text = "Orders Being Served";
            // 
            // richtxtnextOrd
            // 
            this.richtxtnextOrd.Location = new System.Drawing.Point(403, 10);
            this.richtxtnextOrd.Name = "richtxtnextOrd";
            this.richtxtnextOrd.Size = new System.Drawing.Size(174, 32);
            this.richtxtnextOrd.TabIndex = 9;
            this.richtxtnextOrd.Text = "";
            // 
            // lblnextOrd
            // 
            this.lblnextOrd.AutoSize = true;
            this.lblnextOrd.BackColor = System.Drawing.Color.White;
            this.lblnextOrd.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblnextOrd.ForeColor = System.Drawing.Color.Black;
            this.lblnextOrd.Location = new System.Drawing.Point(287, 23);
            this.lblnextOrd.Name = "lblnextOrd";
            this.lblnextOrd.Size = new System.Drawing.Size(98, 19);
            this.lblnextOrd.TabIndex = 10;
            this.lblnextOrd.Text = "Next Order";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(73, 118);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(745, 289);
            this.dataGridView1.TabIndex = 11;
            // 
            // Orders
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.lblnextOrd);
            this.Controls.Add(this.richtxtnextOrd);
            this.Controls.Add(this.lblordserv);
            this.Controls.Add(this.lblordMade);
            this.Controls.Add(this.lblordTaken);
            this.Controls.Add(this.btnservOrd);
            this.Controls.Add(this.btnMkOrd);
            this.Controls.Add(this.richtxtordMade);
            this.Controls.Add(this.richtxtordServe);
            this.Controls.Add(this.richtxtOrderHolder);
            this.MinimumSize = new System.Drawing.Size(898, 586);
            this.Name = "Orders";
            this.Size = new System.Drawing.Size(898, 589);
            this.Load += new System.EventHandler(this.Orders_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.RichTextBox richtxtordServe;
        private System.Windows.Forms.Button btnMkOrd;
        private System.Windows.Forms.Button btnservOrd;
        private System.Windows.Forms.RichTextBox richtxtOrderHolder;
        private System.Windows.Forms.Label lblordTaken;
        private System.Windows.Forms.Label lblordMade;
        private System.Windows.Forms.Label lblordserv;
        private System.Windows.Forms.RichTextBox richtxtnextOrd;
        private System.Windows.Forms.Label lblnextOrd;
        public System.Windows.Forms.RichTextBox richtxtordMade;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}

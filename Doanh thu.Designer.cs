namespace Quản_lý_bán_hàng
{
    partial class formDT
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(formDT));
            this.label1 = new System.Windows.Forms.Label();
            this.lblnguoilap = new System.Windows.Forms.Label();
            this.lblngaylap = new System.Windows.Forms.Label();
            this.pck = new System.Windows.Forms.DateTimePicker();
            this.btnthoat = new System.Windows.Forms.Button();
            this.btnin = new System.Windows.Forms.Button();
            this.btnDT = new System.Windows.Forms.Button();
            this.txtDT = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 17.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.Location = new System.Drawing.Point(218, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(202, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Báo cáo doanh thu";
            // 
            // lblnguoilap
            // 
            this.lblnguoilap.AutoSize = true;
            this.lblnguoilap.Location = new System.Drawing.Point(52, 70);
            this.lblnguoilap.Name = "lblnguoilap";
            this.lblnguoilap.Size = new System.Drawing.Size(81, 15);
            this.lblnguoilap.TabIndex = 1;
            this.lblnguoilap.Text = "Tên người lập";
            // 
            // lblngaylap
            // 
            this.lblngaylap.AutoSize = true;
            this.lblngaylap.Location = new System.Drawing.Point(333, 67);
            this.lblngaylap.Name = "lblngaylap";
            this.lblngaylap.Size = new System.Drawing.Size(55, 15);
            this.lblngaylap.TabIndex = 4;
            this.lblngaylap.Text = "Ngày lập";
            // 
            // pck
            // 
            this.pck.Location = new System.Drawing.Point(425, 63);
            this.pck.Name = "pck";
            this.pck.Size = new System.Drawing.Size(160, 22);
            this.pck.TabIndex = 5;
            // 
            // btnthoat
            // 
            this.btnthoat.Location = new System.Drawing.Point(197, 416);
            this.btnthoat.Name = "btnthoat";
            this.btnthoat.Size = new System.Drawing.Size(75, 23);
            this.btnthoat.TabIndex = 6;
            this.btnthoat.Text = "Thoát";
            this.btnthoat.UseVisualStyleBackColor = true;
            this.btnthoat.Click += new System.EventHandler(this.btnthoat_Click);
            // 
            // btnin
            // 
            this.btnin.Location = new System.Drawing.Point(373, 416);
            this.btnin.Name = "btnin";
            this.btnin.Size = new System.Drawing.Size(75, 23);
            this.btnin.TabIndex = 7;
            this.btnin.Text = "In";
            this.btnin.UseVisualStyleBackColor = true;
            this.btnin.Click += new System.EventHandler(this.btnin_Click);
            // 
            // btnDT
            // 
            this.btnDT.BackColor = System.Drawing.SystemColors.Control;
            this.btnDT.Location = new System.Drawing.Point(167, 376);
            this.btnDT.Name = "btnDT";
            this.btnDT.Size = new System.Drawing.Size(122, 23);
            this.btnDT.TabIndex = 10;
            this.btnDT.Text = "Tổng doanh thu";
            this.btnDT.UseVisualStyleBackColor = false;
            this.btnDT.Click += new System.EventHandler(this.btnDT_Click);
            // 
            // txtDT
            // 
            this.txtDT.Location = new System.Drawing.Point(360, 376);
            this.txtDT.Name = "txtDT";
            this.txtDT.Size = new System.Drawing.Size(118, 22);
            this.txtDT.TabIndex = 11;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(18, 115);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(620, 255);
            this.dataGridView1.TabIndex = 12;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(167, 67);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(99, 22);
            this.textBox1.TabIndex = 13;
            this.textBox1.Text = "   Mai Phương";
            // 
            // printPreviewDialog1
            // 
            this.printPreviewDialog1.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreviewDialog1.Enabled = true;
            this.printPreviewDialog1.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialog1.Icon")));
            this.printPreviewDialog1.Name = "printPreviewDialog1";
            this.printPreviewDialog1.Visible = false;
            // 
            // printDocument1
            // 
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage);
            // 
            // formDT
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(663, 451);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.txtDT);
            this.Controls.Add(this.btnDT);
            this.Controls.Add(this.btnin);
            this.Controls.Add(this.btnthoat);
            this.Controls.Add(this.pck);
            this.Controls.Add(this.lblngaylap);
            this.Controls.Add(this.lblnguoilap);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.Name = "formDT";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Báo cáo";
            this.Load += new System.EventHandler(this.formDT_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblnguoilap;
        private System.Windows.Forms.Label lblngaylap;
        private System.Windows.Forms.DateTimePicker pck;
        private System.Windows.Forms.Button btnthoat;
        private System.Windows.Forms.Button btnin;
        private System.Windows.Forms.Button btnDT;
        private System.Windows.Forms.TextBox txtDT;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
        private System.Drawing.Printing.PrintDocument printDocument1;
    }
}
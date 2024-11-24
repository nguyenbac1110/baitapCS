namespace Bai4
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.btncapnhap = new System.Windows.Forms.Button();
            this.txtnhap = new System.Windows.Forms.TextBox();
            this.list = new System.Windows.Forms.ListBox();
            this.groupBox = new System.Windows.Forms.GroupBox();
            this.btntang2 = new System.Windows.Forms.Button();
            this.btnfirstchan = new System.Windows.Forms.Button();
            this.btnlastle = new System.Windows.Forms.Button();
            this.btndelchon = new System.Windows.Forms.Button();
            this.btndelfirst = new System.Windows.Forms.Button();
            this.btndellast = new System.Windows.Forms.Button();
            this.btnthoat = new System.Windows.Forms.Button();
            this.btnthem = new System.Windows.Forms.Button();
            this.groupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(47, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nhập số nguyên";
            // 
            // btncapnhap
            // 
            this.btncapnhap.Location = new System.Drawing.Point(655, 32);
            this.btncapnhap.Name = "btncapnhap";
            this.btncapnhap.Size = new System.Drawing.Size(94, 34);
            this.btncapnhap.TabIndex = 1;
            this.btncapnhap.Text = "Cập nhập";
            this.btncapnhap.UseVisualStyleBackColor = true;
            this.btncapnhap.Click += new System.EventHandler(this.btncapnhap_Click);
            // 
            // txtnhap
            // 
            this.txtnhap.Location = new System.Drawing.Point(188, 32);
            this.txtnhap.Name = "txtnhap";
            this.txtnhap.Size = new System.Drawing.Size(429, 22);
            this.txtnhap.TabIndex = 2;
            // 
            // list
            // 
            this.list.FormattingEnabled = true;
            this.list.ItemHeight = 16;
            this.list.Location = new System.Drawing.Point(37, 83);
            this.list.Name = "list";
            this.list.Size = new System.Drawing.Size(262, 260);
            this.list.TabIndex = 3;
            // 
            // groupBox
            // 
            this.groupBox.Controls.Add(this.btndellast);
            this.groupBox.Controls.Add(this.btndelfirst);
            this.groupBox.Controls.Add(this.btndelchon);
            this.groupBox.Controls.Add(this.btnlastle);
            this.groupBox.Controls.Add(this.btnfirstchan);
            this.groupBox.Controls.Add(this.btntang2);
            this.groupBox.Location = new System.Drawing.Point(400, 83);
            this.groupBox.Name = "groupBox";
            this.groupBox.Size = new System.Drawing.Size(330, 260);
            this.groupBox.TabIndex = 4;
            this.groupBox.TabStop = false;
            this.groupBox.Text = "Chức năng";
            // 
            // btntang2
            // 
            this.btntang2.Location = new System.Drawing.Point(22, 31);
            this.btntang2.Name = "btntang2";
            this.btntang2.Size = new System.Drawing.Size(302, 23);
            this.btntang2.TabIndex = 0;
            this.btntang2.Text = "tăng mỗi phần tử lên 2";
            this.btntang2.UseVisualStyleBackColor = true;
            this.btntang2.Click += new System.EventHandler(this.btntang2_Click);
            // 
            // btnfirstchan
            // 
            this.btnfirstchan.Location = new System.Drawing.Point(22, 71);
            this.btnfirstchan.Name = "btnfirstchan";
            this.btnfirstchan.Size = new System.Drawing.Size(302, 23);
            this.btnfirstchan.TabIndex = 1;
            this.btnfirstchan.Text = "chọn số chắn đầu";
            this.btnfirstchan.UseVisualStyleBackColor = true;
            this.btnfirstchan.Click += new System.EventHandler(this.btnfirstchan_Click);
            // 
            // btnlastle
            // 
            this.btnlastle.Location = new System.Drawing.Point(22, 100);
            this.btnlastle.Name = "btnlastle";
            this.btnlastle.Size = new System.Drawing.Size(302, 23);
            this.btnlastle.TabIndex = 2;
            this.btnlastle.Text = "chọn số lẻ ở cuối";
            this.btnlastle.UseVisualStyleBackColor = true;
            this.btnlastle.Click += new System.EventHandler(this.btnlastle_Click);
            // 
            // btndelchon
            // 
            this.btndelchon.Location = new System.Drawing.Point(22, 145);
            this.btndelchon.Name = "btndelchon";
            this.btndelchon.Size = new System.Drawing.Size(302, 23);
            this.btndelchon.TabIndex = 3;
            this.btndelchon.Text = "Xóa phần tử đang chọn";
            this.btndelchon.UseVisualStyleBackColor = true;
            this.btndelchon.Click += new System.EventHandler(this.btndelchon_Click);
            // 
            // btndelfirst
            // 
            this.btndelfirst.Location = new System.Drawing.Point(22, 174);
            this.btndelfirst.Name = "btndelfirst";
            this.btndelfirst.Size = new System.Drawing.Size(302, 23);
            this.btndelfirst.TabIndex = 4;
            this.btndelfirst.Text = "Xóa phần tử đầu";
            this.btndelfirst.UseVisualStyleBackColor = true;
            this.btndelfirst.Click += new System.EventHandler(this.btndelfirst_Click);
            // 
            // btndellast
            // 
            this.btndellast.Location = new System.Drawing.Point(22, 212);
            this.btndellast.Name = "btndellast";
            this.btndellast.Size = new System.Drawing.Size(302, 23);
            this.btndellast.TabIndex = 5;
            this.btndellast.Text = "Xóa phần tử cuối";
            this.btndellast.UseVisualStyleBackColor = true;
            this.btndellast.Click += new System.EventHandler(this.btndellast_Click);
            // 
            // btnthoat
            // 
            this.btnthoat.Location = new System.Drawing.Point(37, 401);
            this.btnthoat.Name = "btnthoat";
            this.btnthoat.Size = new System.Drawing.Size(687, 23);
            this.btnthoat.TabIndex = 6;
            this.btnthoat.Text = "Thoát";
            this.btnthoat.UseVisualStyleBackColor = true;
            this.btnthoat.Click += new System.EventHandler(this.btnthoat_Click);
            // 
            // btnthem
            // 
            this.btnthem.Location = new System.Drawing.Point(803, 35);
            this.btnthem.Name = "btnthem";
            this.btnthem.Size = new System.Drawing.Size(75, 23);
            this.btnthem.TabIndex = 7;
            this.btnthem.Text = "Thêm 10 số";
            this.btnthem.UseVisualStyleBackColor = true;
            this.btnthem.Click += new System.EventHandler(this.btnthem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1004, 521);
            this.Controls.Add(this.btnthem);
            this.Controls.Add(this.btnthoat);
            this.Controls.Add(this.groupBox);
            this.Controls.Add(this.list);
            this.Controls.Add(this.txtnhap);
            this.Controls.Add(this.btncapnhap);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btncapnhap;
        private System.Windows.Forms.TextBox txtnhap;
        private System.Windows.Forms.ListBox list;
        private System.Windows.Forms.GroupBox groupBox;
        private System.Windows.Forms.Button btndellast;
        private System.Windows.Forms.Button btndelfirst;
        private System.Windows.Forms.Button btndelchon;
        private System.Windows.Forms.Button btnlastle;
        private System.Windows.Forms.Button btnfirstchan;
        private System.Windows.Forms.Button btntang2;
        private System.Windows.Forms.Button btnthoat;
        private System.Windows.Forms.Button btnthem;
    }
}


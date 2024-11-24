namespace Bai3_btvn
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
            this.label2 = new System.Windows.Forms.Label();
            this.txta = new System.Windows.Forms.TextBox();
            this.btncapnhap = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btndiphai = new System.Windows.Forms.Button();
            this.btnditrai = new System.Windows.Forms.Button();
            this.btnchuyenphai = new System.Windows.Forms.Button();
            this.btnchuyentrai = new System.Windows.Forms.Button();
            this.btnxoa = new System.Windows.Forms.Button();
            this.btnend = new System.Windows.Forms.Button();
            this.listA = new System.Windows.Forms.ListBox();
            this.listB = new System.Windows.Forms.ListBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(153, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(252, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "DANH SÁCH SINH VIÊN";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(81, 88);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Họ và tên: ";
            // 
            // txta
            // 
            this.txta.Location = new System.Drawing.Point(178, 88);
            this.txta.Name = "txta";
            this.txta.Size = new System.Drawing.Size(227, 22);
            this.txta.TabIndex = 2;
            // 
            // btncapnhap
            // 
            this.btncapnhap.Location = new System.Drawing.Point(467, 75);
            this.btncapnhap.Name = "btncapnhap";
            this.btncapnhap.Size = new System.Drawing.Size(108, 43);
            this.btncapnhap.TabIndex = 3;
            this.btncapnhap.Text = "Cập nhập";
            this.btncapnhap.UseVisualStyleBackColor = true;
            this.btncapnhap.Click += new System.EventHandler(this.btncapnhap_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.listA);
            this.groupBox1.Location = new System.Drawing.Point(32, 134);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(212, 254);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Lớp A";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.listB);
            this.groupBox2.Location = new System.Drawing.Point(497, 134);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(212, 254);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Lớp B";
            // 
            // btndiphai
            // 
            this.btndiphai.Location = new System.Drawing.Point(267, 197);
            this.btndiphai.Name = "btndiphai";
            this.btndiphai.Size = new System.Drawing.Size(68, 23);
            this.btndiphai.TabIndex = 6;
            this.btndiphai.Text = ">";
            this.btndiphai.UseVisualStyleBackColor = true;
            this.btndiphai.Click += new System.EventHandler(this.btndiphai_Click);
            // 
            // btnditrai
            // 
            this.btnditrai.Location = new System.Drawing.Point(376, 197);
            this.btnditrai.Name = "btnditrai";
            this.btnditrai.Size = new System.Drawing.Size(68, 23);
            this.btnditrai.TabIndex = 7;
            this.btnditrai.Text = "<";
            this.btnditrai.UseVisualStyleBackColor = true;
            this.btnditrai.Click += new System.EventHandler(this.btnditrai_Click);
            // 
            // btnchuyenphai
            // 
            this.btnchuyenphai.Location = new System.Drawing.Point(267, 249);
            this.btnchuyenphai.Name = "btnchuyenphai";
            this.btnchuyenphai.Size = new System.Drawing.Size(68, 23);
            this.btnchuyenphai.TabIndex = 8;
            this.btnchuyenphai.Text = ">>";
            this.btnchuyenphai.UseVisualStyleBackColor = true;
            this.btnchuyenphai.Click += new System.EventHandler(this.btnchuyenphai_Click);
            // 
            // btnchuyentrai
            // 
            this.btnchuyentrai.Location = new System.Drawing.Point(376, 249);
            this.btnchuyentrai.Name = "btnchuyentrai";
            this.btnchuyentrai.Size = new System.Drawing.Size(68, 23);
            this.btnchuyentrai.TabIndex = 9;
            this.btnchuyentrai.Text = "<<";
            this.btnchuyentrai.UseVisualStyleBackColor = true;
            this.btnchuyentrai.Click += new System.EventHandler(this.btnchuyentrai_Click);
            // 
            // btnxoa
            // 
            this.btnxoa.Location = new System.Drawing.Point(84, 406);
            this.btnxoa.Name = "btnxoa";
            this.btnxoa.Size = new System.Drawing.Size(75, 23);
            this.btnxoa.TabIndex = 10;
            this.btnxoa.Text = "Xóa";
            this.btnxoa.UseVisualStyleBackColor = true;
            this.btnxoa.Click += new System.EventHandler(this.btnxoa_Click);
            // 
            // btnend
            // 
            this.btnend.Location = new System.Drawing.Point(559, 406);
            this.btnend.Name = "btnend";
            this.btnend.Size = new System.Drawing.Size(75, 23);
            this.btnend.TabIndex = 11;
            this.btnend.Text = "Kết thúc";
            this.btnend.UseVisualStyleBackColor = true;
            // 
            // listA
            // 
            this.listA.FormattingEnabled = true;
            this.listA.ItemHeight = 16;
            this.listA.Location = new System.Drawing.Point(16, 26);
            this.listA.Name = "listA";
            this.listA.Size = new System.Drawing.Size(172, 212);
            this.listA.TabIndex = 0;
            // 
            // listB
            // 
            this.listB.FormattingEnabled = true;
            this.listB.ItemHeight = 16;
            this.listB.Location = new System.Drawing.Point(6, 21);
            this.listB.Name = "listB";
            this.listB.Size = new System.Drawing.Size(172, 212);
            this.listB.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnend);
            this.Controls.Add(this.btnxoa);
            this.Controls.Add(this.btnchuyentrai);
            this.Controls.Add(this.btnchuyenphai);
            this.Controls.Add(this.btnditrai);
            this.Controls.Add(this.btndiphai);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btncapnhap);
            this.Controls.Add(this.txta);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txta;
        private System.Windows.Forms.Button btncapnhap;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btndiphai;
        private System.Windows.Forms.Button btnditrai;
        private System.Windows.Forms.Button btnchuyenphai;
        private System.Windows.Forms.Button btnchuyentrai;
        private System.Windows.Forms.Button btnxoa;
        private System.Windows.Forms.Button btnend;
        private System.Windows.Forms.ListBox listA;
        private System.Windows.Forms.ListBox listB;
    }
}


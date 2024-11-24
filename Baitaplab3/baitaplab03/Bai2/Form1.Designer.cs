namespace Bai2
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
            this.rtbtt = new System.Windows.Forms.RichTextBox();
            this.btnhauto = new System.Windows.Forms.Button();
            this.btnthoat = new System.Windows.Forms.Button();
            this.rtbht = new System.Windows.Forms.RichTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(237, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(510, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "chuyển biểu thức trung tố đầy đủ ngoặc sang hậu tố";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(22, 83);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(183, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nhập biểu thức trung tố";
            // 
            // rtbtt
            // 
            this.rtbtt.Location = new System.Drawing.Point(26, 107);
            this.rtbtt.Name = "rtbtt";
            this.rtbtt.Size = new System.Drawing.Size(884, 150);
            this.rtbtt.TabIndex = 2;
            this.rtbtt.Text = "";
            this.rtbtt.TextChanged += new System.EventHandler(this.rtbtt_TextChanged);
            // 
            // btnhauto
            // 
            this.btnhauto.Enabled = false;
            this.btnhauto.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnhauto.Location = new System.Drawing.Point(173, 293);
            this.btnhauto.Name = "btnhauto";
            this.btnhauto.Size = new System.Drawing.Size(181, 39);
            this.btnhauto.TabIndex = 3;
            this.btnhauto.Text = "Chuyển hậu tố";
            this.btnhauto.UseVisualStyleBackColor = true;
            this.btnhauto.Click += new System.EventHandler(this.btnhauto_Click);
            // 
            // btnthoat
            // 
            this.btnthoat.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnthoat.Location = new System.Drawing.Point(445, 293);
            this.btnthoat.Name = "btnthoat";
            this.btnthoat.Size = new System.Drawing.Size(85, 29);
            this.btnthoat.TabIndex = 4;
            this.btnthoat.Text = "Thoát";
            this.btnthoat.UseVisualStyleBackColor = true;
            this.btnthoat.Click += new System.EventHandler(this.btnthoat_Click);
            // 
            // rtbht
            // 
            this.rtbht.Enabled = false;
            this.rtbht.Location = new System.Drawing.Point(26, 398);
            this.rtbht.Name = "rtbht";
            this.rtbht.Size = new System.Drawing.Size(884, 150);
            this.rtbht.TabIndex = 6;
            this.rtbht.Text = "";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(22, 359);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(131, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "Biểu thức hậu tố";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(980, 620);
            this.Controls.Add(this.rtbht);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnthoat);
            this.Controls.Add(this.btnhauto);
            this.Controls.Add(this.rtbtt);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RichTextBox rtbtt;
        private System.Windows.Forms.Button btnhauto;
        private System.Windows.Forms.Button btnthoat;
        private System.Windows.Forms.RichTextBox rtbht;
        private System.Windows.Forms.Label label3;
    }
}


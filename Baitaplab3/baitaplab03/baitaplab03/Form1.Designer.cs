namespace baitaplab03
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
            this.texta = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textb = new System.Windows.Forms.TextBox();
            this.btnktra = new System.Windows.Forms.Button();
            this.btngpt = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(177, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(302, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Bất phương trình ax+b <0";
            // 
            // texta
            // 
            this.texta.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.texta.Location = new System.Drawing.Point(237, 112);
            this.texta.Name = "texta";
            this.texta.Size = new System.Drawing.Size(163, 28);
            this.texta.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(101, 112);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 22);
            this.label2.TabIndex = 2;
            this.label2.Text = "Nhập a";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(101, 168);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 22);
            this.label3.TabIndex = 4;
            this.label3.Text = "Nhập b";
            // 
            // textb
            // 
            this.textb.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textb.Location = new System.Drawing.Point(237, 168);
            this.textb.Name = "textb";
            this.textb.Size = new System.Drawing.Size(163, 28);
            this.textb.TabIndex = 3;
            // 
            // btnktra
            // 
            this.btnktra.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnktra.Location = new System.Drawing.Point(127, 254);
            this.btnktra.Name = "btnktra";
            this.btnktra.Size = new System.Drawing.Size(99, 50);
            this.btnktra.TabIndex = 5;
            this.btnktra.Text = "kiểm tra";
            this.btnktra.UseVisualStyleBackColor = true;
            this.btnktra.Click += new System.EventHandler(this.btnktra_Click);
            // 
            // btngpt
            // 
            this.btngpt.Enabled = false;
            this.btngpt.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btngpt.Location = new System.Drawing.Point(363, 254);
            this.btngpt.Name = "btngpt";
            this.btngpt.Size = new System.Drawing.Size(194, 57);
            this.btngpt.TabIndex = 6;
            this.btngpt.Text = "giải phương trình";
            this.btngpt.UseVisualStyleBackColor = true;
            this.btngpt.Click += new System.EventHandler(this.btngpt_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btngpt);
            this.Controls.Add(this.btnktra);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textb);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.texta);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox texta;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textb;
        private System.Windows.Forms.Button btnktra;
        private System.Windows.Forms.Button btngpt;
    }
}


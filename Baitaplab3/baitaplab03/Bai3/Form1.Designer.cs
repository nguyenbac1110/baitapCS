namespace Bai3
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
            this.label2 = new System.Windows.Forms.Label();
            this.texta = new System.Windows.Forms.TextBox();
            this.btntong = new System.Windows.Forms.Button();
            this.btnnt = new System.Windows.Forms.Button();
            this.lblkq = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(115, 105);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 22);
            this.label2.TabIndex = 4;
            this.label2.Text = "Nhập a";
            // 
            // texta
            // 
            this.texta.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.texta.Location = new System.Drawing.Point(251, 105);
            this.texta.Name = "texta";
            this.texta.Size = new System.Drawing.Size(163, 28);
            this.texta.TabIndex = 3;
            // 
            // btntong
            // 
            this.btntong.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btntong.Location = new System.Drawing.Point(156, 192);
            this.btntong.Name = "btntong";
            this.btntong.Size = new System.Drawing.Size(125, 43);
            this.btntong.TabIndex = 5;
            this.btntong.Text = "Tính Tổng";
            this.btntong.UseVisualStyleBackColor = true;
            this.btntong.Click += new System.EventHandler(this.btntong_Click);
            // 
            // btnnt
            // 
            this.btnnt.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnnt.Location = new System.Drawing.Point(339, 192);
            this.btnnt.Name = "btnnt";
            this.btnnt.Size = new System.Drawing.Size(216, 43);
            this.btnnt.TabIndex = 6;
            this.btnnt.Text = "Kiểm tra số nguyên tố";
            this.btnnt.UseVisualStyleBackColor = true;
            this.btnnt.Click += new System.EventHandler(this.btnnt_Click);
            // 
            // lblkq
            // 
            this.lblkq.AutoSize = true;
            this.lblkq.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblkq.Location = new System.Drawing.Point(115, 268);
            this.lblkq.Name = "lblkq";
            this.lblkq.Size = new System.Drawing.Size(0, 22);
            this.lblkq.TabIndex = 7;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblkq);
            this.Controls.Add(this.btnnt);
            this.Controls.Add(this.btntong);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.texta);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox texta;
        private System.Windows.Forms.Button btntong;
        private System.Windows.Forms.Button btnnt;
        private System.Windows.Forms.Label lblkq;
    }
}


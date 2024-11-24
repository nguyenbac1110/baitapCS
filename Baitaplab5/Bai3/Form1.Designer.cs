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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rdbhv = new System.Windows.Forms.RadioButton();
            this.rdbelipse = new System.Windows.Forms.RadioButton();
            this.rdbhcn = new System.Windows.Forms.RadioButton();
            this.rdbtron = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.hScrollBarRed = new System.Windows.Forms.HScrollBar();
            this.hScrollBarGreen = new System.Windows.Forms.HScrollBar();
            this.hScrollBarBlue = new System.Windows.Forms.HScrollBar();
            this.btnve = new System.Windows.Forms.Button();
            this.pnl = new System.Windows.Forms.Panel();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rdbhv);
            this.groupBox1.Controls.Add(this.rdbelipse);
            this.groupBox1.Controls.Add(this.rdbhcn);
            this.groupBox1.Controls.Add(this.rdbtron);
            this.groupBox1.Location = new System.Drawing.Point(13, 22);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(382, 150);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Chọn hình vẽ";
            // 
            // rdbhv
            // 
            this.rdbhv.AutoSize = true;
            this.rdbhv.Location = new System.Drawing.Point(203, 99);
            this.rdbhv.Name = "rdbhv";
            this.rdbhv.Size = new System.Drawing.Size(95, 20);
            this.rdbhv.TabIndex = 3;
            this.rdbhv.TabStop = true;
            this.rdbhv.Text = "Hình vuông";
            this.rdbhv.UseVisualStyleBackColor = true;
            // 
            // rdbelipse
            // 
            this.rdbelipse.AutoSize = true;
            this.rdbelipse.Location = new System.Drawing.Point(28, 99);
            this.rdbelipse.Name = "rdbelipse";
            this.rdbelipse.Size = new System.Drawing.Size(95, 20);
            this.rdbelipse.TabIndex = 2;
            this.rdbelipse.TabStop = true;
            this.rdbelipse.Text = "Hình elipse";
            this.rdbelipse.UseVisualStyleBackColor = true;
            // 
            // rdbhcn
            // 
            this.rdbhcn.AutoSize = true;
            this.rdbhcn.Location = new System.Drawing.Point(203, 39);
            this.rdbhcn.Name = "rdbhcn";
            this.rdbhcn.Size = new System.Drawing.Size(107, 20);
            this.rdbhcn.TabIndex = 1;
            this.rdbhcn.TabStop = true;
            this.rdbhcn.Text = "Hình chữ nhật";
            this.rdbhcn.UseVisualStyleBackColor = true;
            // 
            // rdbtron
            // 
            this.rdbtron.AutoSize = true;
            this.rdbtron.Location = new System.Drawing.Point(28, 39);
            this.rdbtron.Name = "rdbtron";
            this.rdbtron.Size = new System.Drawing.Size(80, 20);
            this.rdbtron.TabIndex = 0;
            this.rdbtron.TabStop = true;
            this.rdbtron.Text = "Hình tròn";
            this.rdbtron.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(38, 202);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Red";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(38, 240);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Green";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(38, 278);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 16);
            this.label3.TabIndex = 3;
            this.label3.Text = "Blue";
            // 
            // hScrollBarRed
            // 
            this.hScrollBarRed.Location = new System.Drawing.Point(140, 202);
            this.hScrollBarRed.Name = "hScrollBarRed";
            this.hScrollBarRed.Size = new System.Drawing.Size(229, 21);
            this.hScrollBarRed.TabIndex = 4;
            // 
            // hScrollBarGreen
            // 
            this.hScrollBarGreen.Location = new System.Drawing.Point(140, 240);
            this.hScrollBarGreen.Name = "hScrollBarGreen";
            this.hScrollBarGreen.Size = new System.Drawing.Size(229, 21);
            this.hScrollBarGreen.TabIndex = 5;
            // 
            // hScrollBarBlue
            // 
            this.hScrollBarBlue.Location = new System.Drawing.Point(140, 278);
            this.hScrollBarBlue.Name = "hScrollBarBlue";
            this.hScrollBarBlue.Size = new System.Drawing.Size(229, 21);
            this.hScrollBarBlue.TabIndex = 6;
            // 
            // btnve
            // 
            this.btnve.Location = new System.Drawing.Point(496, 362);
            this.btnve.Name = "btnve";
            this.btnve.Size = new System.Drawing.Size(105, 24);
            this.btnve.TabIndex = 7;
            this.btnve.Text = "Vẽ hình";
            this.btnve.UseVisualStyleBackColor = true;
            this.btnve.Click += new System.EventHandler(this.btnve_Click);
            // 
            // pnl
            // 
            this.pnl.Location = new System.Drawing.Point(467, 38);
            this.pnl.Name = "pnl";
            this.pnl.Size = new System.Drawing.Size(299, 261);
            this.pnl.TabIndex = 8;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pnl);
            this.Controls.Add(this.btnve);
            this.Controls.Add(this.hScrollBarBlue);
            this.Controls.Add(this.hScrollBarGreen);
            this.Controls.Add(this.hScrollBarRed);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rdbtron;
        private System.Windows.Forms.RadioButton rdbhv;
        private System.Windows.Forms.RadioButton rdbelipse;
        private System.Windows.Forms.RadioButton rdbhcn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.HScrollBar hScrollBarRed;
        private System.Windows.Forms.HScrollBar hScrollBarGreen;
        private System.Windows.Forms.HScrollBar hScrollBarBlue;
        private System.Windows.Forms.Button btnve;
        private System.Windows.Forms.Panel pnl;
    }
}


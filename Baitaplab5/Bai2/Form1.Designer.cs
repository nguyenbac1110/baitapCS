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
            this.txtnhap = new System.Windows.Forms.TextBox();
            this.listEng = new System.Windows.Forms.ListBox();
            this.listVie = new System.Windows.Forms.ListBox();
            this.btnadd = new System.Windows.Forms.Button();
            this.btndelone = new System.Windows.Forms.Button();
            this.btndelall = new System.Windows.Forms.Button();
            this.btnaddnhieu = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(69, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tiếng anh";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(567, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "TIếng việt";
            // 
            // txtnhap
            // 
            this.txtnhap.Location = new System.Drawing.Point(29, 71);
            this.txtnhap.Name = "txtnhap";
            this.txtnhap.Size = new System.Drawing.Size(244, 22);
            this.txtnhap.TabIndex = 2;
            // 
            // listEng
            // 
            this.listEng.FormattingEnabled = true;
            this.listEng.ItemHeight = 16;
            this.listEng.Location = new System.Drawing.Point(29, 111);
            this.listEng.Name = "listEng";
            this.listEng.Size = new System.Drawing.Size(244, 292);
            this.listEng.TabIndex = 3;
            this.listEng.SelectedIndexChanged += new System.EventHandler(this.listEng_SelectedIndexChanged);
            // 
            // listVie
            // 
            this.listVie.FormattingEnabled = true;
            this.listVie.ItemHeight = 16;
            this.listVie.Location = new System.Drawing.Point(489, 72);
            this.listVie.Name = "listVie";
            this.listVie.Size = new System.Drawing.Size(244, 324);
            this.listVie.TabIndex = 4;
            // 
            // btnadd
            // 
            this.btnadd.Location = new System.Drawing.Point(335, 137);
            this.btnadd.Name = "btnadd";
            this.btnadd.Size = new System.Drawing.Size(75, 23);
            this.btnadd.TabIndex = 5;
            this.btnadd.Text = "Thêm từ";
            this.btnadd.UseVisualStyleBackColor = true;
            this.btnadd.Click += new System.EventHandler(this.btnadd_Click);
            // 
            // btndelone
            // 
            this.btndelone.Location = new System.Drawing.Point(335, 189);
            this.btndelone.Name = "btndelone";
            this.btndelone.Size = new System.Drawing.Size(75, 23);
            this.btndelone.TabIndex = 6;
            this.btndelone.Text = "Xóa từ";
            this.btndelone.UseVisualStyleBackColor = true;
            this.btndelone.Click += new System.EventHandler(this.btndelone_Click);
            // 
            // btndelall
            // 
            this.btndelall.Location = new System.Drawing.Point(335, 246);
            this.btndelall.Name = "btndelall";
            this.btndelall.Size = new System.Drawing.Size(104, 42);
            this.btndelall.TabIndex = 7;
            this.btndelall.Text = "Xóa tất cả";
            this.btndelall.UseVisualStyleBackColor = true;
            this.btndelall.Click += new System.EventHandler(this.btndelall_Click);
            // 
            // btnaddnhieu
            // 
            this.btnaddnhieu.Location = new System.Drawing.Point(335, 94);
            this.btnaddnhieu.Name = "btnaddnhieu";
            this.btnaddnhieu.Size = new System.Drawing.Size(75, 23);
            this.btnaddnhieu.TabIndex = 8;
            this.btnaddnhieu.Text = "Thêm từ nhiều";
            this.btnaddnhieu.UseVisualStyleBackColor = true;
            this.btnaddnhieu.Click += new System.EventHandler(this.btnaddnhieu_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnaddnhieu);
            this.Controls.Add(this.btndelall);
            this.Controls.Add(this.btndelone);
            this.Controls.Add(this.btnadd);
            this.Controls.Add(this.listVie);
            this.Controls.Add(this.listEng);
            this.Controls.Add(this.txtnhap);
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
        private System.Windows.Forms.TextBox txtnhap;
        private System.Windows.Forms.ListBox listEng;
        private System.Windows.Forms.ListBox listVie;
        private System.Windows.Forms.Button btnadd;
        private System.Windows.Forms.Button btndelone;
        private System.Windows.Forms.Button btndelall;
        private System.Windows.Forms.Button btnaddnhieu;
    }
}


namespace Bai5
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.txtfirst = new System.Windows.Forms.TextBox();
            this.txtlast = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnaddname = new System.Windows.Forms.Button();
            this.btnexit = new System.Windows.Forms.Button();
            this.treeView = new System.Windows.Forms.TreeView();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.btnaddname);
            this.panel1.Controls.Add(this.txtlast);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.txtfirst);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(518, 42);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(240, 245);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "First Name";
            // 
            // txtfirst
            // 
            this.txtfirst.Location = new System.Drawing.Point(18, 54);
            this.txtfirst.Name = "txtfirst";
            this.txtfirst.Size = new System.Drawing.Size(193, 22);
            this.txtfirst.TabIndex = 1;
            // 
            // txtlast
            // 
            this.txtlast.Location = new System.Drawing.Point(24, 128);
            this.txtlast.Name = "txtlast";
            this.txtlast.Size = new System.Drawing.Size(193, 22);
            this.txtlast.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 92);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Last Name";
            // 
            // btnaddname
            // 
            this.btnaddname.Location = new System.Drawing.Point(43, 176);
            this.btnaddname.Name = "btnaddname";
            this.btnaddname.Size = new System.Drawing.Size(121, 44);
            this.btnaddname.TabIndex = 4;
            this.btnaddname.Text = "Add Name";
            this.btnaddname.UseVisualStyleBackColor = true;
            this.btnaddname.Click += new System.EventHandler(this.btnaddname_Click);
            // 
            // btnexit
            // 
            this.btnexit.Location = new System.Drawing.Point(585, 335);
            this.btnexit.Name = "btnexit";
            this.btnexit.Size = new System.Drawing.Size(98, 26);
            this.btnexit.TabIndex = 5;
            this.btnexit.Text = "Exit";
            this.btnexit.UseVisualStyleBackColor = true;
            // 
            // treeView
            // 
            this.treeView.Location = new System.Drawing.Point(38, 22);
            this.treeView.Name = "treeView";
            this.treeView.Size = new System.Drawing.Size(348, 355);
            this.treeView.TabIndex = 6;
            this.treeView.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treeView_AfterSelect);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.treeView);
            this.Controls.Add(this.btnexit);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnaddname;
        private System.Windows.Forms.TextBox txtlast;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtfirst;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnexit;
        private System.Windows.Forms.TreeView treeView;
    }
}


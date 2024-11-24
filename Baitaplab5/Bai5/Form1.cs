using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bai5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
       
        private void btnaddname_Click(object sender, EventArgs e)
        {
           
            string firstName = txtfirst.Text.Trim();
            string lastName = txtlast.Text.Trim();

            if (!string.IsNullOrEmpty(firstName) && !string.IsNullOrEmpty(lastName))
            {
                string fullName = firstName + " " + lastName;
                char firstChar = fullName[0];

                TreeNode parentNode = treeView.Nodes[firstChar - 'A'];
                TreeNode newNode = new TreeNode(fullName);
                parentNode.Nodes.Add(newNode);
            }
        }

        private void treeView_AfterSelect(object sender, TreeViewEventArgs e)
        {
            TreeNode selectedNode = e.Node;
            if (selectedNode != null && selectedNode.Level == 1)
            {
                string fullName = selectedNode.Text;
                string[] parts = fullName.Split(' ');
                txtfirst.Text = parts[0];
                txtlast.Text = parts[1];
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            for (char c = 'A'; c <= 'Z'; c++)
            {
                TreeNode node = new TreeNode(c.ToString());
                treeView.Nodes.Add(node);
            }
        }
    }
}

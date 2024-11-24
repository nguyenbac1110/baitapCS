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

        private void label1_Click(object sender, EventArgs e)
        {

        }
        private void cbx_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedFont = cbx.SelectedItem.ToString(); 
            rtb.Font = new Font(selectedFont, rtb.Font.Size);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cbx.SelectedIndex = 0;
        }
    }
}

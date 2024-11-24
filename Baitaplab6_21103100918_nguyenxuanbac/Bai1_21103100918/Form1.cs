using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bai1_21103100918
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void thoátToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cbx.SelectedIndex = 0;
        }

        private void cbx_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbx.SelectedIndex == 0) 
            {
                lbl_21103100918.Text = $"{DateTime.Now.Hour} Giờ {DateTime.Now.Minute} Phút {DateTime.Now.Second} Giây";
            }
            else if (cbx.SelectedIndex == 1) 
            {
                lbl_21103100918.Text = $"Ngày {DateTime.Now.Day} tháng {DateTime.Now.Month} năm {DateTime.Now.Year}";
            }
        }
    }
}

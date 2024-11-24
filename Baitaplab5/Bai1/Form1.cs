using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bai1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btn_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtnhap.Text))
            {
                MessageBox.Show("Vui lòng nhập số n!", "Thông báo");
                return;
            }
            int n = int.Parse(txtnhap.Text);

            double tong = 1;
            for (int i = 2; i <= n; i++)
            {
                tong += 1.0 / GiaiThua(i);
            }

            lblkq.Text = tong.ToString("F2");
        }
        private int GiaiThua(int n)
        {
            if (n == 0)
            {
                return 1;
            }
            else
            {
                return n * GiaiThua(n - 1);
            }
        }
    }
}

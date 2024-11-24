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

        private void btnOK_Click(object sender, EventArgs e)
        {
            if (lstWeb.SelectedItem != null)
            {
                rtb.Text = $"Bạn đã chọn website {lstWeb.SelectedItem}";
            }
            else
            {
                MessageBox.Show("Vui lòng chọn một website từ danh sách.");
            }
        }

        private void btnreset_Click(object sender, EventArgs e)
        {
            rtb.Clear();
        }
    }
}

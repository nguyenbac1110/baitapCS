using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace baitaplab03
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnktra_Click(object sender, EventArgs e)
        {
            if (!KiemTra(texta) || !KiemTra(textb))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ và hợp lệ a, b (số thực)", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            MessageBox.Show("Dữ liệu hợp lệ!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            btngpt.Enabled = true; 
            btnktra.Enabled = false;
        }
        bool KiemTra(TextBox t)
        {
            int num;
            if (string.IsNullOrWhiteSpace(t.Text)) return false;
            if (!int.TryParse(t.Text, out num) || num < 0) return false;
            return true;
        }
        private void btngpt_Click(object sender, EventArgs e)
        {
            double a = double.Parse(texta.Text);
            double b = double.Parse(textb.Text);

            string ketQua = GiaiBPT(a, b);
            MessageBox.Show(ketQua, "Kết quả", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        string GiaiBPT(double a, double b)
        {
            if (a == 0)
            {
                if (b < 0)
                    return "Bất phương trình có vô số nghiệm.";
                else
                    return "Bất phương trình vô nghiệm.";
            }
            else
            {
                double nghiem = -b / a;
                return $"Nghiệm của bất phương trình là x < {nghiem}";
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}

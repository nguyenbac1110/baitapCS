using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bai3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btntong_Click(object sender, EventArgs e)
        {
            if (KiemTra(texta))
            {
                int n = int.Parse(texta.Text);
                int tong = TinhTongChuSo(n);
                lblkq.Text = $"Tổng các chữ số của {n} là: {tong}";
                lblkq.Visible = true;
            }
        }

        private void btnnt_Click(object sender, EventArgs e)
        {
            if (KiemTra(texta))
            {
                int n = int.Parse(texta.Text);
                bool laNguyenTo = LaSoNguyenTo(n);
                if (laNguyenTo)
                {
                    MessageBox.Show($"{n} là số nguyên tố", "Kết quả", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show($"{n} không là số nguyên tố", "Kết quả", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }
        int TinhTongChuSo(int n)
        {
            int tong = 0;
            while (n > 0)
            {
                tong += n % 10;
                n /= 10;
            }
            return tong;
        }
        bool KiemTra(TextBox t)
        {
            int num;
            if (string.IsNullOrWhiteSpace(t.Text)) return false;
            if (!int.TryParse(t.Text, out num) || num < 0) return false;
            return true;
        }
        bool LaSoNguyenTo(int n)
        {
            if (n < 2)
            {
                return false;
            }
            for (int i = 2; i <= Math.Sqrt(n); i++)
            {
                if (n % i == 0)
                {
                    return false;
                }
            }
            return true;
        }
    }
}

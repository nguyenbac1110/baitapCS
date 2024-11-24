using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bai2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnhauto_Click(object sender, EventArgs e)
        {
            if (rtbtt.Text == "")
            {
                MessageBox.Show("Vui lòng nhập biểu thức trung tố!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                rtbtt.Focus();
                return;
            }

            string bieuThucHauTo = TrungToHau(rtbtt.Text);
            rtbht.Text = bieuThucHauTo;
        }
        string TrungToHau(string trungto)
        {
            string ketqua = "";
            Stack<char> nganxep = new Stack<char>();

            for (int i = 0; i < trungto.Length; i++)
            {
                char kytu = trungto[i];
                if (char.IsLetterOrDigit(kytu))
                {
                    ketqua += kytu;
                }
                else if (kytu == '(')
                {
                    nganxep.Push(kytu);
                }
                else if (kytu == ')')
                {
                    while (nganxep.Count > 0 && nganxep.Peek() != '(')
                    {
                        ketqua += nganxep.Pop();
                    }
                    nganxep.Pop(); 
                }
                else
                {
                    while (nganxep.Count > 0 && ThuTuUuTien(kytu) <= ThuTuUuTien(nganxep.Peek()))
                    {
                        ketqua += nganxep.Pop();
                    }
                    nganxep.Push(kytu);
                }
            }

            while (nganxep.Count > 0)
            {
                ketqua += nganxep.Pop();
            }

            return ketqua;
        }

        private int ThuTuUuTien(char toantu)
        {
            if (toantu == '+' || toantu == '-')
                return 1;
            else if (toantu == '*' || toantu == '/')
                return 2;
            else if (toantu == '^')
                return 3;
            else
                return 0; 
        }
        private void btnthoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void rtbtt_TextChanged(object sender, EventArgs e)
        {
            btnhauto.Enabled = true;
        }
    }
}

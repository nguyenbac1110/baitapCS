using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bai4
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

        private void btntang2_Click(object sender, EventArgs e)
        {
            var item = list.Items.Cast<int>().ToList();
            list.Items.Clear();


            foreach (var items in item)
            {
                list.Items.Add(items + 2);
            }
        }

            private void btnfirstchan_Click(object sender, EventArgs e)
        {
            var sochandau = list.Items.Cast<int>().FirstOrDefault(x => x % 2 == 0);
            if (sochandau != 0)
            {
                list.SelectedItem = sochandau;
            }
        }

        private void btnlastle_Click(object sender, EventArgs e)
        {
            var solecuoi = list.Items.Cast<int>().LastOrDefault(x => x % 2 != 0);
            if (solecuoi != 0)
            {
                list.SelectedItem = solecuoi;
            }
        }

        private void btndelchon_Click(object sender, EventArgs e)
        {
            if (list.SelectedItem != null)
            {
                list.Items.Remove(list.SelectedItem);
            }
        }

        private void btndelfirst_Click(object sender, EventArgs e)
        {
            if (list.Items.Count > 0)
            {
                list.Items.RemoveAt(0);
            }
        }

        private void btndellast_Click(object sender, EventArgs e)
        {
            if (list.Items.Count > 0)
            {
                list.Items.RemoveAt(list.Items.Count - 1);
            }
        }

        private void btncapnhap_Click(object sender, EventArgs e)
        {
            
            if (!KiemTra(txtnhap) )
            {
                MessageBox.Show("Vui lòng nhập số nguyên không âm vào cả hai ô.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            int a = int.Parse(txtnhap.Text);
            list.Items.Add(a);
        }
        bool KiemTra(TextBox t)
        {
            int num;
            if (string.IsNullOrWhiteSpace(t.Text)) return false;
            if (!int.TryParse(t.Text, out num) || num < 0) return false;
            return true;
        }

        private void btnthem_Click(object sender, EventArgs e)
        {
            for (int i = 1; i <= 10; i++)
            {
                list.Items.Add(i);
            }
        }

        private void btnthoat_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}

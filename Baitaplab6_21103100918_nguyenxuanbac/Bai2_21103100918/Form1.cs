using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bai2_21103100918
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void thoátChươngTrìnhToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btncapnhap_Click(object sender, EventArgs e)
        {
            string tenSV = txt_21103100918.Text; 
            string nhom = cbx_21103100918.SelectedItem?.ToString(); 

            if (!string.IsNullOrEmpty(tenSV) && nhom != null) 
            {
                if (nhom == "Nhóm 1") 
                {
                    listBox1.Items.Add(tenSV); 
                }
                else if (nhom == "Nhóm 2") 
                {
                    listBox2.Items.Add(tenSV); 
                }
                txt_21103100918.Clear();
            }
            else
            {
                MessageBox.Show("Vui lòng nhập tên sinh viên và chọn nhóm."); 
            }
            CapNhapSLNhom();
        }

        private void btnQua1_Click(object sender, EventArgs e)
        {
            for (int i = listBox1.SelectedItems.Count - 1; i >= 0; i--)
            {
                object item = listBox1.SelectedItems[i];
                listBox2.Items.Add(item);
                listBox1.Items.Remove(item);
            }
            CapNhapSLNhom();
        }

        private void btnQua2_Click(object sender, EventArgs e)
        {
            for (int i = listBox2.SelectedItems.Count - 1; i >= 0; i--)
            {
                object item = listBox2.SelectedItems[i];
                listBox1.Items.Add(item);
                listBox2.Items.Remove(item);
            }
            CapNhapSLNhom();

        }

        private void btnChuyenQ1_Click(object sender, EventArgs e)
        {
            foreach (var item in listBox1.Items.Cast<object>().ToArray())
            {
                listBox2.Items.Add(item);
            }
            listBox1.Items.Clear();
            CapNhapSLNhom();

        }

        private void btnChuyenQ2_Click(object sender, EventArgs e)
        {
            foreach (var item in listBox2.Items.Cast<object>().ToArray())
            {
                listBox1.Items.Add(item);
            }
            listBox2.Items.Clear();
            CapNhapSLNhom();

        }

        private void btnxoa_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedItems.Count > 0)
            {
                listBox1.Items.Remove(listBox1.SelectedItem);
            }

            if (listBox2.SelectedItems.Count > 0)
            {
                listBox2.Items.Remove(listBox2.SelectedItem);
            }
            CapNhapSLNhom();

        }

        private void btnnhapnhieu_21103100918_Click(object sender, EventArgs e)
        {
            string[] HS = { "Học sinh 1", "Học sinh 2", "Học sinh 3", "Học sinh 4", "Học sinh 5" };

            foreach (var hs in HS)
            {
                listBox1.Items.Add(hs);
                
            }
            string[] HS_ = { "Học sinh 6", "Học sinh 7", "Học sinh 8", "Học sinh 9", "Học sinh 10" };

            foreach (var hs in HS_)
            {
                listBox2.Items.Add(hs);

            }
            CapNhapSLNhom();

        }
        private void CapNhapSLNhom()
        {
            lblnhom1.Text = "Số lượng Nhóm 1: " + listBox1.Items.Count;
            lblnhom2.Text = "Số lượng Nhóm 2: " + listBox2.Items.Count;
        }

    }
}

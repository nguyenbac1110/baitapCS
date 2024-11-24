using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bai3_btvn
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btncapnhap_Click(object sender, EventArgs e)
        {
            string strinput = txta.Text.Trim();

            if (string.IsNullOrEmpty(strinput))
            {
                MessageBox.Show("Vui lòng nhập giá trị vào textbox trước khi cập nhật.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DialogResult result = MessageBox.Show("Bạn muốn thêm giá trị vào ListBox? \nYes: Xóa ListA\nNo: Xóa ListB", "Chọn ListBox", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                listA.Items.Add(strinput);
                MessageBox.Show("Đã thêm giá trị vào ListA.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (result == DialogResult.No)
            {
                listB.Items.Add(strinput);
                MessageBox.Show("Đã thêm giá trị vào ListB.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            txta.Clear();
        }

        private void btndiphai_Click(object sender, EventArgs e)
        {
            if (listA.SelectedItem != null)
            {
                listB.Items.Add(listA.SelectedItem);
                listA.Items.Remove(listA.SelectedItem);
            }
        }

        private void btnditrai_Click(object sender, EventArgs e)
        {
            if (listB.SelectedItem != null)
            {
                listA.Items.Add(listB.SelectedItem);
                listB.Items.Remove(listB.SelectedItem);
            }
        }

        private void btnchuyenphai_Click(object sender, EventArgs e)
        {
            foreach (var item in listA.Items)
            {
                listB.Items.Add(item);
            }
            listA.Items.Clear();
        }

        private void btnchuyentrai_Click(object sender, EventArgs e)
        {
            foreach (var item in listB.Items)
            {
                listA.Items.Add(item);
            }
            listB.Items.Clear();
        }

        private void btnxoa_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn muốn xóa tất cả mục từ ListBox nào?\nYes: Xóa ListA\nNo: Xóa ListB","Chọn ListBox để xóa", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);

            if (result == DialogResult.Yes) 
            {
                if (listA.Items.Count > 0)
                {
                    listA.Items.Clear();
                    MessageBox.Show("Đã xóa tất cả các mục từ ListA.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("ListA đã trống.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else if (result == DialogResult.No) 
            {
                if (listB.Items.Count > 0)
                {
                    listB.Items.Clear();
                    MessageBox.Show("Đã xóa tất cả các mục từ ListB.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("ListB đã trống.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }
    }
}

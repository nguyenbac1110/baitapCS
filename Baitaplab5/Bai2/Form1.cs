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

namespace Bai2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private Dictionary<string, string> tudien = new Dictionary<string, string>
    {
        { "apple", "quả táo" },
        { "banana", "quả chuối" },
        { "cat", "con mèo" },
        { "dog", "con chó" }
        
    };
        private void btnadd_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtnhap.Text))
            {
                listEng.Items.Add(txtnhap.Text);
                txtnhap.Clear();
            }

        }

        private void btndelone_Click(object sender, EventArgs e)
        {
            if (listEng.SelectedIndex != -1)
            {
                listEng.Items.RemoveAt(listEng.SelectedIndex);
            }
        }

        private void btndelall_Click(object sender, EventArgs e)
        {
            listEng.Items.Clear();
        }

        private void listEng_SelectedIndexChanged(object sender, EventArgs e)
        {
            listVie.Items.Clear();
            if (listEng.SelectedItem != null)
            {
                string tudaclick = listEng.SelectedItem.ToString();
                if (tudien.ContainsKey(tudaclick))
                {
                    listVie.Items.Add(tudien[tudaclick]);
                }
            }
        }

        private void btnaddnhieu_Click(object sender, EventArgs e)
        {
            listEng.Items.Add("apple");
            listEng.Items.Add("banana");
            listEng.Items.Add("cat");
            listEng.Items.Add("dog");
        }
    }
}

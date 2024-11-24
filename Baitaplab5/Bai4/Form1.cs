using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using Button = System.Windows.Forms.Button;

namespace Bai4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void btndem_Click(object sender, EventArgs e)
        {
            HashSet<char> uniqueDigits = new HashSet<char>();
            foreach (char c in rtb.Text)
            {
                if (char.IsDigit(c))
                {
                    uniqueDigits.Add(c);
                }
            }
            txt.Text = uniqueDigits.Count.ToString();
        }

        private void rtb_KeyDown(object sender, KeyEventArgs e)
        {
            if (char.IsLetter((char)e.KeyCode))
            {
                
                ChangeButtonColor((char)e.KeyCode, Color.Red);
            }
        }

        private void rtb_KeyUp(object sender, KeyEventArgs e)
        {
            if (char.IsLetter((char)e.KeyCode))
            {
                ChangeButtonColor((char)e.KeyCode, Color.Black);
            }
        }

        private void ChangeButtonColor(char letter, Color color)
        {
            if (char.IsLetter(letter))
            {
                int index = char.ToLower(letter) - 'a'; 

                if (index >= 0 && index < 26)
                {
                    Button button = (Button)groupBox1.Controls[index];
                    if (button != null)
                    {
                        button.ForeColor = color;
                    }
                }
            }
        }
    }
}

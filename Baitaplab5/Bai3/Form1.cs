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

        private void btnve_Click(object sender, EventArgs e)
        {
            int red = hScrollBarRed.Value;
            int green = hScrollBarGreen.Value;
            int blue = hScrollBarBlue.Value;

            Color color = Color.FromArgb(red, green, blue);

            Graphics g = pnl.CreateGraphics();

            g.Clear(pnl.BackColor);

            SolidBrush brush = new SolidBrush(color);
            if (rdbtron.Checked)
            {
                g.FillEllipse(brush, 50, 50, 100, 100);
            }
            else if (rdbhcn.Checked)
            {
                g.FillRectangle(brush, 50, 50, 150, 100);
            }
            else if (rdbelipse.Checked)
            {
                g.FillEllipse(brush, 50, 50, 150, 100);
            }
            else if (rdbhv.Checked)
            {
                g.FillRectangle(brush, 50, 50, 100, 100);
            }
            brush.Dispose();
            g.Dispose();
        }
    }
}

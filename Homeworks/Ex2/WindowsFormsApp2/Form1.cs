using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
        public bool greyGradIsChecked;

        private void Correcting()
        {
            RedValue.Text = RedScrollBar.Value.ToString();
            GreenValue.Text = GreenScrollBar.Value.ToString();
            BlueValue.Text = BlueScrollBar.Value.ToString();
            pictureBox1.BackColor = Color.FromArgb(RedScrollBar.Value, GreenScrollBar.Value, BlueScrollBar.Value);
        }

        public Form1()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            
        }
        private void RedScrollBar_Scroll(object sender, ScrollEventArgs e)
        {
            if (greyGradIsChecked)
            {
                GreenScrollBar.Value = RedScrollBar.Value;
                BlueScrollBar.Value = RedScrollBar.Value;
            }
            pictureBox1.BackColor = Color.FromArgb(RedScrollBar.Value, GreenScrollBar.Value, BlueScrollBar.Value);
            Correcting();
        }

        private void GreenScrollBar_Scroll(object sender, ScrollEventArgs e)
        {
            if (greyGradIsChecked)
            {
                RedScrollBar.Value = GreenScrollBar.Value;
                BlueScrollBar.Value = GreenScrollBar.Value;
            }
            pictureBox1.BackColor = Color.FromArgb(RedScrollBar.Value, GreenScrollBar.Value, BlueScrollBar.Value);
            Correcting();
            
        }

        private void BlueScrollBar_Scroll(object sender, ScrollEventArgs e)
        {
            if (greyGradIsChecked)
            {
                GreenScrollBar.Value = BlueScrollBar.Value;
                RedScrollBar.Value = BlueScrollBar.Value;
            }
            pictureBox1.BackColor = Color.FromArgb(RedScrollBar.Value, GreenScrollBar.Value, BlueScrollBar.Value);
            Correcting();
        }

        private void RedValue_Click(object sender, EventArgs e)
        {

        }

        private void GreenValue_Click(object sender, EventArgs e)
        {
            
        }

        private void BlueValue_Click(object sender, EventArgs e)
        {
            
        }

        private void greyGrad_CheckedChanged(object sender, EventArgs e)
        {
            if (greyGrad.Checked) greyGradIsChecked = true;
            else greyGradIsChecked = false;
            RedScrollBar.Value = BlueScrollBar.Value = GreenScrollBar.Value = 0;
            Correcting();
        }

        private void picHeight_Scroll(object sender, ScrollEventArgs e)
        {
            pictureBox1.Height = picHeight.Value;
        }

        private void picWidth_Scroll(object sender, ScrollEventArgs e)
        {
            pictureBox1.Width = picWidth.Value;
        }
    }
}

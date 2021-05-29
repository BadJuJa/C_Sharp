using System;
using System.Drawing;
using System.Windows.Forms;

namespace GraphEditor {

    public partial class GraphEditorForm : Form {
        private Pen p = new Pen(Color.Black, 1);
        private Bitmap buf;
        private Graphics gr;

        private int tool = 1;

        public GraphEditorForm() {
            InitializeComponent();
            buf = new Bitmap(picPicture.Width, picPicture.Height);
            gr = Graphics.FromImage(buf);
        }

        private void picPicture_MouseMove(object sender, MouseEventArgs e) {
            if (e.Button != MouseButtons.Left) {
                return;
            }
            if (tool == 1) {
                gr.DrawLine(p, e.X, e.Y, picPicture.Width / 2, picPicture.Height / 2);
            } else if (tool == 2) {
                gr.DrawRectangle(p, e.X, e.Y, 25, 25);
            } else if (tool == 3) {
                gr.DrawLine(p, e.X, e.Y, e.X + 15, e.Y + 20);
            }
            picPicture.Image = buf;
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e) {
            tool = 1;
        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e) {
            tool = 2;
        }

        private void toolStripMenuItem3_Click(object sender, EventArgs e) {
            tool = 3;
        }

        private void цветToolStripMenuItem_Click(object sender, EventArgs e) {
            ColorDialog colorDialog = new ColorDialog();
            DialogResult result = colorDialog.ShowDialog();
            if (result == DialogResult.OK) {
                p.Color = colorDialog.Color;
            }
        }

        private void ClearContextToolStrip_Click(object sender, EventArgs e) {
            gr.Clear(Color.White);
            picPicture.Image = buf;
        }
    }
}
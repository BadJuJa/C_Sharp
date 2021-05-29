using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace mdiGeneral {
    public partial class frmPicture : Form {

        public Bitmap buf;
        Graphics graph;

        public frmPicture() {
            InitializeComponent();
        }

        private void frmPicture_Load(object sender, EventArgs e) {
            graph = Graphics.FromImage(buf);
            picPicture.Image = buf;
        }

        private void picPicture_MouseMove(object sender, MouseEventArgs e) {
            
            if (e.Button != MouseButtons.Left) {
                return;
            }
            if (global::mdiGeneral.mdiGeneral.tool == 1) {
                graph.DrawLine(global::mdiGeneral.mdiGeneral.pen, e.X, e.Y, picPicture.Width / 2, picPicture.Height / 2);
            } else if (global::mdiGeneral.mdiGeneral.tool == 2) {
                graph.DrawRectangle(global::mdiGeneral.mdiGeneral.pen, e.X-8, e.Y-8, 16, 16);
            }
            picPicture.Image = buf;
        }

        private void picPicture_MouseClick(object sender, MouseEventArgs e) {
            if (e.Button == MouseButtons.Right) {
                graph.Clear(Color.White);
                picPicture.Image = buf;
            }
        }

        private void frmPicture_Activated(object sender, EventArgs e) {
            picPicture.Focus();
        }
    }
}

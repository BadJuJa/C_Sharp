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
    public partial class mdiGeneral : Form {

        public static Pen pen = new Pen(Color.Black, 1);
        public static int tool = 1;

        private int countPicture = 0;
        public mdiGeneral() {
            InitializeComponent();
            mnuGeneral.MdiWindowListItem = mnuWindow;
        }

        private void mnuColor_Click(object sender, EventArgs e) {
            ColorDialog colorDialog = new ColorDialog();
            DialogResult result = colorDialog.ShowDialog();
            if (result == DialogResult.OK) {
                pen.Color = colorDialog.Color;
            }
        }

        private void lineToCenter_ToolStripMenuItem_Click(object sender, EventArgs e) {
            tool = 1;
        }

        private void Squares_ToolStripMenuItem_Click(object sender, EventArgs e) {
            tool = 2;
        }

        private void mnuNewPicture_Click(object sender, EventArgs e) {
            countPicture++;
            frmPicture childForm = new frmPicture {
                MdiParent = this,
                Text = "Рисунок №" + countPicture.ToString(),
                buf = new Bitmap(1280, 720)
            };
            childForm.Show();
        }

        private void mnuLoadPicture_Click(object sender, EventArgs e) {
            string resol = Microsoft.VisualBasic.Interaction.InputBox("Введите желаемое разрешение через пробел.", "Open...", "1280 720");
            string[] resols = resol.Split();

            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            openFileDialog1.ShowDialog();

            Image pic = Image.FromFile(openFileDialog1.FileName);
            /*float k = 1f;
            if (pic.Width >= pic.Height && pic.Width >1280) {
                k = 1280f / pic.Width;
            } else if (pic.Width < pic.Height && pic.Height>720) {
                k = 720f / pic.Height;
            }*/
            frmPicture childForm = new frmPicture {
                MdiParent = this,
                Text = openFileDialog1.FileName,
                //buf = new Bitmap(pic, (int)(pic.Width * k), (int)(pic.Height * k))
                buf = new Bitmap(pic, Convert.ToInt32(resols[0]), Convert.ToInt32(resols[1]))
            };
            childForm.Show();
        }

        private void mnuSavePicture_Click(object sender, EventArgs e) {
            PictureBox myPicture = (PictureBox)ActiveMdiChild.ActiveControl;
            SaveFileDialog saveFileDialog1 = new SaveFileDialog();
            saveFileDialog1.ShowDialog();
            myPicture.Image.Save(saveFileDialog1.FileName, System.Drawing.Imaging.ImageFormat.Png);
            ActiveMdiChild.Text = saveFileDialog1.FileName;
        }

        private void каскадToolStripMenuItem_Click(object sender, EventArgs e) {
            this.LayoutMdi(MdiLayout.Cascade);
        }

        private void вертикальноToolStripMenuItem_Click(object sender, EventArgs e) {
            this.LayoutMdi(MdiLayout.TileVertical);
        }

        private void горизонтальноToolStripMenuItem_Click(object sender, EventArgs e) {
            this.LayoutMdi(MdiLayout.TileHorizontal);
        }

        private void иконкиToolStripMenuItem_Click(object sender, EventArgs e) {
            this.LayoutMdi(MdiLayout.ArrangeIcons);
        }
    }
}

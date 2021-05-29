
namespace WindowsFormsApp2
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.RedScrollBar = new System.Windows.Forms.HScrollBar();
            this.GreenScrollBar = new System.Windows.Forms.HScrollBar();
            this.BlueScrollBar = new System.Windows.Forms.HScrollBar();
            this.Red = new System.Windows.Forms.Label();
            this.Green = new System.Windows.Forms.Label();
            this.Blue = new System.Windows.Forms.Label();
            this.RedValue = new System.Windows.Forms.Label();
            this.GreenValue = new System.Windows.Forms.Label();
            this.BlueValue = new System.Windows.Forms.Label();
            this.picWidth = new System.Windows.Forms.HScrollBar();
            this.picHeight = new System.Windows.Forms.VScrollBar();
            this.greyGrad = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.MenuText;
            this.pictureBox1.Location = new System.Drawing.Point(43, 9);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(469, 177);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // RedScrollBar
            // 
            this.RedScrollBar.LargeChange = 1;
            this.RedScrollBar.Location = new System.Drawing.Point(187, 218);
            this.RedScrollBar.Maximum = 255;
            this.RedScrollBar.Name = "RedScrollBar";
            this.RedScrollBar.Size = new System.Drawing.Size(601, 33);
            this.RedScrollBar.TabIndex = 1;
            this.RedScrollBar.Scroll += new System.Windows.Forms.ScrollEventHandler(this.RedScrollBar_Scroll);
            // 
            // GreenScrollBar
            // 
            this.GreenScrollBar.LargeChange = 1;
            this.GreenScrollBar.Location = new System.Drawing.Point(187, 260);
            this.GreenScrollBar.Maximum = 255;
            this.GreenScrollBar.Name = "GreenScrollBar";
            this.GreenScrollBar.Size = new System.Drawing.Size(598, 33);
            this.GreenScrollBar.TabIndex = 2;
            this.GreenScrollBar.Scroll += new System.Windows.Forms.ScrollEventHandler(this.GreenScrollBar_Scroll);
            // 
            // BlueScrollBar
            // 
            this.BlueScrollBar.LargeChange = 1;
            this.BlueScrollBar.Location = new System.Drawing.Point(187, 302);
            this.BlueScrollBar.Maximum = 255;
            this.BlueScrollBar.Name = "BlueScrollBar";
            this.BlueScrollBar.Size = new System.Drawing.Size(598, 33);
            this.BlueScrollBar.TabIndex = 3;
            this.BlueScrollBar.Scroll += new System.Windows.Forms.ScrollEventHandler(this.BlueScrollBar_Scroll);
            // 
            // Red
            // 
            this.Red.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Red.ForeColor = System.Drawing.Color.Red;
            this.Red.Location = new System.Drawing.Point(9, 228);
            this.Red.Name = "Red";
            this.Red.Size = new System.Drawing.Size(100, 23);
            this.Red.TabIndex = 4;
            this.Red.Text = "Красный";
            // 
            // Green
            // 
            this.Green.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Green.ForeColor = System.Drawing.Color.Green;
            this.Green.Location = new System.Drawing.Point(9, 270);
            this.Green.Name = "Green";
            this.Green.Size = new System.Drawing.Size(100, 23);
            this.Green.TabIndex = 5;
            this.Green.Text = "Зеленый";
            // 
            // Blue
            // 
            this.Blue.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Blue.ForeColor = System.Drawing.Color.Blue;
            this.Blue.Location = new System.Drawing.Point(9, 312);
            this.Blue.Name = "Blue";
            this.Blue.Size = new System.Drawing.Size(100, 23);
            this.Blue.TabIndex = 6;
            this.Blue.Text = "Синий";
            // 
            // RedValue
            // 
            this.RedValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.RedValue.Location = new System.Drawing.Point(105, 228);
            this.RedValue.Name = "RedValue";
            this.RedValue.Size = new System.Drawing.Size(79, 23);
            this.RedValue.TabIndex = 7;
            this.RedValue.Text = "0";
            this.RedValue.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.RedValue.Click += new System.EventHandler(this.RedValue_Click);
            // 
            // GreenValue
            // 
            this.GreenValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.GreenValue.Location = new System.Drawing.Point(105, 270);
            this.GreenValue.Name = "GreenValue";
            this.GreenValue.Size = new System.Drawing.Size(79, 23);
            this.GreenValue.TabIndex = 8;
            this.GreenValue.Text = "0";
            this.GreenValue.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.GreenValue.Click += new System.EventHandler(this.GreenValue_Click);
            // 
            // BlueValue
            // 
            this.BlueValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BlueValue.Location = new System.Drawing.Point(105, 312);
            this.BlueValue.Name = "BlueValue";
            this.BlueValue.Size = new System.Drawing.Size(79, 23);
            this.BlueValue.TabIndex = 9;
            this.BlueValue.Text = "0";
            this.BlueValue.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.BlueValue.Click += new System.EventHandler(this.BlueValue_Click);
            // 
            // picWidth
            // 
            this.picWidth.LargeChange = 1;
            this.picWidth.Location = new System.Drawing.Point(43, 189);
            this.picWidth.Maximum = 469;
            this.picWidth.Name = "picWidth";
            this.picWidth.Size = new System.Drawing.Size(469, 27);
            this.picWidth.TabIndex = 10;
            this.picWidth.Value = 469;
            this.picWidth.Scroll += new System.Windows.Forms.ScrollEventHandler(this.picWidth_Scroll);
            // 
            // picHeight
            // 
            this.picHeight.LargeChange = 1;
            this.picHeight.Location = new System.Drawing.Point(12, 9);
            this.picHeight.Maximum = 177;
            this.picHeight.Name = "picHeight";
            this.picHeight.Size = new System.Drawing.Size(28, 180);
            this.picHeight.TabIndex = 11;
            this.picHeight.Value = 177;
            this.picHeight.Scroll += new System.Windows.Forms.ScrollEventHandler(this.picHeight_Scroll);
            // 
            // greyGrad
            // 
            this.greyGrad.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.greyGrad.Location = new System.Drawing.Point(12, 353);
            this.greyGrad.Name = "greyGrad";
            this.greyGrad.Size = new System.Drawing.Size(251, 45);
            this.greyGrad.TabIndex = 12;
            this.greyGrad.Text = "Режим градации серого";
            this.greyGrad.UseVisualStyleBackColor = true;
            this.greyGrad.CheckedChanged += new System.EventHandler(this.greyGrad_CheckedChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.greyGrad);
            this.Controls.Add(this.picHeight);
            this.Controls.Add(this.picWidth);
            this.Controls.Add(this.BlueValue);
            this.Controls.Add(this.GreenValue);
            this.Controls.Add(this.RedValue);
            this.Controls.Add(this.Blue);
            this.Controls.Add(this.Green);
            this.Controls.Add(this.Red);
            this.Controls.Add(this.BlueScrollBar);
            this.Controls.Add(this.GreenScrollBar);
            this.Controls.Add(this.RedScrollBar);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form1";
            this.Text = "Работа с цветом";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.HScrollBar RedScrollBar;
        private System.Windows.Forms.HScrollBar GreenScrollBar;
        private System.Windows.Forms.HScrollBar BlueScrollBar;
        private System.Windows.Forms.Label Red;
        private System.Windows.Forms.Label Green;
        private System.Windows.Forms.Label Blue;
        private System.Windows.Forms.Label RedValue;
        private System.Windows.Forms.Label GreenValue;
        private System.Windows.Forms.Label BlueValue;
        private System.Windows.Forms.HScrollBar picWidth;
        private System.Windows.Forms.VScrollBar picHeight;
        private System.Windows.Forms.CheckBox greyGrad;
    }
}



namespace mdiGeneral {
    partial class mdiGeneral {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent() {
            this.mnuGeneral = new System.Windows.Forms.MenuStrip();
            this.mnuFile = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuTools = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuColor = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuWindow = new System.Windows.Forms.ToolStripMenuItem();
            this.lineToCenter_ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Squares_ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuNewPicture = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuLoadPicture = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuSavePicture = new System.Windows.Forms.ToolStripMenuItem();
            this.sort_ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.каскадToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.вертикальноToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.горизонтальноToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.иконкиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuGeneral.SuspendLayout();
            this.SuspendLayout();
            // 
            // mnuGeneral
            // 
            this.mnuGeneral.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuFile,
            this.mnuTools,
            this.mnuColor,
            this.mnuWindow});
            this.mnuGeneral.Location = new System.Drawing.Point(0, 0);
            this.mnuGeneral.Name = "mnuGeneral";
            this.mnuGeneral.Size = new System.Drawing.Size(980, 24);
            this.mnuGeneral.TabIndex = 1;
            this.mnuGeneral.Text = "menuStrip1";
            // 
            // mnuFile
            // 
            this.mnuFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuNewPicture,
            this.mnuLoadPicture,
            this.mnuSavePicture});
            this.mnuFile.Name = "mnuFile";
            this.mnuFile.Size = new System.Drawing.Size(48, 20);
            this.mnuFile.Text = "Файл";
            // 
            // mnuTools
            // 
            this.mnuTools.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lineToCenter_ToolStripMenuItem,
            this.Squares_ToolStripMenuItem});
            this.mnuTools.Name = "mnuTools";
            this.mnuTools.Size = new System.Drawing.Size(95, 20);
            this.mnuTools.Text = "Инструменты";
            // 
            // mnuColor
            // 
            this.mnuColor.Name = "mnuColor";
            this.mnuColor.Size = new System.Drawing.Size(45, 20);
            this.mnuColor.Text = "Цвет";
            this.mnuColor.Click += new System.EventHandler(this.mnuColor_Click);
            // 
            // mnuWindow
            // 
            this.mnuWindow.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sort_ToolStripMenuItem});
            this.mnuWindow.Name = "mnuWindow";
            this.mnuWindow.Size = new System.Drawing.Size(48, 20);
            this.mnuWindow.Text = "Окно";
            // 
            // lineToCenter_ToolStripMenuItem
            // 
            this.lineToCenter_ToolStripMenuItem.Name = "lineToCenter_ToolStripMenuItem";
            this.lineToCenter_ToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.lineToCenter_ToolStripMenuItem.Text = "Линии в центр";
            this.lineToCenter_ToolStripMenuItem.Click += new System.EventHandler(this.lineToCenter_ToolStripMenuItem_Click);
            // 
            // Squares_ToolStripMenuItem
            // 
            this.Squares_ToolStripMenuItem.Name = "Squares_ToolStripMenuItem";
            this.Squares_ToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.Squares_ToolStripMenuItem.Text = "Квадратики";
            this.Squares_ToolStripMenuItem.Click += new System.EventHandler(this.Squares_ToolStripMenuItem_Click);
            // 
            // mnuNewPicture
            // 
            this.mnuNewPicture.Name = "mnuNewPicture";
            this.mnuNewPicture.Size = new System.Drawing.Size(210, 22);
            this.mnuNewPicture.Text = "Новое полотно";
            this.mnuNewPicture.Click += new System.EventHandler(this.mnuNewPicture_Click);
            // 
            // mnuLoadPicture
            // 
            this.mnuLoadPicture.Name = "mnuLoadPicture";
            this.mnuLoadPicture.Size = new System.Drawing.Size(210, 22);
            this.mnuLoadPicture.Text = "Открыть изображение";
            this.mnuLoadPicture.Click += new System.EventHandler(this.mnuLoadPicture_Click);
            // 
            // mnuSavePicture
            // 
            this.mnuSavePicture.Name = "mnuSavePicture";
            this.mnuSavePicture.Size = new System.Drawing.Size(210, 22);
            this.mnuSavePicture.Text = "Сохранить изображение";
            this.mnuSavePicture.Click += new System.EventHandler(this.mnuSavePicture_Click);
            // 
            // sort_ToolStripMenuItem
            // 
            this.sort_ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.каскадToolStripMenuItem,
            this.вертикальноToolStripMenuItem,
            this.горизонтальноToolStripMenuItem,
            this.иконкиToolStripMenuItem});
            this.sort_ToolStripMenuItem.Name = "sort_ToolStripMenuItem";
            this.sort_ToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.sort_ToolStripMenuItem.Text = "Сортировка";
            // 
            // каскадToolStripMenuItem
            // 
            this.каскадToolStripMenuItem.Name = "каскадToolStripMenuItem";
            this.каскадToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.каскадToolStripMenuItem.Text = "Каскад";
            this.каскадToolStripMenuItem.Click += new System.EventHandler(this.каскадToolStripMenuItem_Click);
            // 
            // вертикальноToolStripMenuItem
            // 
            this.вертикальноToolStripMenuItem.Name = "вертикальноToolStripMenuItem";
            this.вертикальноToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.вертикальноToolStripMenuItem.Text = "Вертикально";
            this.вертикальноToolStripMenuItem.Click += new System.EventHandler(this.вертикальноToolStripMenuItem_Click);
            // 
            // горизонтальноToolStripMenuItem
            // 
            this.горизонтальноToolStripMenuItem.Name = "горизонтальноToolStripMenuItem";
            this.горизонтальноToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.горизонтальноToolStripMenuItem.Text = "Горизонтально";
            this.горизонтальноToolStripMenuItem.Click += new System.EventHandler(this.горизонтальноToolStripMenuItem_Click);
            // 
            // иконкиToolStripMenuItem
            // 
            this.иконкиToolStripMenuItem.Name = "иконкиToolStripMenuItem";
            this.иконкиToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.иконкиToolStripMenuItem.Text = "Иконки";
            this.иконкиToolStripMenuItem.Click += new System.EventHandler(this.иконкиToolStripMenuItem_Click);
            // 
            // mdiGeneral
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(980, 560);
            this.Controls.Add(this.mnuGeneral);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.mnuGeneral;
            this.Name = "mdiGeneral";
            this.Text = "Графический редактор Художник 2.0";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.mnuGeneral.ResumeLayout(false);
            this.mnuGeneral.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip mnuGeneral;
        private System.Windows.Forms.ToolStripMenuItem mnuFile;
        private System.Windows.Forms.ToolStripMenuItem mnuTools;
        private System.Windows.Forms.ToolStripMenuItem mnuColor;
        private System.Windows.Forms.ToolStripMenuItem mnuWindow;
        private System.Windows.Forms.ToolStripMenuItem lineToCenter_ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem Squares_ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mnuNewPicture;
        private System.Windows.Forms.ToolStripMenuItem mnuLoadPicture;
        private System.Windows.Forms.ToolStripMenuItem mnuSavePicture;
        private System.Windows.Forms.ToolStripMenuItem sort_ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem каскадToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem вертикальноToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem горизонтальноToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem иконкиToolStripMenuItem;
    }
}


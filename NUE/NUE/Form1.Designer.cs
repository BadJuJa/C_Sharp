
namespace NUE {
    partial class MainForm {
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
            this.tableLayout_Main = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayout_topCR = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayout_topR = new System.Windows.Forms.TableLayoutPanel();
            this.trackBar_current_song_volume = new System.Windows.Forms.TrackBar();
            this.label_volume = new System.Windows.Forms.Label();
            this.flowLayout_topC = new System.Windows.Forms.FlowLayoutPanel();
            this.btn_current_song_prev = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.lable_current_song_name = new System.Windows.Forms.Label();
            this.trackBar_current_song_progress = new System.Windows.Forms.TrackBar();
            this.btn_current_song_next = new System.Windows.Forms.Button();
            this.flowLayout_topL = new System.Windows.Forms.FlowLayoutPanel();
            this.btn_stop = new System.Windows.Forms.Button();
            this.btn_shuffle = new System.Windows.Forms.Button();
            this.btn_play_pause = new System.Windows.Forms.Button();
            this.flowLayout_left_libAplay = new System.Windows.Forms.FlowLayoutPanel();
            this.groupBox_lib = new System.Windows.Forms.GroupBox();
            this.btn_artists = new System.Windows.Forms.Button();
            this.btn_songs = new System.Windows.Forms.Button();
            this.groupBox_playlist = new System.Windows.Forms.GroupBox();
            this.listBox_playlists_list = new System.Windows.Forms.ListBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayout_Main.SuspendLayout();
            this.tableLayout_topCR.SuspendLayout();
            this.tableLayout_topR.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar_current_song_volume)).BeginInit();
            this.flowLayout_topC.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar_current_song_progress)).BeginInit();
            this.flowLayout_topL.SuspendLayout();
            this.flowLayout_left_libAplay.SuspendLayout();
            this.groupBox_lib.SuspendLayout();
            this.groupBox_playlist.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayout_Main
            // 
            this.tableLayout_Main.ColumnCount = 2;
            this.tableLayout_Main.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 21.00568F));
            this.tableLayout_Main.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 78.99432F));
            this.tableLayout_Main.Controls.Add(this.tableLayout_topCR, 1, 0);
            this.tableLayout_Main.Controls.Add(this.flowLayout_topL, 0, 0);
            this.tableLayout_Main.Controls.Add(this.flowLayout_left_libAplay, 0, 1);
            this.tableLayout_Main.Controls.Add(this.tabControl1, 1, 1);
            this.tableLayout_Main.Location = new System.Drawing.Point(12, 12);
            this.tableLayout_Main.Margin = new System.Windows.Forms.Padding(1);
            this.tableLayout_Main.Name = "tableLayout_Main";
            this.tableLayout_Main.RowCount = 2;
            this.tableLayout_Main.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.51913F));
            this.tableLayout_Main.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 89.48087F));
            this.tableLayout_Main.Size = new System.Drawing.Size(1233, 732);
            this.tableLayout_Main.TabIndex = 0;
            // 
            // tableLayout_topCR
            // 
            this.tableLayout_topCR.ColumnCount = 2;
            this.tableLayout_topCR.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 77.81218F));
            this.tableLayout_topCR.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 22.18782F));
            this.tableLayout_topCR.Controls.Add(this.tableLayout_topR, 1, 0);
            this.tableLayout_topCR.Controls.Add(this.flowLayout_topC, 0, 0);
            this.tableLayout_topCR.Location = new System.Drawing.Point(260, 1);
            this.tableLayout_topCR.Margin = new System.Windows.Forms.Padding(1);
            this.tableLayout_topCR.Name = "tableLayout_topCR";
            this.tableLayout_topCR.RowCount = 1;
            this.tableLayout_topCR.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayout_topCR.Size = new System.Drawing.Size(972, 75);
            this.tableLayout_topCR.TabIndex = 0;
            // 
            // tableLayout_topR
            // 
            this.tableLayout_topR.ColumnCount = 1;
            this.tableLayout_topR.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayout_topR.Controls.Add(this.trackBar_current_song_volume, 0, 1);
            this.tableLayout_topR.Controls.Add(this.label_volume, 0, 0);
            this.tableLayout_topR.Location = new System.Drawing.Point(757, 1);
            this.tableLayout_topR.Margin = new System.Windows.Forms.Padding(1);
            this.tableLayout_topR.Name = "tableLayout_topR";
            this.tableLayout_topR.RowCount = 2;
            this.tableLayout_topR.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 36F));
            this.tableLayout_topR.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayout_topR.Size = new System.Drawing.Size(212, 73);
            this.tableLayout_topR.TabIndex = 0;
            // 
            // trackBar_current_song_volume
            // 
            this.trackBar_current_song_volume.AutoSize = false;
            this.trackBar_current_song_volume.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.trackBar_current_song_volume.LargeChange = 10;
            this.trackBar_current_song_volume.Location = new System.Drawing.Point(3, 41);
            this.trackBar_current_song_volume.Maximum = 100;
            this.trackBar_current_song_volume.Name = "trackBar_current_song_volume";
            this.trackBar_current_song_volume.Size = new System.Drawing.Size(206, 29);
            this.trackBar_current_song_volume.TabIndex = 0;
            this.trackBar_current_song_volume.TickStyle = System.Windows.Forms.TickStyle.None;
            this.trackBar_current_song_volume.Value = 100;
            // 
            // label_volume
            // 
            this.label_volume.Font = new System.Drawing.Font("Edo SZ HQ", 14F);
            this.label_volume.Location = new System.Drawing.Point(3, 0);
            this.label_volume.Name = "label_volume";
            this.label_volume.Size = new System.Drawing.Size(206, 36);
            this.label_volume.TabIndex = 1;
            this.label_volume.Text = "Volume";
            this.label_volume.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // flowLayout_topC
            // 
            this.flowLayout_topC.Controls.Add(this.btn_current_song_prev);
            this.flowLayout_topC.Controls.Add(this.tableLayoutPanel1);
            this.flowLayout_topC.Controls.Add(this.btn_current_song_next);
            this.flowLayout_topC.Location = new System.Drawing.Point(1, 1);
            this.flowLayout_topC.Margin = new System.Windows.Forms.Padding(1);
            this.flowLayout_topC.Name = "flowLayout_topC";
            this.flowLayout_topC.Size = new System.Drawing.Size(754, 73);
            this.flowLayout_topC.TabIndex = 1;
            // 
            // btn_current_song_prev
            // 
            this.btn_current_song_prev.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F);
            this.btn_current_song_prev.Location = new System.Drawing.Point(3, 3);
            this.btn_current_song_prev.Margin = new System.Windows.Forms.Padding(3, 3, 1, 1);
            this.btn_current_song_prev.Name = "btn_current_song_prev";
            this.btn_current_song_prev.Size = new System.Drawing.Size(75, 70);
            this.btn_current_song_prev.TabIndex = 0;
            this.btn_current_song_prev.Text = "<<";
            this.btn_current_song_prev.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.lable_current_song_name, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.trackBar_current_song_progress, 0, 1);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(82, 3);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(585, 71);
            this.tableLayoutPanel1.TabIndex = 2;
            // 
            // lable_current_song_name
            // 
            this.lable_current_song_name.Font = new System.Drawing.Font("Edo SZ HQ", 14F);
            this.lable_current_song_name.Location = new System.Drawing.Point(3, 0);
            this.lable_current_song_name.Name = "lable_current_song_name";
            this.lable_current_song_name.Size = new System.Drawing.Size(579, 35);
            this.lable_current_song_name.TabIndex = 0;
            this.lable_current_song_name.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // trackBar_current_song_progress
            // 
            this.trackBar_current_song_progress.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.trackBar_current_song_progress.LargeChange = 10;
            this.trackBar_current_song_progress.Location = new System.Drawing.Point(3, 38);
            this.trackBar_current_song_progress.Maximum = 100;
            this.trackBar_current_song_progress.Name = "trackBar_current_song_progress";
            this.trackBar_current_song_progress.Size = new System.Drawing.Size(579, 30);
            this.trackBar_current_song_progress.TabIndex = 1;
            this.trackBar_current_song_progress.TickStyle = System.Windows.Forms.TickStyle.None;
            // 
            // btn_current_song_next
            // 
            this.btn_current_song_next.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F);
            this.btn_current_song_next.Location = new System.Drawing.Point(671, 3);
            this.btn_current_song_next.Margin = new System.Windows.Forms.Padding(1, 3, 3, 1);
            this.btn_current_song_next.Name = "btn_current_song_next";
            this.btn_current_song_next.Size = new System.Drawing.Size(75, 70);
            this.btn_current_song_next.TabIndex = 1;
            this.btn_current_song_next.Text = ">>";
            this.btn_current_song_next.UseVisualStyleBackColor = true;
            // 
            // flowLayout_topL
            // 
            this.flowLayout_topL.Controls.Add(this.btn_stop);
            this.flowLayout_topL.Controls.Add(this.btn_shuffle);
            this.flowLayout_topL.Controls.Add(this.btn_play_pause);
            this.flowLayout_topL.Location = new System.Drawing.Point(1, 1);
            this.flowLayout_topL.Margin = new System.Windows.Forms.Padding(1);
            this.flowLayout_topL.Name = "flowLayout_topL";
            this.flowLayout_topL.Size = new System.Drawing.Size(256, 75);
            this.flowLayout_topL.TabIndex = 1;
            // 
            // btn_stop
            // 
            this.btn_stop.Font = new System.Drawing.Font("Edo SZ HQ", 14F);
            this.btn_stop.Location = new System.Drawing.Point(3, 3);
            this.btn_stop.Name = "btn_stop";
            this.btn_stop.Size = new System.Drawing.Size(79, 71);
            this.btn_stop.TabIndex = 0;
            this.btn_stop.Text = "Stop";
            this.btn_stop.UseVisualStyleBackColor = true;
            // 
            // btn_shuffle
            // 
            this.btn_shuffle.Font = new System.Drawing.Font("Edo SZ HQ", 14F);
            this.btn_shuffle.Location = new System.Drawing.Point(88, 3);
            this.btn_shuffle.Name = "btn_shuffle";
            this.btn_shuffle.Size = new System.Drawing.Size(79, 71);
            this.btn_shuffle.TabIndex = 1;
            this.btn_shuffle.Text = "Shuffle";
            this.btn_shuffle.UseVisualStyleBackColor = true;
            // 
            // btn_play_pause
            // 
            this.btn_play_pause.Font = new System.Drawing.Font("Edo SZ HQ", 14F);
            this.btn_play_pause.Location = new System.Drawing.Point(173, 3);
            this.btn_play_pause.Name = "btn_play_pause";
            this.btn_play_pause.Size = new System.Drawing.Size(79, 71);
            this.btn_play_pause.TabIndex = 2;
            this.btn_play_pause.Text = "Play || Pause";
            this.btn_play_pause.UseVisualStyleBackColor = true;
            // 
            // flowLayout_left_libAplay
            // 
            this.flowLayout_left_libAplay.Controls.Add(this.groupBox_lib);
            this.flowLayout_left_libAplay.Controls.Add(this.groupBox_playlist);
            this.flowLayout_left_libAplay.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayout_left_libAplay.Location = new System.Drawing.Point(3, 80);
            this.flowLayout_left_libAplay.Margin = new System.Windows.Forms.Padding(3, 3, 0, 3);
            this.flowLayout_left_libAplay.Name = "flowLayout_left_libAplay";
            this.flowLayout_left_libAplay.Size = new System.Drawing.Size(250, 649);
            this.flowLayout_left_libAplay.TabIndex = 2;
            // 
            // groupBox_lib
            // 
            this.groupBox_lib.Controls.Add(this.btn_artists);
            this.groupBox_lib.Controls.Add(this.btn_songs);
            this.groupBox_lib.Location = new System.Drawing.Point(3, 3);
            this.groupBox_lib.Name = "groupBox_lib";
            this.groupBox_lib.Size = new System.Drawing.Size(247, 103);
            this.groupBox_lib.TabIndex = 0;
            this.groupBox_lib.TabStop = false;
            this.groupBox_lib.Text = "Library";
            // 
            // btn_artists
            // 
            this.btn_artists.Font = new System.Drawing.Font("Edo SZ HQ", 14F);
            this.btn_artists.Location = new System.Drawing.Point(6, 62);
            this.btn_artists.Name = "btn_artists";
            this.btn_artists.Size = new System.Drawing.Size(235, 35);
            this.btn_artists.TabIndex = 1;
            this.btn_artists.Text = "Artists";
            this.btn_artists.UseVisualStyleBackColor = true;
            // 
            // btn_songs
            // 
            this.btn_songs.Font = new System.Drawing.Font("Edo SZ HQ", 14F);
            this.btn_songs.Location = new System.Drawing.Point(6, 19);
            this.btn_songs.Name = "btn_songs";
            this.btn_songs.Size = new System.Drawing.Size(235, 35);
            this.btn_songs.TabIndex = 0;
            this.btn_songs.Text = "Songs";
            this.btn_songs.UseVisualStyleBackColor = true;
            // 
            // groupBox_playlist
            // 
            this.groupBox_playlist.Controls.Add(this.listBox_playlists_list);
            this.groupBox_playlist.Controls.Add(this.button2);
            this.groupBox_playlist.Controls.Add(this.button1);
            this.groupBox_playlist.Location = new System.Drawing.Point(3, 112);
            this.groupBox_playlist.Name = "groupBox_playlist";
            this.groupBox_playlist.Size = new System.Drawing.Size(247, 529);
            this.groupBox_playlist.TabIndex = 1;
            this.groupBox_playlist.TabStop = false;
            this.groupBox_playlist.Text = "Playlists";
            // 
            // listBox_playlists_list
            // 
            this.listBox_playlists_list.FormattingEnabled = true;
            this.listBox_playlists_list.Location = new System.Drawing.Point(6, 101);
            this.listBox_playlists_list.Name = "listBox_playlists_list";
            this.listBox_playlists_list.Size = new System.Drawing.Size(235, 420);
            this.listBox_playlists_list.TabIndex = 2;
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Edo SZ HQ", 14F);
            this.button2.Location = new System.Drawing.Point(6, 60);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(235, 35);
            this.button2.TabIndex = 1;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Edo SZ HQ", 14F);
            this.button1.Location = new System.Drawing.Point(6, 19);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(235, 35);
            this.button1.TabIndex = 0;
            this.button1.Text = "Create";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(262, 80);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(968, 649);
            this.tabControl1.TabIndex = 3;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.tableLayoutPanel2);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(960, 623);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "tabPage1";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(192, 74);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 2;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 48F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 52F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(960, 623);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1257, 756);
            this.Controls.Add(this.tableLayout_Main);
            this.MaximumSize = new System.Drawing.Size(1273, 795);
            this.MinimumSize = new System.Drawing.Size(1273, 795);
            this.Name = "MainForm";
            this.Text = "NUE";
            this.tableLayout_Main.ResumeLayout(false);
            this.tableLayout_topCR.ResumeLayout(false);
            this.tableLayout_topR.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.trackBar_current_song_volume)).EndInit();
            this.flowLayout_topC.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar_current_song_progress)).EndInit();
            this.flowLayout_topL.ResumeLayout(false);
            this.flowLayout_left_libAplay.ResumeLayout(false);
            this.groupBox_lib.ResumeLayout(false);
            this.groupBox_playlist.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayout_Main;
        private System.Windows.Forms.TableLayoutPanel tableLayout_topCR;
        private System.Windows.Forms.TableLayoutPanel tableLayout_topR;
        private System.Windows.Forms.FlowLayoutPanel flowLayout_topC;
        private System.Windows.Forms.FlowLayoutPanel flowLayout_topL;
        private System.Windows.Forms.TrackBar trackBar_current_song_volume;
        private System.Windows.Forms.Button btn_current_song_prev;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label lable_current_song_name;
        private System.Windows.Forms.TrackBar trackBar_current_song_progress;
        private System.Windows.Forms.Button btn_current_song_next;
        private System.Windows.Forms.Button btn_stop;
        private System.Windows.Forms.Button btn_shuffle;
        private System.Windows.Forms.Button btn_play_pause;
        private System.Windows.Forms.FlowLayoutPanel flowLayout_left_libAplay;
        private System.Windows.Forms.GroupBox groupBox_lib;
        private System.Windows.Forms.Button btn_artists;
        private System.Windows.Forms.Button btn_songs;
        private System.Windows.Forms.GroupBox groupBox_playlist;
        private System.Windows.Forms.ListBox listBox_playlists_list;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label_volume;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.TabPage tabPage2;
    }
}


﻿
namespace The_Last_Round_Reborn
{
    partial class form_Main
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
            this.components = new System.ComponentModel.Container();
            this.groupBox_Menu = new System.Windows.Forms.GroupBox();
            this.listBox_Menu = new System.Windows.Forms.ListBox();
            this.mnuContext = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem4 = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox_Order = new System.Windows.Forms.GroupBox();
            this.listBox_Order = new System.Windows.Forms.ListBox();
            this.btn_AddToOrder = new System.Windows.Forms.Button();
            this.btn_RemoveFromOrder = new System.Windows.Forms.Button();
            this.btn_MakeAnOrder = new System.Windows.Forms.Button();
            this.textBox_Search = new System.Windows.Forms.TextBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.mnuFile = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuKitchens = new System.Windows.Forms.ToolStripMenuItem();
            this.удалитьКухнюToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox_Menu.SuspendLayout();
            this.mnuContext.SuspendLayout();
            this.groupBox_Order.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox_Menu
            // 
            this.groupBox_Menu.Controls.Add(this.listBox_Menu);
            this.groupBox_Menu.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox_Menu.Location = new System.Drawing.Point(12, 22);
            this.groupBox_Menu.Name = "groupBox_Menu";
            this.groupBox_Menu.Size = new System.Drawing.Size(394, 529);
            this.groupBox_Menu.TabIndex = 0;
            this.groupBox_Menu.TabStop = false;
            this.groupBox_Menu.Text = "МЕНЮ:";
            // 
            // listBox_Menu
            // 
            this.listBox_Menu.ContextMenuStrip = this.mnuContext;
            this.listBox_Menu.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.listBox_Menu.FormattingEnabled = true;
            this.listBox_Menu.ItemHeight = 24;
            this.listBox_Menu.Location = new System.Drawing.Point(6, 28);
            this.listBox_Menu.Name = "listBox_Menu";
            this.listBox_Menu.Size = new System.Drawing.Size(382, 484);
            this.listBox_Menu.TabIndex = 0;
            this.listBox_Menu.SelectedIndexChanged += new System.EventHandler(this.listBox_Menu_SelectedIndexChanged);
            // 
            // mnuContext
            // 
            this.mnuContext.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1,
            this.toolStripMenuItem2,
            this.toolStripMenuItem3,
            this.toolStripMenuItem4});
            this.mnuContext.Name = "mnuContext";
            this.mnuContext.Size = new System.Drawing.Size(221, 92);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Enabled = false;
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(220, 22);
            this.toolStripMenuItem1.Text = "Добавить новое блюдо";
            this.toolStripMenuItem1.Click += new System.EventHandler(this.toolStripMenuItem1_Click);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Enabled = false;
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(220, 22);
            this.toolStripMenuItem2.Text = "Заказать блюдо";
            this.toolStripMenuItem2.Click += new System.EventHandler(this.toolStripMenuItem2_Click);
            // 
            // toolStripMenuItem3
            // 
            this.toolStripMenuItem3.Enabled = false;
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            this.toolStripMenuItem3.Size = new System.Drawing.Size(220, 22);
            this.toolStripMenuItem3.Text = "Удалить блюдо";
            this.toolStripMenuItem3.Click += new System.EventHandler(this.toolStripMenuItem3_Click);
            // 
            // toolStripMenuItem4
            // 
            this.toolStripMenuItem4.Enabled = false;
            this.toolStripMenuItem4.Name = "toolStripMenuItem4";
            this.toolStripMenuItem4.Size = new System.Drawing.Size(220, 22);
            this.toolStripMenuItem4.Text = "Изменить название блюда";
            this.toolStripMenuItem4.Click += new System.EventHandler(this.toolStripMenuItem4_Click);
            // 
            // groupBox_Order
            // 
            this.groupBox_Order.Controls.Add(this.listBox_Order);
            this.groupBox_Order.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox_Order.Location = new System.Drawing.Point(666, 22);
            this.groupBox_Order.Name = "groupBox_Order";
            this.groupBox_Order.Size = new System.Drawing.Size(394, 529);
            this.groupBox_Order.TabIndex = 1;
            this.groupBox_Order.TabStop = false;
            this.groupBox_Order.Text = "ЗАКАЗ:";
            // 
            // listBox_Order
            // 
            this.listBox_Order.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.listBox_Order.FormattingEnabled = true;
            this.listBox_Order.ItemHeight = 24;
            this.listBox_Order.Location = new System.Drawing.Point(6, 28);
            this.listBox_Order.Name = "listBox_Order";
            this.listBox_Order.Size = new System.Drawing.Size(382, 484);
            this.listBox_Order.TabIndex = 0;
            this.listBox_Order.SelectedIndexChanged += new System.EventHandler(this.listBox_Order_SelectedIndexChanged);
            // 
            // btn_AddToOrder
            // 
            this.btn_AddToOrder.Location = new System.Drawing.Point(481, 150);
            this.btn_AddToOrder.Name = "btn_AddToOrder";
            this.btn_AddToOrder.Size = new System.Drawing.Size(117, 34);
            this.btn_AddToOrder.TabIndex = 2;
            this.btn_AddToOrder.Text = "Добавить -->";
            this.btn_AddToOrder.UseVisualStyleBackColor = true;
            this.btn_AddToOrder.Click += new System.EventHandler(this.btn_AddToOrder_Click);
            // 
            // btn_RemoveFromOrder
            // 
            this.btn_RemoveFromOrder.Location = new System.Drawing.Point(481, 203);
            this.btn_RemoveFromOrder.Name = "btn_RemoveFromOrder";
            this.btn_RemoveFromOrder.Size = new System.Drawing.Size(115, 33);
            this.btn_RemoveFromOrder.TabIndex = 3;
            this.btn_RemoveFromOrder.Text = "<-- Убрать";
            this.btn_RemoveFromOrder.UseVisualStyleBackColor = true;
            this.btn_RemoveFromOrder.Click += new System.EventHandler(this.btn_RemoveFromOrder_Click);
            // 
            // btn_MakeAnOrder
            // 
            this.btn_MakeAnOrder.Location = new System.Drawing.Point(481, 255);
            this.btn_MakeAnOrder.Name = "btn_MakeAnOrder";
            this.btn_MakeAnOrder.Size = new System.Drawing.Size(117, 34);
            this.btn_MakeAnOrder.TabIndex = 4;
            this.btn_MakeAnOrder.Text = "Заказать";
            this.btn_MakeAnOrder.UseVisualStyleBackColor = true;
            this.btn_MakeAnOrder.Click += new System.EventHandler(this.btn_MakeAnOrder_Click);
            // 
            // textBox_Search
            // 
            this.textBox_Search.Location = new System.Drawing.Point(412, 50);
            this.textBox_Search.Name = "textBox_Search";
            this.textBox_Search.Size = new System.Drawing.Size(248, 20);
            this.textBox_Search.TabIndex = 6;
            this.textBox_Search.TextChanged += new System.EventHandler(this.textBox_Search_TextChanged);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuFile,
            this.mnuKitchens});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1072, 24);
            this.menuStrip1.TabIndex = 7;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // mnuFile
            // 
            this.mnuFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.удалитьКухнюToolStripMenuItem});
            this.mnuFile.Name = "mnuFile";
            this.mnuFile.Size = new System.Drawing.Size(48, 20);
            this.mnuFile.Text = "Файл";
            // 
            // mnuKitchens
            // 
            this.mnuKitchens.Name = "mnuKitchens";
            this.mnuKitchens.Size = new System.Drawing.Size(91, 20);
            this.mnuKitchens.Text = "Выбор кухни";
            this.mnuKitchens.DropDownItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.mnuKitchens_DropDownItemClicked);
            // 
            // удалитьКухнюToolStripMenuItem
            // 
            this.удалитьКухнюToolStripMenuItem.Name = "удалитьКухнюToolStripMenuItem";
            this.удалитьКухнюToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.удалитьКухнюToolStripMenuItem.Text = "Удалить кухню";
            this.удалитьКухнюToolStripMenuItem.Click += new System.EventHandler(this.удалитьКухнюToolStripMenuItem_Click);
            // 
            // form_Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1072, 577);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.textBox_Search);
            this.Controls.Add(this.btn_RemoveFromOrder);
            this.Controls.Add(this.btn_MakeAnOrder);
            this.Controls.Add(this.btn_AddToOrder);
            this.Controls.Add(this.groupBox_Order);
            this.Controls.Add(this.groupBox_Menu);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "form_Main";
            this.Text = "The Last Round";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.form_Main_FormClosing);
            this.Load += new System.EventHandler(this.form_Main_Load);
            this.groupBox_Menu.ResumeLayout(false);
            this.mnuContext.ResumeLayout(false);
            this.groupBox_Order.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox_Menu;
        private System.Windows.Forms.GroupBox groupBox_Order;
        private System.Windows.Forms.Button btn_AddToOrder;
        private System.Windows.Forms.Button btn_RemoveFromOrder;
        private System.Windows.Forms.Button btn_MakeAnOrder;
        private System.Windows.Forms.ListBox listBox_Menu;
        private System.Windows.Forms.ListBox listBox_Order;
        private System.Windows.Forms.ContextMenuStrip mnuContext;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem4;
        private System.Windows.Forms.TextBox textBox_Search;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem mnuFile;
        private System.Windows.Forms.ToolStripMenuItem mnuKitchens;
        private System.Windows.Forms.ToolStripMenuItem удалитьКухнюToolStripMenuItem;
    }
}


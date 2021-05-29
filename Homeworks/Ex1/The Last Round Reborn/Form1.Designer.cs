
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
            this.groupBox_Menu = new System.Windows.Forms.GroupBox();
            this.listBox_Menu = new System.Windows.Forms.ListBox();
            this.groupBox_Order = new System.Windows.Forms.GroupBox();
            this.listBox_Order = new System.Windows.Forms.ListBox();
            this.btn_AddToOrder = new System.Windows.Forms.Button();
            this.btn_RemoveFromOrder = new System.Windows.Forms.Button();
            this.btn_MakeAnOrder = new System.Windows.Forms.Button();
            this.groupBox_Menu.SuspendLayout();
            this.groupBox_Order.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox_Menu
            // 
            this.groupBox_Menu.Controls.Add(this.listBox_Menu);
            this.groupBox_Menu.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox_Menu.Location = new System.Drawing.Point(12, 92);
            this.groupBox_Menu.Name = "groupBox_Menu";
            this.groupBox_Menu.Size = new System.Drawing.Size(394, 518);
            this.groupBox_Menu.TabIndex = 0;
            this.groupBox_Menu.TabStop = false;
            this.groupBox_Menu.Text = "МЕНЮ:";
            // 
            // listBox_Menu
            // 
            this.listBox_Menu.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.listBox_Menu.FormattingEnabled = true;
            this.listBox_Menu.ItemHeight = 24;
            this.listBox_Menu.Items.AddRange(new object[] {
            "Борщ - 90",
            "Бутерброд - 50",
            "Суп бульон - 60",
            "Сельд под шубой - 80",
            "Салат цезарь - 70",
            "Чай - 20",
            "Кофе -30",
            "Сок - 50"});
            this.listBox_Menu.Location = new System.Drawing.Point(6, 28);
            this.listBox_Menu.Name = "listBox_Menu";
            this.listBox_Menu.Size = new System.Drawing.Size(382, 484);
            this.listBox_Menu.TabIndex = 0;
            this.listBox_Menu.SelectedIndexChanged += new System.EventHandler(this.listBox_Menu_SelectedIndexChanged);
            // 
            // groupBox_Order
            // 
            this.groupBox_Order.Controls.Add(this.listBox_Order);
            this.groupBox_Order.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox_Order.Location = new System.Drawing.Point(678, 92);
            this.groupBox_Order.Name = "groupBox_Order";
            this.groupBox_Order.Size = new System.Drawing.Size(394, 518);
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
            // form_Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1084, 622);
            this.Controls.Add(this.btn_RemoveFromOrder);
            this.Controls.Add(this.btn_MakeAnOrder);
            this.Controls.Add(this.btn_AddToOrder);
            this.Controls.Add(this.groupBox_Order);
            this.Controls.Add(this.groupBox_Menu);
            this.Name = "form_Main";
            this.Text = "The Last Round";
            this.groupBox_Menu.ResumeLayout(false);
            this.groupBox_Order.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox_Menu;
        private System.Windows.Forms.GroupBox groupBox_Order;
        private System.Windows.Forms.Button btn_AddToOrder;
        private System.Windows.Forms.Button btn_RemoveFromOrder;
        private System.Windows.Forms.Button btn_MakeAnOrder;
        private System.Windows.Forms.ListBox listBox_Menu;
        private System.Windows.Forms.ListBox listBox_Order;
    }
}


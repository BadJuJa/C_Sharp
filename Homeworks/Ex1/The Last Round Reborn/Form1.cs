using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace The_Last_Round_Reborn
{
    public partial class form_Main : Form
    {
        public form_Main()
        {
            InitializeComponent();
            btn_AddToOrder.Enabled = false;
            btn_RemoveFromOrder.Enabled = false;
            btn_MakeAnOrder.Enabled = false;
        }

        #region buttons

        private void btn_AddToOrder_Click(object sender, EventArgs e)
        {
            listBox_Order.Items.Add(listBox_Menu.SelectedItem);

            btn_MakeAnOrder.Enabled = true;
        }

        private void btn_RemoveFromOrder_Click(object sender, EventArgs e)
        {
            if (listBox_Order.SelectedIndex >= 0)
            {
                listBox_Order.Items.Remove(listBox_Order.SelectedItem);
            }

            if (listBox_Order.Items.Count == 0)
            {
                btn_MakeAnOrder.Enabled = false;
            }
        }

        private void btn_MakeAnOrder_Click(object sender, EventArgs e)
        {
            int Cost = 0;
            string len;

            DialogResult result = MessageBox.Show("Это весь заказ?", "Кафе-бар 'The Last Round'", MessageBoxButtons.YesNo, MessageBoxIcon.Hand);
            if (result == DialogResult.Yes)
            {
                for (int i = 0; i < listBox_Order.Items.Count; i++)
                {
                    len = Convert.ToString(listBox_Order.Items[i]);
                    string resultString = Regex.Match(len, @"\d+").Value;
                    Cost += int.Parse(resultString);
                }

                MessageBox.Show($"Приятного аппетита!\nВаш счет - {Cost}", "Ресторан 'The Last Round'", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Close();
            }
        }

        #endregion buttons

        private void listBox_Menu_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBox_Menu.SelectedItem != null)
            {
                btn_AddToOrder.Enabled = true;
            }
        }

        private void listBox_Order_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBox_Order.SelectedIndex == -1)
            {
                btn_RemoveFromOrder.Enabled = false;
            }
            else
            {
                btn_RemoveFromOrder.Enabled = true;
            }
        }
    }
}
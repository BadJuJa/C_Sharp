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

            DialogResult result = MessageBox.Show("Это весь заказ?", "Кафе-бар 'The Last Round'", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                for (int i = 0; i < listBox_Order.Items.Count; i++)
                {
                    len = Convert.ToString(listBox_Order.Items[i]);
                    string resultString = Regex.Match(len, @"\d+").Value;
                    Cost += int.Parse(resultString);
                }

                MessageBox.Show($"Приятного аппетита!\nВаш счет - {Cost}", "Ресторан 'The Last Round'", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                Close();
            }
        }

        

        #endregion buttons

        #region listBoxes and textBoxes
        private void listBox_Menu_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBox_Menu.SelectedItem != null)
            {
                btn_AddToOrder.Enabled = true;
            }

            toolStripMenuItem2.Enabled = true;
            toolStripMenuItem3.Enabled = true;
            toolStripMenuItem4.Enabled = true;
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

        private void textBox_Search_TextChanged(object sender, EventArgs e)
        {
            var Result = listBox_Menu.FindString(textBox_Search.Text);
            if (Result.GetType().ToString() == "System.Int32" && Result >= 0)
            {
                listBox_Menu.SetSelected(Result, true);
            }
            else
            {
                MessageBox.Show("Блюдо не найдено", "Ресторан 'The Last Round'", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        #endregion

        #region toolStripMenu
        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            string s = Microsoft.VisualBasic.Interaction.InputBox("Введите название нового блюда и цену через дефис","Ресторан 'The Last Round'", "<Новое блюдо>");
            if (s == "") return;
            listBox_Menu.Items.Add(s);
        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            btn_AddToOrder_Click(sender, e);
        }

        private void toolStripMenuItem3_Click(object sender, EventArgs e)
        {
            listBox_Menu.Items.Remove(listBox_Menu.SelectedItem);
        }

        private void toolStripMenuItem4_Click(object sender, EventArgs e)
        {
            string selected = listBox_Menu.SelectedItem.ToString();
            string s = Microsoft.VisualBasic.Interaction.InputBox("Введите новое название блюда", "Ресторан 'The Last Round'", "<Новое название>");
            if (s == "") return;
            string newDish = $"{s} {selected.Substring(selected.IndexOf('-'))}";
            listBox_Menu.Items.Insert(listBox_Menu.SelectedIndex, newDish);
            listBox_Menu.Items.Remove(selected);
        }

        #endregion

    }
}
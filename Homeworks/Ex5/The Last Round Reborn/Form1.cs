using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using System.IO;

namespace The_Last_Round_Reborn
{
    public partial class form_Main : Form
    {
        string dirKitchen = Directory.GetCurrentDirectory() + "\\Kitchen";
        string fileKitchen;
        string currentKitchen;
        bool changes = false;
        public form_Main()
        {
            InitializeComponent();
            btn_AddToOrder.Enabled = false;
            btn_RemoveFromOrder.Enabled = false;
            btn_MakeAnOrder.Enabled = false;
        }

        private void form_Main_Load(object sender, EventArgs e)
        {
            menuLoad();
        }


        #region Funcs and Methods

        void menuLoad()
        {
            if (!Directory.Exists(dirKitchen))
            {
                MessageBox.Show("Каталог 'Кухня' отсутствует!", "Кафе-бар 'The Last Round'",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            string[] files = Directory.GetFiles(dirKitchen, "*.khn");
            mnuKitchens.DropDownItems.Clear();
            foreach (string s in files)
            {
                string f = new FileInfo(s).Name.ToString();
                f = f.Remove(f.Length - 4);
                mnuKitchens.DropDownItems.Add(f);
            }
        }

        void saveKitchen()
        {
            changes = false;
            DialogResult result = MessageBox.Show("Вы хотите сохранить изменения?", "Кафе-бар 'The Last Round'",
            MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.No) return;
            StreamWriter f = new StreamWriter(fileKitchen, false);
            for (int i = 0; i < listBox_Menu.Items.Count; i++) f.WriteLine(listBox_Menu.Items[i]);
            f.Close();
        }

        private void mnuKitchens_DropDownItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            if (changes) saveKitchen();
            fileKitchen = dirKitchen + "\\" + e.ClickedItem.Text + ".khn";
            if (new FileInfo(fileKitchen).Exists == false)
            {
                MessageBox.Show("Данных об этой кухне нет!",
                "Кафе-бар 'The Last Round'", MessageBoxButtons.OK,
                MessageBoxIcon.Error);
                return;
            }
            currentKitchen = fileKitchen;
            StreamReader f = new StreamReader(fileKitchen);
            listBox_Menu.Items.Clear();
            while (!f.EndOfStream) listBox_Menu.Items.Add(f.ReadLine());
            f.Close();
            toolStripMenuItem1.Enabled = true;
        }

        #endregion

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
            //int Cost = 0;
            //string len;

            DialogResult result = MessageBox.Show("Это весь заказ?", "Кафе-бар 'The Last Round'", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                /*for (int i = 0; i < listBox_Order.Items.Count; i++)
                {
                    len = Convert.ToString(listBox_Order.Items[i]);
                    string resultString = Regex.Match(len, @"\d+").Value;
                    Cost += int.Parse(resultString);
                }
                MessageBox.Show($"Приятного аппетита!\nВаш счет - {Cost}", "Ресторан 'The Last Round'", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);*/
                
                MessageBox.Show("Приятного аппетита!", "Ресторан 'The Last Round'", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
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

            changes = true;
        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            btn_AddToOrder_Click(sender, e);
        }

        private void toolStripMenuItem3_Click(object sender, EventArgs e)
        {
            listBox_Menu.Items.Remove(listBox_Menu.SelectedItem);
            changes = true;
        }

        private void toolStripMenuItem4_Click(object sender, EventArgs e)
        {
            string selected = listBox_Menu.SelectedItem.ToString();
            string s = Microsoft.VisualBasic.Interaction.InputBox("Введите новое название блюда", "Ресторан 'The Last Round'", "<Новое название>");
            if (s == "") return;
            string newDish = $"{s} {selected.Substring(selected.IndexOf('-'))}";
            listBox_Menu.Items.Insert(listBox_Menu.SelectedIndex, newDish);
            listBox_Menu.Items.Remove(selected);

            changes = true;
        }

        #endregion

        private void form_Main_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (changes) saveKitchen();
        }

        private void удалитьКухнюToolStripMenuItem_Click(object sender, EventArgs e) {
            File.Delete(currentKitchen);
            listBox_Menu.Items.Clear();
            menuLoad();
        }
    }
}
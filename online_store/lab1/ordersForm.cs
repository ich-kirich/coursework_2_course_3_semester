﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab1
{
    public partial class ordersForm : Form
    {
        public ordersForm()
        {
            InitializeComponent();
        }

        protected override void OnFormClosed(FormClosedEventArgs e)
        {
            Environment.Exit(1);
        }

        private void toMain_Click(object sender, EventArgs e)
        {
            this.Hide();
            MainPage toMain = new MainPage();
            toMain.Show();
        }

        private void ordersForm_Load(object sender, EventArgs e)
        {
            string[] basketGoods = File.ReadAllLines(Directory.GetCurrentDirectory() + @"\files\basket.txt");
            for (int i = 1; i < basketGoods.Length; i++)
            {
                string[] goods = basketGoods[i].Split('_');
                string userName = goods[0];
                string sum = goods[1];
                string count = goods[2];
                string[] row = { userName, sum, count };
                var listViewItem = new ListViewItem(row);
                basketList.Items.Add(listViewItem);
            }
        }

        private int createId()
        {
            int id = 1;
            string[] idList = File.ReadAllLines(Directory.GetCurrentDirectory() + @"\files\ordersInProgress.txt");
            if (idList.Length != 0)
            {
                string[] Good = idList[idList.Length - 1].Split('/');
                string idGood = Good[0];
                id = Convert.ToInt32(idGood) + 1;
            }
            return id;
        }

        private void order_Click(object sender, EventArgs e)
        {
            if (checkBalance())
            {
                ListView.CheckedListViewItemCollection selectedGoods = basketList.CheckedItems;
                if (selectedGoods.Count <= 0)
                {
                    MessageBox.Show(
                        "Выберите товары, которые хотите заказать!",
                        "Ошибка оформления заказа",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.None,
                        MessageBoxDefaultButton.Button1,
                        MessageBoxOptions.DefaultDesktopOnly
                    );
                }
                else
                {
                    StreamReader f = new StreamReader(Directory.GetCurrentDirectory() + @"\files\localStorage.txt");
                    string user = "";
                    while (!f.EndOfStream)
                    {
                        user = f.ReadLine();
                    }
                    f.Close();
                    string path = Directory.GetCurrentDirectory() + @"\files\ordersInProgress.txt";
                    string goods = "";
                    string worker = "Не назначен";
                    string statusOrder = "В процессе рассмотрения";
                    int idGood = createId();
                    if (File.Exists(path))
                    {
                        File.AppendAllText(path, idGood + "/" + user + "/" + worker + "/" + statusOrder + "/");
                        foreach (ListViewItem item in selectedGoods)
                        {
                            string res = item.SubItems[0].Text + "_" + Convert.ToInt32(item.SubItems[1].Text.Replace("р.", "")) * Convert.ToInt32(item.SubItems[2].Text.Replace("шт.", ""));
                            goods += res + "/";
                        }
                        File.AppendAllText(path, goods + "\n");
                    }
                    MessageBox.Show(
                        "Заказ сделан!",
                        "Заказ успешно оформлен",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.None,
                        MessageBoxDefaultButton.Button1,
                        MessageBoxOptions.DefaultDesktopOnly
                    );
                }
            }
            else
            {
                MessageBox.Show(
                    "Недостаточно средств на вашем счету!",
                    "Ошибка оформления заказа",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.None,
                    MessageBoxDefaultButton.Button1,
                    MessageBoxOptions.DefaultDesktopOnly
                );
            }
        }

        private bool checkBalance()
        {
            string[] usersBalance = File.ReadAllLines(Directory.GetCurrentDirectory() + @"\files\usersBalance.txt");
            string[] currentUser = File.ReadAllLines(Directory.GetCurrentDirectory() + @"\files\localStorage.txt");
            for (int i = 0; i < usersBalance.Length; i++)
            {
                string[] userBalance = usersBalance[i].Split(' ');
                if (userBalance[0] == currentUser[0])
                {
                    string numberOnly = resultPrice.Text;
                    numberOnly = Regex.Replace(numberOnly, "[^0-9,-]+", "");
                    if (Convert.ToInt32(numberOnly) <= Convert.ToInt32(userBalance[1]))
                    {
                        int updateBalance = Convert.ToInt32(userBalance[1]) - Convert.ToInt32(numberOnly);
                        string updateUser = currentUser[0] + " " + updateBalance;
                        string str = string.Empty;
                        using (StreamReader reader = File.OpenText(Directory.GetCurrentDirectory() + @"\files\usersBalance.txt"))
                        {
                            str = reader.ReadToEnd();
                        }
                        str = str.Replace(usersBalance[i], updateUser);
                        using (StreamWriter file = new StreamWriter(Directory.GetCurrentDirectory() + @"\files\usersBalance.txt"))
                        {
                            file.Write(str);
                        }
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                }
            }
            return false;
        }

        private void upgateCountGood_Click(object sender, EventArgs e)
        {
            if (inputCountGood.Text.All(char.IsDigit) && inputCountGood.Text != "")
            {
                if (inputCountGood.Text.Length >= 4)
                {
                    MessageBox.Show(
                       "Нельзя купить больше 100 шт. товара!",
                       "Ошибка выбора количества товара",
                       MessageBoxButtons.OK,
                       MessageBoxIcon.None,
                       MessageBoxDefaultButton.Button1,
                       MessageBoxOptions.DefaultDesktopOnly
                   );
                }
                else if (Convert.ToInt32(inputCountGood.Text) > 0 && Convert.ToInt32(inputCountGood.Text) <= 100)
                {
                    ListView.CheckedListViewItemCollection checkedItems = basketList.CheckedItems;
                    if (checkedItems.Count <= 0)
                    {
                        MessageBox.Show(
                            "Выберите товар!",
                            "Ошибка выбора количества товара",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.None,
                            MessageBoxDefaultButton.Button1,
                            MessageBoxOptions.DefaultDesktopOnly
                        );
                    }
                    else
                    {
                        foreach (ListViewItem item in checkedItems)
                        {
                            item.SubItems[2].Text = inputCountGood.Text + "шт.";
                        }
                        updatePrice();
                    }
                }
                else
                {
                    MessageBox.Show(
                        "Введите число, большее нуля, но меньшее 100!",
                        "Ошибка выбора количества товара",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.None,
                        MessageBoxDefaultButton.Button1,
                        MessageBoxOptions.DefaultDesktopOnly
                    );
                }
            }
            else
            {
                MessageBox.Show(
                    "Введите целое число!",
                    "Ошибка выбора количества товара",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.None,
                    MessageBoxDefaultButton.Button1,
                    MessageBoxOptions.DefaultDesktopOnly
                );
            }
        }

        private void updatePrice()
        {
            ListView.CheckedListViewItemCollection checkedItems = basketList.CheckedItems;
            int price = 0;
            foreach (ListViewItem item in checkedItems)
            {
                price += Convert.ToInt32(item.SubItems[1].Text.Replace("р.", "")) * Convert.ToInt32(item.SubItems[2].Text.Replace("шт.", ""));
            }
            resultPrice.Text = "Итоговая цена: " + price.ToString() + "р.";
        }

        private void countPrice_Click(object sender, EventArgs e)
        {
            updatePrice();
        }
    }
}

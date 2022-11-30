using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab1
{
    public partial class MainPage : Form
    {
        private string selectedCategory;
        public MainPage()
        {
            InitializeComponent();
            listOfGoods.SelectedIndexChanged += listOfGoods_SelectedIndexChanged;
        }

        private void listOfGoods_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (selectedCategory)
            {
                case "Рыбы":
                    listOfGoods.Items.AddRange(new string[] { "Тунец", "Минтай", "Белуга", "Щука", "Вобла", "Карась", "Треска" });
                    break;
                case "Хлебобулочные":
                    listOfGoods.Items.AddRange(new string[] { "Ржаной хлеб", "Белый хлеб", "Зерновой хлеб", "Лаваш", "Плоский хлеб", "Тортилья", "Бисквит" });
                    break;
                case "Мясо":
                    listOfGoods.Items.AddRange(new string[] { "Телятина", "Печень", "Стейк", "Говядина", "Свинина", "Конина", "Дичь" });
                    break;
                case "Молочные продукты":
                    listOfGoods.Items.AddRange(new string[] { "Творог", "Йогурт", "Кефир", "Сметана", "Кумыс", "Сливки", "Ряженка" });
                    break;
                case "Морепродукты":
                    listOfGoods.Items.AddRange(new string[] { "Моллюски", "Устрицы", "Мидии", "Осьминоги", "Кальмары", "Креветки", "Крабы" });
                    break;
                case "Яйца":
                    listOfGoods.Items.AddRange(new string[] { "Утиные", "Гусиные", "Индюшачьи", "Перепелиные", "Куриные", "Страусиные", "Фазаньи" });
                    break;
                case "Овощи":
                    listOfGoods.Items.AddRange(new string[] { "Авокадо", "Картофель", "Томат", "Тыква", "Свекла", "Красный лук", "Огурец" });
                    break;
                case "Зелень":
                    listOfGoods.Items.AddRange(new string[] { "Укроп", "Петрушка", "Зеленый лук", "Кинза", "Базилик", "Шпинатная зелень", "Пряные травы" });
                    break;
                case "Фрукты":
                    listOfGoods.Items.AddRange(new string[] { "Банан", "Апельсин", "Мандарин", "Яблоко", "Слива", "Гранат", "Ананас" });
                    break;
                case "Ягоды":
                    picturePokypka.Image = Image.FromFile(System.IO.Directory.GetCurrentDirectory() + @"\img\aim.jpg");
                    break;
                case "Грибы":
                    picturePokypka.Image = Image.FromFile(System.IO.Directory.GetCurrentDirectory() + @"\img\reservoir.jpg");
                    break;
                case "Орехи":
                    picturePokypka.Image = Image.FromFile(System.IO.Directory.GetCurrentDirectory() + @"\img\pistol-pnevm.jpg");
                    break;
                case "Сладости":
                    picturePokypka.Image = Image.FromFile(System.IO.Directory.GetCurrentDirectory() + @"\img\rifle-pnevm.jpg");
                    break;
                case "Соки":
                    picturePokypka.Image = Image.FromFile(System.IO.Directory.GetCurrentDirectory() + @"\img\knife.jpg");
                    break;
                case "Газировка":
                    picturePokypka.Image = Image.FromFile(System.IO.Directory.GetCurrentDirectory() + @"\img\torch.jpg");
                    break;
                case "Фастфуд":
                    picturePokypka.Image = Image.FromFile(System.IO.Directory.GetCurrentDirectory() + @"\img\torch.jpg");
                    break;
                default:
                    picturePokypka.Image = Image.FromFile(System.IO.Directory.GetCurrentDirectory() + @"\img\error.jpg");
                    break;
            }
        }

        protected override void OnFormClosed(FormClosedEventArgs e)
        {
            string path = Directory.GetCurrentDirectory() + @"\files\basket.txt";
            if (File.Exists(path))
            {
                File.WriteAllText(path, string.Empty);
            }
            Environment.Exit(1);
        }

        private void basket_Click(object sender, EventArgs e)
        {
            string path = Directory.GetCurrentDirectory() + @"\files\basket.txt";
            if (File.Exists(path))
            {
                File.WriteAllText(path, string.Empty);
                string text = string.Join(" ", listProducts.getProductsList()).Replace(" ", Environment.NewLine);
                File.AppendAllText(path, text);
            }
            this.Hide();
            ordersForm basket = new ordersForm();
            basket.Show();
        }

        private void личныйКабинетToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Profile toProfile = new Profile();
            toProfile.Show();
        }

        private void выходToolStripMenuItem_Click(object sender, EventArgs e)
        {
             Environment.Exit(1);
        }

        private void loginField_reg_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {
            selectedCategory = label3.Text;
        }

        private void label4_Click(object sender, EventArgs e)
        {
            selectedCategory = label4.Text;
        }

        private void label5_Click(object sender, EventArgs e)
        {
            selectedCategory = label5.Text;
        }

        private void label6_Click(object sender, EventArgs e)
        {
            selectedCategory = label6.Text;
        }

        private void label7_Click(object sender, EventArgs e)
        {
            selectedCategory = label7.Text;
        }

        private void label9_Click(object sender, EventArgs e)
        {
            selectedCategory = label9.Text;
        }

        private void label10_Click(object sender, EventArgs e)
        {
            selectedCategory = label10.Text;
        }

        private void label8_Click(object sender, EventArgs e)
        {
            selectedCategory = label8.Text;
        }

        private void label12_Click(object sender, EventArgs e)
        {
            selectedCategory = label12.Text;
        }

        private void label11_Click(object sender, EventArgs e)
        {
            selectedCategory = label11.Text;
        }

        private void label13_Click(object sender, EventArgs e)
        {
            selectedCategory = label13.Text;
        }

        private void label14_Click(object sender, EventArgs e)
        {
            selectedCategory = label14.Text;
        }

        private void label15_Click(object sender, EventArgs e)
        {
            selectedCategory = label15.Text;
        }

        private void label16_Click(object sender, EventArgs e)
        {
            selectedCategory = label16.Text;
        }

        private void label17_Click(object sender, EventArgs e)
        {
            selectedCategory = label17.Text;
        }

        private void label18_Click(object sender, EventArgs e)
        {
            selectedCategory = label18.Text;
        }
    }
}

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
                    listOfGoods.Items.AddRange(new string[] { "Малина", "Клюква", "Голубика", "Черника", "Морошка", "Брусника", "Облепиха" });
                    break;
                case "Грибы":
                    listOfGoods.Items.AddRange(new string[] { "Лишайники", "Клюква", "Голубика", "Черника", "Морошка", "Брусника", "Облепиха" });
                    break;
                case "Орехи":
                    listOfGoods.Items.AddRange(new string[] { "Фундук", "Грецкие орехи", "Миндаль", "Арахис", "Фисташки", "Кешью", "Каштаны" });
                    break;
                case "Сладости":
                    listOfGoods.Items.AddRange(new string[] { "Безе", "Зефир", "Ирис", "Макарун", "Ганаш", "Ромовая баба", "Маршмэллоу" });
                    break;
                case "Соки":
                    listOfGoods.Items.AddRange(new string[] { "Гранатовый", "Апельсиновый", "Яблочный", "Виноградный", "Грейпфрутовый", "Вишнёвый", "Клюквенный" });
                    break;
                case "Газировка":
                    listOfGoods.Items.AddRange(new string[] { "Fanta", "Pepsi", "CocaCola", "Sprite", "Mountain Dew", "7up", "Schweppes" });
                    break;
                case "Фастфуд":
                    listOfGoods.Items.AddRange(new string[] { "Картошка Фри", "Хот-дог", "Тако", "Чипсы", "Хачапури", "Чизбургер", "Schweppes" });
                    break;
                default:
                    listOfGoods.Items.AddRange(new string[] {});
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
            chandeListGoods(selectedCategory);
        }

        private void label4_Click(object sender, EventArgs e)
        {
            selectedCategory = label4.Text;
            chandeListGoods(selectedCategory);
        }

        private void label5_Click(object sender, EventArgs e)
        {
            selectedCategory = label5.Text;
            chandeListGoods(selectedCategory);
        }

        private void label6_Click(object sender, EventArgs e)
        {
            selectedCategory = label6.Text;
            chandeListGoods(selectedCategory);
        }

        private void label7_Click(object sender, EventArgs e)
        {
            selectedCategory = label7.Text;
            chandeListGoods(selectedCategory);
        }

        private void label9_Click(object sender, EventArgs e)
        {
            selectedCategory = label9.Text;
            chandeListGoods(selectedCategory);
        }

        private void label10_Click(object sender, EventArgs e)
        {
            selectedCategory = label10.Text;
            chandeListGoods(selectedCategory);
        }

        private void label8_Click(object sender, EventArgs e)
        {
            selectedCategory = label8.Text;
            chandeListGoods(selectedCategory);
        }

        private void label12_Click(object sender, EventArgs e)
        {
            selectedCategory = label12.Text;
            chandeListGoods(selectedCategory);
        }

        private void label11_Click(object sender, EventArgs e)
        {
            selectedCategory = label11.Text;
            chandeListGoods(selectedCategory);
        }

        private void label13_Click(object sender, EventArgs e)
        {
            selectedCategory = label13.Text;
            chandeListGoods(selectedCategory);
        }

        private void label14_Click(object sender, EventArgs e)
        {
            selectedCategory = label14.Text;
            chandeListGoods(selectedCategory);
        }

        private void label15_Click(object sender, EventArgs e)
        {
            selectedCategory = label15.Text;
            chandeListGoods(selectedCategory);
        }

        private void label16_Click(object sender, EventArgs e)
        {
            selectedCategory = label16.Text;
            chandeListGoods(selectedCategory);
        }

        private void label17_Click(object sender, EventArgs e)
        {
            selectedCategory = label17.Text;
            chandeListGoods(selectedCategory);
        }

        private void label18_Click(object sender, EventArgs e)
        {
            selectedCategory = label18.Text;
            chandeListGoods(selectedCategory);
        }

        private void chandeListGoods(string selectedCategory)
        {
            listOfGoods.Items.Clear();
            switch (selectedCategory)
            {
                case "Рыбы":
                    pictureGood.Image = Image.FromFile(Directory.GetCurrentDirectory() + @"\img\fish.jpg");
                    listOfGoods.Items.AddRange(new string[] { "Тунец", "Минтай", "Белуга", "Щука", "Вобла", "Карась", "Треска" });
                    break;
                case "Хлебобулочные":
                    pictureGood.Image = Image.FromFile(Directory.GetCurrentDirectory() + @"\img\bread.jpg");
                    listOfGoods.Items.AddRange(new string[] { "Ржаной хлеб", "Белый хлеб", "Зерновой хлеб", "Лаваш", "Плоский хлеб", "Тортилья", "Бисквит" });
                    break;
                case "Мясо":
                    pictureGood.Image = Image.FromFile(Directory.GetCurrentDirectory() + @"\img\meat.jpg");
                    listOfGoods.Items.AddRange(new string[] { "Телятина", "Печень", "Стейк", "Говядина", "Свинина", "Конина", "Дичь" });
                    break;
                case "Молочные изделия":
                    pictureGood.Image = Image.FromFile(Directory.GetCurrentDirectory() + @"\img\milk.jpg");
                    listOfGoods.Items.AddRange(new string[] { "Творог", "Йогурт", "Кефир", "Сметана", "Кумыс", "Сливки", "Ряженка" });
                    break;
                case "Морепродукты":
                    pictureGood.Image = Image.FromFile(Directory.GetCurrentDirectory() + @"\img\seafood.jpg");
                    listOfGoods.Items.AddRange(new string[] { "Моллюски", "Устрицы", "Мидии", "Осьминоги", "Кальмары", "Креветки", "Крабы" });
                    break;
                case "Яйца":
                    pictureGood.Image = Image.FromFile(Directory.GetCurrentDirectory() + @"\img\eggs.jpg");
                    listOfGoods.Items.AddRange(new string[] { "Утиные", "Гусиные", "Индюшачьи", "Перепелиные", "Куриные", "Страусиные", "Фазаньи" });
                    break;
                case "Овощи":
                    pictureGood.Image = Image.FromFile(Directory.GetCurrentDirectory() + @"\img\vegetables.jpg");
                    listOfGoods.Items.AddRange(new string[] { "Авокадо", "Картофель", "Томат", "Тыква", "Свекла", "Красный лук", "Огурец" });
                    break;
                case "Зелень":
                    pictureGood.Image = Image.FromFile(Directory.GetCurrentDirectory() + @"\img\greens.jpg");
                    listOfGoods.Items.AddRange(new string[] { "Укроп", "Петрушка", "Зеленый лук", "Кинза", "Базилик", "Шпинатная зелень", "Пряные травы" });
                    break;
                case "Фрукты":
                    pictureGood.Image = Image.FromFile(Directory.GetCurrentDirectory() + @"\img\fruit.jpg");
                    listOfGoods.Items.AddRange(new string[] { "Банан", "Апельсин", "Мандарин", "Яблоко", "Слива", "Гранат", "Ананас" });
                    break;
                case "Ягоды":
                    pictureGood.Image = Image.FromFile(Directory.GetCurrentDirectory() + @"\img\berries.jpg");
                    listOfGoods.Items.AddRange(new string[] { "Малина", "Клюква", "Голубика", "Черника", "Морошка", "Брусника", "Облепиха" });
                    break;
                case "Грибы":
                    pictureGood.Image = Image.FromFile(Directory.GetCurrentDirectory() + @"\img\mushrooms.jpg");
                    listOfGoods.Items.AddRange(new string[] { "Лишайники", "Клюква", "Голубика", "Черника", "Морошка", "Брусника", "Облепиха" });
                    break;
                case "Орехи":
                    pictureGood.Image = Image.FromFile(Directory.GetCurrentDirectory() + @"\img\nuts.jpg");
                    listOfGoods.Items.AddRange(new string[] { "Фундук", "Грецкие орехи", "Миндаль", "Арахис", "Фисташки", "Кешью", "Каштаны" });
                    break;
                case "Сладости":
                    pictureGood.Image = Image.FromFile(Directory.GetCurrentDirectory() + @"\img\sweets.jpg");
                    listOfGoods.Items.AddRange(new string[] { "Безе", "Зефир", "Ирис", "Макарун", "Ганаш", "Ромовая баба", "Маршмэллоу" });
                    break;
                case "Соки":
                    pictureGood.Image = Image.FromFile(Directory.GetCurrentDirectory() + @"\img\juices.jpg");
                    listOfGoods.Items.AddRange(new string[] { "Гранатовый", "Апельсиновый", "Яблочный", "Виноградный", "Грейпфрутовый", "Вишнёвый", "Клюквенный" });
                    break;
                case "Газировка":
                    pictureGood.Image = Image.FromFile(Directory.GetCurrentDirectory() + @"\img\soda.jpg");
                    listOfGoods.Items.AddRange(new string[] { "Fanta", "Pepsi", "CocaCola", "Sprite", "Mountain Dew", "7up", "Schweppes" });
                    break;
                case "Фастфуд":
                    pictureGood.Image = Image.FromFile(Directory.GetCurrentDirectory() + @"\img\fast_food.jpg");
                    listOfGoods.Items.AddRange(new string[] { "Картошка Фри", "Хот-дог", "Тако", "Чипсы", "Хачапури", "Чизбургер", "Schweppes" });
                    break;
                default:
                    pictureGood.Image = Image.FromFile(Directory.GetCurrentDirectory() + @"\img\basket.jpg");
                    listOfGoods.Items.AddRange(new string[] { });
                    break;
            }
        }
    }
}

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
        private string selectedCategory, selectedGood;
        public MainPage()
        {
            InitializeComponent();
            listOfGoods.SelectedIndexChanged += listOfGoods_SelectedIndexChanged;
            listView1.SelectedIndexChanged += listView1_SelectedIndexChanged;
        }

        private void listOfGoods_SelectedIndexChanged(object sender, EventArgs e)
        {
            selectedGood = listOfGoods.SelectedItem.ToString();
            selectPictGood(selectedGood);
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

        private void chandeListGoods(string selectedCategory)
        {
            listOfGoods.Items.Clear();
            switch (selectedCategory)
            {
                case "Рыбы":
                    pictureGood.Image = Image.FromFile(Directory.GetCurrentDirectory() + @"\img\fish.jpg");
                    listOfGoods.Items.AddRange(new string[] { "Тунец", "Минтай", "Белуга" });
                    break;
                case "Хлебобулочные":
                    pictureGood.Image = Image.FromFile(Directory.GetCurrentDirectory() + @"\img\bread.jpg");
                    listOfGoods.Items.AddRange(new string[] { "Ржаной хлеб", "Белый хлеб", "Зерновой хлеб" });
                    break;
                case "Мясо":
                    pictureGood.Image = Image.FromFile(Directory.GetCurrentDirectory() + @"\img\meat.jpg");
                    listOfGoods.Items.AddRange(new string[] { "Телятина", "Печень", "Стейк" });
                    break;
                case "Молочные продукты":
                    pictureGood.Image = Image.FromFile(Directory.GetCurrentDirectory() + @"\img\milk.jpg");
                    listOfGoods.Items.AddRange(new string[] { "Творог", "Йогурт", "Кефир" });
                    break;
                case "Морепродукты":
                    pictureGood.Image = Image.FromFile(Directory.GetCurrentDirectory() + @"\img\seafood.jpg");
                    listOfGoods.Items.AddRange(new string[] { "Моллюски", "Устрицы", "Мидии" });
                    break;
                case "Яйца":
                    pictureGood.Image = Image.FromFile(Directory.GetCurrentDirectory() + @"\img\eggs.jpg");
                    listOfGoods.Items.AddRange(new string[] { "Утиные", "Гусиные", "Индюшачьи" });
                    break;
                case "Овощи":
                    pictureGood.Image = Image.FromFile(Directory.GetCurrentDirectory() + @"\img\vegetables.jpg");
                    listOfGoods.Items.AddRange(new string[] { "Авокадо", "Картофель", "Томат" });
                    break;
                case "Зелень":
                    pictureGood.Image = Image.FromFile(Directory.GetCurrentDirectory() + @"\img\greens.jpg");
                    listOfGoods.Items.AddRange(new string[] { "Укроп", "Петрушка", "Зеленый лук" });
                    break;
                case "Фрукты":
                    pictureGood.Image = Image.FromFile(Directory.GetCurrentDirectory() + @"\img\fruit.jpg");
                    listOfGoods.Items.AddRange(new string[] { "Банан", "Апельсин", "Мандарин" });
                    break;
                case "Ягоды":
                    pictureGood.Image = Image.FromFile(Directory.GetCurrentDirectory() + @"\img\berries.jpg");
                    listOfGoods.Items.AddRange(new string[] { "Малина", "Клюква", "Голубика" });
                    break;
                case "Грибы":
                    pictureGood.Image = Image.FromFile(Directory.GetCurrentDirectory() + @"\img\mushrooms.jpg");
                    listOfGoods.Items.AddRange(new string[] { "Лисички", "Шампиньоны", "Белые грибы" });
                    break;
                case "Орехи":
                    pictureGood.Image = Image.FromFile(Directory.GetCurrentDirectory() + @"\img\nuts.jpg");
                    listOfGoods.Items.AddRange(new string[] { "Фундук", "Грецкие орехи", "Миндаль" });
                    break;
                case "Сладости":
                    pictureGood.Image = Image.FromFile(Directory.GetCurrentDirectory() + @"\img\sweets.jpg");
                    listOfGoods.Items.AddRange(new string[] { "Безе", "Зефир", "Ирис" });
                    break;
                case "Соки":
                    pictureGood.Image = Image.FromFile(Directory.GetCurrentDirectory() + @"\img\juices.jpg");
                    listOfGoods.Items.AddRange(new string[] { "Гранатовый", "Апельсиновый", "Яблочный" });
                    break;
                case "Газировка":
                    pictureGood.Image = Image.FromFile(Directory.GetCurrentDirectory() + @"\img\soda.jpg");
                    listOfGoods.Items.AddRange(new string[] { "Fanta", "Pepsi", "CocaCola" });
                    break;
                case "Фастфуд":
                    pictureGood.Image = Image.FromFile(Directory.GetCurrentDirectory() + @"\img\fast_food.jpg");
                    listOfGoods.Items.AddRange(new string[] { "Картошка Фри", "Хот-дог", "Тако" });
                    break;
                default:
                    pictureGood.Image = Image.FromFile(Directory.GetCurrentDirectory() + @"\img\basket.jpg");
                    listOfGoods.Items.Clear();
                    break;
            }
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listView1.SelectedIndices.Count <= 0)
            {
                return;
            }
            int intselectedindex = listView1.SelectedIndices[0];
            if (intselectedindex >= 0)
            {
                selectedCategory = listView1.Items[intselectedindex].Text;
                chandeListGoods(selectedCategory);
            }
        }

        private void selectPictGood(string nameGood)
        {
            pictureGood.Image = Image.FromFile(Directory.GetCurrentDirectory() + $@"\img\{nameGood}.jpg");
        }
    }
}

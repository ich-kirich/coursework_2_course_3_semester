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

        private string selectedState;
        private string[] productsInBasket;
        private Products listProducts = new Products();
        public MainPage()
        {
            InitializeComponent();
            listOfGoods.SelectedIndexChanged += ListOfGoods_SelectedIndexChanged;
            goodsChoose.SelectedIndexChanged += goodsChoose_SelectedIndexChanged;
            basketList.Items.Clear();
            basketList.Items.AddRange(listProducts.getProductsList());

        }

        private void goodsChoose_SelectedIndexChanged(object sender, EventArgs e)
        {
            selectedState = goodsChoose.SelectedItem.ToString();
            pictureGood.Visible = true;
            toBusket.Visible = true;
            switch (selectedState)
            {
                case "Автоматы":
                    pictureGood.Image = Image.FromFile(System.IO.Directory.GetCurrentDirectory() + @"\img\automatic.jpg");
                    break;
                case "Пистолеты":
                    pictureGood.Image = Image.FromFile(System.IO.Directory.GetCurrentDirectory() + @"\img\pistol.jpg");
                    break;
                case "Винтовки":
                    pictureGood.Image = Image.FromFile(System.IO.Directory.GetCurrentDirectory() + @"\img\rifle.jpg");
                    break;
                case "Пулеметы":
                    pictureGood.Image = Image.FromFile(System.IO.Directory.GetCurrentDirectory() + @"\img\machine-gun.jpg");
                    break;
                case "Гранатометы":
                    pictureGood.Image = Image.FromFile(System.IO.Directory.GetCurrentDirectory() + @"\img\grenade-gun.jpg");
                    break;
                case "Пиротехника":
                    pictureGood.Image = Image.FromFile(System.IO.Directory.GetCurrentDirectory() + @"\img\grenade.jpg");
                    break;
                case "Шары":
                    pictureGood.Image = Image.FromFile(System.IO.Directory.GetCurrentDirectory() + @"\img\balls.jpg");
                    break;
                case "Очки":
                    pictureGood.Image = Image.FromFile(System.IO.Directory.GetCurrentDirectory() + @"\img\glasses.jpg");
                    break;
                case "Аккумуляторы":
                    pictureGood.Image = Image.FromFile(System.IO.Directory.GetCurrentDirectory() + @"\img\accumulator.jpg");
                    break;
                case "Прицелы":
                    pictureGood.Image = Image.FromFile(System.IO.Directory.GetCurrentDirectory() + @"\img\aim.jpg");
                    break;
                case "Магазины":
                    pictureGood.Image = Image.FromFile(System.IO.Directory.GetCurrentDirectory() + @"\img\reservoir.jpg");
                    break;
                case "Пневмапистолеты":
                    pictureGood.Image = Image.FromFile(System.IO.Directory.GetCurrentDirectory() + @"\img\pistol-pnevm.jpg");
                    break;
                case "Пневмавинтовки":
                    pictureGood.Image = Image.FromFile(System.IO.Directory.GetCurrentDirectory() + @"\img\rifle-pnevm.jpg");
                    break;
                case "Ножи":
                    pictureGood.Image = Image.FromFile(System.IO.Directory.GetCurrentDirectory() + @"\img\knife.jpg");
                    break;
                case "Фонарики":
                    pictureGood.Image = Image.FromFile(System.IO.Directory.GetCurrentDirectory() + @"\img\torch.jpg");
                    break;
                default:
                    pictureGood.Image = Image.FromFile(System.IO.Directory.GetCurrentDirectory() + @"\img\error.jpg");
                    break;
            }
        }

        private void MainPage_Load(object sender, EventArgs e)
        {
            productsInBasket = File.ReadAllLines(Directory.GetCurrentDirectory() + @"\files\basket.txt");
            for(int i = 0; i < productsInBasket.Length; i++)
            {
                listProducts.addProduct(productsInBasket[i]);
            }
            basketList.Items.Clear();
            basketList.Items.AddRange(listProducts.getProductsList());
        }

        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {

        }

        private void ListOfGoods_SelectedIndexChanged(object sender, EventArgs e)
        {
            selectedState = listOfGoods.SelectedItem.ToString();
            goodsChoose.Items.Clear();
            pictureGood.Visible = false;
            toBusket.Visible = false;
            switch (selectedState)
            {
                case "Страйкбольное оружие":
                    goodsChoose.Items.AddRange(new string[] { "Автоматы", "Пистолеты", "Винтовки", "Пулеметы", "Гранатометы", "Пиротехника"});
                    break;
                case "Аксессуары для страйкбола":
                    goodsChoose.Items.AddRange(new string[] { "Шары", "Очки", "Аккумуляторы", "Прицелы", "Магазины" });
                    break;
                case "Пневматическое оружие":
                    goodsChoose.Items.AddRange(new string[] { "Пневмапистолеты", "Пневмавинтовки"});
                    break;
                case "Прочее":
                    goodsChoose.Items.AddRange(new string[] { "Ножи", "Фонарики" });
                    break;
                default:
                    goodsChoose.Items.Add("Вы ничего не выбрали");
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

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void toBusket_Click(object sender, EventArgs e)
        {
            basket.Visible = true;
            listProducts.addProduct(selectedState);
            basketList.Items.Clear();
            basketList.Items.AddRange(listProducts.getProductsList());
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

        private void goodsChoose_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }

        private void basketList_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}

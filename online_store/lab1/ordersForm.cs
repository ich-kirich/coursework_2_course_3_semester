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
    public partial class ordersForm : Form
    {
        private string selectedState;
        private string[] massPokypok, curentLogin;
        public ordersForm()
        {
            InitializeComponent();
            massPokypok = File.ReadAllLines(Directory.GetCurrentDirectory() + @"\files\basket.txt");
            listOfPokypok.Items.AddRange(massPokypok);
            listOfPokypok.SelectedIndexChanged += listOfPokypok_SelectedIndexChanged;
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void listOfPokypok_SelectedIndexChanged(object sender, EventArgs e)
        {
            selectedState = listOfPokypok.SelectedItem.ToString();
            switch (selectedState)
            {
                case "Автоматы":
                    picturePokypka.Image = Image.FromFile(System.IO.Directory.GetCurrentDirectory() + @"\img\automatic.jpg");
                    break;
                case "Пистолеты":
                    picturePokypka.Image = Image.FromFile(System.IO.Directory.GetCurrentDirectory() + @"\img\pistol.jpg");
                    break;
                case "Винтовки":
                    picturePokypka.Image = Image.FromFile(System.IO.Directory.GetCurrentDirectory() + @"\img\rifle.jpg");
                    break;
                case "Пулеметы":
                    picturePokypka.Image = Image.FromFile(System.IO.Directory.GetCurrentDirectory() + @"\img\machine-gun.jpg");
                    break;
                case "Гранатометы":
                    picturePokypka.Image = Image.FromFile(System.IO.Directory.GetCurrentDirectory() + @"\img\grenade-gun.jpg");
                    break;
                case "Пиротехника":
                    picturePokypka.Image = Image.FromFile(System.IO.Directory.GetCurrentDirectory() + @"\img\grenade.jpg");
                    break;
                case "Шары":
                    picturePokypka.Image = Image.FromFile(System.IO.Directory.GetCurrentDirectory() + @"\img\balls.jpg");
                    break;
                case "Очки":
                    picturePokypka.Image = Image.FromFile(System.IO.Directory.GetCurrentDirectory() + @"\img\glasses.jpg");
                    break;
                case "Аккумуляторы":
                    picturePokypka.Image = Image.FromFile(System.IO.Directory.GetCurrentDirectory() + @"\img\accumulator.jpg");
                    break;
                case "Прицелы":
                    picturePokypka.Image = Image.FromFile(System.IO.Directory.GetCurrentDirectory() + @"\img\aim.jpg");
                    break;
                case "Магазины":
                    picturePokypka.Image = Image.FromFile(System.IO.Directory.GetCurrentDirectory() + @"\img\reservoir.jpg");
                    break;
                case "Пневмапистолеты":
                    picturePokypka.Image = Image.FromFile(System.IO.Directory.GetCurrentDirectory() + @"\img\pistol-pnevm.jpg");
                    break;
                case "Пневмавинтовки":
                    picturePokypka.Image = Image.FromFile(System.IO.Directory.GetCurrentDirectory() + @"\img\rifle-pnevm.jpg");
                    break;
                case "Ножи":
                    picturePokypka.Image = Image.FromFile(System.IO.Directory.GetCurrentDirectory() + @"\img\knife.jpg");
                    break;
                case "Фонарики":
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

        private void deletePokypky_Click(object sender, EventArgs e)
        {
            massPokypok = massPokypok.Where(val => val != selectedState).ToArray();
            listOfPokypok.Items.Clear();
            listOfPokypok.Items.AddRange(massPokypok);
        }

        private void toMain_Click(object sender, EventArgs e)
        {
            string path = Directory.GetCurrentDirectory() + @"\files\basket.txt";
            if (File.Exists(path))
            {
                File.WriteAllText(path, string.Empty);
                string text = string.Join(" ", massPokypok).Replace(" ", Environment.NewLine);
                File.AppendAllText(path, text);
            }
            this.Hide();
            MainPage toMain = new MainPage();
            toMain.Show();
        }

        private void listOfPokypok_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }

        private void picturePokypka_Click(object sender, EventArgs e)
        {

        }

        private void order_Click(object sender, EventArgs e)
        {
            curentLogin = File.ReadAllLines(Directory.GetCurrentDirectory() + @"\files\localStorage.txt");
            string path = Directory.GetCurrentDirectory() + @"\files\orders.txt";
            if (File.Exists(path))
            {
                string text = curentLogin[0] + " " + string.Join(" ", massPokypok) + "\n";
                File.AppendAllText(path, text);
            }
        }
    }
}

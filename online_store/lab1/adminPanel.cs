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
    public partial class adminPanel : Form
    {
        private string[] massOrders, massLogins;
        private string selectedState, userName, workerName, order;
        public adminPanel()
        {
            InitializeComponent();
            listOrders.SelectedIndexChanged += listOrders_SelectedIndexChanged;
            listWorkers.SelectedIndexChanged += listWorkers_SelectedIndexChanged;
        }

        private string[] addToMass(string itemToAdd, string[] mass)
        {
            mass = new string[] { };
            List<string> list = mass.ToList<string>();
            list.Add(itemToAdd);
            mass = list.ToArray();
            return mass;
        }

        private string listToString(List<string> list)
        {
            string res = "";
            for(int i = 0; i < list.Count; i++)
            {
                res += list[i];
                if (i != list.Count - 1)
                {
                    res += " ";
                }
            }
            return res;
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            string s;
            StreamReader f = new StreamReader(Directory.GetCurrentDirectory() + @"\files\orders.txt");
            while ((s = f.ReadLine()) != null)
            {
                massOrders = s.Split(' ');
                massLogins = addToMass(massOrders[0], massLogins);
                listOrders.Items.AddRange(massLogins);
            }
            f.Close();
            listWorkers.Items.AddRange(new string[] { "Bob", "Steve", "Anna", "Pomchik" });
        }

        private void listOrders_SelectedIndexChanged(object sender, EventArgs e)
        {
            selectedState = listOrders.SelectedItem.ToString();
            userName = selectedState;
            listGoodsOrder.Items.Clear();
            string s;
            StreamReader f = new StreamReader(Directory.GetCurrentDirectory() + @"\files\orders.txt");
            while ((s = f.ReadLine()) != null)
            {
                massOrders = s.Split(' ');
                if(massOrders[0] == selectedState)
                {
                    for (int i = 1; i < massOrders.Length; i++)
                    {
                        listGoodsOrder.Items.Add(massOrders[i]);
                    }
                }
            }
            f.Close();
        }

        private void listGoodsOrder_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void assignOrder_Click(object sender, EventArgs e)
        {
            string path = Directory.GetCurrentDirectory() + @"\files\ordersInProgress.txt";
            if (File.Exists(path))
            {
                List<String> list = listGoodsOrder.Items.Cast<String>().ToList();
                string text = listToString(list);
                order = userName + " " + workerName + " " + text + "\n";
                File.AppendAllText(path, order);
            }
        }

        private void listWorkers_SelectedIndexChanged(object sender, EventArgs e)
        {
            selectedState = listWorkers.SelectedItem.ToString();
            workerName = selectedState;
        }

        protected override void OnFormClosed(FormClosedEventArgs e)
        {
            Environment.Exit(1);
        }
    }
}

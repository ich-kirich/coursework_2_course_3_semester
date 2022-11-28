using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab1
{
    public partial class Profile : Form
    {
        public Profile()
        {
            InitializeComponent();
        }

        private void buttonAddBalance_Click(object sender, EventArgs e)
        {

        }
        protected override void OnFormClosed(FormClosedEventArgs e)
        {
            Environment.Exit(1);
        }
    }
}

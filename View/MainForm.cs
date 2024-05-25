using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LR3
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void Ekaterina_Click(object sender, EventArgs e)
        {
            Ekaterina kate = new Ekaterina();
            kate.Show();
        }

        private void Daria_Click(object sender, EventArgs e)
        {
            Kate2 kate2 = new Kate2();
            kate2.Show();
        }
    }
    
}
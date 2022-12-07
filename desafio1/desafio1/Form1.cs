using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace desafio1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            label1.Text = "A COR É VERDE";
            label1.BackColor = Color.Green;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            label1.Text = "A COR É AMARELA";
            label1.BackColor = Color.Yellow;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            label1.Text = "A COR É VERMELHA";
            label1.BackColor = Color.Red;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace additionneur
{
    public partial class Form1 : Form
    {
        
        public Form1()
        {
            InitializeComponent();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            textBox1.Text += "7 + ";
            resultat += 7;
        }

        private void zero_Click(object sender, EventArgs e)
            
        {   
            textBox1.Text += "0 + ";                
        }

        private void vider_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            resultat = 0;
        }

        private void un_Click(object sender, EventArgs e)
        {
            textBox1.Text += "1 + ";
            resultat += 1;
        }

        private void deux_Click(object sender, EventArgs e)
            
        {
            
            textBox1.Text += "2 + ";
            resultat += 2;
        }
        
        private void trois_Click(object sender, EventArgs e)
        {
            textBox1.Text += "3 + ";
            resultat += 3;
        }

        private void quatre_Click(object sender, EventArgs e)
        {
            textBox1.Text += "4 + ";
            resultat += 4;
        }

        private void cinq_Click(object sender, EventArgs e)
        {
            textBox1.Text += "5 + ";
            resultat += 5;
        }

        private void six_Click(object sender, EventArgs e)
        {
            textBox1.Text += "6 + ";
            resultat += 6;
        }

        private void huit_Click(object sender, EventArgs e)
        {
            textBox1.Text +=  "8 + ";
            resultat += 8;
        }

        private void neuf_Click(object sender, EventArgs e)
        {
            textBox1.Text += "9 + ";
            resultat += 9;
        }
        int resultat = 0;
        private void Calculer_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text+ "=  " +resultat+ "+" ;
        }
    }
}

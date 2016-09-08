using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Le_synthèse
{
    public partial class Form1 : Form
    {
        double t = 0;
        double k;
        double n;
        double resultat = 0;
        double annee;
        public Form1()
        {
            InitializeComponent();
        }

        private void hScrollBar1_Scroll(object sender, ScrollEventArgs e)
        {
            label4.Text = Convert.ToString(hScrollBar1.Value);
            if (Convert.ToString(listBox1.SelectedItem) == "Mensuelle")
            {
                label6.Text = Convert.ToString(hScrollBar1.Value );
                hScrollBar1.LargeChange = 1;
                hScrollBar1.SmallChange = 1;
               
            }

            if (Convert.ToString(listBox1.SelectedItem) == "Bimestrielle")
            {
                label6.Text = Convert.ToString(hScrollBar1.Value / 2);
                hScrollBar1.LargeChange = 2;
                hScrollBar1.SmallChange = 2;
                
            }

            if (Convert.ToString(listBox1.SelectedItem) == "Trimestrielle")
            {
                label6.Text = Convert.ToString(hScrollBar1.Value / 3);
                hScrollBar1.LargeChange = 3;
                hScrollBar1.SmallChange = 3;
               

            }

            if (Convert.ToString(listBox1.SelectedItem) == "Semestrielle")
            {
                label6.Text = Convert.ToString(hScrollBar1.Value / 6);
                hScrollBar1.LargeChange = 6;
                hScrollBar1.SmallChange = 6;
               

            }

            if (Convert.ToString(listBox1.SelectedItem) == "Annuelle")
            {
                label6.Text = Convert.ToString(hScrollBar1.Value / 12);
                hScrollBar1.LargeChange = 12;
                hScrollBar1.SmallChange = 12;
                
            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (Convert.ToString(listBox1.SelectedItem) == "Mensuelle")
            {
                label6.Text = Convert.ToString(hScrollBar1.Value);
                hScrollBar1.LargeChange = 1;
                hScrollBar1.SmallChange = 1;
                annee = 12;
            }

            if (Convert.ToString(listBox1.SelectedItem) == "Bimestrielle")
            {
                label6.Text = Convert.ToString(hScrollBar1.Value / 2);
                hScrollBar1.LargeChange = 2;
                hScrollBar1.SmallChange = 2;
                annee = 6;

            }

            if (Convert.ToString(listBox1.SelectedItem) == "Trimestrielle")
            {
                label6.Text = Convert.ToString(hScrollBar1.Value / 3);
                hScrollBar1.LargeChange = 3;
                hScrollBar1.SmallChange = 3;
                annee = 4;

            }

            if (Convert.ToString(listBox1.SelectedItem) == "Semestrielle")
            {
                label6.Text = Convert.ToString(hScrollBar1.Value / 6);
                hScrollBar1.LargeChange = 6;
                hScrollBar1.SmallChange = 6;
                annee = 2;
            }

            if (Convert.ToString(listBox1.SelectedItem) == "Annuelle")
            {
                label6.Text = Convert.ToString(hScrollBar1.Value / 12);
                hScrollBar1.LargeChange = 12;
                hScrollBar1.SmallChange = 12;
                annee = 1;
            }


        }

        private void button1_Click(object sender, EventArgs e)

        {
            double une;

            n = Convert.ToInt32(label6.Text);
            une = t / annee;
            resultat = k * (une / (1 - Math.Pow(1 + une, -n)));
            resultat = Math.Round(resultat * 100) / 100;
            label8.Text = Convert.ToString(resultat)+" €";
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            
            if (radioButton1.Checked)
            {
                t = 0.07;
            }
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            
            if (radioButton2.Checked)
            {
                t = 0.08;
            }
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
           
            if (radioButton3.Checked)
            {
                t = 0.09;
            }
        }

        private void capitalemp_TextChanged_1(object sender, EventArgs e)
        {
            if (capitalemp.TextLength > 0)
            {
                k = Convert.ToInt32(capitalemp.Text);
            }
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            radioButton1.Select();
            listBox1.SelectedIndex = 0;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            hScrollBar1.Value = 0;
            textBox1.Clear();
            capitalemp.Clear();
            label4.Text = "0";
            listBox1.SelectedIndex = 0;
            label8.Text = "0";
        }
    }
}

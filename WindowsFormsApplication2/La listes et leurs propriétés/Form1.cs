using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace La_listes_et_leurs_propriétés
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void AjoutListe_Click(object sender, EventArgs e)
        {

            
            if (textBox1.Text != "")
            {
                Liste.Items.Add(textBox1.Text);
                textBox1.Text = string.Empty;
            }

              ItemsCountR.Text = Convert.ToString(Liste.Items.Count);


        }

        private void Liste_SelectedIndexChanged(object sender, EventArgs e)
        {
            SelectedIndexR.Text = Convert.ToString(Liste.SelectedIndex);
            TextR.Text = Liste.Text;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Liste.Items.Clear();
            ItemsCountR.Clear();
            SelectedIndexR.Clear();
            index.Text = string.Empty;
            TextR.Clear();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                Liste.SelectedIndex = Convert.ToInt32(index.Text);
            }
            catch (Exception Ex)
            {
                Console.WriteLine("test2");
            }
      
        }

        private void SelectedIndexR_TextChanged(object sender, EventArgs e)
        {

        }

        private void index_TextChanged(object sender, EventArgs e)
        {
          
        }
    }
}

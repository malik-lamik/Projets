using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Les_Listes
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
              
        }

        private void aller_Click(object sender, EventArgs e)
        {
            liste.Items.Add(pays.Text);
            pays.Items.Remove(pays.Text);
        }

        private void tousaller_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < pays.Items.Count; i++)
            {
                liste.Items.Add(pays.Items[i]);

            }
            pays.Items.Clear();
        }

        private void retour_Click(object sender, EventArgs e)
        {
            pays.Items.Add(liste.Text);
            liste.Items.Remove(liste.Text);
        }

        private void retourtous_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < liste.Items.Count; i++)
            {
                pays.Items.Add(liste.Items[i]);

            }
            liste.Items.Clear();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int i = liste.SelectedIndex;

            if (i > 0)
            {
                string tpm = Convert.ToString(liste.Items[i - 1]);
                liste.Items[i - 1] = liste.Items[i];
                liste.Items[i] = tpm;
                liste.SelectedIndex--;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int i = liste.SelectedIndex;

            if (i > 0)
            {
                string tpm = Convert.ToString(liste.Items[i + 1]);
                liste.Items[i + 1] = liste.Items[i];
                liste.Items[i] = tpm;
                liste.SelectedIndex++;
            }
        }
    }
}

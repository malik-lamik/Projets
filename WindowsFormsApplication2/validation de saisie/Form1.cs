using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace validation_de_saisie
{
    public partial class Form1 : Form
    {
        

        public object MessageBoxImage { get; private set; }

        public Form1()
        {
            InitializeComponent();
        }

        

        private void button1_Click(object sender, EventArgs e)
        {
            if (date.BackColor == Color.Green && cp.BackColor == Color.Green && nom.BackColor==Color.Green && montant.BackColor == Color.Green )
            {
                string nom1 = nom.Text;
                MessageBox.Show(" Nom :" + nom.Text + "\n Date :" + date.Text + " \n Montant :" + montant.Text + " \n Code Postal :" + cp.Text);
            }
            else
            {
                
            }
            
            
        }
      
        private void date_Leave(object sender, EventArgs e)
        {
            
            Regex re = new Regex(@"^[0-9]{2}/[0-9]{2}/[0-9]{2,4}");
            //re = Convert.ToDateTime();
                

            if (re.IsMatch(date.Text) == false)
            {
                date.BackColor = Color.Red;
            }
            else
            {
                DateTime date_test;

                if (DateTime.TryParse(date.Text, out date_test))
                {
                    if (date_test > DateTime.Now)
                    {
                        date.BackColor = Color.Green;
                    }
                    else
                    {
                        date.BackColor = Color.Red;
                    }
                    
                }
                else
                {
                    date.BackColor = Color.Red;
                }

                
            }
        }

        private void cp_Leave(object sender, EventArgs e)
        {
            Regex re = new Regex(@"^[0-9]{5}$");
            if (re.IsMatch(cp.Text) == false)
            {
                cp.BackColor = Color.Red;
            }
            else
            {
                cp.BackColor = Color.Green;
            }
        }

        private void nom_Leave(object sender, EventArgs e)
        {
            Regex re = new Regex(@"^[A-Za-z]+(([- ][A-Za-z])?[A-Za-z]){1,30}$");
            if (re.IsMatch(nom.Text) == false)
            {
                
                nom.BackColor = Color.Red;
            }
            else
            {
                nom.BackColor = Color.Green;
            }
        }

        private void montant_TextChanged(object sender, EventArgs e)
        {
        }

        private void montant_Leave(object sender, EventArgs e)
        {
            Regex re = new Regex(@"^[0-9]+.[0-9]{2}$");
            if (re.IsMatch(montant.Text) == false)
            {
            
                montant.BackColor = Color.Red;
            }
            else
            {
                montant.BackColor = Color.Green;
            }
        }

        

        private void button2_Click(object sender, EventArgs e)
        {
            nom.Clear();
            date.Clear();
            montant.Clear();
            cp.Clear();
            nom.BackColor = Color.White;
            date.BackColor = Color.White;
            cp.BackColor = Color.White;            
            montant.BackColor = Color.White;

        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult fermer = MessageBox.Show("Fin de l’application ?", "FIN", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);

            if (fermer == DialogResult.Yes)
            {
                
            }
            else
            {
                e.Cancel = true;
            }
        }

        private void nom_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Check_et_RadioButton
{
    public partial class minuscule : Form
    {
        public minuscule()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            label2.Text = textBox1.Text;
            if (textBox1.Text == "")
            {
                Choix.Enabled = false;
                couleurfond.Checked = false;
                couleurcaractere.Checked = false;
                cassecasse.Checked = false;
            }

            else
            {
                Choix.Enabled = true;

            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (couleurfond.Checked == true)
            {
                fond.Visible = true;
            }
            else
            {
                fond.Visible = false;
                label2.BackColor = SystemColors.Control ;

            }
        }
        private void rougec_CheckedChanged(object sender, EventArgs e)
        {
            if (rougec.Checked == true)
            {
                label2.ForeColor = Color.Red;
            }
            else
            {
                label2.ForeColor = Color.Black;
            }
        }

        private void rougef_CheckedChanged(object sender, EventArgs e)
        {
            if (rougef.Checked == true)
            {
                label2.BackColor = Color.Red;
            }
            
        }

        private void Choix_Enter(object sender, EventArgs e)
        {
            
        }

        private void vertf_CheckedChanged(object sender, EventArgs e)
        {
            if (vertf.Checked == true)
            {
                label2.BackColor = Color.Green;
            }
           
        }
        private void bleuf_CheckedChanged(object sender, EventArgs e)
        {
            if (bleuf.Checked == true)
            {
                label2.BackColor = Color.Blue;
            }
            
        }
        private void couleurcaractere_CheckedChanged(object sender, EventArgs e)
        {
            if (couleurcaractere.Checked == true)
            {
                caractere.Visible = true;
            }
            else
            {
                caractere.Visible = false;
                label2.ForeColor = Color.Black;
            }
        }

        private void blancc_CheckedChanged(object sender, EventArgs e)
        {
            if (blancc.Checked == true)
            {
                label2.ForeColor = Color.White;
            }
            else
            {
                label2.ForeColor = Color.Black;
            }
        }

        private void noirc_CheckedChanged(object sender, EventArgs e)
        {
            if (noirc.Checked == true)
            {
                label2.ForeColor = Color.Black;
            }
            else
            {
                label2.ForeColor = Color.Black;
            }
        }

        private void cassecasse_CheckedChanged(object sender, EventArgs e)
        {
            if (cassecasse.Checked == true)
            {
                casse.Visible = true;
            }
            else
            {
                casse.Visible = false;

            }
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton1.Checked == true)
            {
                label2.Text = label2.Text.ToLower();
            }

        }

        private void majuscule_CheckedChanged(object sender, EventArgs e)
        {
            if (majuscule.Checked == true)
            {
                label2.Text = label2.Text.ToUpper();
            }
        }

        private void fond_Enter(object sender, EventArgs e)
        {

        }
    }
}

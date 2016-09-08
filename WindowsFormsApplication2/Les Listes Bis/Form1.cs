using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Les_Listes_Bis
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            {
                button1.Enabled = false;
            }
            listBox1.Items.Add(comboBox1.Text);
            comboBox1.Items.Remove(comboBox1.Text);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (comboBox1.Text == listBox1.Text)
            {
                button1.Enabled = false;
                button2.Enabled = false;               
                button4.Enabled = true;
                button5.Enabled = true;
                button6.Enabled = true;
            }

            for (int i = 0; i < comboBox1.Items.Count; i++)
            {
                listBox1.Items.Add(comboBox1.Items[i]);
            }
            comboBox1.Items.Clear();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            comboBox1.Items.Add(listBox1.Text);
            listBox1.Items.Remove(listBox1.Text);
            button3.Enabled = false;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < listBox1.Items.Count; i++)
            {
                comboBox1.Items.Add(listBox1.Items[i]);
            }
            listBox1.Items.Clear();
            if (comboBox1.Text == listBox1.Text)
            {
                button1.Enabled = true;
                button2.Enabled = true;
                button3.Enabled = false;
                button4.Enabled = false;
                button5.Enabled = false;
                button6.Enabled = false;
            }
        }
    


private void button5_Click(object sender, EventArgs e)
{

    int i = listBox1.SelectedIndex;

    if (i > 0)
    {
        string tpm = Convert.ToString(listBox1.Items[i - 1]);
        listBox1.Items[i - 1] = listBox1.Items[i];
        listBox1.Items[i] = tpm;
        listBox1.SelectedIndex--;
    }
            
}

private void button6_Click(object sender, EventArgs e)
{
    try
    {
        int i = listBox1.SelectedIndex;

        if (i > -1)
        {
            string tpm = Convert.ToString(listBox1.Items[i + 1]);
            listBox1.Items[i + 1] = listBox1.Items[i];
            listBox1.Items[i] = tpm;
            listBox1.SelectedIndex++;
        }
    }
    catch (Exception text)
    {
        Console.WriteLine("test");
    }



}

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex == 0)
            {
                button5.Enabled = false;
               
            }
            else
            {
                button5.Enabled = true;
                
            }

            if (listBox1.SelectedIndex == listBox1.Items.Count -1)
            {
                button6.Enabled = false;
            }
            else
            {
                button6.Enabled = true;
            }

            if (listBox1.Items.Count <= 0)
            {
                
                button4.Enabled = false;
                button1.Enabled = true;
                button2.Enabled = true;
                button5.Enabled = false;
                button6.Enabled = false;
            }
            button3.Enabled = true;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            {
                button1.Enabled = true;
            }
        }
    }   
}

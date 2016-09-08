using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Defilement
{
    public partial class Defilement : Form
    {
        public Defilement()
        {
            InitializeComponent();
        }

        private void hScrollBar1_Scroll(object sender, ScrollEventArgs e)
        {
            label7.BackColor = Color.FromArgb(hScrollBar1.Value, hScrollBar2.Value, hScrollBar3.Value);
            numericUpDown1.Value = hScrollBar1.Value;
            
        }

        private void hScrollBar2_Scroll(object sender, ScrollEventArgs e)
        {
            label7.BackColor = Color.FromArgb(hScrollBar1.Value, hScrollBar2.Value, hScrollBar3.Value);
            numericUpDown2.Value = hScrollBar2.Value;
        }

        private void hScrollBar3_Scroll(object sender, ScrollEventArgs e)
        {
            label7.BackColor = Color.FromArgb(hScrollBar1.Value, hScrollBar2.Value, hScrollBar3.Value);
            numericUpDown3.Value = hScrollBar3.Value;
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
          hScrollBar1.Value = (int)numericUpDown1.Value;
            label7.BackColor = Color.FromArgb(hScrollBar1.Value, hScrollBar2.Value, hScrollBar3.Value);
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void numericUpDown2_ValueChanged(object sender, EventArgs e)
        {
            hScrollBar2.Value = (int)numericUpDown2.Value;
            label7.BackColor = Color.FromArgb(hScrollBar1.Value, hScrollBar2.Value, hScrollBar3.Value);
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void numericUpDown3_ValueChanged(object sender, EventArgs e)
        {
            hScrollBar3.Value = (int)numericUpDown3.Value;
            label7.BackColor = Color.FromArgb(hScrollBar1.Value, hScrollBar2.Value, hScrollBar3.Value);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            label7.BackColor = Color.FromArgb(hScrollBar1.Value, hScrollBar2.Value, hScrollBar3.Value);
        }
    }
}

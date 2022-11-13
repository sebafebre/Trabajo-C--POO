using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Trabajo_Practico.Forms
{
    public partial class FormMemoriaRAM : Form
    {
        public FormMemoriaRAM()
        {
            InitializeComponent();
        }

        private void labelCeleron_MouseMove(object sender, MouseEventArgs e)
        {
            label1.ForeColor = Color.FromArgb(0, 117, 214);
        }

        private void labelCeleron_MouseLeave(object sender, EventArgs e)
        {
            label1.ForeColor = SystemColors.ControlText;
        }

        private void labelPentium_MouseMove(object sender, MouseEventArgs e)
        {
            label2.ForeColor = Color.FromArgb(0, 117, 214);
        }

        private void labelPentium_MouseLeave(object sender, EventArgs e)
        {
            label2.ForeColor = SystemColors.ControlText;
        }

        private void labelI3_MouseMove(object sender, MouseEventArgs e)
        {
            label3.ForeColor = Color.FromArgb(0, 117, 214);
        }

        private void labelI3_MouseLeave(object sender, EventArgs e)
        {
            label3.ForeColor = SystemColors.ControlText;
        }

        private void labelI7_MouseMove(object sender, MouseEventArgs e)
        {
            label4.ForeColor = Color.FromArgb(0, 117, 214);
        }

        private void labelI7_MouseLeave(object sender, EventArgs e)
        {
            label4.ForeColor = SystemColors.ControlText;
        }

        private void labelI9_MouseMove(object sender, MouseEventArgs e)
        {
            label5.ForeColor = Color.FromArgb(0, 117, 214);
        }

        private void labelI9_MouseLeave(object sender, EventArgs e)
        {
            label5.ForeColor = SystemColors.ControlText;
        }

        private void labelI5_MouseMove(object sender, MouseEventArgs e)
        {
            label6.ForeColor = Color.FromArgb(0, 117, 214);
        }

        private void labelI5_MouseLeave(object sender, EventArgs e)
        {
            label6.ForeColor = SystemColors.ControlText;
        }

        private void label1_Click(object sender, EventArgs e)
        {
            Store.seleccionMemoriaDouble = 7755.00;
            Store.seleccionMemoriaString = "Memoria Corsair LPX 8GB DDR4 3200Mhz";
        }

        private void label2_Click(object sender, EventArgs e)
        {
            Store.seleccionMemoriaDouble = 18975.00;
            Store.seleccionMemoriaString = "Memoria Corsair Pro SL 16GB 3200mhz";
        }

        private void label3_Click(object sender, EventArgs e)
        {
            Store.seleccionMemoriaDouble = 36300.00;
            Store.seleccionMemoriaString = "Memoria Corsair TUF RGB 32GB 3200mhz";
        }

        private void label4_Click(object sender, EventArgs e)
        {
            Store.seleccionMemoriaDouble = 16170.00;
            Store.seleccionMemoriaString = "Crucial Ballistix 8GB DDR5 5200Mhz";
        }

        private void label5_Click(object sender, EventArgs e)
        {
            Store.seleccionMemoriaDouble = 28875.00;
            Store.seleccionMemoriaString = "Memoria XPG Lancer RGB 16GB DDR5 5200Mhz";
        }

        private void label6_Click(object sender, EventArgs e)
        {
            Store.seleccionMemoriaDouble = 52800.00;
            Store.seleccionMemoriaString = "Memoria Corsair Dominator 32GB 5200Mhz";
        }

        //PictureBox

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Store.seleccionMemoriaDouble = 7755.00;
            Store.seleccionMemoriaString = "Memoria Corsair LPX 8GB DDR4 3200Mhz";
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Store.seleccionMemoriaDouble = 18975.00;
            Store.seleccionMemoriaString = "Memoria Corsair Pro SL 16GB 3200mhz";
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            Store.seleccionMemoriaDouble = 36300.00;
            Store.seleccionMemoriaString = "Memoria Corsair TUF RGB 32GB 3200mhz";
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            Store.seleccionMemoriaDouble = 16170.00;
            Store.seleccionMemoriaString = "Crucial Ballistix 8GB DDR5 5200Mhz";
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            Store.seleccionMemoriaDouble = 28875.00;
            Store.seleccionMemoriaString = "Memoria XPG Lancer RGB 16GB DDR5 5200Mhz";
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            Store.seleccionMemoriaDouble = 52800.00;
            Store.seleccionMemoriaString = "Memoria Corsair Dominator 32GB 5200Mhz";
        }

        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            label1.ForeColor = Color.FromArgb(0, 117, 214);
        }

        private void pictureBox1_MouseLeave(object sender, EventArgs e)
        {
            label1.ForeColor = SystemColors.ControlText;
        }

        private void pictureBox2_MouseMove(object sender, MouseEventArgs e)
        {
            label2.ForeColor = Color.FromArgb(0, 117, 214);
        }

        private void pictureBox2_MouseLeave(object sender, EventArgs e)
        {
            label2.ForeColor = SystemColors.ControlText;
        }

        private void pictureBox3_MouseMove(object sender, MouseEventArgs e)
        {
            label3.ForeColor = Color.FromArgb(0, 117, 214);
        }

        private void pictureBox3_MouseLeave(object sender, EventArgs e)
        {
            label3.ForeColor = SystemColors.ControlText;
        }

        private void pictureBox4_MouseMove(object sender, MouseEventArgs e)
        {
            label4.ForeColor = Color.FromArgb(0, 117, 214);
        }

        private void pictureBox4_MouseLeave(object sender, EventArgs e)
        {
            label4.ForeColor = SystemColors.ControlText;
        }

        private void pictureBox5_MouseMove(object sender, MouseEventArgs e)
        {
            label5.ForeColor = Color.FromArgb(0, 117, 214);
        }

        private void pictureBox5_MouseLeave(object sender, EventArgs e)
        {
            label5.ForeColor = SystemColors.ControlText;
        }

        private void pictureBox6_MouseMove(object sender, MouseEventArgs e)
        {
            label6.ForeColor = Color.FromArgb(0, 117, 214);
        }

        private void pictureBox6_MouseLeave(object sender, EventArgs e)
        {
            label6.ForeColor = SystemColors.ControlText;
        }
    }
}

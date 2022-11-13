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
    public partial class FormGabinete : Form
    {
        public FormGabinete()
        {
            InitializeComponent();
        }

        //Mouse Move y Leave --> Cambia de color las letras al tener el mouse arriba
        private void label1_MouseMove(object sender, MouseEventArgs e)
        {
            label1.ForeColor = Color.FromArgb(0, 117, 214);
        }

        private void label1_MouseLeave(object sender, EventArgs e)
        {
            label1.ForeColor = SystemColors.ControlText;
        }

        private void label2_MouseMove(object sender, MouseEventArgs e)
        {
            label2.ForeColor = Color.FromArgb(0, 117, 214);
        }

        private void label2_MouseLeave(object sender, EventArgs e)
        {
            label2.ForeColor = SystemColors.ControlText;
        }

        private void label3_MouseMove(object sender, MouseEventArgs e)
        {
            label3.ForeColor = Color.FromArgb(0, 117, 214);
        }

        private void label3_MouseLeave(object sender, EventArgs e)
        {
            label3.ForeColor = SystemColors.ControlText;
        }

        private void label1_Click(object sender, EventArgs e)
        {
            Store.seleccionGabineteDouble = 21450.00;
            Store.seleccionGabineteString = "Gabinete Phanteks P200A DRGB ITX";
        }

        private void label2_Click(object sender, EventArgs e)
        {
            Store.seleccionGabineteDouble = 31350.00;
            Store.seleccionGabineteString = "Gabinete DeepCool Matrexx 70 RGB 3F";
        }

        private void label3_Click(object sender, EventArgs e)
        {
            Store.seleccionGabineteDouble = 69960.001;
            Store.seleccionGabineteString = "Gabinete Corsair iCUE 7000X RGB Black";
        }

        //PictureBox

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Store.seleccionGabineteDouble = 21450.00;
            Store.seleccionGabineteString = "Gabinete Phanteks P200A DRGB ITX";
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Store.seleccionGabineteDouble = 31350.00;
            Store.seleccionGabineteString = "Gabinete DeepCool Matrexx 70 RGB 3F";
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            Store.seleccionGabineteDouble = 69960.001;
            Store.seleccionGabineteString = "Gabinete Corsair iCUE 7000X RGB Black";
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
    }
}

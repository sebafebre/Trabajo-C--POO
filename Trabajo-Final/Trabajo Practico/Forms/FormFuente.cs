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
    public partial class FormFuente : Form
    {
        public FormFuente()
        {
            InitializeComponent();
        }

        //Mouse Move and Leave cambio de color
        private void label3_MouseMove(object sender, MouseEventArgs e)
        {
            //Cambia de color a celeste
            label3.ForeColor = Color.FromArgb(0, 117, 214);
        }

        private void label3_MouseLeave(object sender, EventArgs e)
        {
            //Vuelve a negro
            label3.ForeColor = SystemColors.ControlText;
        }

        private void label2_MouseMove(object sender, MouseEventArgs e)
        {
            label2.ForeColor = Color.FromArgb(0, 117, 214);
        }

        private void label2_MouseLeave(object sender, EventArgs e)
        {
            label2.ForeColor = SystemColors.ControlText;
        }

        private void label1_MouseMove(object sender, MouseEventArgs e)
        {
            label1.ForeColor = Color.FromArgb(0, 117, 214);
        }

        private void label1_MouseLeave(object sender, EventArgs e)
        {
            label1.ForeColor = SystemColors.ControlText;
        }

        //Pasar Variables
        private void label1_Click(object sender, EventArgs e)
        {
            Store.seleccionFuenteDouble = 29700.00;
            Store.seleccionFuenteString = "Fuente Corsair RM850X White 80+Gold";
        }

        private void label2_Click(object sender, EventArgs e)
        {
            Store.seleccionFuenteDouble = 57750.00;
            Store.seleccionFuenteString = "Fuente Corsair HX1000 80+ Platinum";
        }

        private void label3_Click(object sender, EventArgs e)
        {
            Store.seleccionFuenteDouble = 90750.00;
            Store.seleccionFuenteString = "Fuente Gigabyte Aorus P1200W LCD 80+Plat.";
        }

        //PictureBox
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Store.seleccionFuenteDouble = 29700.00;
            Store.seleccionFuenteString = "Fuente Corsair RM850X White 80+Gold";
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Store.seleccionFuenteDouble = 57750.00;
            Store.seleccionFuenteString = "Fuente Corsair HX1000 80+ Platinum";
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            Store.seleccionFuenteDouble = 90750.00;
            Store.seleccionFuenteString = "Fuente Gigabyte Aorus P1200W LCD 80+Plat.";
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

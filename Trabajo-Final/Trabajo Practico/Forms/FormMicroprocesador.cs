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
    public partial class FormMicroprocesador : Form
    {
        //Variable Global
        Store frm = new Store();

        public FormMicroprocesador()
        {
            InitializeComponent();
        }

        //Agregar evento right click y despliegue un menu con detalles, copiar los que aparecen en Hardcore al principio
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Store.seleccionMicroprocesadorDouble = 135300.00;
            Store.seleccionMicroprocesadorString = "Micro Intel Core i9 12900K LGA1700";
        }

        private void label12_MouseUp(object sender, MouseEventArgs e)
        {
            //Creado por error
        }

        //Cambiar color al poner el mouse encima
        private void labelCeleron_MouseMove(object sender, MouseEventArgs e)
        {
            labelCeleron.ForeColor = Color.FromArgb(0, 117, 214);
        }

        private void labelCeleron_MouseLeave(object sender, EventArgs e)
        {
            labelCeleron.ForeColor = SystemColors.ControlText;
        }

        private void label10_MouseMove(object sender, MouseEventArgs e)
        {
            labelPentium.ForeColor = Color.FromArgb(0, 117, 214);
        }

        private void label10_MouseLeave(object sender, EventArgs e)
        {
            labelPentium.ForeColor = SystemColors.ControlText;
        }

        private void labelI3_MouseMove(object sender, MouseEventArgs e)
        {
            labelI3.ForeColor = Color.FromArgb(0, 117, 214);
        }

        private void labelI3_MouseLeave(object sender, EventArgs e)
        {
            labelI3.ForeColor = SystemColors.ControlText;
        }

        private void labeli5_MouseMove(object sender, MouseEventArgs e)
        {
            labelI5.ForeColor = Color.FromArgb(0, 117, 214);
        }

        private void labeli5_MouseLeave(object sender, EventArgs e)
        {
            labelI5.ForeColor = SystemColors.ControlText;
        }

        private void labelI7_MouseMove(object sender, MouseEventArgs e)
        {
            labelI7.ForeColor = Color.FromArgb(0, 117, 214);
        }

        private void labelI7_MouseLeave(object sender, EventArgs e)
        {
            labelI7.ForeColor = SystemColors.ControlText;
        }

        private void labeli9_MouseMove(object sender, MouseEventArgs e)
        {
            labelI9.ForeColor = Color.FromArgb(0, 117, 214);
        }

        private void labeli9_MouseLeave(object sender, EventArgs e)
        {
            labelI9.ForeColor = SystemColors.ControlText;
        }

        private void labelR5_MouseMove(object sender, MouseEventArgs e)
        {
            labelR5.ForeColor = Color.FromArgb(0, 117, 214);
        }

        private void labelR5_MouseLeave(object sender, EventArgs e)
        {
            labelR5.ForeColor = SystemColors.ControlText;
        }

        private void labelR7_MouseMove(object sender, MouseEventArgs e)
        {
            labelR7.ForeColor = Color.FromArgb(0, 117, 214);
        }

        private void labelR7_MouseLeave(object sender, EventArgs e)
        {
            labelR7.ForeColor = SystemColors.ControlText;
        }

        private void labelR9_MouseMove(object sender, MouseEventArgs e)
        {
            labelR9.ForeColor = Color.FromArgb(0, 117, 214);
        }

        private void labelR9_MouseLeave(object sender, EventArgs e)
        {
            labelR9.ForeColor = SystemColors.ControlText;
        }

        //Pasar valores

        private void labelCeleron_Click(object sender, EventArgs e)
        {
            Store.seleccionMicroprocesadorDouble = 11880.00;
            Store.seleccionMicroprocesadorString = "Micro Intel Celeron G6900 LGA1700";
        }

        private void labelPentium_Click(object sender, EventArgs e)
        {
            Store.seleccionMicroprocesadorDouble = 16500.00;
            Store.seleccionMicroprocesadorString = "Micro Intel Pentium G7400 LGA1700";
        }

        private void labelI3_Click(object sender, EventArgs e)
        {
            Store.seleccionMicroprocesadorDouble = 31350.00;
            Store.seleccionMicroprocesadorString = "Micro Intel Core i3 12100 LGA1700";
        }

        private void labelI5_Click(object sender, EventArgs e)
        {
            Store.seleccionMicroprocesadorDouble = 66000.00;
            Store.seleccionMicroprocesadorString = "Micro Intel Core i5 12600K LGA1700";
        }

        private void labelI7_Click(object sender, EventArgs e)
        {
            Store.seleccionMicroprocesadorDouble = 94875.00;
            Store.seleccionMicroprocesadorString = "Micro Intel Core i7 12700K LGA1700";
        }

        private void labelI9_Click(object sender, EventArgs e)
        {
            Store.seleccionMicroprocesadorDouble = 135300.00;
            Store.seleccionMicroprocesadorString = "Micro Intel Core i9 12900K LGA1700";
        }

        private void labelR5_Click(object sender, EventArgs e)
        {
            Store.seleccionMicroprocesadorDouble = 44550.00;
            Store.seleccionMicroprocesadorString = "Micro Amd Ryzen 5 5600G Vega 7 AM4";
        }

        private void labelR7_Click(object sender, EventArgs e)
        {
            Store.seleccionMicroprocesadorDouble = 89100.00;
            Store.seleccionMicroprocesadorString = "Micro AMD Ryzen 7 5800X3D AM4";
        }

        private void labelR9_Click(object sender, EventArgs e)
        {
            Store.seleccionMicroprocesadorDouble = 99000.00;
            Store.seleccionMicroprocesadorString = "Micro AMD Ryzen 9 5900X AM4";
        }

        private void pictureBox6_MouseMove(object sender, MouseEventArgs e)
        {
            labelCeleron.ForeColor = Color.FromArgb(0, 117, 214);
        }

        private void pictureBox6_MouseLeave(object sender, EventArgs e)
        {
            labelCeleron.ForeColor = SystemColors.ControlText;
        }

        private void pictureBox5_MouseMove(object sender, MouseEventArgs e)
        {
            labelPentium.ForeColor = Color.FromArgb(0, 117, 214);
        }

        private void pictureBox5_MouseLeave(object sender, EventArgs e)
        {
            labelPentium.ForeColor = SystemColors.ControlText;
        }

        private void pictureBox4_MouseMove(object sender, MouseEventArgs e)
        {
            labelI3.ForeColor = Color.FromArgb(0, 117, 214);
        }

        private void pictureBox4_MouseLeave(object sender, EventArgs e)
        {
            labelI3.ForeColor = SystemColors.ControlText;
        }

        private void pictureBox3_MouseMove(object sender, MouseEventArgs e)
        {
            labelI5.ForeColor = Color.FromArgb(0, 117, 214);
        }

        private void pictureBox3_MouseLeave(object sender, EventArgs e)
        {
            labelI5.ForeColor = SystemColors.ControlText;
        }

        private void pictureBox2_MouseMove(object sender, MouseEventArgs e)
        {
            labelI7.ForeColor = Color.FromArgb(0, 117, 214);
        }

        private void pictureBox2_MouseLeave(object sender, EventArgs e)
        {
            labelI7.ForeColor = SystemColors.ControlText;
        }

        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            labelI9.ForeColor = Color.FromArgb(0, 117, 214);
        }

        private void pictureBox1_MouseLeave(object sender, EventArgs e)
        {
            labelI9.ForeColor = SystemColors.ControlText;
        }

        private void pictureBox7_MouseMove(object sender, MouseEventArgs e)
        {
            labelR5.ForeColor = Color.FromArgb(0, 117, 214);
        }

        private void pictureBox7_MouseLeave(object sender, EventArgs e)
        {
            labelR5.ForeColor = SystemColors.ControlText;
        }

        private void pictureBox8_MouseMove(object sender, MouseEventArgs e)
        {
            labelR7.ForeColor = Color.FromArgb(0, 117, 214);
        }

        private void pictureBox8_MouseLeave(object sender, EventArgs e)
        {
            labelR7.ForeColor = SystemColors.ControlText;
        }

        private void pictureBox9_MouseMove(object sender, MouseEventArgs e)
        {
            labelR9.ForeColor = Color.FromArgb(0, 117, 214);
        }

        private void pictureBox9_MouseLeave(object sender, EventArgs e)
        {
            labelR9.ForeColor = SystemColors.ControlText;
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            Store.seleccionMicroprocesadorDouble = 11880.00;
            Store.seleccionMicroprocesadorString = "Micro Intel Celeron G6900 LGA1700";
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            Store.seleccionMicroprocesadorDouble = 16500.00;
            Store.seleccionMicroprocesadorString = "Micro Intel Pentium G7400 LGA1700";
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            Store.seleccionMicroprocesadorDouble = 31350.00;
            Store.seleccionMicroprocesadorString = "Micro Intel Core i3 12100 LGA1700";
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            Store.seleccionMicroprocesadorDouble = 66000.00;
            Store.seleccionMicroprocesadorString = "Micro Intel Core i5 12600K LGA1700";
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Store.seleccionMicroprocesadorDouble = 94875.00;
            Store.seleccionMicroprocesadorString = "Micro Intel Core i7 12700K LGA1700";
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            Store.seleccionMicroprocesadorDouble = 44550.00;
            Store.seleccionMicroprocesadorString = "Micro Amd Ryzen 5 5600G Vega 7 AM4";
        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {
            Store.seleccionMicroprocesadorDouble = 89100.00;
            Store.seleccionMicroprocesadorString = "Micro AMD Ryzen 7 5800X3D AM4";
        }

        private void pictureBox9_Click(object sender, EventArgs e)
        {
            Store.seleccionMicroprocesadorDouble = 99000.00;
            Store.seleccionMicroprocesadorString = "Micro AMD Ryzen 9 5900X AM4";
        }
    }
}

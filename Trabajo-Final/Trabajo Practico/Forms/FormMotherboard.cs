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
    public partial class FormMotherboard : Form
    {
        public FormMotherboard()
        {
            InitializeComponent();
        }

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

        private void label4_MouseMove(object sender, MouseEventArgs e)
        {
            label4.ForeColor = Color.FromArgb(0, 117, 214);
        }

        private void label4_MouseLeave(object sender, EventArgs e)
        {
            label4.ForeColor = SystemColors.ControlText;
        }

        private void label5_MouseMove(object sender, MouseEventArgs e)
        {
            label5.ForeColor = Color.FromArgb(0, 117, 214);
        }

        private void label5_MouseLeave(object sender, EventArgs e)
        {
            label5.ForeColor = SystemColors.ControlText;
        }

        private void label6_MouseMove(object sender, MouseEventArgs e)
        {
            label6.ForeColor = Color.FromArgb(0, 117, 214);
        }

        private void label6_MouseLeave(object sender, EventArgs e)
        {
            label6.ForeColor = SystemColors.ControlText;
        }

        private void label1_Click(object sender, EventArgs e)
        {
            Store.seleccionMotherboardDouble = 67650.00;
            Store.seleccionMotherboardString = "Mother Asus Prime Z690-A LGA1700";
        }

        private void label2_Click(object sender, EventArgs e)
        {
            Store.seleccionMotherboardDouble = 77550.00;
            Store.seleccionMotherboardString = "Mother Asus TUF Z690-Plus Wifi D4 LGA1700";
        }

        private void label3_Click(object sender, EventArgs e)
        {
            Store.seleccionMotherboardDouble = 97350.00;
            Store.seleccionMotherboardString = "Mother Gigabyte Z690 Aorus Ultra LGA1700";
        }

        private void label4_Click(object sender, EventArgs e)
        {
            Store.seleccionMotherboardDouble = 37125.00;
            Store.seleccionMotherboardString = "Mother Asus Prime X570-P AM4";
        }

        private void label5_Click(object sender, EventArgs e)
        {
            Store.seleccionMotherboardDouble = 39600.00;
            Store.seleccionMotherboardString = "Mother Gigabyte B550 Aorus Elite V2 AM4";
        }

        private void label6_Click(object sender, EventArgs e)
        {
            Store.seleccionMotherboardDouble = 51150.00;
            Store.seleccionMotherboardString = "Mother Gigabyte B550I Aorus Pro AX AM4";
        }

        //PictureBox

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Store.seleccionMotherboardDouble = 67650.00;
            Store.seleccionMotherboardString = "Mother Asus Prime Z690-A LGA1700";
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Store.seleccionMotherboardDouble = 77550.00;
            Store.seleccionMotherboardString = "Mother Asus TUF Z690-Plus Wifi D4 LGA1700";
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            Store.seleccionMotherboardDouble = 97350.00;
            Store.seleccionMotherboardString = "Mother Gigabyte Z690 Aorus Ultra LGA1700";
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            Store.seleccionMotherboardDouble = 37125.00;
            Store.seleccionMotherboardString = "Mother Asus Prime X570-P AM4";
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            Store.seleccionMotherboardDouble = 39600.00;
            Store.seleccionMotherboardString = "Mother Gigabyte B550 Aorus Elite V2 AM4";
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            Store.seleccionMotherboardDouble = 51150.00;
            Store.seleccionMotherboardString = "Mother Gigabyte B550I Aorus Pro AX AM4";
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

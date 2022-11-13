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
    public partial class FormAlmacenamiento : Form
    {
        public FormAlmacenamiento()
        {
            InitializeComponent();
        }

        private void label2_MouseMove(object sender, MouseEventArgs e)
        {
            label1.ForeColor = Color.FromArgb(0, 117, 214);
        }

        private void label2_MouseLeave(object sender, EventArgs e)
        {
            label1.ForeColor = SystemColors.ControlText;
        }

        private void label3_MouseMove(object sender, MouseEventArgs e)
        {
            label2.ForeColor = Color.FromArgb(0, 117, 214);
        }

        private void label3_MouseLeave(object sender, EventArgs e)
        {
            label2.ForeColor = SystemColors.ControlText;
        }

        private void label4_MouseMove(object sender, MouseEventArgs e)
        {
            label3.ForeColor = Color.FromArgb(0, 117, 214);
        }

        private void label4_MouseLeave(object sender, EventArgs e)
        {
            label3.ForeColor = SystemColors.ControlText;
        }

        private void label5_MouseMove(object sender, MouseEventArgs e)
        {
            label4.ForeColor = Color.FromArgb(0, 117, 214);
        }

        private void label5_MouseLeave(object sender, EventArgs e)
        {
            label4.ForeColor = SystemColors.ControlText;
        }

        private void label8_MouseMove(object sender, MouseEventArgs e)
        {
            label5.ForeColor = Color.FromArgb(0, 117, 214);
        }

        private void label8_MouseLeave(object sender, EventArgs e)
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
            Store.seleccionAlmacenamientoDouble = 23100.00;
            Store.seleccionAlmacenamientoString = "Disco Rigido Seagate IronWolf 4TB Nas";
        }

        private void label2_Click(object sender, EventArgs e)
        {
            Store.seleccionAlmacenamientoDouble = 49500.00;
            Store.seleccionAlmacenamientoString = "Disco Rígido Seagate IronWolf 8TB";
        }

        private void label3_Click(object sender, EventArgs e)
        {
            Store.seleccionAlmacenamientoDouble = 114840.00;
            Store.seleccionAlmacenamientoString = "Disco Rígido WD Gold 16TB Enterprise";
        }

        private void label4_Click(object sender, EventArgs e)
        {
            Store.seleccionAlmacenamientoDouble = 18150.00;
            Store.seleccionAlmacenamientoString = "Disco SSD Corsair MP600 500GB M.2.Pcie";
        }

        private void label5_Click(object sender, EventArgs e)
        {
            Store.seleccionAlmacenamientoDouble = 41250.00;
            Store.seleccionAlmacenamientoString = "SSD Crucial P5 Plus 1TB M.2 Pcie x4";
        }

        private void label6_Click(object sender, EventArgs e)
        {
            Store.seleccionAlmacenamientoDouble = 89100.00;
            Store.seleccionAlmacenamientoString = "Disco SSD Aorus 7000S 2TB M.2. Pcie Gen 4";
        }

        //PictureBox

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Store.seleccionAlmacenamientoDouble = 23100.00;
            Store.seleccionAlmacenamientoString = "Disco Rigido Seagate IronWolf 4TB Nas";
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Store.seleccionAlmacenamientoDouble = 49500.00;
            Store.seleccionAlmacenamientoString = "Disco Rígido Seagate IronWolf 8TB";
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            Store.seleccionAlmacenamientoDouble = 114840.00;
            Store.seleccionAlmacenamientoString = "Disco Rígido WD Gold 16TB Enterprise";
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            Store.seleccionAlmacenamientoDouble = 18150.00;
            Store.seleccionAlmacenamientoString = "Disco SSD Corsair MP600 500GB M.2.Pcie";
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            Store.seleccionAlmacenamientoDouble = 41250.00;
            Store.seleccionAlmacenamientoString = "SSD Crucial P5 Plus 1TB M.2 Pcie x4";
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            Store.seleccionAlmacenamientoDouble = 89100.00;
            Store.seleccionAlmacenamientoString = "Disco SSD Aorus 7000S 2TB M.2. Pcie Gen 4";
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

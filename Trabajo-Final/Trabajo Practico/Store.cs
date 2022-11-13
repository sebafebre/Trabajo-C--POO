using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Net.Mail;
using System.Runtime.InteropServices;

namespace Trabajo_Practico
{
    public partial class Store : Form
    {
        //Fields
        private Form activeForm;

        //Variables global
        string sender_auxiliar;
        static public double seleccionMicroprocesadorDouble = 0;
        static public string seleccionMicroprocesadorString = "";
        static public double seleccionMotherboardDouble = 0;
        static public string seleccionMotherboardString = "";
        static public double seleccionMemoriaDouble = 0;
        static public string seleccionMemoriaString = "";
        static public double seleccionPlacaDeVideoDouble = 0;
        static public string seleccionPlacaDeVideoString = "";
        static public double seleccionAlmacenamientoDouble = 0;
        static public string seleccionAlmacenamientoString = "";
        static public double seleccionFuenteDouble = 0;
        static public string seleccionFuenteString = "";
        static public double seleccionGabineteDouble = 0;
        static public string seleccionGabineteString = "";

        //static public double subTotal = seleccionMicroprocesadorDouble + seleccionMotherboardDouble + seleccionMemoriaDouble + seleccionPlacaDeVideoDouble + seleccionAlmacenamientoDouble + seleccionFuenteDouble + seleccionGabineteDouble;
        //static public double impuesto = subTotal * 0.21;
        //static public double total = subTotal + impuesto;

        //Move
        int mov;
        int movX;
        int movY;

        public Store(/*string email_global*/)
        {
            InitializeComponent();
            OpenChildForm(new Forms.FormInicio(), sender_auxiliar); 
        }

        private void Store_Load(object sender, EventArgs e)
        {
            //Utilizar 1 en la PC
            //Utilizar 0 en la NoteBook
            try
            {
                this.Location = Screen.AllScreens[1].WorkingArea.Location;
            }
            catch
            {
                this.Location = Screen.AllScreens[0].WorkingArea.Location;
            }

            //Timer
            timer1.Start();      
        }

        static public KeyPressEventArgs KeyPressSoloNumeros(KeyPressEventArgs e)
        {
            //Solo numeros
            if (Char.IsDigit(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (Char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (Char.IsSeparator(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }

            return e;
        }
   
        public void enviarEmail()
        {
            //Variables
            string email, contrasena;
            email = "email@outlook.com";
            contrasena = "contrasenaEmail";
            string path = @"C:\Users\ramir\Dropbox\Materias\Segundo Año\Primer Cuatrimestre\Programacion Orientada a Objetos\Trabajo Practico\Orden de compra\" + "Orden de compra" + ".txt"; // Establecer nueva ruta

            //Body
            string subject = "Orden de compra";
            string body = "Gracias por su compra";
            int port = 587;
            string host = "smtp.office365.com";

            MailMessage msg = new MailMessage();

            msg.To.Add(Log_In.email_global);
            msg.Subject = subject;
            msg.SubjectEncoding = Encoding.UTF8;
            msg.Body = body;
            msg.BodyEncoding = Encoding.UTF8;
            msg.IsBodyHtml = true;
            msg.Attachments.Add(new Attachment(path));
            msg.From = new MailAddress(email);

            SmtpClient cliente = new SmtpClient();
            cliente.Credentials = new System.Net.NetworkCredential(email, contrasena);
            cliente.Port = port;
            cliente.EnableSsl = true;
            cliente.Host = host;

            try
            {
                cliente.Send(msg);
                //MessageBox.Show("Se envio el email correctamente.", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                DialogResult mensajeEmail = MessageBox.Show("Se envio el email correctamente.", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                if (mensajeEmail == DialogResult.OK)
                {
                    this.Close();
                    Application.Exit();
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Error al enviar");
            }
        }

        public void ordenCompraRegistro()
        {
            string PATHLOG = @"C:\Users\ramir\Dropbox\Materias\Segundo Año\Primer Cuatrimestre\Programacion Orientada a Objetos\Trabajo Practico\Orden de compra"; //Establecer la ruta de la carpeta donde se quiere crear
            string ARCHIVOLOG = "Orden de compra" + ".txt";

            StreamWriter sw;
            string pathCompleto = PATHLOG + @"\" + ARCHIVOLOG;
            var dirInfo = new DirectoryInfo(PATHLOG);
            if (!dirInfo.Exists)
            {
                Directory.CreateDirectory(PATHLOG);
            }
            if (File.Exists(pathCompleto))
            {
                sw = File.AppendText(pathCompleto);
            }
            else
            {
                sw = File.CreateText(pathCompleto);
            }

            sw.WriteLine("¡Orden de compra!");
            sw.WriteLine("Fecha de la compra: " + DateTime.Now.ToString());
            sw.WriteLine("Componentes:");
            sw.WriteLine("Microprocesador: " + labelMicroprocesador.Text);
            sw.WriteLine("Motherboard: " + labelMotherboard.Text);
            sw.WriteLine("Memoria: " + labelMemoria.Text);
            sw.WriteLine("Placa de Video: " + labelPlacaDeVideo.Text);
            sw.WriteLine("Almacenamiento: " + labelAlmacenamiento.Text);
            sw.WriteLine("Fuente: " + labelFuente.Text);
            sw.WriteLine("Gabinete: " + labelGabinete.Text);
            sw.WriteLine("Total: " + labelTotalPrecio.Text);
            sw.WriteLine("¡Esperamos que los disfrute!");
            sw.Close();
        }

        private void OpenChildForm(Form childForm, object btnSender)
        {
            if (activeForm != null)
            {
                activeForm.Close();
            }
                
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            this.panelDesktopPane.Controls.Add(childForm);
            this.panelDesktopPane.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
            //lblTitle.Text = childForm.Text;
        }

        private void panelTitleBar_MouseDown(object sender, MouseEventArgs e)
        {
            mov = 1;
            movX = e.X;
            movY= e.Y;
        }

        private void panelTitleBar_MouseMove(object sender, MouseEventArgs e)
        {
            if (mov == 1)
            {
                this.SetDesktopLocation(MousePosition.X - movX, MousePosition.Y - movY);
            }
        }

        private void panelTitleBar_MouseUp(object sender, MouseEventArgs e)
        {
            mov = 0;
        }

        private void panelTitleBar_MouseDown_1(object sender, MouseEventArgs e)
        {
            mov = 1;
            movX = e.X;
            movY = e.Y;
        }

        private void panelTitleBar_MouseMove_1(object sender, MouseEventArgs e)
        {
            if (mov == 1)
            {
                this.SetDesktopLocation(MousePosition.X - movX, MousePosition.Y - movY);
            }
        }

        private void panelTitleBar_MouseUp_1(object sender, MouseEventArgs e)
        {
            mov = 0;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void buttonSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void buttonVolverAtras_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonMicroprocesador_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.FormMicroprocesador(), sender);
        }

        private void buttonMotherboard_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.FormMotherboard(), sender);
        }

        private void buttonMemoria_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.FormMemoriaRAM(), sender);
        }

        private void buttonPlacaDeVideo_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.FormPlacaDeVideo(), sender);
        }

        private void buttonAlmacenamiento_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.FormAlmacenamiento(), sender);
        }

        private void buttonFuente_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.FormFuente(), sender);
        }

        private void buttonGabinete_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.FormGabinete(), sender);
        }

        private void label11_Click(object sender, EventArgs e)
        {
            //Creado por error
        }

        private void buttonPay_Click(object sender, EventArgs e)
        {
            if (labelMicroprocesador.Text == "")
            {
                MessageBox.Show("Por favor escoga un microprocesador", "Atencion", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (labelMotherboard.Text == "")
            {
                MessageBox.Show("Por favor escoga una motherboard", "Atencion", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            /*else if (labelMicroprocesador.Text == "Micro Intel Celeron G6900 LGA1700" || labelMicroprocesador.Text == "Micro Intel Pentium G7400 LGA1700" || labelMicroprocesador.Text == "Micro Intel Core i3 12100 LGA1700" || labelMicroprocesador.Text == "Micro Intel Core i5 12600K LGA1700" || labelMicroprocesador.Text == "Micro Intel Core i7 12700K LGA1700" || labelMicroprocesador.Text == "Micro Intel Core i9 12900K LGA1700" && labelMotherboard.Text == "Mother Asus Prime X570-P AM4" || labelMotherboard.Text == "Mother Gigabyte B550 Aorus Elite V2 AM4" || labelMotherboard.Text == "Mother Gigabyte B550I Aorus Pro AX AM4")
            {
                MessageBox.Show("El microprocesador y la motherboard seleccionados, no son compatibles", "Atencion", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }*/
            /*else if (labelMicroprocesador.Text == "Micro Amd Ryzen 5 5600G Vega 7 AM4" || labelMicroprocesador.Text == "Micro AMD Ryzen 7 5800X3D AM4" || labelMicroprocesador.Text == "Micro AMD Ryzen 9 5900X AM4" && labelMotherboard.Text == "Mother Asus Prime Z690-A LGA1700" || labelMotherboard.Text == "Mother Asus TUF Z690-Plus Wifi D4 LGA1700" || labelMotherboard.Text == "Mother Gigabyte Z690 Aorus Ultra LGA1700")
            {
                MessageBox.Show("El microprocesador y la motherboard seleccionados, no son compatibles", "Atencion", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }*/
            else if (labelMemoria.Text == "")
            {
                MessageBox.Show("Por favor escoga una memoria", "Atencion", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (labelPlacaDeVideo.Text == "")
            {
                MessageBox.Show("Por favor escoga una placa de video", "Atencion", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (labelAlmacenamiento.Text == "")
            {
                MessageBox.Show("Por favor escoga una unidad de almacenamiento", "Atencion", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (labelFuente.Text == "")
            {
                MessageBox.Show("Por favor escoga una fuente", "Atencion", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (labelGabinete.Text == "")
            {
                MessageBox.Show("Por favor escoga un gabinete", "Atencion", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                DialogResult mensajeCompra = MessageBox.Show("Esta seguro que desea realizar la compra?", "Atencion", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                if (mensajeCompra == DialogResult.Yes)
                {
                    ordenCompraRegistro();
                    enviarEmail();
                    Application.Exit();
                }
                else if (mensajeCompra == DialogResult.No)
                {

                }
            }
        }

        private void panelDesktopPane_MouseMove(object sender, MouseEventArgs e)
        {
            //Creado por error
        }

        private void panelDesktopPane_MouseUp(object sender, MouseEventArgs e)
        {
            //Creado por error
        }

        private void panelDesktopPane_MouseLeave(object sender, EventArgs e)
        {
            //Creado por error
        }

        private void Store_MouseMove(object sender, MouseEventArgs e)
        {
            //Creado por error
        }

        private void Store_MouseLeave(object sender, EventArgs e)
        {
            //Creado por error
        }

        public void anadirListBox()
        {
            if (seleccionMicroprocesadorString != "")
            {
                //listBox1.Items.Add(seleccionMicroprocesadorString);
            }
            seleccionMicroprocesadorString = "";
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            //Microprocesador
            if(seleccionMicroprocesadorDouble != 0)
            {
                labelMicroprocesadorPrecio.Visible = true;
                labelMicroprocesadorPrecio.Text = "$" + seleccionMicroprocesadorDouble.ToString();
                labelMicroprocesadorPrecio.Enabled = true;
            }

            if(seleccionMicroprocesadorString != "")
            {
                labelMicroprocesador.Visible = true;
                labelMicroprocesador.Text = seleccionMicroprocesadorString;
                labelMicroprocesador.Enabled = true;
            }

            //Motherboard
            if (seleccionMotherboardDouble != 0)
            {
                labelMotherboardPrecio.Visible = true;  
                labelMotherboardPrecio.Text = "$" + seleccionMotherboardDouble.ToString();
                labelMotherboardPrecio.Enabled = true;
            }

            if (seleccionMotherboardString != "")
            {
                labelMotherboard.Visible = true;    
                labelMotherboard.Text = seleccionMotherboardString;
                labelMotherboard.Enabled = true;
            }

            //Memoria
            if (seleccionMemoriaDouble != 0)
            {
                labelMemoriaPrecio.Visible = true;
                labelMemoriaPrecio.Text = "$" + seleccionMemoriaDouble.ToString();
                labelMemoriaPrecio.Enabled = true;
            }

            if (seleccionMemoriaString != "")
            {
                labelMemoria.Visible = true;
                labelMemoria.Text = seleccionMemoriaString;
                labelMemoria.Enabled = true;
            }

            //Placa de Video
            if (seleccionPlacaDeVideoDouble != 0)
            {
                labelPlacaDeVideoPrecio.Visible = true;
                labelPlacaDeVideoPrecio.Text = "$" + seleccionPlacaDeVideoDouble.ToString();
                labelPlacaDeVideoPrecio.Enabled = true;
            }

            if (seleccionPlacaDeVideoString != "")
            {
                labelPlacaDeVideo.Visible = true;
                labelPlacaDeVideo.Text = seleccionPlacaDeVideoString;
                labelPlacaDeVideo.Enabled = true;
            }

            //Almacenamiento
            if (seleccionAlmacenamientoDouble != 0)
            {
                labelAlmacenamientoPrecio.Visible = true;
                labelAlmacenamientoPrecio.Text = "$" + seleccionAlmacenamientoDouble.ToString();
                labelAlmacenamientoPrecio.Enabled = true;
            }

            if (seleccionAlmacenamientoString != "")
            {
                labelAlmacenamiento.Visible = true;
                labelAlmacenamiento.Text = seleccionAlmacenamientoString;
                labelAlmacenamiento.Enabled = true;
            }

            //Fuente
            if (seleccionFuenteDouble != 0)
            {
                labelFuentePrecio.Visible = true;
                labelFuentePrecio.Text = "$" + seleccionFuenteDouble.ToString();
                labelFuentePrecio.Enabled = true;
            }

            if (seleccionFuenteString != "")
            {
                labelFuente.Visible = true;
                labelFuente.Text = seleccionFuenteString;
                labelFuente.Enabled = true;
            }

            //Gabinete
            if (seleccionGabineteDouble != 0)
            {
                labelGabinetePrecio.Visible = true;
                labelGabinetePrecio.Text = "$" + seleccionGabineteDouble.ToString();
                labelGabinetePrecio.Enabled = true;
            }

            if (seleccionGabineteString != "")
            {
                labelGabinete.Visible = true;
                labelGabinete.Text = seleccionGabineteString;
                labelGabinete.Enabled = true;
            }

            double subTotal = seleccionMicroprocesadorDouble + seleccionMotherboardDouble + seleccionMemoriaDouble + seleccionPlacaDeVideoDouble + seleccionAlmacenamientoDouble + seleccionFuenteDouble + seleccionGabineteDouble;
            double impuesto = subTotal * 0.21;
            double total = subTotal + impuesto;

            labelSubTotalPrecio.Text = "$" + subTotal.ToString();
            labelImpuestoPrecio.Text = "$" + impuesto.ToString();
            labelTotalPrecio.Text = "$" + total.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //Microprocesador
            labelMicroprocesadorPrecio.Visible = false;
            seleccionMicroprocesadorDouble = 0;
            labelMicroprocesador.Visible = false;
            seleccionMicroprocesadorString = "";
            labelMicroprocesadorPrecio.Enabled = false;

            //Motherboard
            labelMotherboardPrecio.Visible = false;
            seleccionMotherboardDouble = 0;
            labelMotherboard.Visible = false;
            seleccionMotherboardString = "";
            labelMotherboard.Enabled = false;

            //Memoria
            labelMemoriaPrecio.Visible = false;
            seleccionMemoriaDouble = 0;
            labelMemoria.Visible = false;
            seleccionMemoriaString = "";
            labelMemoria.Enabled = false;

            //Placa de Video
            labelPlacaDeVideoPrecio.Visible = false;
            seleccionPlacaDeVideoDouble = 0;
            labelPlacaDeVideo.Visible = false;
            seleccionPlacaDeVideoString = "";
            labelPlacaDeVideo.Enabled = false;

            //Almacenamiento
            labelAlmacenamientoPrecio.Visible = false;
            seleccionAlmacenamientoDouble = 0;
            labelAlmacenamiento.Visible = false;
            seleccionAlmacenamientoString = "";
            labelAlmacenamiento.Enabled = false;

            //Fuente
            labelFuentePrecio.Visible = false;
            seleccionFuenteDouble = 0;
            labelFuente.Visible = false;
            seleccionFuenteString = "";
            labelFuente.Enabled = false;

            //Gabinete
            labelGabinetePrecio.Visible = false;
            seleccionGabineteDouble = 0;
            labelGabinete.Visible = false;
            seleccionGabineteString = "";
            labelGabinete.Enabled = false;
        }

        private void labelMicroprocesador_Click(object sender, EventArgs e)
        {
            labelMicroprocesadorPrecio.Visible = false;
            seleccionMicroprocesadorDouble = 0;
            labelMicroprocesador.Visible = false;
            seleccionMicroprocesadorString = "";
            labelMicroprocesadorPrecio.Enabled = false;
        }

        private void labelMotherboard_Click(object sender, EventArgs e)
        {
            labelMotherboardPrecio.Visible = false;
            seleccionMotherboardDouble = 0;
            labelMotherboard.Visible = false;
            seleccionMotherboardString = "";
            labelMotherboard.Enabled = false;
        }

        private void labelMemoria_Click(object sender, EventArgs e)
        {
            labelMemoriaPrecio.Visible = false;
            seleccionMemoriaDouble = 0;
            labelMemoria.Visible = false;
            seleccionMemoriaString = "";
            labelMemoria.Enabled = false;
        }

        private void labelPlacaDeVideo_Click(object sender, EventArgs e)
        {
            labelPlacaDeVideoPrecio.Visible = false;
            seleccionPlacaDeVideoDouble = 0;
            labelPlacaDeVideo.Visible = false;
            seleccionPlacaDeVideoString = "";
            labelPlacaDeVideo.Enabled = false;
        }

        private void labelAlmacenamiento_Click(object sender, EventArgs e)
        {
            labelAlmacenamientoPrecio.Visible = false;
            seleccionAlmacenamientoDouble = 0;
            labelAlmacenamiento.Visible = false;
            seleccionAlmacenamientoString = "";
            labelAlmacenamiento.Enabled = false;
        }

        private void labelFuente_Click(object sender, EventArgs e)
        {
            labelFuentePrecio.Visible = false;
            seleccionFuenteDouble = 0;
            labelFuente.Visible = false;
            seleccionFuenteString = "";
            labelFuente.Enabled = false;
        }

        private void labelGabinete_Click(object sender, EventArgs e)
        {
            labelGabinetePrecio.Visible = false;
            seleccionGabineteDouble = 0;
            labelGabinete.Visible = false;
            seleccionGabineteString = "";
            labelGabinete.Enabled = false;
        }

        private void labelMicroprocesador_MouseMove(object sender, MouseEventArgs e)
        {
            labelMicroprocesador.ForeColor = Color.FromArgb(0, 117, 214);
            labelMicroprocesadorPrecio.ForeColor = Color.FromArgb(0, 117, 214);
        }

        private void labelMicroprocesador_MouseLeave(object sender, EventArgs e)
        {
            labelMicroprocesador.ForeColor = SystemColors.ControlText;
            labelMicroprocesadorPrecio.ForeColor = SystemColors.ControlText;
        }

        private void labelMotherboard_MouseMove(object sender, MouseEventArgs e)
        {
            labelMotherboard.ForeColor = Color.FromArgb(0, 117, 214);
            labelMotherboardPrecio.ForeColor = Color.FromArgb(0, 117, 214);
        }

        private void labelMotherboard_MouseLeave(object sender, EventArgs e)
        {
            labelMotherboard.ForeColor = SystemColors.ControlText;
            labelMotherboardPrecio.ForeColor = SystemColors.ControlText;
        }

        private void labelMemoria_MouseMove(object sender, MouseEventArgs e)
        {
            labelMemoria.ForeColor = Color.FromArgb(0, 117, 214);
            labelMemoriaPrecio.ForeColor = Color.FromArgb(0, 117, 214);
        }

        private void labelMemoria_MouseLeave(object sender, EventArgs e)
        {
            labelMemoria.ForeColor = SystemColors.ControlText;
            labelMemoriaPrecio.ForeColor = SystemColors.ControlText;
        }

        private void labelPlacaDeVideo_MouseMove(object sender, MouseEventArgs e)
        {
            labelPlacaDeVideo.ForeColor = Color.FromArgb(0, 117, 214);
            labelPlacaDeVideoPrecio.ForeColor = Color.FromArgb(0, 117, 214);
        }

        private void labelPlacaDeVideo_MouseLeave(object sender, EventArgs e)
        {
            labelPlacaDeVideo.ForeColor = SystemColors.ControlText;
            labelPlacaDeVideoPrecio.ForeColor = SystemColors.ControlText;
        }

        private void labelAlmacenamiento_MouseMove(object sender, MouseEventArgs e)
        {
            labelAlmacenamiento.ForeColor = Color.FromArgb(0, 117, 214);
            labelAlmacenamientoPrecio.ForeColor = Color.FromArgb(0, 117, 214);
        }

        private void labelAlmacenamiento_MouseLeave(object sender, EventArgs e)
        {
            labelAlmacenamiento.ForeColor = SystemColors.ControlText;
            labelAlmacenamientoPrecio.ForeColor = SystemColors.ControlText;
        }

        private void labelFuente_MouseMove(object sender, MouseEventArgs e)
        {
            labelFuente.ForeColor = Color.FromArgb(0, 117, 214);
            labelFuentePrecio.ForeColor = Color.FromArgb(0, 117, 214);
        }

        private void labelFuente_MouseLeave(object sender, EventArgs e)
        {
            labelFuente.ForeColor = SystemColors.ControlText;
            labelFuentePrecio.ForeColor = SystemColors.ControlText;
        }

        private void labelGabinete_MouseMove(object sender, MouseEventArgs e)
        {
            labelGabinete.ForeColor = Color.FromArgb(0, 117, 214);
            labelGabinetePrecio.ForeColor = Color.FromArgb(0, 117, 214);
        }

        private void labelGabinete_MouseLeave(object sender, EventArgs e)
        {
            labelGabinete.ForeColor = SystemColors.ControlText;
            labelGabinetePrecio.ForeColor = SystemColors.ControlText;
        }

        private void labelMicroprocesadorPrecio_MouseMove(object sender, MouseEventArgs e)
        {
            labelMicroprocesador.ForeColor = Color.FromArgb(0, 117, 214);
            labelMicroprocesadorPrecio.ForeColor = Color.FromArgb(0, 117, 214);
        }

        private void labelMicroprocesadorPrecio_MouseLeave(object sender, EventArgs e)
        {
            labelMicroprocesador.ForeColor = SystemColors.ControlText;
            labelMicroprocesadorPrecio.ForeColor = SystemColors.ControlText;
        }

        private void labelMotherboardPrecio_MouseMove(object sender, MouseEventArgs e)
        {
            labelMotherboard.ForeColor = Color.FromArgb(0, 117, 214);
            labelMotherboardPrecio.ForeColor = Color.FromArgb(0, 117, 214);
        }

        private void labelMotherboardPrecio_MouseLeave(object sender, EventArgs e)
        {
            labelMotherboard.ForeColor = SystemColors.ControlText;
            labelMotherboardPrecio.ForeColor = SystemColors.ControlText;
        }

        private void labelMemoriaPrecio_MouseMove(object sender, MouseEventArgs e)
        {
            labelMemoria.ForeColor = Color.FromArgb(0, 117, 214);
            labelMemoriaPrecio.ForeColor = Color.FromArgb(0, 117, 214);
        }

        private void labelMemoriaPrecio_MouseLeave(object sender, EventArgs e)
        {
            labelMemoria.ForeColor = SystemColors.ControlText;
            labelMemoriaPrecio.ForeColor = SystemColors.ControlText;
        }

        private void labelPlacaDeVideoPrecio_MouseMove(object sender, MouseEventArgs e)
        {
            labelPlacaDeVideo.ForeColor = Color.FromArgb(0, 117, 214);
            labelPlacaDeVideoPrecio.ForeColor = Color.FromArgb(0, 117, 214);
        }

        private void labelPlacaDeVideoPrecio_MouseLeave(object sender, EventArgs e)
        {
            labelPlacaDeVideo.ForeColor = SystemColors.ControlText;
            labelPlacaDeVideoPrecio.ForeColor = SystemColors.ControlText;
        }

        private void labelAlmacenamientoPrecio_MouseMove(object sender, MouseEventArgs e)
        {
            labelAlmacenamiento.ForeColor = Color.FromArgb(0, 117, 214);
            labelAlmacenamientoPrecio.ForeColor = Color.FromArgb(0, 117, 214);
        }

        private void labelAlmacenamientoPrecio_MouseLeave(object sender, EventArgs e)
        {
            labelAlmacenamiento.ForeColor = SystemColors.ControlText;
            labelAlmacenamientoPrecio.ForeColor = SystemColors.ControlText;
        }

        private void labelFuentePrecio_MouseMove(object sender, MouseEventArgs e)
        {
            labelFuente.ForeColor = Color.FromArgb(0, 117, 214);
            labelFuentePrecio.ForeColor = Color.FromArgb(0, 117, 214);
        }

        private void labelFuentePrecio_MouseLeave(object sender, EventArgs e)
        {
            labelFuente.ForeColor = SystemColors.ControlText;
            labelFuentePrecio.ForeColor = SystemColors.ControlText;
        }

        private void labelGabinetePrecio_MouseMove(object sender, MouseEventArgs e)
        {
            labelGabinete.ForeColor = Color.FromArgb(0, 117, 214);
            labelGabinetePrecio.ForeColor = Color.FromArgb(0, 117, 214);
        }

        private void labelGabinetePrecio_MouseLeave(object sender, EventArgs e)
        {
            labelGabinete.ForeColor = SystemColors.ControlText;
            labelGabinetePrecio.ForeColor = SystemColors.ControlText;
        }

        private void panelMenu_Paint(object sender, PaintEventArgs e)
        {
            //Creado por error
        }

        private void buttonNombreEmpresa_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.FormInicio(), sender);
        }
    }
}

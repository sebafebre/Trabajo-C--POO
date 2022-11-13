using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Text.RegularExpressions;
using System.Net.Mail;
using System.Security.Cryptography;

namespace Trabajo_Practico
{
    public partial class Register : Form
    {
        //Variable Global
        public string conexion_database;
        string hashCode;

        //Move Bar
        int mov;
        int movX;
        int movY;

        public Register(string conexion_database)
        {
            InitializeComponent();
            this.conexion_database = conexion_database; //Obtiene la conexion de la base de datos
        }

        private void btn_confirmar_Click(object sender, EventArgs e)
        {
            if (txt_nombre.Text == "")
            {
               MessageBox.Show("Ingrese su nombre.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (txt_apellido.Text == "")
            {
                MessageBox.Show("Ingrese su apellido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (txt_email.Text == "")
            {
                MessageBox.Show("Ingrese un email.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (syntaxis_email(e, txt_email.Text) == false)
            {
                MessageBox.Show("Mala redaccion del email.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (txt_contrasena.Text == "")
            {
                MessageBox.Show("Ingrese una contraseña.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (validar_email() == true)
            {
                MessageBox.Show("El email a se encuentra en uso.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (txt_email.TextLength > 40)
            {
                MessageBox.Show("Ingrese su email debe ser menor a 40 caracteres.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (txt_contrasena.TextLength > 20)
            {
                MessageBox.Show("Ingrese su contrasena debe ser menor a 20 caracteres.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                registro();           
                enviar_email();
            }
        }

        public void registro()
        {
            hashCode = GetSHA1(txt_contrasena.Text);

            try
            {
                using (SqlConnection cn = new SqlConnection(conexion_database))
                {
                    SqlCommand cmd = new SqlCommand("insert into usuarios(nombre,apellido,email,contrasena) values ('" + txt_nombre.Text + "','" + txt_apellido.Text + "','" + txt_email.Text + "','" + hashCode + "');", cn);
                    cmd.CommandType = CommandType.Text;
                    cn.Open();
                    cmd.ExecuteNonQuery();
                    DialogResult MensajeFinal = MessageBox.Show("Registro Exitoso.", "Importante", MessageBoxButtons.OK);
                    if (MensajeFinal == DialogResult.OK)
                    {
                        this.Close();
                    }
                }
            }
            catch
            {
                MessageBox.Show("No se pudo realizar el registro.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public bool validar_email()
        {
            SqlConnection cn = new SqlConnection(conexion_database);

            cn.Open();
            SqlCommand cmd = new SqlCommand("select * from usuarios where email = '" + txt_email.Text + "'", cn);
            SqlDataReader registro = cmd.ExecuteReader();

            if (registro.Read())
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private void btn_volver_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        static public bool syntaxis_email(EventArgs e, string Mail)//validacion formato de direccion de e-mail
        {

            Regex mRegxExpression;

            if (Mail.Trim() != string.Empty)
            {

                mRegxExpression = new Regex(@"^([a-zA-Z0-9_\-])([a-zA-Z0-9_\-\.]*)@(\[((25[0-5]|2[0-4][0-9]|1[0-9][0-9]|[1-9][0-9]|[0-9])\.){3}|((([a-zA-Z0-9\-]+)\.)+))([a-zA-Z]{2,}|(25[0-5]|2[0-4][0-9]|1[0-9][0-9]|[1-9][0-9]|[0-9])\])$");

                if (!mRegxExpression.IsMatch(Mail.Trim()))
                {
                    //no es correcta
                    return false;
                }
                else
                {
                    //es correcta
                    return true;
                }

            }
            else
            {
                //no es correcta, esta vacia
                return false;
            }

        }

        private void lbl_registro_Click(object sender, EventArgs e)
        {
            //
        }

        private void label4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txt_nombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Solo letras
            if (Char.IsLetter(e.KeyChar))
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
        }

        private void txt_apellido_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Solo letras
            if (Char.IsLetter(e.KeyChar))
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
        }

        public void enviar_email()
        {
            //Variables
            string email, contrasena;
            email = "email@outlook.com";
            contrasena = "contrasenaEmail";
            
            //Body
            string subject = "Registro";
            string body = "¡Registro exisitoso! <br> Gracias por registrarse " + txt_nombre.Text+" "+txt_apellido.Text+". <br> Disfrute su experiencia.";
            int port = 587;
            string host = "smtp.office365.com";

            MailMessage msg = new MailMessage(); //Crea la instancia de msg

            msg.To.Add(txt_email.Text);
            msg.Subject = subject;
            msg.SubjectEncoding = Encoding.UTF8;
            msg.Body = body;
            msg.BodyEncoding = Encoding.UTF8;
            msg.IsBodyHtml = true;
            msg.From = new MailAddress(email);

            SmtpClient cliente = new SmtpClient();
            cliente.Credentials = new System.Net.NetworkCredential(email, contrasena);
            cliente.Port = port;
            cliente.EnableSsl = true;
            cliente.Host = host;

            try
            {
                cliente.Send(msg);
                DialogResult MensajeFinal = MessageBox.Show("Se envio el email correctamente.", "Informe", MessageBoxButtons.OK, MessageBoxIcon.Information);
                if (MensajeFinal == DialogResult.OK)
                {
                    this.Close();
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Error al enviar");
            }
        }

        private void panelMove_MouseDown(object sender, MouseEventArgs e)
        {
            mov = 1;
            movX = e.X;
            movY = e.Y;
        }

        private void panelMove_MouseMove(object sender, MouseEventArgs e)
        {
            if (mov == 1)
            {
                this.SetDesktopLocation(MousePosition.X - movX, MousePosition.Y - movY);
            }
        }

        private void panelMove_MouseUp(object sender, MouseEventArgs e)
        {
            mov = 0;
        }

        public static string GetSHA1(String texto)
        {
            SHA1 sha1 = SHA1CryptoServiceProvider.Create();
            Byte[] textOriginal = ASCIIEncoding.Default.GetBytes(texto);
            Byte[] hash = sha1.ComputeHash(textOriginal);
            StringBuilder cadena = new StringBuilder();
            foreach (byte i in hash)
            {
                cadena.AppendFormat("{0:x2}", i);
            }
            return cadena.ToString();
        }
    }
}

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
using System.IO;
using System.Security.Cryptography;

namespace Trabajo_Practico
{
    public partial class Log_In : Form
    {
        //Move Bar
        int mov;
        int movX;
        int movY;
        
        public Log_In()
        {
            InitializeComponent();
            txt_email.Clear();
            txt_contrasena.Clear();
        }

        //Variable Global      
        //PC
        static public string conexion_database = "Data Source=DESKTOP-K0KPPT1;Initial Catalog=master;Integrated Security=True";
        //NoteBook
        //static public string conexion_database = @"";
        static public string email_global;
        string hashCode;


        private void btn_iniciarSesion_Click(object sender, EventArgs e)
        {
            //Validaciones
            string email = txt_email.Text;

            if (txt_email.Text == "")
            {
                MessageBox.Show("Ingrese su email.","Error", MessageBoxButtons.OK,MessageBoxIcon.Error );
            }
            else if (txt_email.Text != "admin" && txt_email.Text != "123" && syntaxis_email(e, email) == false)
            {
                MessageBox.Show("Mala redaccion del email.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if(txt_contrasena.Text == "")
            {
                MessageBox.Show("Ingrese su contrasena.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (login() == false)
            {
                MessageBox.Show("Datos Incorrectos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if(txt_email.Text == "admin" && txt_contrasena.Text == "admin")
                {
                    Administrador_de_Usuarios frm1 = new Administrador_de_Usuarios(conexion_database);
                    frm1.ShowDialog();
                }
                else
                {
                    email_global = txt_email.Text;
                    //string email_global = txt_email.Text;
                    Store frm = new Store(/*email_global*/);
                    frm.ShowDialog();
                }
            }
        }

        private void lbl_crearCuenta_Click(object sender, EventArgs e)
        {
            //Abre el form de Registro
            Register frm = new Register(conexion_database);   
            frm.ShowDialog();
        }

        public bool login()
        {
            hashCode = GetSHA1(txt_contrasena.Text);

            //Conexion con SQL
            SqlConnection cn = new SqlConnection(conexion_database); //Crea la instancia SQL
            cn.Open(); //Abre la conexion
            SqlCommand cmd = new SqlCommand("select * from usuarios where email = '" + txt_email.Text + "' and contrasena = '" + hashCode + "'", cn); //Crea la instancia "cmd" con el comando para SQL
            SqlDataReader registro = cmd.ExecuteReader(); //Ejecuta el comando

            if (registro.Read())
            {
                //Encontro el registro
                return true;
            }
            else
            {
                //No encontro el registro
                return false;
            }

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

        private void Sign_In_Load(object sender, EventArgs e)
        {
            //
        }

        private void label1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void panel3_MouseDown(object sender, MouseEventArgs e)
        {
            //Permite mover el form seleccionando el panel
            mov = 1;
            movX = e.X;
            movY = e.Y;
        }

        private void panel3_MouseMove(object sender, MouseEventArgs e)
        {
            //Permite mover el form seleccionando el panel
            if (mov == 1)
            {
                this.SetDesktopLocation(MousePosition.X - movX, MousePosition.Y - movY);
            }
        }

        private void panel3_MouseUp(object sender, MouseEventArgs e)
        {
            //Permite mover el form seleccionando el panel
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

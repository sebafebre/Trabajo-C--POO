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
using System.Security.Cryptography;

namespace Trabajo_Practico
{
    public partial class Administrador_de_Usuarios : Form
    {
        //Varaiable Global
        public string conexion_database;
        string hashCode;

        //Move Bar
        int mov;
        int movX;
        int movY;

        public Administrador_de_Usuarios(string conexion_database)
        {
            //Inicializacion
            InitializeComponent();
            txt_nombre.BringToFront();
            txt_contrasena.BringToFront();

            //Variable global de conexion
            this.conexion_database = conexion_database;

            //Muestra todos los registros al inicializar
            DataTable dt = new DataTable();
            using (SqlConnection cn = new SqlConnection(conexion_database))
            {
                cn.Open();
                SqlDataAdapter da = new SqlDataAdapter("select * from usuarios;", cn);
                da.SelectCommand.CommandType = CommandType.Text;
                da.Fill(dt);
                dgv_clientes.DataSource = dt;
                cn.Close();
            }

        }

        private void label1_Click(object sender, EventArgs e)
        {
            //Creado por error
        }

        private void btn_insertar_Click(object sender, EventArgs e)
        {
            //Insertar cliente
            /*if(txt_id.Text != "")
            {
                MessageBox.Show("No se debe ingresar un ID para insertar un cliente.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else*/ if (txt_nombre.Text == "")
            {
                MessageBox.Show("Ingrese un nombre.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (txt_apellido.Text == "")
            {
                MessageBox.Show("Ingrese un apellido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (txt_email.Text == "")
            {
                MessageBox.Show("Ingrese un email.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (syntaxis_email(e, txt_email.Text) == false)
            {
                MessageBox.Show("Ingrese email valido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (validar_email() == true)
            {
                MessageBox.Show("El email a se encuentra en uso.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (txt_contrasena.Text == "")
            {
                MessageBox.Show("Ingrese un contraseña.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                hashCode = GetSHA1(txt_contrasena.Text);
                //Inserta cliente
                using (SqlConnection cn = new SqlConnection(conexion_database))
                {
                    SqlCommand cmd = new SqlCommand("insert into usuarios(nombre,apellido,email,contrasena) values ('" + txt_nombre.Text + "','" + txt_apellido.Text + "','" + txt_email.Text + "','" + hashCode + "');", cn);
                    cmd.CommandType = CommandType.Text;
                    cn.Open();
                    cmd.ExecuteNonQuery();
                    cn.Close();

                    MessageBox.Show("Usuario ingresado con exito", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                //Actualiza la tabla
                DataTable dt = new DataTable();
                using (SqlConnection cn = new SqlConnection(conexion_database))
                {
                    cn.Open();
                    SqlDataAdapter da = new SqlDataAdapter("select * from usuarios;", cn);
                    da.SelectCommand.CommandType = CommandType.Text;
                    da.Fill(dt);
                    dgv_clientes.DataSource = dt;
                    cn.Close();
                }

                //Limpiar textBoxs
                txt_id.Clear();
                txt_nombre.Clear();
                txt_apellido.Clear();
                txt_email.Clear();
                txt_contrasena.Clear();

                //Deshabilitar textBoxs
                txt_nombre.Enabled = false;
                txt_apellido.Enabled = false;
                txt_email.Enabled = false;
                txt_contrasena.Enabled = false;
                btn_insertar.Enabled = false;
                btn_insertar.Visible = false;
            }
        }

        private void btn_modificar_Click(object sender, EventArgs e)
        {
            //Modifica cliente
            if (txt_id.Text == "1")
            {
                MessageBox.Show("No se puede modificar este usuario.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (txt_id.Text == "")
            {
                MessageBox.Show("Ingrese un ID para modificar un cliente.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (txt_nombre.Text == "")
            {
                MessageBox.Show("Ingrese un nombre.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (txt_apellido.Text == "")
            {
                MessageBox.Show("Ingrese un apellido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (txt_email.Text == "")
            {
                MessageBox.Show("Ingrese un email.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (syntaxis_email(e, txt_email.Text) == false)
            {
                MessageBox.Show("Ingrese email valido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (txt_contrasena.Text == "")
            {
                MessageBox.Show("Ingrese un contraseña.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (validar_id() == false)
            {
                MessageBox.Show("Ingrese un ID valido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            /*else if (validar_email() == true && txt_email !=)
            {
                MessageBox.Show("El email a se encuentra en uso.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }*/
            else
            {
                hashCode = GetSHA1(txt_contrasena.Text);

                //Modifica cliente
                using (SqlConnection cn = new SqlConnection(conexion_database))
                {
                    SqlCommand cmd = new SqlCommand("update usuarios set nombre = '" + txt_nombre.Text + "', apellido = '" + txt_apellido.Text + "', email = '" + txt_email.Text + "', contrasena = '" + hashCode + "' where id = " + txt_id.Text + ";", cn);
                    cmd.CommandType = CommandType.Text;
                    cn.Open();
                    cmd.ExecuteNonQuery();
                    cn.Close();
                    MessageBox.Show("Usuario modificado con exito", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                //Actualiza la tabla
                DataTable dt = new DataTable();
                using (SqlConnection cn = new SqlConnection(conexion_database))
                {
                    cn.Open();
                    SqlDataAdapter da = new SqlDataAdapter("select * from usuarios;", cn);
                    da.SelectCommand.CommandType = CommandType.Text;
                    da.Fill(dt);
                    dgv_clientes.DataSource = dt;
                    cn.Close();
                }

                //Limpiar textBoxs
                txt_id.Clear();
                txt_nombre.Clear();
                txt_apellido.Clear();
                txt_email.Clear();
                txt_contrasena.Clear();

                //Deshabilitar textBoxs
                txt_nombre.Enabled = false;
                txt_apellido.Enabled = false;
                txt_email.Enabled = false;
                txt_contrasena.Enabled = false;
                btn_modificar.Enabled = false;
                btn_modificar.Visible = false;
            }
        }

        private void btn_eliminar_Click(object sender, EventArgs e)
        {
            //Ya no se usa
            //Elimina cliente
            if(txt_id.Text == "1")
            {
                MessageBox.Show("No se puede eliminar este usuario.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (validar_id() == false)
            {
                MessageBox.Show("Ingrese un ID valido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (txt_nombre.Text != "")
            {
                MessageBox.Show("No se debe ingresar un nombre para eliminar un cliente, solo se necesita el ID.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (txt_apellido.Text != "")
            {
                MessageBox.Show("No se debe ingresar un apellido para eliminar un cliente, solo se necesita el ID.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (txt_email.Text != "")
            {
                MessageBox.Show("No se debe ingresar un email para eliminar un cliente, solo se necesita el ID.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (txt_contrasena.Text != "")
            {
                MessageBox.Show("No se debe ingresar una contraseña para eliminar un cliente, solo se necesita el ID.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                //Elimina cliente
                using (SqlConnection cn = new SqlConnection(conexion_database))
                {
                    
                    SqlCommand cmd = new SqlCommand("delete from usuarios where id = " + txt_id.Text + ";", cn);
                    cmd.CommandType = CommandType.Text;
                    cn.Open();
                    cmd.ExecuteNonQuery();
                    cn.Close();
                    MessageBox.Show("Usuario eliminado con exito", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                //Actualiza la tabla
                DataTable dt = new DataTable();
                using (SqlConnection cn = new SqlConnection(conexion_database))
                {
                    cn.Open();
                    SqlDataAdapter da = new SqlDataAdapter("select * from usuarios;", cn);
                    da.SelectCommand.CommandType = CommandType.Text;
                    da.Fill(dt);
                    dgv_clientes.DataSource = dt;
                    cn.Close();
                }

                //Limpiar texBoxs
                txt_id.Clear();
                txt_nombre.Clear();
                txt_apellido.Clear();
                txt_email.Clear();
                txt_contrasena.Clear();
            }
        }

        static public bool syntaxis_email(EventArgs e, string Mail)//validacion formato de direccion de e-mail
        {
            //Corrobora que la sintaxis del email este correcta
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

        public bool validar_email()
        {
            //Valida que el email exista
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

        public bool validar_id()
        {
            //Valida que el ID exista
            SqlConnection cn = new SqlConnection(conexion_database);

            cn.Open();
            SqlCommand cmd = new SqlCommand("select * from usuarios where id = '" + txt_id.Text + "'", cn);
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

        private void txt_id_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Solo numeros
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
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

        private void dataGridView1_MouseUp(object sender, MouseEventArgs e)
        {
            //Creado por error
        }

        private void dataGridView1_MouseClick(object sender, MouseEventArgs e)
        {
            //Muestra los valores en los textBoxs
            txt_id.Text = dgv_clientes.CurrentRow.Cells[0].Value.ToString();
            txt_nombre.Text = dgv_clientes.CurrentRow.Cells[1].Value.ToString();
            txt_apellido.Text = dgv_clientes.CurrentRow.Cells[2].Value.ToString();
            txt_email.Text = dgv_clientes.CurrentRow.Cells[3].Value.ToString();
            txt_contrasena.Text = dgv_clientes.CurrentRow.Cells[4].Value.ToString();

            //Crea el Menu
            if (e.Button == MouseButtons.Right)
            {
                ContextMenuStrip menu = new ContextMenuStrip();
                int posicion = dgv_clientes.HitTest(e.X, e.Y).RowIndex;
                if (posicion > -1)
                {
                    //Crea las opciones del Menu
                    menu.Items.Add("Insertar").Name = "Insertar" + posicion;
                    menu.Items.Add("Modificar").Name = "Modificar" + posicion;
                    menu.Items.Add("Eliminar").Name = "Eliminar" + posicion;
                }     
                menu.Show(dgv_clientes, e.X, e.Y);
                menu.ItemClicked += new ToolStripItemClickedEventHandler(menuClick);
            }
        }

        private void menuClick(object sender, ToolStripItemClickedEventArgs e)
        {
            //Acciones del menu
            string id = e.ClickedItem.Name.ToString();
            if (id.Contains("Insertar"))
            {
                txt_id.Clear();
                txt_nombre.Enabled = true;
                txt_nombre.Clear();
                txt_apellido.Enabled = true;
                txt_apellido.Clear();
                txt_email.Enabled = true;
                txt_email.Clear();
                txt_contrasena.Enabled = true;
                txt_contrasena.Clear();
                btn_insertar.Enabled = true;
                btn_insertar.Visible = true;
            }
            else if (id.Contains("Modificar"))
            {
                txt_nombre.Enabled = true;
                txt_apellido.Enabled = true;
                txt_contrasena.Enabled = true;
                btn_modificar.Enabled = true;
                btn_modificar.Visible = true;
            }
            else if (id.Contains("Eliminar"))
            {
                DialogResult MensajeFinal = MessageBox.Show("Esta seguro que desea eliminar a "+txt_nombre.Text+" "+txt_apellido.Text+".", "Atencion", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (MensajeFinal == DialogResult.Yes)
                {
                    if (txt_email.Text != "admin" && txt_contrasena.Text!= "admin")
                    {
                        eliminar_cliente();
                    }
                    else
                    {
                        MessageBox.Show("Este usuario no se puede eliminar", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
            }
        }

        private void eliminar_cliente()
        {
            //Elimina cliente
            using (SqlConnection cn = new SqlConnection(conexion_database))
            {

                SqlCommand cmd = new SqlCommand("delete from usuarios where id = " + txt_id.Text + ";", cn);
                cmd.CommandType = CommandType.Text;
                cn.Open();
                cmd.ExecuteNonQuery();
                cn.Close();
                MessageBox.Show("Usuario eliminado con exito", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            //Actualiza la tabla
            DataTable dt = new DataTable();
            using (SqlConnection cn = new SqlConnection(conexion_database))
            {
                cn.Open();
                SqlDataAdapter da = new SqlDataAdapter("select * from usuarios;", cn);
                da.SelectCommand.CommandType = CommandType.Text;
                da.Fill(dt);
                dgv_clientes.DataSource = dt;
                cn.Close();
            }

            //Limpiar texBoxs
            txt_id.Clear();
            txt_nombre.Clear();
            txt_apellido.Clear();
            txt_email.Clear();
            txt_contrasena.Clear();
        }

        private void Administrador_de_Usuarios_Load(object sender, EventArgs e)
        {
            //Creado por error
        }

        private void label1_Click_1(object sender, EventArgs e)
        {
            //Creado por error
        }

        private void label2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void lvl_volver_atras_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_modificar_EnabledChanged(object sender, EventArgs e)
        {
            //Creado por error
        }

        private void dgv_clientes_RowLeave(object sender, DataGridViewCellEventArgs e)
        {
            //Si selecciona otro Row saca la accion que se esta ejecutando en ese momento
            btn_insertar.Enabled = false;
            btn_insertar.Visible = false;
            btn_modificar.Enabled = false;
            btn_modificar.Visible = false;
            txt_id.Enabled = false;
            txt_nombre.Enabled = false;
            txt_apellido.Enabled = false;
            txt_email.Enabled = false;
            txt_contrasena.Enabled = false;
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

        private void txt_email_TextChanged(object sender, EventArgs e)
        {
            //Si selecciona otro Row saca la accion que se esta ejecutando en ese momento
            //Nueva solucion
            /*btn_insertar.Enabled = false;
            btn_insertar.Visible = false;
            btn_modificar.Enabled = false;
            btn_modificar.Visible = false;
            txt_id.Enabled = false;
            txt_nombre.Enabled = false;
            txt_apellido.Enabled = false;
            txt_email.Enabled = false;
            txt_contrasena.Enabled = false;*/
        }
    }
}

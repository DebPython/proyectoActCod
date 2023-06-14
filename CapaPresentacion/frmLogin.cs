using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaNegocio;
using System.Data.SqlClient;

namespace CapaPresentacion
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            NUsuarios usu = new NUsuarios();
            DataTable datos = NUsuarios.Login(this.txtUsuario.Text, this.txtPassword.Text);
            //evaluar si existe el usuario.............

            if (datos.Rows.Count == 0)
            {
                MessageBox.Show("No tienes Acceso al Sistema", "Sistema de Inventario", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {


                string usuario = datos.Rows[0][3].ToString();
                string connectionString = "Data Source=DESKTOP-80IDSOL; Initial Catalog=inventario; Integrated Security=true";

                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    SqlCommand command = new SqlCommand("SET CONTEXT_INFO @parametro_varbinary", connection);
                    command.Parameters.AddWithValue("@parametro_varbinary", Encoding.Unicode.GetBytes(usuario));
                    command.ExecuteNonQuery();
                }
                mdiPresentacion frm = new mdiPresentacion();
                frm.usuario_no = datos.Rows[0][0].ToString();
                frm.Apellidos = datos.Rows[0][2].ToString() + " " + datos.Rows[0][4].ToString();
                frm.Nombre = datos.Rows[0][3].ToString();
                frm.Acceso = datos.Rows[0][9].ToString();
                
                //MessageBox.Show("");
                frm.Show();
                this.Hide();
            }
            

        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}

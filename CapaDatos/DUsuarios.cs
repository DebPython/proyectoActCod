using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace CapaDatos
{
    public class DUsuarios
    {

        private int usuario_no;
        private int ci;
        private string nombre;
        private string paterno;
        private string materno;
        private string cargo;
        private string profesion;
        private string usuario;
        private string passwor;


        public int Usuario_no
        {
            get { return usuario_no; }
            set { usuario_no = value; }
        }
        public int Ci
        {
            get { return ci; }
            set { ci = value; }
        }
        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }

        public string Paterno
        {
            get { return paterno; }
            set { paterno = value; }
        }


        public string Materno
        {
            get { return materno; }
            set { materno = value; }
        }

        public string Cargo
        {
            get { return cargo; }
            set { cargo = value; }
        }

        public string Profesion
        {
            get { return profesion; }
            set { profesion = value; }
        }
        public string Usuario
        {
            get { return usuario; }
            set { usuario = value; }
        }


        public string Passwor
        {
            get { return passwor; }
            set { passwor = value; }
        }
        public DUsuarios() { 
        
        }

        public DUsuarios(int usuarioNo, int ci, string nombre, string paterno, string materno, 
            string cargo, string profesion, string usuario, string password)
        {
            this.Usuario_no = usuarioNo;
            this.Ci = ci;
            this.Nombre = nombre;
            this.Paterno = paterno;
            this.Materno = materno;
            this.Cargo = cargo;
            this.Profesion = profesion;
            this.Usuario = usuario;
            this.Passwor = passwor;
        }

        public DataTable Mostrar()
        {
            DataTable DtResultado = new DataTable("Usuarios");
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                SqlCon.ConnectionString = Conexion.Cn;
                String sql = "SELECT * FROM usuario ORDER BY "+ 
                " CAST(SUBSTRING(usuario_no, CHARINDEX('-', usuario_no) + 1, LEN(usuario_no)) AS INT) ASC";
                SqlDataAdapter sda = new SqlDataAdapter(sql, SqlCon);

                sda.Fill(DtResultado);


            }
            catch (Exception ex)
            {
                DtResultado = null;

            }
            return DtResultado;

        }


        public DataTable Login(DUsuarios usuario)
        {
            DataTable DtResultado = new DataTable("Usuarios");
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                //Código
                SqlCon.ConnectionString = Conexion.Cn;
                SqlCon.Open();
                //Establecer el Comando

                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;


                SqlCmd.CommandText = "SELECT * FROM usuario WHERE usuario = @usuario and passwor = @passwor";
                SqlCmd.CommandType = CommandType.Text;
                /*SqlCmd.CommandText = "EXEC SetSessionParametro '"+ usuario.Usuario +"'";
                SqlCmd.CommandType = CommandType.Text;
                */
                SqlCmd.Parameters.AddWithValue("@usuario", usuario.Usuario);
                SqlCmd.Parameters.AddWithValue("@passwor", usuario.Passwor);


                SqlDataAdapter SqlDat = new SqlDataAdapter(SqlCmd);
                SqlDat.Fill(DtResultado);

            }
            catch (Exception ex)
            {
                DtResultado = null;
            }
            return DtResultado;

        }

        public DataTable Mostrar_Historial()
        {
            DataTable DtResultado = new DataTable("Historial");
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                SqlCon.ConnectionString = Conexion.Cn;
                String sql = "SELECT * FROM historial_inventario";
                SqlDataAdapter sda = new SqlDataAdapter(sql, SqlCon);

                sda.Fill(DtResultado);


            }
            catch (Exception ex)
            {
                DtResultado = null;

            }
            return DtResultado;

        }


        public void EjecutarProcedimientoAlmacenado(string parametro)
        {
            using (SqlConnection connection = new SqlConnection(Conexion.Cn))
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand("SetSessionParametro", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@parametro_varchar", parametro);
                    command.ExecuteNonQuery();
                }
            }
        }

        public DataTable Buscar_Usuarios(string variable, string condicion)
        {
            DataTable DtResultado = new DataTable("Usuario");
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                SqlCon.ConnectionString = Conexion.Cn;
                SqlCon.Open();

                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandText = "SELECT * FROM usuario WHERE " + condicion + " LIKE '" + variable + "%' ";
                SqlCmd.CommandType = CommandType.Text;

                SqlDataAdapter SqlDat = new SqlDataAdapter(SqlCmd);
                SqlDat.Fill(DtResultado);

            }
            catch (Exception ex)
            {
                DtResultado = null;
            }
            return DtResultado;
        }


        public DataTable Buscar_Historial(string variable, string condicion)
        {
            DataTable DtResultado = new DataTable("Historial");
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                SqlCon.ConnectionString = Conexion.Cn;
                SqlCon.Open();

                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandText = "SELECT * FROM historial_inventario WHERE " + condicion + " LIKE '" + variable + "%' ";
                SqlCmd.CommandType = CommandType.Text;

                SqlDataAdapter SqlDat = new SqlDataAdapter(SqlCmd);
                SqlDat.Fill(DtResultado);

            }
            catch (Exception ex)
            {
                DtResultado = null;
            }
            return DtResultado;
        }
        
    }
}

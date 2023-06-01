using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace CapaDatos
{
    public  class DInventario
    {

        private string _inv_no;
        private string _auxiliar;
        private string _cod_entidad;
        private string _cod_antiguo;
        private string _serie;
        private string _descripcion;
        private string _estado;
        private string _geografica;
        private string _especifica;
        private string _procedencia;
        private DateTime _fecha_ingreso;
        private string observaciones;
        private string _oficina_no;
        private string _emp_no;
        private string _partida_no;
       



        public string Inv_no
        {
            get { return _inv_no; }
            set { _inv_no = value; }
        }

        public string Auxiliar
        {
            get { return _auxiliar; }
            set { _auxiliar = value; }
        }
        public string Cod_entidad
        {
            get { return _cod_entidad; }
            set { _cod_entidad = value; }
        }
        public string Cod_antiguo
        {
            get { return _cod_antiguo; }
            set { _cod_antiguo = value; }
        }

        public string Serie
        {
            get { return _serie; }
            set { _serie = value; }
        }

        public string Descripcion
        {
            get { return _descripcion; }
            set { _descripcion = value; }
        }

        public string Estado
        {
            get { return _estado; }
            set { _estado = value; }
        }
        public string Geografica
        {
            get { return _geografica; }
            set { _geografica = value; }
        }

        public string Especifica
        {
            get { return _especifica; }
            set { _especifica = value; }
        }

        public string Procedencia
        {
            get { return _procedencia; }
            set { _procedencia = value; }
        }


        public DateTime Fecha_ingreso
        {
            get { return _fecha_ingreso; }
            set { _fecha_ingreso = value; }
        }
        public string Observaciones
        {
            get { return observaciones; }
            set { observaciones = value; }
        }

        public string Oficina_no
        {
            get { return _oficina_no; }
            set { _oficina_no = value; }
        }


        public string Emp_no
        {
            get { return _emp_no; }
            set { _emp_no = value; }
        }


        public string Partida_no
        {
            get { return _partida_no; }
            set { _partida_no = value; }
        }
       

        public DInventario()
        { 

        }
        public DInventario(string inv_no, string auxiliar, string cod_entidad, string cod_antiguo,
            string serie, string descripcion, string estado, string geografica, string especifica, string procedencia,
            DateTime fecha_ingreso, string observaciones, string oficina_no, string emp_no, string partida_no)
        {
            this.Inv_no = inv_no;
            this.Auxiliar = auxiliar;
            this.Cod_entidad = cod_entidad;
            this.Cod_antiguo = cod_antiguo;
            this.Serie = serie;
            this.Descripcion = descripcion;
            this.Estado = estado;
            this.Geografica = geografica;
            this.Especifica = especifica;
            this.Procedencia = procedencia;
            this.Fecha_ingreso = fecha_ingreso;
            this.Observaciones = observaciones;
            this.Oficina_no = oficina_no;
            this.Emp_no = emp_no;
            this.Partida_no = partida_no;

        }

        public string Insertar(DInventario Inventario)
        {
            string rpta = "";
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                //Código
                SqlCon.ConnectionString = Conexion.Cn;
                SqlCon.Open();
                //Establecer el Comando
                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandText = "INSERT INTO inventario ('AF-' + CAST(NEXT VALUE FOR SecInventario AS VARCHAR), auxiliar,"+ 
                " cod_entidad, cod_antiguo,serie, descripcion, estado, geografica, especifica, procedencia, fecha_ingreso," + 
                " observaciones, codoficina_id, ci_id, partida_id) VALUES(@auxiliar, @cod_entidad, "+
                " @cod_antiguo, @serie, @descripcion, @estado, @geografica, @especifica, @procedencia, @fecha_ingreso,"+
                " @observaciones, @oficina_no, @emp_no, @partida_no)";
                SqlCmd.CommandType = CommandType.Text;
                SqlCmd.Parameters.AddWithValue("@auxiliar", Inventario.Auxiliar);
                SqlCmd.Parameters.AddWithValue("@cod_entidad", Inventario.Cod_entidad);

                SqlCmd.Parameters.AddWithValue("@cod_antiguo", Inventario.Cod_antiguo);
                SqlCmd.Parameters.AddWithValue("@serie", Inventario.Serie);
                SqlCmd.Parameters.AddWithValue("@descripcion", Inventario.Descripcion);
                SqlCmd.Parameters.AddWithValue("@estado", Inventario.Estado);
                SqlCmd.Parameters.AddWithValue("@geografica", Inventario.Geografica);
                SqlCmd.Parameters.AddWithValue("@especifica", Inventario.Especifica);
                SqlCmd.Parameters.AddWithValue("@procedencia", Inventario.Procedencia);
                SqlCmd.Parameters.AddWithValue("@fecha_ingreso", Inventario.Fecha_ingreso);
                SqlCmd.Parameters.AddWithValue("@observaciones", Inventario.Observaciones);
                SqlCmd.Parameters.AddWithValue("@oficina_no", Inventario.Oficina_no);
                SqlCmd.Parameters.AddWithValue("@emp_no", Inventario.Emp_no);
                SqlCmd.Parameters.AddWithValue("@partida_no", Inventario.Partida_no);

                rpta = SqlCmd.ExecuteNonQuery() == 1 ? "OK" : "NO se Ingreso el Registro";
            }

            catch (Exception ex)
            {
                rpta = ex.Message;
                throw;
            }
            finally
            {
                if (SqlCon.State == ConnectionState.Open)
                {
                    SqlCon.Close();
                }
            }
            return rpta;

        }

        public string Editar(DInventario Inventario)
        {
            string rpta = "";
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                //Código
                SqlCon.ConnectionString = Conexion.Cn;
                SqlCon.Open();
                //Establecer el Comando
                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandText = "UPDATE inventario SET auxiliar = @auxiliar, cod_entidad = @cod_entidad, " +
                " cod_entidad = @cod_entidad, cod_antiguo = @cod_antiguo, serie = @serie, descripcion = @descripcion, " +
                "estado = @estado, geografica = @geografica, especifica = @especifica, procedencia = @procedencia, " +
                "fecha_ingreso = @fecha_ingreso, observaciones = @observaciones, oficina_no = @oficina_no, emp_no = @emp_no, " +
                " partida_no = @parida_no WHERE inv_no = @inv_no";
                
                SqlCmd.CommandType = CommandType.Text;

                SqlCmd.Parameters.AddWithValue("@inv_no", Inventario.Inv_no);
                SqlCmd.Parameters.AddWithValue("@auxiliar", Inventario.Auxiliar);
                SqlCmd.Parameters.AddWithValue("@cod_entidad", Inventario.Cod_entidad);
                SqlCmd.Parameters.AddWithValue("@cod_antiguo", Inventario.Cod_antiguo);
                SqlCmd.Parameters.AddWithValue("@serie", Inventario.Serie);
                SqlCmd.Parameters.AddWithValue("@descripcion", Inventario.Descripcion);
                SqlCmd.Parameters.AddWithValue("@estado", Inventario.Estado);
                SqlCmd.Parameters.AddWithValue("@geografica", Inventario.Geografica);
                SqlCmd.Parameters.AddWithValue("@especifica", Inventario.Especifica);
                SqlCmd.Parameters.AddWithValue("@procedencia", Inventario.Procedencia);
                SqlCmd.Parameters.AddWithValue("@fecha_ingreso", Inventario.Fecha_ingreso);
                SqlCmd.Parameters.AddWithValue("@observaciones", Inventario.Observaciones);
                SqlCmd.Parameters.AddWithValue("@oficina_no", Inventario.Oficina_no);
                SqlCmd.Parameters.AddWithValue("@emp_no", Inventario.Emp_no);
                SqlCmd.Parameters.AddWithValue("@partida_no", Inventario.Partida_no);

                rpta = SqlCmd.ExecuteNonQuery() == 1 ? "OK" : "NO se Ingreso el Registro";
            }

            catch (Exception ex)
            {
                rpta = ex.Message;
                throw;
            }
            finally
            {
                if (SqlCon.State == ConnectionState.Open)
                {
                    SqlCon.Close();
                }
            }
            return rpta;

        }

        //Método Eliminar
        public string Eliminar(DInventario Inventario)
        {
            string rpta = "";
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                //Código
                SqlCon.ConnectionString = Conexion.Cn;
                SqlCon.Open();
                //Establecer el Comando
                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandText = "DELETE FROM inventario WHERE inv_no = @inv_no";

                SqlCmd.CommandType = CommandType.Text;
                SqlCmd.Parameters.AddWithValue("@inv_no", Inventario.Inv_no);

                /*SqlParameter ParIdcliente = new SqlParameter();
                ParIdcliente.ParameterName = "@idcliente";
                ParIdcliente.SqlDbType = SqlDbType.Int;
                ParIdcliente.Value = Cliente.Idcliente;
                SqlCmd.Parameters.Add(ParIdcliente);
                */

                //Ejecutamos nuestro comando

                rpta = SqlCmd.ExecuteNonQuery() == 1 ? "OK" : "NO se Elimino el Registro";


            }
            catch (Exception ex)
            {
                rpta = ex.Message;
            }
            finally
            {
                if (SqlCon.State == ConnectionState.Open) SqlCon.Close();
            }
            return rpta;
        }

        public DataTable Mostrar()
        {
            DataTable DtResultado = new DataTable("inventario");
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                SqlCon.ConnectionString = Conexion.Cn;
                String sql = "SELECT * FROM inventario ORDER BY "+
                " CAST(SUBSTRING(inv_no, CHARINDEX('-', inv_no) + 1, LEN(inv_no)) AS INT) ASC";
                SqlDataAdapter sda = new SqlDataAdapter(sql, SqlCon);
                
                sda.Fill(DtResultado);


            }
            catch (Exception ex)
            {
                DtResultado = null;
                
            }
            return DtResultado;

        }
    }
}

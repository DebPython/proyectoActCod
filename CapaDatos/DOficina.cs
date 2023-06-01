using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace CapaDatos
{
    public class DOficina
    {
        public DOficina() { 
        
        }

        public DataTable Mostrar()
        {
            DataTable DtResultado = new DataTable("Oficina");
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                SqlCon.ConnectionString = Conexion.Cn;
                String sql = "SELECT * FROM oficina ORDER BY "+ 
                " CAST(SUBSTRING(oficina_no, CHARINDEX('-', oficina_no) + 1, LEN(oficina_no)) AS INT) ASC";
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

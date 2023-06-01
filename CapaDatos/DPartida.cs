using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace CapaDatos
{
    public class DPartida
    {

        public DPartida() { 
        
        }

        public DataTable Mostrar()
        {
            DataTable DtResultado = new DataTable("Partida");
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                SqlCon.ConnectionString = Conexion.Cn;
                String sql = "SELECT * FROM partida ORDER BY"+ 
                " CAST(SUBSTRING(partida_no, CHARINDEX('-', partida_no) + 1, LEN(partida_no)) AS INT) ASC";
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

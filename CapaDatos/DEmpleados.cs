using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;


namespace CapaDatos
{
    public class DEmpleados
    {

        public DEmpleados()
        {
        }

        public DataTable Mostrar()
        {
            DataTable DtResultado = new DataTable("Empleados");
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                SqlCon.ConnectionString = Conexion.Cn;
                String sql = "SELECT * FROM empleados ORDER "+ 
                " BY CAST(SUBSTRING(emp_no, CHARINDEX('-', emp_no) + 1, LEN(emp_no)) AS INT) ASC";
                SqlDataAdapter sda = new SqlDataAdapter(sql, SqlCon);

                sda.Fill(DtResultado);


            }
            catch (Exception ex)
            {
                DtResultado = null;

            }
            return DtResultado;

        }

        public DataTable Buscar_Empleados(string variable, string condicion)
        {
            DataTable DtResultado = new DataTable("Empleados");
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                SqlCon.ConnectionString = Conexion.Cn;
                SqlCon.Open();

                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandText = "SELECT * FROM empleados WHERE " + condicion + " LIKE '" + variable + "%' ";
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

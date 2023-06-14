using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDatos;
using System.Data;

namespace CapaNegocio
{
    public class NUsuarios
    {
        

        public static DataTable Mostrar()
        {
            return new DUsuarios().Mostrar();
        }

        public static DataTable Mostrar_Historial()
        {
            return new DUsuarios().Mostrar_Historial();
        }

        public static DataTable Login(string usuario, string password)
        {
            DUsuarios Obj = new DUsuarios();
            Obj.Usuario = usuario;
            Obj.Passwor = password;
            return Obj.Login(Obj);

        }



        public void EjecutarProcedimiento(string parametro)
        {
            DUsuarios usu = new DUsuarios();

            usu.EjecutarProcedimientoAlmacenado(parametro);
            
        }

        public static DataTable BuscarUsuarios(string textobuscar, string condicion)
        {
            DUsuarios Obj = new DUsuarios();
            return Obj.Buscar_Usuarios(textobuscar, condicion);

        }

        public static DataTable BuscarHistorial(string textobuscar, string condicion)
        {
            DUsuarios Obj = new DUsuarios();
            return Obj.Buscar_Historial(textobuscar, condicion);

        }

        
    }
}

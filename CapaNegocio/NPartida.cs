using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDatos;
using System.Data;

namespace CapaNegocio
{
    public class NPartida
    {
        public static DataTable Mostrar()
        {
            return new DPartida().Mostrar();
        }

        public static DataTable BuscarPartida(string textobuscar, string condicion)
        {
            DPartida Obj = new DPartida();
            return Obj.Buscar_Partida(textobuscar, condicion);

        }
    }
}

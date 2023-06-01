using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDatos;
using System.Data;

namespace CapaNegocio
{
    public class NInventario
    {
        //metodo para insertar datos

        public static string Insertar(string auxiliar, string cod_entidad, string cod_antiguo,
            string serie, string descripcion, string estado, string geografica, string especifica, string procedencia,
            DateTime fecha_ingreso, string observaciones, string oficina_no, string emp_no, string partida_no)
        {
            DInventario Obj = new DInventario();

            Obj.Auxiliar = auxiliar;
            Obj.Cod_entidad = cod_entidad;
            Obj.Cod_antiguo = cod_antiguo;
            Obj.Serie = serie;
            Obj.Descripcion = descripcion;
            Obj.Estado = estado;
            Obj.Geografica = geografica;
            Obj.Especifica = especifica;
            Obj.Procedencia = procedencia;
            Obj.Fecha_ingreso = fecha_ingreso;
            Obj.Observaciones = observaciones;
            Obj.Oficina_no = oficina_no;
            Obj.Emp_no = emp_no;
            Obj.Partida_no = partida_no;
            
            return Obj.Insertar(Obj);
        
        }

        //Metdo editaar la clase dinventario
        public static string Editar(string inv_no, string auxiliar, string cod_entidad, string cod_antiguo,
            string serie, string descripcion, string estado, string geografica, string especifica, string procedencia,
            DateTime fecha_ingreso, string observaciones, string oficina_no, string emp_no, string partida_no)
        {

            DInventario Obj = new DInventario();
            Obj.Inv_no = inv_no;
            Obj.Auxiliar = auxiliar;
            Obj.Cod_entidad = cod_entidad;
            Obj.Cod_antiguo = cod_antiguo;
            Obj.Serie = serie;
            Obj.Descripcion = descripcion;
            Obj.Estado = estado;
            Obj.Geografica = geografica;
            Obj.Especifica = especifica;
            Obj.Procedencia = procedencia;
            Obj.Fecha_ingreso = fecha_ingreso;
            Obj.Observaciones = observaciones;
            Obj.Oficina_no = oficina_no;
            Obj.Emp_no = emp_no;
            Obj.Partida_no = partida_no;

            return Obj.Insertar(Obj);
        }
        public static string Eliminar(string inv_no)
        {

            DInventario Obj = new DInventario();
            
            Obj.Inv_no = inv_no;
            
            return Obj.Eliminar(Obj);
        }

        public static DataTable Mostrar()
        {
            return new DInventario().Mostrar();
        }
    }
}

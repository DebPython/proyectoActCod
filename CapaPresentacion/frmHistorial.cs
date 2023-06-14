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

namespace CapaPresentacion
{
    public partial class frmHistorial : Form
    {
        public frmHistorial()
        {
            InitializeComponent();
        }

        private void Mostrar()
        {
            this.dataHistorial.DataSource = NUsuarios.Mostrar_Historial();

            lblregistros.Text = "Total de Registros : " + Convert.ToString(dataHistorial.Rows.Count - 1);
        }

        private void buscar_changed()
        {

            string condicion = "";

            if (cboBuscar.Text.Equals("Auxiliar"))
            {
                condicion = "auxiliar";
            }
            if (cboBuscar.Text.Equals("Codigo Entidad"))
            {
                condicion = "cod_entidad";
            }
            if (cboBuscar.Text.Equals("Operación"))
            {
                condicion = "operacion";

            }

            this.dataHistorial.DataSource = NUsuarios.BuscarHistorial(this.txtBuscar.Text, condicion);

            lblregistros.Text = "Total de Registros : " + Convert.ToString(dataHistorial.Rows.Count - 1);


        }

        private void frmHistorial_Load(object sender, EventArgs e)
        {
            Mostrar();
        }

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            buscar_changed();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            buscar_changed();
        }


    }
}

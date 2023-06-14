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
    public partial class frmUsuarios : Form
    {
        public frmUsuarios()
        {
            InitializeComponent();
            Mostrar();
        }

        private void buscar_changed()
        {

            string condicion = "";

            if (cboBuscar.Text.Equals("Nombre"))
            {
                condicion = "nombre";
            }
            if (cboBuscar.Text.Equals("CI"))
            {
                condicion = "ci";
            }
            if (cboBuscar.Text.Equals("Apellido Paterno"))
            {
                condicion = "paterno";

            }

            this.dataUsuarios.DataSource = NUsuarios.BuscarUsuarios(this.txtBuscar.Text, condicion);

            lblregistros.Text = "Total de Registros : " + Convert.ToString(dataUsuarios.Rows.Count - 1);


        }

        private void frmUsuarios_Load(object sender, EventArgs e)
        {

        }

        private void Mostrar()
        {
            this.dataUsuarios.DataSource = NUsuarios.Mostrar();

            lblregistros.Text = "Total de Registros : " + Convert.ToString(dataUsuarios.Rows.Count - 1);
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

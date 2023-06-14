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
    public partial class frmPartida : Form
    {
        public frmPartida()
        {
            InitializeComponent();
            Mostrar();
        }

        private void frmPartida_Load(object sender, EventArgs e)
        {

        }
        private void buscar_changed()
        {

            string condicion = "";

            if (cboBuscar.Text.Equals("Nombre"))
            {
                condicion = "nombre";
            }
            if (cboBuscar.Text.Equals("Partida"))
            {
                condicion = "partida";
            }

            this.dataPartida.DataSource = NPartida.BuscarPartida(this.txtBuscar.Text, condicion);

            lblregistros.Text = "Total de Registros : " + Convert.ToString(dataPartida.Rows.Count - 1);


        }

        private void Mostrar()
        {
            this.dataPartida.DataSource = NPartida.Mostrar();

            lblregistros.Text = "Total de Registros : " + Convert.ToString(dataPartida.Rows.Count - 1);
        }

        private void dataPartida_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            frmInventario form = frmInventario.GetInstancia();
            string par1, par2;
            par1 = Convert.ToString(this.dataPartida.CurrentRow.Cells["partida_no"].Value);
            par2 = Convert.ToString(this.dataPartida.CurrentRow.Cells["partida"].Value);

            form.setPartida(par1, par2);
            this.Hide();
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

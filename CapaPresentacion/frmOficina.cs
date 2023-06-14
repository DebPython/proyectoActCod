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
    public partial class frmOficina : Form
    {
        public frmOficina()
        {
            InitializeComponent();
            Mostrar();
        }

        private void frmOficina_Load(object sender, EventArgs e)
        {

        }

        private void buscar_changed()
        {

            string condicion = "";

            if (cboBuscar.Text.Equals("Nombre"))
            {
                condicion = "nombre_of";
            }
            if (cboBuscar.Text.Equals("Departamento"))
            {
                condicion = "depto";
            }
            if (cboBuscar.Text.Equals("Ubicación"))
            {
                condicion = "ubicacion";

            }

            this.dataOficina.DataSource = NOficina.BuscarOficina(this.txtBuscar.Text, condicion);

            lblregistros.Text = "Total de Registros : " + Convert.ToString(dataOficina.Rows.Count - 1);


        }
        private void Mostrar()
        {
            this.dataOficina.DataSource = NOficina.Mostrar();

            lblregistros.Text = "Total de Registros : " + Convert.ToString(dataOficina.Rows.Count - 1);
        }

        private void dataOficina_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            
            frmInventario form = frmInventario.GetInstancia();
            string par1, par2;
            par1 = Convert.ToString(this.dataOficina.CurrentRow.Cells["oficina_no"].Value);
            par2 = Convert.ToString(this.dataOficina.CurrentRow.Cells["nombre_of"].Value);
           
            form.setOficina(par1, par2);
            this.Hide();
        }

        private void dataOficina_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void dataOficina_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            
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

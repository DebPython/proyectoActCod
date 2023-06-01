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
    public partial class frmEmpleados : Form
    {
        public frmEmpleados()
        {
            InitializeComponent();
            Mostrar();
        }

        private void frmEmpleados_Load(object sender, EventArgs e)
        {

        }

        private void Mostrar()
        {
            this.dataEmpleados.DataSource = NEmpleados.Mostrar();

            lblregistros.Text = "Total de Registros : " + Convert.ToString(dataEmpleados.Rows.Count - 1);
        }

        private void dataEmpleados_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            frmInventario form = frmInventario.GetInstancia();
            string par1, par2;
            par1 = Convert.ToString(this.dataEmpleados.CurrentRow.Cells["emp_no"].Value);
            par2 = Convert.ToString(this.dataEmpleados.CurrentRow.Cells["nombre"].Value);

            form.setEmpleado(par1, par2);
            this.Hide();
        }
    }
}

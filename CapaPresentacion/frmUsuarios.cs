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

        private void frmUsuarios_Load(object sender, EventArgs e)
        {

        }

        private void Mostrar()
        {
            this.dataUsuarios.DataSource = NUsuarios.Mostrar();

            lblregistros.Text = "Total de Registros : " + Convert.ToString(dataUsuarios.Rows.Count - 1);
        }
    }
}

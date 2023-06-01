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
    public partial class frmInventario : Form
    {
        public frmInventario()
        {
            InitializeComponent();
            btnGuardar.Text = "Nuevo";

            buttons_text(false, false);
            Mostrar();
        }

        private static frmInventario _Instancia;

        public static frmInventario GetInstancia()
        {
            if (_Instancia == null)
            {
                _Instancia = new frmInventario();

            }
            return _Instancia;

        }

        public void setOficina(string oficina_no, string nombre_of)
        {
            this.txtOficina_no.Text = oficina_no;
            this.txtOficina.Text = nombre_of;
        }

        public void setEmpleado(string emp_no, string nombre)
        {
            this.txtEmp_no.Text = emp_no;
            this.txtEmpleado.Text = nombre;
        }

        public void setPartida(string partida_no, string partida)
        {
            this.txtPartida_no.Text = partida_no;
            this.txtPartida.Text = partida;
        }


        public void limpiar()
        {
            txtAuxiliar.Text = "";
            txtCod_antiguo.Text = "";
            txtCod_entidad.Text = "";
            txtDescripcion.Text = "";
            txtSerie.Text = "";
            txtEstado.Text = "";
            txtGeografica.Text = "";
            txtEspecifica.Text = "";
            txtProcedencia.Text = "";
            txtObservaciones.Text = "";
            txtInv_no.Text = "";
            txtEmp_no.Text = "";
            txtBuscar.Text = "";
            txtEmpleado.Text = "";
            txtOficina.Text = "";
            txtOficina_no.Text = "";
            txtPartida.Text = "";
            txtPartida_no.Text = "";

            btnGuardar.Text = "Nuevo";
        }

        public void buttons_text(bool a, bool b)
        {
            txtAuxiliar.Enabled = a;
            txtCod_antiguo.Enabled = a;
            txtCod_entidad.Enabled = a;
            txtDescripcion.Enabled = a;
            txtSerie.Enabled = a;
            txtEstado.Enabled = a;
            txtGeografica.Enabled = a;
            txtEspecifica.Enabled = a;
            txtProcedencia.Enabled = a;
            txtObservaciones.Enabled = a;
            
            btnPartida.Enabled = a;
            btnEmpleado.Enabled = a;
            btnOficina.Enabled = a;
            

            btnEliminar.Enabled = b;
            btnModificar.Enabled = b;

        }
        private void Mostrar()
        {
            this.dataInventario.DataSource = NInventario.Mostrar();
           
            lbltotal.Text = "Total de Registros : " + Convert.ToString(dataInventario.Rows.Count - 1);
        }
        private void frmInventario_Load(object sender, EventArgs e)
        {

        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            buttons_text(true, false);
            btnGuardar.Text = "Guardar";
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            buttons_text(false, false);
            limpiar();
            btnGuardar.Enabled = true;
        }

        private void dataInventario_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            btnGuardar.Enabled = true;
            btnGuardar.Text = "Guardar";
            buttons_text(true, false);
        }

        private void dataInventario_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        
        }

        private void dataInventario_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            btnGuardar.Enabled = false;
            buttons_text(false, true);
            this.txtInv_no.Text = Convert.ToString(this.dataInventario.CurrentRow.Cells["inv_no"].Value);
            this.txtEmp_no.Text = Convert.ToString(this.dataInventario.CurrentRow.Cells["emp_no"].Value);
            this.txtOficina_no.Text = Convert.ToString(this.dataInventario.CurrentRow.Cells["oficina_no"].Value);
            this.txtPartida_no.Text = Convert.ToString(this.dataInventario.CurrentRow.Cells["partida_no"].Value);

            this.txtAuxiliar.Text = Convert.ToString(this.dataInventario.CurrentRow.Cells["auxiliar"].Value);
            this.txtCod_antiguo.Text = Convert.ToString(this.dataInventario.CurrentRow.Cells["cod_antiguo"].Value);
            this.txtCod_entidad.Text = Convert.ToString(this.dataInventario.CurrentRow.Cells["cod_entidad"].Value);
            this.txtDescripcion.Text = Convert.ToString(this.dataInventario.CurrentRow.Cells["descripcion"].Value);
            this.txtSerie.Text = Convert.ToString(this.dataInventario.CurrentRow.Cells["serie"].Value);
            this.txtEstado.Text = Convert.ToString(this.dataInventario.CurrentRow.Cells["estado"].Value);
            this.txtGeografica.Text = Convert.ToString(this.dataInventario.CurrentRow.Cells["geografica"].Value);
            this.txtEspecifica.Text = Convert.ToString(this.dataInventario.CurrentRow.Cells["especifica"].Value);
            this.txtProcedencia.Text = Convert.ToString(this.dataInventario.CurrentRow.Cells["procedencia"].Value);
            this.txtObservaciones.Text = Convert.ToString(this.dataInventario.CurrentRow.Cells["observaciones"].Value);

        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {

        }

        private void btnOficina_Click(object sender, EventArgs e)
        {
            frmOficina form = new frmOficina();
            form.ShowDialog();

        }

        private void btnEmpleado_Click(object sender, EventArgs e)
        {
            frmEmpleados form = new frmEmpleados();
            form.ShowDialog();
        }

        private void btnPartida_Click(object sender, EventArgs e)
        {
            frmPartida form = new frmPartida();
            form.ShowDialog();
        }
    }
}

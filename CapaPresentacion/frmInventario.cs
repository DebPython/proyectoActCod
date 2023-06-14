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
using System.Windows;

namespace CapaPresentacion
{
    public partial class frmInventario : Form
    {
        public frmInventario()
        {
            InitializeComponent();

            buttons_text(false, false);
            Mostrar();

            this.ttMensaje.SetToolTip(this.txtEmp_no, "Ingrese el Nombre del Empleado");
            this.ttMensaje.SetToolTip(this.txtOficina_no, "Ingrese una oficina de empleado");
            this.ttMensaje.SetToolTip(this.txtPartida_no, "Ingrese el Numero de Partida");
            this.ttMensaje.SetToolTip(this.txtSerie, "Ingrese Serie de Inventario");

            this.ttMensaje.SetToolTip(this.txtDescripcion, "Ingrese Descripcion de Inventario");
            this.ttMensaje.SetToolTip(this.txtCod_entidad, "Ingrese Codigo de entidad");
        }

        private bool IsNuevo = false;
        private bool IsEditar = false;

        private static frmInventario _Instancia = null;

        public static frmInventario GetInstancia()
        {
            if (_Instancia == null)
            {
                _Instancia = new frmInventario();

            }
            return _Instancia;

        }

        private void MensajeOk(string mensaje)
        {
            MessageBox.Show(mensaje, " Sistema de Inventario ", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private void MensajeError(string mensaje)
        {
            MessageBox.Show(mensaje, " Sistema de Inventario ", MessageBoxButtons.OK, MessageBoxIcon.Error);

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
            this.txtAsignacion.Text = "ASIG-" + emp_no;

        }

        public void setPartida(string partida_no, string partida)
        {
            this.txtPartida_no.Text = partida_no;
            this.txtPartida.Text = partida;
        }

        public void ocultar_columnas()
        {
           // this.dataInventario.Columns[14].Visible = false;
            //this.dataInventario.Columns[15].Visible = false;
           // this.dataInventario.Columns[16].Visible = false;
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
            btnGuardar.Enabled = a;
            

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

        private void buscar_changed()
        {
    
            string condicion = "";

            if(cboBuscar.Text.Equals("Auxiliar")){
                condicion = "auxiliar";    
            }
            if(cboBuscar.Text.Equals("Código Entidad")){
                condicion = "cod_entidad";
            }
            if(cboBuscar.Text.Equals("Empleado")){
                condicion = "em.ci";
            
            }
            
            this.dataInventario.DataSource = NInventario.BuscarNombre(this.txtBuscar.Text, condicion);

            lbltotal.Text = "Total de Registros : " + Convert.ToString(dataInventario.Rows.Count - 1);
        

        }
        private void frmInventario_Load(object sender, EventArgs e)
        {

        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {

                string rpta = "";

                if (this.txtEmp_no.Text == string.Empty || this.txtOficina_no.Text == string.Empty || 
                    this.txtPartida_no.Text == string.Empty || this.txtSerie.Text == string.Empty || 
                    this.txtDescripcion.Text == string.Empty || this.txtCod_entidad.Text == string.Empty)
                {
                    MensajeError("Falta Ingresar algunos datos, seran remarcados");

                    errorIcono.SetError(txtEmp_no, "Ingrese el Nombre del Empleado");
                    errorIcono.SetError(txtOficina_no, "Ingrese una oficina de empleado");
                    errorIcono.SetError(txtPartida_no, "Ingrese el Numero de Partida");
                    errorIcono.SetError(txtSerie, "Ingrese Serie de Inventario");

                    errorIcono.SetError(txtDescripcion, "Ingrese Descripcion de Inventario");
                    errorIcono.SetError(txtCod_entidad, "Ingrese Codigo de entidad");


                }
                else
                {
                    if (this.IsNuevo)
                    {
                       
                        rpta = NInventario.Insertar(this.txtAuxiliar.Text.Trim(), this.txtCod_entidad.Text.Trim(), 
                            this.txtCod_antiguo.Text.Trim(), this.txtSerie.Text.Trim(), this.txtDescripcion.Text, this.txtEstado.Text, 
                            this.txtGeografica.Text, this.txtEspecifica.Text, this.txtProcedencia.Text, this.txtObservaciones.Text,
                            this.txtOficina_no.Text, this.txtEmp_no.Text, this.txtPartida_no.Text, this.txtAsignacion.Text);

                    }
                    else
                    {
                        rpta = NInventario.Editar(this.txtInv_no.Text, this.txtAuxiliar.Text.Trim(), this.txtCod_entidad.Text.Trim(),
                            this.txtCod_antiguo.Text.Trim(), this.txtSerie.Text.Trim(), this.txtDescripcion.Text, this.txtEstado.Text,
                            this.txtGeografica.Text, this.txtEspecifica.Text, this.txtProcedencia.Text, this.txtObservaciones.Text,
                            this.txtOficina_no.Text, this.txtEmp_no.Text, this.txtPartida_no.Text, this.txtAsignacion.Text);
                    }

                    if (rpta.Equals("OK"))
                    {
                        if (this.IsNuevo)
                        {
                            this.MensajeOk("Se Inserto de Forma correcta el Registro");
                        }
                        else
                        {
                            this.MensajeOk("Se Actualizo correctamente el Registro");
                        }
                    }
                    else
                    {
                        this.MensajeError(rpta);
                    }
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);

            }


            this.IsNuevo = false;
            this.IsEditar = false;
            this.buttons_text(false, false);
            this.limpiar();
            this.Mostrar();
            btnNuevo.Enabled = true;
            txtAsignacion.Text = "ASIG-";


        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            txtAsignacion.Text = "ASIG-";
            buttons_text(false, false);
            limpiar();
            btnNuevo.Enabled = true;
        }

        private void dataInventario_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            if (!this.txtInv_no.Text.Equals(""))
            {
                this.IsEditar = true;
                btnGuardar.Enabled = true;
                btnNuevo.Enabled = false;
                buttons_text(true, false);
            }
            else
            {
                this.MensajeError("Debe de seleccionar primero el registro a Modificar");
            }
           
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
            this.txtAsignacion.Text = Convert.ToString(this.dataInventario.CurrentRow.Cells["asignacion"].Value);
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            string rpta = "";
            if (this.txtInv_no.Text != string.Empty)
            {
                DialogResult result = MessageBox.Show("¿Estás seguro de Eliminar el registro "+txtInv_no.Text+"?", 
                    "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    rpta = NInventario.Eliminar(txtInv_no.Text);
                    if (rpta.Equals("OK"))
                    {
                        this.MensajeOk("Se Elimino el registro correctamente..!");
                        this.IsNuevo = false;
                        this.IsEditar = false;
                        this.buttons_text(false, false);
                        this.limpiar();
                        this.Mostrar();
                        btnNuevo.Enabled = true;
                        txtAsignacion.Text = "ASIG-";
                    }
                }
            }
            else
            {
                MensajeError("Seleccione un Registro para Eliminar");
            }


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

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            
            this.buscar_changed();

        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            this.buscar_changed();
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            this.IsEditar = false;
            this.IsNuevo = true;
            buttons_text(true, false);
            txtAsignacion.Text = "ASIG-";
            btnNuevo.Enabled = false;
        }

        private void frmInventario_FormClosing(object sender, FormClosingEventArgs e)
        {
            _Instancia = null;
        }
    }
}

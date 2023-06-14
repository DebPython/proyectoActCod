using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaPresentacion
{
    public partial class mdiPresentacion : Form
    {
        private int childFormNumber = 0;

        public string usuario_no = "";
        public string Apellidos = "";
        public string Nombre = "";
        public string Acceso = "";

        public mdiPresentacion()
        {
            InitializeComponent();
        }

        private void ShowNewForm(object sender, EventArgs e)
        {
            Form childForm = new Form();
            childForm.MdiParent = this;
            childForm.Text = "Ventana " + childFormNumber++;
            childForm.Show();
        }

        private void OpenFile(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            openFileDialog.Filter = "Archivos de texto (*.txt)|*.txt|Todos los archivos (*.*)|*.*";
            if (openFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                string FileName = openFileDialog.FileName;
            }
        }

        private void SaveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            saveFileDialog.Filter = "Archivos de texto (*.txt)|*.txt|Todos los archivos (*.*)|*.*";
            if (saveFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                string FileName = saveFileDialog.FileName;
            }
        }

        private void ExitToolsStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CutToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void CopyToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void PasteToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

       
        private void CascadeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.Cascade);
        }

        private void TileVerticalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileVertical);
        }

        private void TileHorizontalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileHorizontal);
        }

        private void ArrangeIconsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.ArrangeIcons);
        }

        private void CloseAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form childForm in MdiChildren)
            {
                childForm.Close();
            }
        }

        

        private void oficinaToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmOficina frm = new frmOficina();
            frm.MdiParent = this;
            frm.Show();
        }

        private void empleadosToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            frmEmpleados frm = new frmEmpleados();
            frm.MdiParent = this;
            frm.Show();
        }

        private void partidaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmPartida frm = new frmPartida();
            frm.MdiParent = this;
            frm.Show();
        }

        private void inventarioToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmInventario frm = frmInventario.GetInstancia();
            frm.MdiParent = this;
            frm.Show();
            frm.BringToFront();

        }

        private void usuariosToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmUsuarios frm = new frmUsuarios();
            frm.MdiParent = this;
            frm.Show();
        }

        private void mdiPresentacion_Load(object sender, EventArgs e)
        {
            lblUsuarioNo.Text = usuario_no;
            lblNombre.Text = Nombre + " " + Apellidos;
            lblAcceso.Text = Acceso;
            Gestion_Usuario();
        }

        private void historialToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmHistorial frm = new frmHistorial();
            frm.MdiParent = this;
            frm.Show();
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Gestion_Usuario()
        {
            if (Acceso == "Admin"){
                mmuSistema.Enabled = true;
                mmuEmpresa.Enabled = true;
                mmuInventario.Enabled = true;
                mmuUsuarios.Enabled = true;
                mmuHistorialInventario.Enabled = true;
                mmuAyuda.Enabled = true;
            }
            if(Acceso == "Pasante"){
                mmuSistema.Enabled = true;
                mmuEmpresa.Enabled = true;
                mmuInventario.Enabled = true;
                mmuUsuarios.Enabled = false;
                mmuHistorialInventario.Enabled = false;
                mmuAyuda.Enabled = true;
            }
            if(Acceso == "Ingeniero"){

                mmuSistema.Enabled = true;
                mmuEmpresa.Enabled = true;
                mmuInventario.Enabled = true;
                mmuUsuarios.Enabled = true;
                mmuHistorialInventario.Enabled = false;
                mmuAyuda.Enabled = true;
            }
        }

        private void mdiPresentacion_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}

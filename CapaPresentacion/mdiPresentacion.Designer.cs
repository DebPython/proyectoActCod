namespace CapaPresentacion
{
    partial class mdiPresentacion
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben eliminar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.mmuEmpresa = new System.Windows.Forms.ToolStripMenuItem();
            this.oficinaToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.empleadosToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.partidaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mmuInventario = new System.Windows.Forms.ToolStripMenuItem();
            this.inventarioToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.mmuUsuarios = new System.Windows.Forms.ToolStripMenuItem();
            this.usuariosToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.mmuHistorialInventario = new System.Windows.Forms.ToolStripMenuItem();
            this.historialToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mmuAyuda = new System.Windows.Forms.ToolStripMenuItem();
            this.asistenciaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mmuSistema = new System.Windows.Forms.ToolStripMenuItem();
            this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.lblUsuarioNo = new System.Windows.Forms.ToolStripStatusLabel();
            this.lblNombre = new System.Windows.Forms.ToolStripStatusLabel();
            this.lblAcceso = new System.Windows.Forms.ToolStripStatusLabel();
            this.menuStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mmuSistema,
            this.mmuEmpresa,
            this.mmuInventario,
            this.mmuUsuarios,
            this.mmuHistorialInventario,
            this.mmuAyuda});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(632, 24);
            this.menuStrip1.TabIndex = 4;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // mmuEmpresa
            // 
            this.mmuEmpresa.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.oficinaToolStripMenuItem1,
            this.empleadosToolStripMenuItem2,
            this.partidaToolStripMenuItem});
            this.mmuEmpresa.Name = "mmuEmpresa";
            this.mmuEmpresa.Size = new System.Drawing.Size(64, 20);
            this.mmuEmpresa.Text = "&Empresa";
            // 
            // oficinaToolStripMenuItem1
            // 
            this.oficinaToolStripMenuItem1.Name = "oficinaToolStripMenuItem1";
            this.oficinaToolStripMenuItem1.Size = new System.Drawing.Size(152, 22);
            this.oficinaToolStripMenuItem1.Text = "Oficinas";
            this.oficinaToolStripMenuItem1.Click += new System.EventHandler(this.oficinaToolStripMenuItem1_Click);
            // 
            // empleadosToolStripMenuItem2
            // 
            this.empleadosToolStripMenuItem2.Name = "empleadosToolStripMenuItem2";
            this.empleadosToolStripMenuItem2.Size = new System.Drawing.Size(152, 22);
            this.empleadosToolStripMenuItem2.Text = "Empleados";
            this.empleadosToolStripMenuItem2.Click += new System.EventHandler(this.empleadosToolStripMenuItem2_Click);
            // 
            // partidaToolStripMenuItem
            // 
            this.partidaToolStripMenuItem.Name = "partidaToolStripMenuItem";
            this.partidaToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.partidaToolStripMenuItem.Text = "Partidas";
            this.partidaToolStripMenuItem.Click += new System.EventHandler(this.partidaToolStripMenuItem_Click);
            // 
            // mmuInventario
            // 
            this.mmuInventario.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.inventarioToolStripMenuItem1});
            this.mmuInventario.Name = "mmuInventario";
            this.mmuInventario.Size = new System.Drawing.Size(72, 20);
            this.mmuInventario.Text = "&Inventario";
            // 
            // inventarioToolStripMenuItem1
            // 
            this.inventarioToolStripMenuItem1.Name = "inventarioToolStripMenuItem1";
            this.inventarioToolStripMenuItem1.Size = new System.Drawing.Size(152, 22);
            this.inventarioToolStripMenuItem1.Text = "Inventario";
            this.inventarioToolStripMenuItem1.Click += new System.EventHandler(this.inventarioToolStripMenuItem1_Click);
            // 
            // mmuUsuarios
            // 
            this.mmuUsuarios.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.usuariosToolStripMenuItem1});
            this.mmuUsuarios.Name = "mmuUsuarios";
            this.mmuUsuarios.Size = new System.Drawing.Size(64, 20);
            this.mmuUsuarios.Text = "&Usuarios";
            // 
            // usuariosToolStripMenuItem1
            // 
            this.usuariosToolStripMenuItem1.Name = "usuariosToolStripMenuItem1";
            this.usuariosToolStripMenuItem1.Size = new System.Drawing.Size(152, 22);
            this.usuariosToolStripMenuItem1.Text = "Usuarios";
            this.usuariosToolStripMenuItem1.Click += new System.EventHandler(this.usuariosToolStripMenuItem1_Click);
            // 
            // mmuHistorialInventario
            // 
            this.mmuHistorialInventario.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.historialToolStripMenuItem});
            this.mmuHistorialInventario.Name = "mmuHistorialInventario";
            this.mmuHistorialInventario.Size = new System.Drawing.Size(119, 20);
            this.mmuHistorialInventario.Text = "&Historial Inventario";
            // 
            // historialToolStripMenuItem
            // 
            this.historialToolStripMenuItem.Name = "historialToolStripMenuItem";
            this.historialToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.historialToolStripMenuItem.Text = "historial";
            this.historialToolStripMenuItem.Click += new System.EventHandler(this.historialToolStripMenuItem_Click);
            // 
            // mmuAyuda
            // 
            this.mmuAyuda.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.asistenciaToolStripMenuItem});
            this.mmuAyuda.Name = "mmuAyuda";
            this.mmuAyuda.Size = new System.Drawing.Size(53, 20);
            this.mmuAyuda.Text = "&Ayuda";
            // 
            // asistenciaToolStripMenuItem
            // 
            this.asistenciaToolStripMenuItem.Name = "asistenciaToolStripMenuItem";
            this.asistenciaToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.asistenciaToolStripMenuItem.Text = "Asistencia";
            // 
            // mmuSistema
            // 
            this.mmuSistema.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.salirToolStripMenuItem});
            this.mmuSistema.Name = "mmuSistema";
            this.mmuSistema.Size = new System.Drawing.Size(60, 20);
            this.mmuSistema.Text = "&Sistema";
            // 
            // salirToolStripMenuItem
            // 
            this.salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            this.salirToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.salirToolStripMenuItem.Text = "Salir";
            this.salirToolStripMenuItem.Click += new System.EventHandler(this.salirToolStripMenuItem_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lblUsuarioNo,
            this.lblNombre,
            this.lblAcceso});
            this.statusStrip1.Location = new System.Drawing.Point(0, 459);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(632, 22);
            this.statusStrip1.TabIndex = 10;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // lblUsuarioNo
            // 
            this.lblUsuarioNo.Name = "lblUsuarioNo";
            this.lblUsuarioNo.Size = new System.Drawing.Size(88, 17);
            this.lblUsuarioNo.Text = "labelUsuarioNo";
            // 
            // lblNombre
            // 
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(64, 17);
            this.lblNombre.Text = "lblNombre";
            // 
            // lblAcceso
            // 
            this.lblAcceso.Name = "lblAcceso";
            this.lblAcceso.Size = new System.Drawing.Size(58, 17);
            this.lblAcceso.Text = "lblAcceso";
            // 
            // mdiPresentacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(632, 481);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.Name = "mdiPresentacion";
            this.Text = "mdiPresentacion";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.mdiPresentacion_FormClosing);
            this.Load += new System.EventHandler(this.mdiPresentacion_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem mmuEmpresa;
        private System.Windows.Forms.ToolStripMenuItem oficinaToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem mmuInventario;
        private System.Windows.Forms.ToolStripMenuItem inventarioToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem mmuUsuarios;
        private System.Windows.Forms.ToolStripMenuItem usuariosToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem mmuHistorialInventario;
        private System.Windows.Forms.ToolStripMenuItem historialToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mmuAyuda;
        private System.Windows.Forms.ToolStripMenuItem asistenciaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem empleadosToolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem partidaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mmuSistema;
        private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel lblUsuarioNo;
        private System.Windows.Forms.ToolStripStatusLabel lblNombre;
        private System.Windows.Forms.ToolStripStatusLabel lblAcceso;

    }
}




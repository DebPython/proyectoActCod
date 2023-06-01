namespace CapaPresentacion
{
    partial class frmInventario
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dataInventario = new System.Windows.Forms.DataGridView();
            this.lbltotal = new System.Windows.Forms.Label();
            this.txtBuscar = new System.Windows.Forms.TextBox();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.cboBuscar = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtInv_no = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtCod_entidad = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtAuxiliar = new System.Windows.Forms.TextBox();
            this.txtSerie = new System.Windows.Forms.TextBox();
            this.txtCod_antiguo = new System.Windows.Forms.TextBox();
            this.txtDescripcion = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txtEmpleado = new System.Windows.Forms.TextBox();
            this.txtEmp_no = new System.Windows.Forms.TextBox();
            this.txtOficina = new System.Windows.Forms.TextBox();
            this.txtOficina_no = new System.Windows.Forms.TextBox();
            this.txtPartida = new System.Windows.Forms.TextBox();
            this.txtPartida_no = new System.Windows.Forms.TextBox();
            this.btnEmpleado = new System.Windows.Forms.Button();
            this.btnOficina = new System.Windows.Forms.Button();
            this.btnPartida = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.txtEstado = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txtGeografica = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.txtEspecifica = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.txtProcedencia = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.txtObservaciones = new System.Windows.Forms.TextBox();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnModificar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.dtFecha_Ingreso = new System.Windows.Forms.DateTimePicker();
            this.label14 = new System.Windows.Forms.Label();
            this.btnCancel = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataInventario)).BeginInit();
            this.SuspendLayout();
            // 
            // dataInventario
            // 
            this.dataInventario.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataInventario.Location = new System.Drawing.Point(638, 51);
            this.dataInventario.Name = "dataInventario";
            this.dataInventario.ReadOnly = true;
            this.dataInventario.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataInventario.Size = new System.Drawing.Size(602, 391);
            this.dataInventario.TabIndex = 0;
            this.dataInventario.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataInventario_CellClick);
            this.dataInventario.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataInventario_CellContentClick);
            this.dataInventario.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataInventario_CellContentDoubleClick);
            // 
            // lbltotal
            // 
            this.lbltotal.AutoSize = true;
            this.lbltotal.Location = new System.Drawing.Point(635, 461);
            this.lbltotal.Name = "lbltotal";
            this.lbltotal.Size = new System.Drawing.Size(35, 13);
            this.lbltotal.TabIndex = 1;
            this.lbltotal.Text = "label1";
            // 
            // txtBuscar
            // 
            this.txtBuscar.Location = new System.Drawing.Point(794, 23);
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.Size = new System.Drawing.Size(135, 20);
            this.txtBuscar.TabIndex = 2;
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(961, 21);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(75, 23);
            this.btnBuscar.TabIndex = 3;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            // 
            // cboBuscar
            // 
            this.cboBuscar.FormattingEnabled = true;
            this.cboBuscar.Location = new System.Drawing.Point(638, 23);
            this.cboBuscar.Name = "cboBuscar";
            this.cboBuscar.Size = new System.Drawing.Size(141, 21);
            this.cboBuscar.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Número Inventario";
            // 
            // txtInv_no
            // 
            this.txtInv_no.BackColor = System.Drawing.Color.BurlyWood;
            this.txtInv_no.Enabled = false;
            this.txtInv_no.Location = new System.Drawing.Point(112, 46);
            this.txtInv_no.Name = "txtInv_no";
            this.txtInv_no.Size = new System.Drawing.Size(172, 20);
            this.txtInv_no.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(305, 131);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Código Entidad";
            // 
            // txtCod_entidad
            // 
            this.txtCod_entidad.BackColor = System.Drawing.Color.BurlyWood;
            this.txtCod_entidad.Location = new System.Drawing.Point(390, 128);
            this.txtCod_entidad.Name = "txtCod_entidad";
            this.txtCod_entidad.Size = new System.Drawing.Size(179, 20);
            this.txtCod_entidad.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(65, 134);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Auxiliar";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(350, 174);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(31, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Serie";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(27, 174);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(79, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Código Antiguo";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(40, 202);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(63, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "Descripción";
            // 
            // txtAuxiliar
            // 
            this.txtAuxiliar.BackColor = System.Drawing.Color.BurlyWood;
            this.txtAuxiliar.Location = new System.Drawing.Point(112, 131);
            this.txtAuxiliar.Name = "txtAuxiliar";
            this.txtAuxiliar.Size = new System.Drawing.Size(172, 20);
            this.txtAuxiliar.TabIndex = 13;
            // 
            // txtSerie
            // 
            this.txtSerie.BackColor = System.Drawing.Color.BurlyWood;
            this.txtSerie.Location = new System.Drawing.Point(390, 171);
            this.txtSerie.Name = "txtSerie";
            this.txtSerie.Size = new System.Drawing.Size(179, 20);
            this.txtSerie.TabIndex = 14;
            // 
            // txtCod_antiguo
            // 
            this.txtCod_antiguo.BackColor = System.Drawing.Color.BurlyWood;
            this.txtCod_antiguo.Location = new System.Drawing.Point(112, 171);
            this.txtCod_antiguo.Name = "txtCod_antiguo";
            this.txtCod_antiguo.Size = new System.Drawing.Size(172, 20);
            this.txtCod_antiguo.TabIndex = 15;
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.BackColor = System.Drawing.Color.BurlyWood;
            this.txtDescripcion.Location = new System.Drawing.Point(112, 202);
            this.txtDescripcion.Multiline = true;
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtDescripcion.Size = new System.Drawing.Size(172, 75);
            this.txtDescripcion.TabIndex = 16;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(341, 46);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(40, 13);
            this.label7.TabIndex = 17;
            this.label7.Text = "Oficina";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(52, 88);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(54, 13);
            this.label8.TabIndex = 18;
            this.label8.Text = "Empleado";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(341, 91);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(40, 13);
            this.label9.TabIndex = 19;
            this.label9.Text = "Partida";
            // 
            // txtEmpleado
            // 
            this.txtEmpleado.BackColor = System.Drawing.Color.BurlyWood;
            this.txtEmpleado.Enabled = false;
            this.txtEmpleado.Location = new System.Drawing.Point(112, 88);
            this.txtEmpleado.Name = "txtEmpleado";
            this.txtEmpleado.Size = new System.Drawing.Size(114, 20);
            this.txtEmpleado.TabIndex = 20;
            // 
            // txtEmp_no
            // 
            this.txtEmp_no.BackColor = System.Drawing.Color.BurlyWood;
            this.txtEmp_no.Enabled = false;
            this.txtEmp_no.Location = new System.Drawing.Point(232, 88);
            this.txtEmp_no.Name = "txtEmp_no";
            this.txtEmp_no.Size = new System.Drawing.Size(52, 20);
            this.txtEmp_no.TabIndex = 21;
            // 
            // txtOficina
            // 
            this.txtOficina.BackColor = System.Drawing.Color.BurlyWood;
            this.txtOficina.Enabled = false;
            this.txtOficina.Location = new System.Drawing.Point(390, 46);
            this.txtOficina.Name = "txtOficina";
            this.txtOficina.Size = new System.Drawing.Size(127, 20);
            this.txtOficina.TabIndex = 22;
            // 
            // txtOficina_no
            // 
            this.txtOficina_no.BackColor = System.Drawing.Color.BurlyWood;
            this.txtOficina_no.Enabled = false;
            this.txtOficina_no.Location = new System.Drawing.Point(523, 46);
            this.txtOficina_no.Name = "txtOficina_no";
            this.txtOficina_no.Size = new System.Drawing.Size(46, 20);
            this.txtOficina_no.TabIndex = 23;
            // 
            // txtPartida
            // 
            this.txtPartida.BackColor = System.Drawing.Color.BurlyWood;
            this.txtPartida.Enabled = false;
            this.txtPartida.Location = new System.Drawing.Point(390, 87);
            this.txtPartida.Name = "txtPartida";
            this.txtPartida.Size = new System.Drawing.Size(127, 20);
            this.txtPartida.TabIndex = 24;
            // 
            // txtPartida_no
            // 
            this.txtPartida_no.BackColor = System.Drawing.Color.BurlyWood;
            this.txtPartida_no.Enabled = false;
            this.txtPartida_no.Location = new System.Drawing.Point(524, 87);
            this.txtPartida_no.Name = "txtPartida_no";
            this.txtPartida_no.Size = new System.Drawing.Size(45, 20);
            this.txtPartida_no.TabIndex = 25;
            // 
            // btnEmpleado
            // 
            this.btnEmpleado.Location = new System.Drawing.Point(290, 87);
            this.btnEmpleado.Name = "btnEmpleado";
            this.btnEmpleado.Size = new System.Drawing.Size(34, 23);
            this.btnEmpleado.TabIndex = 26;
            this.btnEmpleado.Text = "...";
            this.btnEmpleado.UseVisualStyleBackColor = true;
            this.btnEmpleado.Click += new System.EventHandler(this.btnEmpleado_Click);
            // 
            // btnOficina
            // 
            this.btnOficina.Location = new System.Drawing.Point(576, 46);
            this.btnOficina.Name = "btnOficina";
            this.btnOficina.Size = new System.Drawing.Size(36, 20);
            this.btnOficina.TabIndex = 27;
            this.btnOficina.Text = "..";
            this.btnOficina.UseVisualStyleBackColor = true;
            this.btnOficina.Click += new System.EventHandler(this.btnOficina_Click);
            // 
            // btnPartida
            // 
            this.btnPartida.Location = new System.Drawing.Point(576, 85);
            this.btnPartida.Name = "btnPartida";
            this.btnPartida.Size = new System.Drawing.Size(36, 23);
            this.btnPartida.TabIndex = 28;
            this.btnPartida.Text = "...";
            this.btnPartida.UseVisualStyleBackColor = true;
            this.btnPartida.Click += new System.EventHandler(this.btnPartida_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(344, 214);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(40, 13);
            this.label10.TabIndex = 29;
            this.label10.Text = "Estado";
            // 
            // txtEstado
            // 
            this.txtEstado.BackColor = System.Drawing.Color.BurlyWood;
            this.txtEstado.Location = new System.Drawing.Point(390, 211);
            this.txtEstado.Name = "txtEstado";
            this.txtEstado.Size = new System.Drawing.Size(179, 20);
            this.txtEstado.TabIndex = 30;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(325, 260);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(59, 13);
            this.label11.TabIndex = 31;
            this.label11.Text = "Geografica";
            // 
            // txtGeografica
            // 
            this.txtGeografica.BackColor = System.Drawing.Color.BurlyWood;
            this.txtGeografica.Location = new System.Drawing.Point(390, 257);
            this.txtGeografica.Name = "txtGeografica";
            this.txtGeografica.Size = new System.Drawing.Size(179, 20);
            this.txtGeografica.TabIndex = 32;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(47, 299);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(58, 13);
            this.label12.TabIndex = 33;
            this.label12.Text = "Específica";
            // 
            // txtEspecifica
            // 
            this.txtEspecifica.BackColor = System.Drawing.Color.BurlyWood;
            this.txtEspecifica.Location = new System.Drawing.Point(112, 296);
            this.txtEspecifica.Name = "txtEspecifica";
            this.txtEspecifica.Size = new System.Drawing.Size(172, 20);
            this.txtEspecifica.TabIndex = 34;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(314, 299);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(67, 13);
            this.label13.TabIndex = 35;
            this.label13.Text = "Procedencia";
            // 
            // txtProcedencia
            // 
            this.txtProcedencia.BackColor = System.Drawing.Color.BurlyWood;
            this.txtProcedencia.Location = new System.Drawing.Point(390, 299);
            this.txtProcedencia.Name = "txtProcedencia";
            this.txtProcedencia.Size = new System.Drawing.Size(179, 20);
            this.txtProcedencia.TabIndex = 36;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(306, 345);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(78, 13);
            this.label15.TabIndex = 40;
            this.label15.Text = "Observaciones";
            // 
            // txtObservaciones
            // 
            this.txtObservaciones.BackColor = System.Drawing.Color.BurlyWood;
            this.txtObservaciones.Location = new System.Drawing.Point(390, 342);
            this.txtObservaciones.Multiline = true;
            this.txtObservaciones.Name = "txtObservaciones";
            this.txtObservaciones.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtObservaciones.Size = new System.Drawing.Size(179, 57);
            this.txtObservaciones.TabIndex = 41;
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(129, 419);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(75, 23);
            this.btnGuardar.TabIndex = 42;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // btnModificar
            // 
            this.btnModificar.Location = new System.Drawing.Point(249, 419);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(75, 23);
            this.btnModificar.TabIndex = 43;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.UseVisualStyleBackColor = true;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(372, 419);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(75, 23);
            this.btnEliminar.TabIndex = 44;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // dtFecha_Ingreso
            // 
            this.dtFecha_Ingreso.CalendarMonthBackground = System.Drawing.Color.White;
            this.dtFecha_Ingreso.Enabled = false;
            this.dtFecha_Ingreso.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtFecha_Ingreso.Location = new System.Drawing.Point(112, 345);
            this.dtFecha_Ingreso.Name = "dtFecha_Ingreso";
            this.dtFecha_Ingreso.Size = new System.Drawing.Size(172, 20);
            this.dtFecha_Ingreso.TabIndex = 45;
            this.dtFecha_Ingreso.Value = new System.DateTime(2023, 6, 1, 0, 0, 0, 0);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(31, 351);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(75, 13);
            this.label14.TabIndex = 46;
            this.label14.Text = "Fecha Ingreso";
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(470, 419);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 47;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // frmInventario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1252, 483);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.dtFecha_Ingreso);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnModificar);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.txtObservaciones);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.txtProcedencia);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.txtEspecifica);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.txtGeografica);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.txtEstado);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.btnPartida);
            this.Controls.Add(this.btnOficina);
            this.Controls.Add(this.btnEmpleado);
            this.Controls.Add(this.txtPartida_no);
            this.Controls.Add(this.txtPartida);
            this.Controls.Add(this.txtOficina_no);
            this.Controls.Add(this.txtOficina);
            this.Controls.Add(this.txtEmp_no);
            this.Controls.Add(this.txtEmpleado);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtDescripcion);
            this.Controls.Add(this.txtCod_antiguo);
            this.Controls.Add(this.txtSerie);
            this.Controls.Add(this.txtAuxiliar);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtCod_entidad);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtInv_no);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cboBuscar);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.txtBuscar);
            this.Controls.Add(this.lbltotal);
            this.Controls.Add(this.dataInventario);
            this.Name = "frmInventario";
            this.Text = "frmInventario";
            this.Load += new System.EventHandler(this.frmInventario_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataInventario)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataInventario;
        private System.Windows.Forms.Label lbltotal;
        private System.Windows.Forms.TextBox txtBuscar;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.ComboBox cboBuscar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtInv_no;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtCod_entidad;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtAuxiliar;
        private System.Windows.Forms.TextBox txtSerie;
        private System.Windows.Forms.TextBox txtCod_antiguo;
        private System.Windows.Forms.TextBox txtDescripcion;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btnEmpleado;
        private System.Windows.Forms.Button btnOficina;
        private System.Windows.Forms.Button btnPartida;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtEstado;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtGeografica;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtEspecifica;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txtProcedencia;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox txtObservaciones;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.DateTimePicker dtFecha_Ingreso;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Button btnCancel;
        protected internal System.Windows.Forms.TextBox txtEmpleado;
        protected internal System.Windows.Forms.TextBox txtEmp_no;
        protected internal System.Windows.Forms.TextBox txtPartida;
        protected internal System.Windows.Forms.TextBox txtPartida_no;
        public System.Windows.Forms.TextBox txtOficina;
        public System.Windows.Forms.TextBox txtOficina_no;
    }
}
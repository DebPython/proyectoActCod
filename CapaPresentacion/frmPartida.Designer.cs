namespace CapaPresentacion
{
    partial class frmPartida
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
            this.btnBuscar = new System.Windows.Forms.Button();
            this.txtBuscar = new System.Windows.Forms.TextBox();
            this.cboBuscar = new System.Windows.Forms.ComboBox();
            this.lblregistros = new System.Windows.Forms.Label();
            this.dataPartida = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataPartida)).BeginInit();
            this.SuspendLayout();
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(414, 34);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(75, 23);
            this.btnBuscar.TabIndex = 9;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            // 
            // txtBuscar
            // 
            this.txtBuscar.Location = new System.Drawing.Point(235, 34);
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.Size = new System.Drawing.Size(152, 20);
            this.txtBuscar.TabIndex = 8;
            // 
            // cboBuscar
            // 
            this.cboBuscar.FormattingEnabled = true;
            this.cboBuscar.Location = new System.Drawing.Point(46, 34);
            this.cboBuscar.Name = "cboBuscar";
            this.cboBuscar.Size = new System.Drawing.Size(158, 21);
            this.cboBuscar.TabIndex = 7;
            // 
            // lblregistros
            // 
            this.lblregistros.AutoSize = true;
            this.lblregistros.Location = new System.Drawing.Point(43, 398);
            this.lblregistros.Name = "lblregistros";
            this.lblregistros.Size = new System.Drawing.Size(35, 13);
            this.lblregistros.TabIndex = 6;
            this.lblregistros.Text = "label1";
            // 
            // dataPartida
            // 
            this.dataPartida.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataPartida.Location = new System.Drawing.Point(46, 77);
            this.dataPartida.Name = "dataPartida";
            this.dataPartida.ReadOnly = true;
            this.dataPartida.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataPartida.Size = new System.Drawing.Size(661, 306);
            this.dataPartida.TabIndex = 5;
            this.dataPartida.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataPartida_CellDoubleClick);
            // 
            // frmPartida
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(772, 422);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.txtBuscar);
            this.Controls.Add(this.cboBuscar);
            this.Controls.Add(this.lblregistros);
            this.Controls.Add(this.dataPartida);
            this.Name = "frmPartida";
            this.Text = "frmPartida";
            this.Load += new System.EventHandler(this.frmPartida_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataPartida)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.TextBox txtBuscar;
        private System.Windows.Forms.ComboBox cboBuscar;
        private System.Windows.Forms.Label lblregistros;
        private System.Windows.Forms.DataGridView dataPartida;
    }
}
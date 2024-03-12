namespace Pantallas_Sistema_facturacion
{
    partial class frmListaFacturas
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
            this.btnSalir = new MaterialSkin.Controls.MaterialRaisedButton();
            this.btnNuevo = new MaterialSkin.Controls.MaterialRaisedButton();
            this.btnBuscar = new MaterialSkin.Controls.MaterialRaisedButton();
            this.txtBuscar = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.lblTitulo = new MaterialSkin.Controls.MaterialLabel();
            this.dgFactura = new System.Windows.Forms.DataGridView();
            this.Id_Factura = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DtmFecha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IdCliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IdEmpleado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NumDescuento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NumImpuesto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NumValorTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IdEstado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DtmFechaModifica = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StrUsuarioModifica = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnEditar = new System.Windows.Forms.DataGridViewButtonColumn();
            this.btnBorrar = new System.Windows.Forms.DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgFactura)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSalir
            // 
            this.btnSalir.Depth = 0;
            this.btnSalir.Location = new System.Drawing.Point(867, 521);
            this.btnSalir.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Primary = true;
            this.btnSalir.Size = new System.Drawing.Size(117, 37);
            this.btnSalir.TabIndex = 11;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // btnNuevo
            // 
            this.btnNuevo.Depth = 0;
            this.btnNuevo.Location = new System.Drawing.Point(867, 90);
            this.btnNuevo.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Primary = true;
            this.btnNuevo.Size = new System.Drawing.Size(117, 37);
            this.btnNuevo.TabIndex = 10;
            this.btnNuevo.Text = "Nuevo";
            this.btnNuevo.UseVisualStyleBackColor = true;
            this.btnNuevo.Click += new System.EventHandler(this.btnNuevo_Click);
            // 
            // btnBuscar
            // 
            this.btnBuscar.Depth = 0;
            this.btnBuscar.Location = new System.Drawing.Point(714, 90);
            this.btnBuscar.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Primary = true;
            this.btnBuscar.Size = new System.Drawing.Size(117, 37);
            this.btnBuscar.TabIndex = 9;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;

            // 
            // txtBuscar
            // 
            this.txtBuscar.Depth = 0;
            this.txtBuscar.Hint = "Buscar por Factura";
            this.txtBuscar.Location = new System.Drawing.Point(27, 104);
            this.txtBuscar.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.PasswordChar = '\0';
            this.txtBuscar.SelectedText = "";
            this.txtBuscar.SelectionLength = 0;
            this.txtBuscar.SelectionStart = 0;
            this.txtBuscar.Size = new System.Drawing.Size(652, 23);
            this.txtBuscar.TabIndex = 8;
            this.txtBuscar.UseSystemPasswordChar = false;
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Depth = 0;
            this.lblTitulo.Font = new System.Drawing.Font("Roboto", 11F);
            this.lblTitulo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblTitulo.Location = new System.Drawing.Point(397, 38);
            this.lblTitulo.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(225, 19);
            this.lblTitulo.TabIndex = 7;
            this.lblTitulo.Text = "AMINISTRACION DE FACTURAS";
            this.lblTitulo.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // dgFactura
            // 
            this.dgFactura.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgFactura.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id_Factura,
            this.DtmFecha,
            this.IdCliente,
            this.IdEmpleado,
            this.NumDescuento,
            this.NumImpuesto,
            this.NumValorTotal,
            this.IdEstado,
            this.DtmFechaModifica,
            this.StrUsuarioModifica,
            this.btnEditar,
            this.btnBorrar});
            this.dgFactura.Location = new System.Drawing.Point(33, 137);
            this.dgFactura.Name = "dgFactura";
            this.dgFactura.Size = new System.Drawing.Size(950, 375);
            this.dgFactura.TabIndex = 12;
            // 
            // Id_Factura
            // 
            this.Id_Factura.HeaderText = "NRO.DE FACTURA";
            this.Id_Factura.Name = "Id_Factura";
            this.Id_Factura.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Id_Factura.Width = 104;
            // 
            // DtmFecha
            // 
            this.DtmFecha.HeaderText = "FECHA";
            this.DtmFecha.Name = "DtmFecha";
            // 
            // IdCliente
            // 
            this.IdCliente.HeaderText = "CLIENTE";
            this.IdCliente.Name = "IdCliente";
            // 
            // IdEmpleado
            // 
            this.IdEmpleado.HeaderText = "EMPLEADO";
            this.IdEmpleado.Name = "IdEmpleado";
            // 
            // NumDescuento
            // 
            this.NumDescuento.HeaderText = "DESCUENTO";
            this.NumDescuento.Name = "NumDescuento";
            // 
            // NumImpuesto
            // 
            this.NumImpuesto.HeaderText = "IMPUESTO";
            this.NumImpuesto.Name = "NumImpuesto";
            // 
            // NumValorTotal
            // 
            this.NumValorTotal.HeaderText = "TOTAL";
            this.NumValorTotal.Name = "NumValorTotal";
            // 
            // IdEstado
            // 
            this.IdEstado.HeaderText = "ESTADO";
            this.IdEstado.Name = "IdEstado";
            // 
            // DtmFechaModifica
            // 
            this.DtmFechaModifica.HeaderText = "FECHA DE MODIFICACION";
            this.DtmFechaModifica.Name = "DtmFechaModifica";
            // 
            // StrUsuarioModifica
            // 
            this.StrUsuarioModifica.HeaderText = "MODIFICO";
            this.StrUsuarioModifica.Name = "StrUsuarioModifica";
            // 
            // btnEditar
            // 
            this.btnEditar.HeaderText = "EDITAR";
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.btnEditar.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.btnEditar.Text = "EDITAR";
            this.btnEditar.UseColumnTextForButtonValue = true;
            // 
            // btnBorrar
            // 
            this.btnBorrar.HeaderText = "BORRAR";
            this.btnBorrar.Name = "btnBorrar";
            this.btnBorrar.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.btnBorrar.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.btnBorrar.Text = "BORRAR";
            this.btnBorrar.UseColumnTextForButtonValue = true;
            // 
            // frmListaFacturas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1010, 596);
            this.Controls.Add(this.dgFactura);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnNuevo);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.txtBuscar);
            this.Controls.Add(this.lblTitulo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmListaFacturas";
            this.Text = "frmListaFacturas";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.dgFactura)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialRaisedButton btnSalir;
        private MaterialSkin.Controls.MaterialRaisedButton btnNuevo;
        private MaterialSkin.Controls.MaterialRaisedButton btnBuscar;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtBuscar;
        private MaterialSkin.Controls.MaterialLabel lblTitulo;
        private System.Windows.Forms.DataGridView dgFactura;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id_Factura;
        private System.Windows.Forms.DataGridViewTextBoxColumn DtmFecha;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdCliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdEmpleado;
        private System.Windows.Forms.DataGridViewTextBoxColumn NumDescuento;
        private System.Windows.Forms.DataGridViewTextBoxColumn NumImpuesto;
        private System.Windows.Forms.DataGridViewTextBoxColumn NumValorTotal;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdEstado;
        private System.Windows.Forms.DataGridViewTextBoxColumn DtmFechaModifica;
        private System.Windows.Forms.DataGridViewTextBoxColumn StrUsuarioModifica;
        private System.Windows.Forms.DataGridViewButtonColumn btnEditar;
        private System.Windows.Forms.DataGridViewButtonColumn btnBorrar;
    }
}
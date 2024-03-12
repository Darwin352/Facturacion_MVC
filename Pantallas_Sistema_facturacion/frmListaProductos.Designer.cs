namespace Pantallas_Sistema_facturacion
{
    partial class frmListaProductos
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
            this.lblPTitulo = new MaterialSkin.Controls.MaterialLabel();
            this.dgProducto = new System.Windows.Forms.DataGridView();
            this.Id_Producto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StrNombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StrCodigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NumPrecioCompra = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NumPrecioVenta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IdCategoria = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StrDetalle = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.strFoto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NumStock = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DtmFechaModifica = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StrUsuarioModifica = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnEditar = new System.Windows.Forms.DataGridViewButtonColumn();
            this.btnBorrar = new System.Windows.Forms.DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgProducto)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSalir
            // 
            this.btnSalir.Depth = 0;
            this.btnSalir.Location = new System.Drawing.Point(873, 521);
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
            this.btnNuevo.Location = new System.Drawing.Point(873, 90);
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
            this.btnBuscar.Location = new System.Drawing.Point(720, 90);
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
            this.txtBuscar.Hint = "Buscar por Producto";
            this.txtBuscar.Location = new System.Drawing.Point(33, 104);
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
            this.lblTitulo.Location = new System.Drawing.Point(292, -35);
            this.lblTitulo.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(196, 19);
            this.lblTitulo.TabIndex = 7;
            this.lblTitulo.Text = "AMINISTRACION CLIENTES";
            this.lblTitulo.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblPTitulo
            // 
            this.lblPTitulo.AutoSize = true;
            this.lblPTitulo.Depth = 0;
            this.lblPTitulo.Font = new System.Drawing.Font("Roboto", 11F);
            this.lblPTitulo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblPTitulo.Location = new System.Drawing.Point(435, 36);
            this.lblPTitulo.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblPTitulo.Name = "lblPTitulo";
            this.lblPTitulo.Size = new System.Drawing.Size(95, 19);
            this.lblPTitulo.TabIndex = 12;
            this.lblPTitulo.Text = "PRODUCTOS";
            // 
            // dgProducto
            // 
            this.dgProducto.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgProducto.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id_Producto,
            this.StrNombre,
            this.StrCodigo,
            this.NumPrecioCompra,
            this.NumPrecioVenta,
            this.IdCategoria,
            this.StrDetalle,
            this.strFoto,
            this.NumStock,
            this.DtmFechaModifica,
            this.StrUsuarioModifica,
            this.btnEditar,
            this.btnBorrar});
            this.dgProducto.Location = new System.Drawing.Point(12, 133);
            this.dgProducto.Name = "dgProducto";
            this.dgProducto.Size = new System.Drawing.Size(978, 367);
            this.dgProducto.TabIndex = 13;

            // 
            // Id_Producto
            // 
            this.Id_Producto.HeaderText = "ID";
            this.Id_Producto.Name = "Id_Producto";
            this.Id_Producto.Width = 110;
            // 
            // StrNombre
            // 
            this.StrNombre.HeaderText = "PRODUCTO";
            this.StrNombre.Name = "StrNombre";
            // 
            // StrCodigo
            // 
            this.StrCodigo.HeaderText = "CODIGO";
            this.StrCodigo.Name = "StrCodigo";
            this.StrCodigo.Width = 110;
            // 
            // NumPrecioCompra
            // 
            this.NumPrecioCompra.HeaderText = "PRECIO DE COMPRA";
            this.NumPrecioCompra.Name = "NumPrecioCompra";
            this.NumPrecioCompra.Width = 110;
            // 
            // NumPrecioVenta
            // 
            this.NumPrecioVenta.HeaderText = "PRECIO DE VENTA";
            this.NumPrecioVenta.Name = "NumPrecioVenta";
            // 
            // IdCategoria
            // 
            this.IdCategoria.HeaderText = "CATEGORIA";
            this.IdCategoria.Name = "IdCategoria";
            // 
            // StrDetalle
            // 
            this.StrDetalle.HeaderText = "DETALLES";
            this.StrDetalle.Name = "StrDetalle";
            // 
            // strFoto
            // 
            this.strFoto.HeaderText = "FOTO";
            this.strFoto.Name = "strFoto";
            // 
            // NumStock
            // 
            this.NumStock.HeaderText = "STOCK";
            this.NumStock.Name = "NumStock";
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
            this.btnEditar.Text = "EDITAR";
            this.btnEditar.UseColumnTextForButtonValue = true;
            // 
            // btnBorrar
            // 
            this.btnBorrar.HeaderText = "BORRAR";
            this.btnBorrar.Name = "btnBorrar";
            this.btnBorrar.Text = "BORRAR";
            this.btnBorrar.UseColumnTextForButtonValue = true;
            // 
            // frmListaProductos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1002, 586);
            this.Controls.Add(this.dgProducto);
            this.Controls.Add(this.lblPTitulo);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnNuevo);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.txtBuscar);
            this.Controls.Add(this.lblTitulo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmListaProductos";
            this.Text = "frmListaProductos";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;

            ((System.ComponentModel.ISupportInitialize)(this.dgProducto)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialRaisedButton btnSalir;
        private MaterialSkin.Controls.MaterialRaisedButton btnNuevo;
        private MaterialSkin.Controls.MaterialRaisedButton btnBuscar;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtBuscar;
        private MaterialSkin.Controls.MaterialLabel lblTitulo;
        private MaterialSkin.Controls.MaterialLabel lblPTitulo;
        private System.Windows.Forms.DataGridView dgProducto;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id_Producto;
        private System.Windows.Forms.DataGridViewTextBoxColumn StrNombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn StrCodigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn NumPrecioCompra;
        private System.Windows.Forms.DataGridViewTextBoxColumn NumPrecioVenta;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdCategoria;
        private System.Windows.Forms.DataGridViewTextBoxColumn StrDetalle;
        private System.Windows.Forms.DataGridViewTextBoxColumn strFoto;
        private System.Windows.Forms.DataGridViewTextBoxColumn NumStock;
        private System.Windows.Forms.DataGridViewTextBoxColumn DtmFechaModifica;
        private System.Windows.Forms.DataGridViewTextBoxColumn StrUsuarioModifica;
        private System.Windows.Forms.DataGridViewButtonColumn btnEditar;
        private System.Windows.Forms.DataGridViewButtonColumn btnBorrar;
    }
}
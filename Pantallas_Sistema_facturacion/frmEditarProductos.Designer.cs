namespace Pantallas_Sistema_facturacion
{
    partial class frmEditarProductos
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
            this.components = new System.ComponentModel.Container();
            this.txtNombre = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.txtCodigo = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.txtPrecioC = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.txtPrecioV = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.txtStock = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblTitulo = new MaterialSkin.Controls.MaterialLabel();
            this.txtRutaImg = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.cbCategoria = new System.Windows.Forms.ComboBox();
            this.btnActualizar = new MaterialSkin.Controls.MaterialRaisedButton();
            this.btnSalir = new MaterialSkin.Controls.MaterialRaisedButton();
            this.txtDetalle = new System.Windows.Forms.TextBox();
            this.MensajeError = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.MensajeError)).BeginInit();
            this.SuspendLayout();
            // 
            // txtNombre
            // 
            this.txtNombre.Depth = 0;
            this.txtNombre.Hint = "Nombre Producto";
            this.txtNombre.Location = new System.Drawing.Point(61, 129);
            this.txtNombre.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.PasswordChar = '\0';
            this.txtNombre.SelectedText = "";
            this.txtNombre.SelectionLength = 0;
            this.txtNombre.SelectionStart = 0;
            this.txtNombre.Size = new System.Drawing.Size(257, 23);
            this.txtNombre.TabIndex = 0;
            this.txtNombre.UseSystemPasswordChar = false;
            // 
            // txtCodigo
            // 
            this.txtCodigo.Depth = 0;
            this.txtCodigo.Hint = "Codigo Referencia";
            this.txtCodigo.Location = new System.Drawing.Point(61, 167);
            this.txtCodigo.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.PasswordChar = '\0';
            this.txtCodigo.SelectedText = "";
            this.txtCodigo.SelectionLength = 0;
            this.txtCodigo.SelectionStart = 0;
            this.txtCodigo.Size = new System.Drawing.Size(257, 23);
            this.txtCodigo.TabIndex = 1;
            this.txtCodigo.UseSystemPasswordChar = false;
            // 
            // txtPrecioC
            // 
            this.txtPrecioC.Depth = 0;
            this.txtPrecioC.Hint = "Precio Compra";
            this.txtPrecioC.Location = new System.Drawing.Point(61, 206);
            this.txtPrecioC.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtPrecioC.Name = "txtPrecioC";
            this.txtPrecioC.PasswordChar = '\0';
            this.txtPrecioC.SelectedText = "";
            this.txtPrecioC.SelectionLength = 0;
            this.txtPrecioC.SelectionStart = 0;
            this.txtPrecioC.Size = new System.Drawing.Size(257, 23);
            this.txtPrecioC.TabIndex = 2;
            this.txtPrecioC.UseSystemPasswordChar = false;
            // 
            // txtPrecioV
            // 
            this.txtPrecioV.Depth = 0;
            this.txtPrecioV.Hint = "Precio Venta";
            this.txtPrecioV.Location = new System.Drawing.Point(61, 247);
            this.txtPrecioV.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtPrecioV.Name = "txtPrecioV";
            this.txtPrecioV.PasswordChar = '\0';
            this.txtPrecioV.SelectedText = "";
            this.txtPrecioV.SelectionLength = 0;
            this.txtPrecioV.SelectionStart = 0;
            this.txtPrecioV.Size = new System.Drawing.Size(257, 23);
            this.txtPrecioV.TabIndex = 3;
            this.txtPrecioV.UseSystemPasswordChar = false;
            // 
            // txtStock
            // 
            this.txtStock.Depth = 0;
            this.txtStock.Hint = "Cantidad/Stock";
            this.txtStock.Location = new System.Drawing.Point(61, 285);
            this.txtStock.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtStock.Name = "txtStock";
            this.txtStock.PasswordChar = '\0';
            this.txtStock.SelectedText = "";
            this.txtStock.SelectionLength = 0;
            this.txtStock.SelectionStart = 0;
            this.txtStock.Size = new System.Drawing.Size(257, 23);
            this.txtStock.TabIndex = 4;
            this.txtStock.UseSystemPasswordChar = false;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(61, 81);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(25, 20);
            this.textBox1.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(378, 129);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Categoria";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(378, 206);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Detalles producto";
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Depth = 0;
            this.lblTitulo.Font = new System.Drawing.Font("Roboto", 11F);
            this.lblTitulo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblTitulo.Location = new System.Drawing.Point(222, 31);
            this.lblTitulo.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(246, 19);
            this.lblTitulo.TabIndex = 8;
            this.lblTitulo.Text = "ADMINISTRACION DE PRODUCTOS";
            // 
            // txtRutaImg
            // 
            this.txtRutaImg.Depth = 0;
            this.txtRutaImg.Hint = "Ruta Imagen";
            this.txtRutaImg.Location = new System.Drawing.Point(381, 167);
            this.txtRutaImg.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtRutaImg.Name = "txtRutaImg";
            this.txtRutaImg.PasswordChar = '\0';
            this.txtRutaImg.SelectedText = "";
            this.txtRutaImg.SelectionLength = 0;
            this.txtRutaImg.SelectionStart = 0;
            this.txtRutaImg.Size = new System.Drawing.Size(195, 23);
            this.txtRutaImg.TabIndex = 9;
            this.txtRutaImg.UseSystemPasswordChar = false;
            // 
            // cbCategoria
            // 
            this.cbCategoria.FormattingEnabled = true;
            this.cbCategoria.Location = new System.Drawing.Point(455, 126);
            this.cbCategoria.Name = "cbCategoria";
            this.cbCategoria.Size = new System.Drawing.Size(121, 21);
            this.cbCategoria.TabIndex = 10;
            // 
            // btnActualizar
            // 
            this.btnActualizar.Depth = 0;
            this.btnActualizar.Location = new System.Drawing.Point(201, 367);
            this.btnActualizar.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Primary = true;
            this.btnActualizar.Size = new System.Drawing.Size(117, 37);
            this.btnActualizar.TabIndex = 11;
            this.btnActualizar.Text = "ACTUALIZAR";
            this.btnActualizar.UseVisualStyleBackColor = true;

            // 
            // btnSalir
            // 
            this.btnSalir.Depth = 0;
            this.btnSalir.Location = new System.Drawing.Point(381, 367);
            this.btnSalir.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Primary = true;
            this.btnSalir.Size = new System.Drawing.Size(117, 37);
            this.btnSalir.TabIndex = 12;
            this.btnSalir.Text = "SALIR";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // txtDetalle
            // 
            this.txtDetalle.Location = new System.Drawing.Point(381, 232);
            this.txtDetalle.Multiline = true;
            this.txtDetalle.Name = "txtDetalle";
            this.txtDetalle.Size = new System.Drawing.Size(195, 76);
            this.txtDetalle.TabIndex = 13;
            // 
            // MensajeError
            // 
            this.MensajeError.ContainerControl = this;
            // 
            // frmEditarProductos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(696, 450);
            this.Controls.Add(this.txtDetalle);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnActualizar);
            this.Controls.Add(this.cbCategoria);
            this.Controls.Add(this.txtRutaImg);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.txtStock);
            this.Controls.Add(this.txtPrecioV);
            this.Controls.Add(this.txtPrecioC);
            this.Controls.Add(this.txtCodigo);
            this.Controls.Add(this.txtNombre);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmEditarProductos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmEditarProductos";
            ((System.ComponentModel.ISupportInitialize)(this.MensajeError)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialSingleLineTextField txtNombre;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtCodigo;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtPrecioC;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtPrecioV;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtStock;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private MaterialSkin.Controls.MaterialLabel lblTitulo;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtRutaImg;
        private System.Windows.Forms.ComboBox cbCategoria;
        private MaterialSkin.Controls.MaterialRaisedButton btnActualizar;
        private MaterialSkin.Controls.MaterialRaisedButton btnSalir;
        private System.Windows.Forms.TextBox txtDetalle;
        private System.Windows.Forms.ErrorProvider MensajeError;
    }
}
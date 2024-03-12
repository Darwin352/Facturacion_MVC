using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MaterialSkin;
using MaterialSkin.Controls;

namespace Pantallas_Sistema_facturacion
{
    public partial class FrmPrincipal : MaterialForm
    {
        public FrmPrincipal()
        {
            InitializeComponent();
        }

        private void FrmPrincipal_Load(object sender, EventArgs e)
        {

        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit(); 
        }

        public void AbrirForm(Form formHijo)
        {
            if (this .pnlContenedor.Controls.Count> 0)
            this.pnlContenedor. Controls. RemoveAt (0);
        formHijo.TopLevel = false;
        formHijo.FormBorderStyle = FormBorderStyle.None;
        formHijo.Dock = DockStyle.Fill;
        this.pnlContenedor.Controls.Add(formHijo) ;
        formHijo.Show();
        }
        private void btnClientes_Click(object sender, EventArgs e)
        {
            frmListaClientes ListaCliente = new frmListaClientes();
            AbrirForm(ListaCliente);
        }

        private void btnProductos_Click(object sender, EventArgs e)
        {
            frmListaProductos ListaCliente = new frmListaProductos();
            AbrirForm(ListaCliente);
        }

        private void btnCategoria_Click(object sender, EventArgs e)
        {
            frmListaCategoria ListaCliente = new frmListaCategoria();
            AbrirForm(ListaCliente);
        }

        private void btnFacturas_Click(object sender, EventArgs e)
        {
            frmListaFacturas ListaCliente = new frmListaFacturas();
            AbrirForm(ListaCliente);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmListaInformes ListaCliente = new frmListaInformes();
            AbrirForm(ListaCliente);
        }

        private void btnEmpleados_Click(object sender, EventArgs e)
        {
            frmListaEmpleados ListaCliente = new frmListaEmpleados();
            AbrirForm(ListaCliente);
        }

        private void btnRoles_Click(object sender, EventArgs e)
        {
            frmListaRoles ListaCliente = new frmListaRoles();
            AbrirForm(ListaCliente);
        }

        private void btnSeguridad_Click(object sender, EventArgs e)
        {
            frmListaSeguridad ListaCliente = new frmListaSeguridad();
            AbrirForm(ListaCliente);
        }

        private void btnAyuda_Click(object sender, EventArgs e)
        {
            frmAyuda ListaCliente = new frmAyuda();
            AbrirForm(ListaCliente);
        }

        private void btnAcerca_Click(object sender, EventArgs e)
        {
            frmAcercaDe ListaCliente = new frmAcercaDe();
            AbrirForm(ListaCliente);
        }
    }
    }


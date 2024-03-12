using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Pantallas_Sistema_facturacion
{
    public partial class frmListaRoles : Form
    {
        public frmListaRoles()
        {
            InitializeComponent();
        }


        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            frmEditarRol rol = new frmEditarRol();
            rol.ShowDialog();
        }
    }
}

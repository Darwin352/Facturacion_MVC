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

namespace Pantallas_Sistema_facturacion
{
    public partial class frmlogin : Form
    {
        public frmlogin()
        {
            InitializeComponent();
        }

        private void materialRaisedButton2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            if (TxtUsuario.Text == "admin" && TxtPassword.Text == "1234")
            {
                MessageBox.Show("Datos de verificacion validos");
                FrmPrincipal frmppal = new FrmPrincipal();
                this.Hide();
                frmppal.Show();           
            }
            else
            {
                MessageBox.Show("Datos erroneos, por favor verificar");
            }
        }
    }
}

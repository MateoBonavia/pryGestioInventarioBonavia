using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pryGestioInventarioBonavia
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            changeTxt(false);
        }

        private void btnAgregar_gestion_Click(object sender, EventArgs e)
        {
            frmAgregar frmAgregar = new frmAgregar();
            frmAgregar.ShowDialog();
        }

        // Función para bloquear/desbloquear las textbox/combo box.
        private void changeTxt(bool change)
        {
            txtCodigo_gestion.Enabled = change;
            cboCat_gestion.Enabled = change;
            txtNombre_gestion.Enabled = change;
            txtPrecio_gestion.Enabled = change;
            txtStock_gestion.Enabled = change;
            txtDesc_gestion.Enabled = change;
        }

        private void btnBuscar_gestion_Click(object sender, EventArgs e)
        {
            if (txtBuscar_gestion.Text != "")
            {
                changeTxt(true);
            }
        }
    }
}

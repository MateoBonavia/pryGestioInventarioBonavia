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
    public partial class frmAgregar : Form
    {
        clsConexion connection = new clsConexion();
        public frmAgregar()
        {
            InitializeComponent();
        }

        private void btnAgregar_agregar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtCodigo_agregar.Text)
                || string.IsNullOrEmpty(txtNombre_agregar.Text)
                || string.IsNullOrEmpty(txtPrecio_agregar.Text)
                || string.IsNullOrEmpty(txtStock_agregar.Text)
                || string.IsNullOrEmpty(txtDesc_agregar.Text)
                || cboCat_agregar.SelectedValue == null)
            {
                MessageBox.Show("Debe completar todos los datos.");
                return;
            }

            bool exito = connection.addProduct(
                txtCodigo_agregar.Text,
                cboCat_agregar.SelectedIndex,
                txtNombre_agregar.Text,
                Convert.ToDecimal(txtPrecio_agregar.Text),
                txtStock_agregar.Text,
                txtDesc_agregar.Text
            );

            if (exito)
            {
                MessageBox.Show("¡Producto agregado con éxito!");
                clean();
            }
        }

        private void frmAgregar_Load(object sender, EventArgs e)
        {
            connection.ConnectDb();
            connection.fillCombo(cboCat_agregar);
        }

        private void clean()
        {
            txtCodigo_agregar.Clear();
            cboCat_agregar.SelectedIndex = 1;
            txtNombre_agregar.Clear();
            txtPrecio_agregar.Clear();
            txtStock_agregar.Clear();
            txtDesc_agregar.Clear();
        }
    }
}

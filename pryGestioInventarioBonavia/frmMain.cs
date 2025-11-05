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
        clsConexion connection = new clsConexion();
        public frmMain()
        {
            InitializeComponent();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            connection.ConnectDb();
            connection.fillCombo(cboCat_gestion);
            connection.fillCombo(cboCat_buscar);
            mtbMain.SelectedIndex = 0;
            changeTxt(false);
            btnEliminar_gestion.Enabled = false;
            btnModificar_gestion.Enabled = false;
        }

        // =================================================================================================
        // ================================ SECCION DE GESTION DE PRODUCTOS ================================
        // =================================================================================================

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

        // Función para bloquear/desbloquear los buttons.
        private void changeBtn()
        {
            if (string.IsNullOrEmpty(txtCodigo_gestion.Text)
                || string.IsNullOrEmpty(txtNombre_gestion.Text)
                || string.IsNullOrEmpty(txtPrecio_gestion.Text)
                || string.IsNullOrEmpty(txtStock_gestion.Text)
                || string.IsNullOrEmpty(txtDesc_gestion.Text)
                || cboCat_gestion.SelectedValue == null)
            {
                btnEliminar_gestion.Enabled = false;
                btnModificar_gestion.Enabled = false;
            }
            else
            {
                btnEliminar_gestion.Enabled = true;
                btnModificar_gestion.Enabled = true;
            }
        }

        private void clean()
        {
            txtBuscar_gestion.Text = "";
            txtCodigo_gestion.Text = "";
            txtNombre_gestion.Text = "";
            txtPrecio_gestion.Text = "";
            txtStock_gestion.Text = "";
            txtDesc_gestion.Text = "";
            cboCat_gestion.SelectedIndex = -1;
            changeTxt(false);
        }

        private void btnBuscar_gestion_Click(object sender, EventArgs e)
        {
            if (txtBuscar_gestion.Text != "")
            {
                changeTxt(true);
            }

            if (rdbCodigo_gestion.Checked)
            {
                connection.searchCode(
                    txtBuscar_gestion.Text,
                    txtCodigo_gestion,
                    cboCat_gestion,
                    txtNombre_gestion,
                    txtPrecio_gestion,
                    txtStock_gestion,
                    txtDesc_gestion
                    );
            }
            if (rdbNombre_gestion.Checked)
            {
                connection.searchName(
                    txtBuscar_gestion.Text,
                    txtCodigo_gestion,
                    cboCat_gestion,
                    txtNombre_gestion,
                    txtPrecio_gestion,
                    txtStock_gestion,
                    txtDesc_gestion
                    );
            }
        }

        private void btnModificar_gestion_Click(object sender, EventArgs e)
        {
            if (rdbCodigo_gestion.Checked)
            {
                bool exito = connection.updateProductByCode(
                    txtCodigo_gestion.Text,
                    cboCat_gestion.SelectedIndex,
                    txtNombre_gestion.Text,
                    Convert.ToDecimal(txtPrecio_gestion.Text),
                    txtStock_gestion.Text,
                    txtDesc_gestion.Text
                    );

                if (exito)
                {
                    MessageBox.Show("¡Producto modificado con éxito!");
                }
                else
                {
                    MessageBox.Show("Producto no encontrado.");
                }
            }
            if (rdbNombre_gestion.Checked)
            {
                bool exito = connection.updateProductByName(
                    txtCodigo_gestion.Text,
                    cboCat_gestion.SelectedIndex,
                    txtNombre_gestion.Text,
                    Convert.ToDecimal(txtPrecio_gestion.Text),
                    txtStock_gestion.Text,
                    txtDesc_gestion.Text
                    );

                if (exito)
                {
                    MessageBox.Show("¡Producto modificado con éxito!");
                }
                else
                {
                    MessageBox.Show("Producto no encontrado.");
                }
            }
        }

        private void btnEliminar_gestion_Click(object sender, EventArgs e)
        {
            if (rdbCodigo_gestion.Checked)
            {
                bool exito = connection.deleteByCode(txtCodigo_gestion.Text);

                if (exito)
                {
                    MessageBox.Show("¡Producto eliminado con éxito!");
                    clean();
                }
            }
            if (rdbNombre_gestion.Checked)
            {
                bool exito = connection.deleteByName(txtNombre_gestion.Text);

                if (exito)
                {
                    MessageBox.Show("¡Producto eliminado con éxito!");
                    clean();
                }
            }
        }

        private void txtCodigo_gestion_TextChanged(object sender, EventArgs e)
        {
            changeBtn();
        }

        private void cboCat_gestion_TextChanged(object sender, EventArgs e)
        {
            changeBtn();
        }

        private void txtNombre_gestion_TextChanged(object sender, EventArgs e)
        {
            changeBtn();
        }

        private void txtPrecio_gestion_TextChanged(object sender, EventArgs e)
        {
            changeBtn();
        }

        private void txtStock_gestion_TextChanged(object sender, EventArgs e)
        {
            changeBtn();
        }

        private void txtDesc_gestion_TextChanged(object sender, EventArgs e)
        {
            changeBtn();
        }

        // =================================================================================================
        // ======================================= SECCION DE BUSCAR =======================================
        // =================================================================================================
        private void btnBuscar_buscar_Click(object sender, EventArgs e)
        {
            connection.searchCat(cboCat_buscar.Text, dgvData);
        }

        private void mtbMain_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (mtbMain.SelectedIndex == 2)
            {
                connection.generateReport(chtReporte);
            }

        }
    }
}

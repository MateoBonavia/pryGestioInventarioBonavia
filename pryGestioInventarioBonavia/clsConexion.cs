using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetroFramework.Controls;

namespace pryGestioInventarioBonavia
{
    internal class clsConexion
    {
        string connectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=../../../db/Inventario.accdb";

        OleDbConnection dbConnection;

        OleDbCommand dbCommand;
        OleDbDataReader dataReader;
        public string dbName;

        public void ConnectDb()
        {
            // ----------------------------------------------------------------------------------------------------
            // ---------------------------------- METODO PARA CONECTARME A LA DB ----------------------------------
            // ----------------------------------------------------------------------------------------------------
            try
            {
                dbConnection = new OleDbConnection(connectionString);

                dbName = Path.GetFileName(dbConnection.DataSource);

                dbConnection.Open();

                //MessageBox.Show("Conectado a " + dbName);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Tiene un errorcito - " + ex.Message);
            }
        }


        // ----------------------------------------------------------------------------------------------------
        // ---------------------------------- METODO PARA LLENAR EL COMBOBOX ----------------------------------
        // ----------------------------------------------------------------------------------------------------
        public void fillCombo(MetroComboBox cat)
        {
            try
            {
                dbCommand = new OleDbCommand();
                dbCommand.Connection = dbConnection;
                dbCommand.CommandText = "SELECT ID, Nombre FROM Categorias";

                dataReader = dbCommand.ExecuteReader();

                var listaCategorias = new List<KeyValuePair<int, string>>();

                while (dataReader.Read())
                {
                    listaCategorias.Add(new KeyValuePair<int, string>(
                        dataReader.GetInt32(0), dataReader.GetString(1)));
                }
                dataReader.Close();

                cat.DataSource = listaCategorias;
                cat.DisplayMember = "Value";
                cat.ValueMember = "Key";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar la db: " + ex.Message);
            }
        }


        // ----------------------------------------------------------------------------------------------------
        // ---------------------------------- METODO PARA BUSCAR POR CODIGO -----------------------------------
        // ----------------------------------------------------------------------------------------------------
        public void searchCode(
            string code,
            MetroTextBox codigo,
            MetroComboBox cat,
            MetroTextBox nombre,
            MetroTextBox precio,
            MetroTextBox stock,
            MetroTextBox desc
        )
        {
            try
            {
                dbCommand = new OleDbCommand();
                dbCommand.Connection = dbConnection;
                dbCommand.CommandText = "SELECT * FROM Productos WHERE Codigo = ?";
                dbCommand.Parameters.AddWithValue("?", code);

                dataReader = dbCommand.ExecuteReader();

                if (dataReader.Read())
                {
                    codigo.Text = dataReader["Codigo"].ToString();
                    nombre.Text = dataReader["Nombre"].ToString();
                    precio.Text = dataReader["Precio"].ToString();
                    stock.Text = dataReader["Stock"].ToString();
                    desc.Text = dataReader["Descripcion"].ToString();
                    cat.SelectedValue = dataReader["Categoria"];
                }
                else
                {
                    MessageBox.Show("No se encontró ningún producto con ese código.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al buscar por código: " + ex.Message);
            }
            finally
            {
                dataReader.Close();
            }
        }



        // ----------------------------------------------------------------------------------------------------
        // ---------------------------------- METODO PARA BUSCAR POR NOMBRE -----------------------------------
        // ----------------------------------------------------------------------------------------------------
        public void searchName(
            string name,
            MetroTextBox codigo,
            MetroComboBox cat,
            MetroTextBox nombre,
            MetroTextBox precio,
            MetroTextBox stock,
            MetroTextBox desc
        )
        {
            try
            {
                dbCommand = new OleDbCommand();
                dbCommand.Connection = dbConnection;
                dbCommand.CommandText = "SELECT * FROM Productos WHERE Nombre = ?";
                dbCommand.Parameters.AddWithValue("?", name);

                dataReader = dbCommand.ExecuteReader();

                if (dataReader.Read())
                {
                    codigo.Text = dataReader["Codigo"].ToString();
                    nombre.Text = dataReader["Nombre"].ToString();
                    precio.Text = dataReader["Precio"].ToString();
                    stock.Text = dataReader["Stock"].ToString();
                    desc.Text = dataReader["Descripcion"].ToString();
                    cat.SelectedValue = dataReader["Categoria"];
                }
                else
                {
                    MessageBox.Show("No se encontró ningún producto con ese nombre.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al buscar por nombre: " + ex.Message);
            }
            finally
            {
                dataReader.Close();
            }
        }


        // ----------------------------------------------------------------------------------------------------
        // --------------------------------- METODO PARA BUSCAR POR CATEGORIA ---------------------------------
        // ----------------------------------------------------------------------------------------------------
        public void searchCat(
            string categoria,
            MetroTextBox codigo,
            MetroComboBox cat,
            MetroTextBox nombre,
            MetroTextBox precio,
            MetroTextBox stock,
            MetroTextBox desc
        )
        {
            try
            {
                dbCommand = new OleDbCommand();
                dbCommand.Connection = dbConnection;
                dbCommand.CommandText = "SELECT * FROM Productos WHERE Codigo = ?";
                dbCommand.Parameters.AddWithValue("?", categoria);

                dataReader = dbCommand.ExecuteReader();

                if (dataReader.Read())
                {
                    codigo.Text = dataReader["Codigo"].ToString();
                    nombre.Text = dataReader["Nombre"].ToString();
                    precio.Text = dataReader["Precio"].ToString();
                    stock.Text = dataReader["Stock"].ToString();
                    desc.Text = dataReader["Descripcion"].ToString();
                    cat.SelectedValue = dataReader["Categoria"];
                }
                else
                {
                    MessageBox.Show("No se encontró ningún producto con esa categoria.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al buscar por categoria: " + ex.Message);
            }
            finally
            {
                dataReader.Close();
            }
        }




        // ----------------------------------------------------------------------------------------------------
        // ----------------------------------- METODO PARA AGREGAR PRODUCTOS ----------------------------------
        // ----------------------------------------------------------------------------------------------------
        public bool addProduct(
            String codigo,
            Int32 cat,
            String nombre,
            decimal precio,
            String stock,
            String desc
        )
        {
            try
            {
                dbCommand = new OleDbCommand();
                dbCommand.Connection = dbConnection;
                dbCommand.CommandText = "INSERT INTO Productos " +
                                "(Codigo, Nombre, Categoria, Precio, Stock, Descripcion) " +
                                "VALUES (?, ?, ?, ?, ?, ?)";
                dbCommand.Parameters.AddWithValue("?", codigo);
                dbCommand.Parameters.AddWithValue("?", nombre);
                dbCommand.Parameters.AddWithValue("?", cat);
                dbCommand.Parameters.AddWithValue("?", precio);
                dbCommand.Parameters.AddWithValue("?", stock);
                dbCommand.Parameters.AddWithValue("?", desc);

                dbCommand.ExecuteNonQuery();
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al agregar el producto: " + ex.Message);
                return false;
            }
            finally
            {
                dataReader.Close();
            }
        }
    }
}

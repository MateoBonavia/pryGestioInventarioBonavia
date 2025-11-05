using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
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
            DataGridView dgvData
        )
        {
            dgvData.Rows.Clear();
            try
            {
                dbCommand = new OleDbCommand();
                dbCommand.Connection = dbConnection;
                dbCommand.CommandText = "SELECT p.Codigo, p.Nombre, c.Nombre AS Categoria, " +
                         "p.Precio, p.Stock, p.Descripcion " +
                         "FROM (Productos AS p " +
                         "INNER JOIN Categorias AS c ON p.Categoria = c.ID) " +
                         "WHERE c.Nombre = ?";
                dbCommand.Parameters.AddWithValue("?", categoria);

                dataReader = dbCommand.ExecuteReader();

                while (dataReader.Read())
                {
                    dgvData.Rows.Add(
                        dataReader["Codigo"].ToString(),
                        dataReader["Nombre"].ToString(),
                        dataReader["Categoria"].ToString(),
                        $"$ {dataReader["Precio"].ToString()}",
                        dataReader["Stock"].ToString(),
                        dataReader["Descripcion"].ToString()
                    );
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

        // ----------------------------------------------------------------------------------------------------
        // ---------------------------- METODO PARA MODIFICAR PRODUCTOS POR CODIGO ----------------------------
        // ----------------------------------------------------------------------------------------------------
        public bool updateProductByCode(
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
                dbCommand.CommandText = "UPDATE Productos SET " +
                                "Nombre = ?, " +
                                "Categoria = ?, " +
                                "Precio = ?, " +
                                "Stock = ?, " +
                                "Descripcion = ? " +
                                "WHERE Codigo = ?";

                dbCommand.Parameters.AddWithValue("?", nombre);
                dbCommand.Parameters.AddWithValue("?", cat);
                dbCommand.Parameters.AddWithValue("?", precio);
                dbCommand.Parameters.AddWithValue("?", stock);
                dbCommand.Parameters.AddWithValue("?", desc);
                dbCommand.Parameters.AddWithValue("?", codigo);

                int filasAfectadas = dbCommand.ExecuteNonQuery();

                if (filasAfectadas > 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al modificar el producto: " + ex.Message);
                return false;
            }
            finally
            {
                dataReader.Close();
            }
        }

        // ----------------------------------------------------------------------------------------------------
        // ---------------------------- METODO PARA MODIFICAR PRODUCTOS POR NOMBRE ----------------------------
        // ----------------------------------------------------------------------------------------------------
        public bool updateProductByName(
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
                dbCommand.CommandText = "UPDATE Productos SET " +
                                "Codigo = ?, " +
                                "Categoria = ?, " +
                                "Precio = ?, " +
                                "Stock = ?, " +
                                "Descripcion = ? " +
                                "WHERE Nombre = ?";

                dbCommand.Parameters.AddWithValue("?", codigo);
                dbCommand.Parameters.AddWithValue("?", cat);
                dbCommand.Parameters.AddWithValue("?", precio);
                dbCommand.Parameters.AddWithValue("?", stock);
                dbCommand.Parameters.AddWithValue("?", desc);
                dbCommand.Parameters.AddWithValue("?", nombre);

                int filasAfectadas = dbCommand.ExecuteNonQuery();

                if (filasAfectadas > 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al modificar el producto: " + ex.Message);
                return false;
            }
            finally
            {
                dataReader.Close();
            }
        }

        // ----------------------------------------------------------------------------------------------------
        // ---------------------------- METODO PARA ELIMINAR PRODUCTOS POR CODIGO -----------------------------
        // ----------------------------------------------------------------------------------------------------
        public bool deleteByCode(String code)
        {
            try
            {
                dbCommand = new OleDbCommand();
                dbCommand.Connection = dbConnection;
                dbCommand.CommandText = "DELETE FROM Productos WHERE Codigo = ?";
                dbCommand.Parameters.AddWithValue("?", code);

                int filasAfectadas = dbCommand.ExecuteNonQuery();

                if (filasAfectadas > 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al  el producto: " + ex.Message);
                return false;
            }
            finally
            {
                dataReader.Close();
            }
        }

        // ----------------------------------------------------------------------------------------------------
        // ---------------------------- METODO PARA ELIMINAR PRODUCTOS POR NOMBRE -----------------------------
        // ----------------------------------------------------------------------------------------------------
        public bool deleteByName(String name)
        {
            try
            {
                dbCommand = new OleDbCommand();
                dbCommand.Connection = dbConnection;
                dbCommand.CommandText = "DELETE FROM Productos WHERE Nombre = ?";
                dbCommand.Parameters.AddWithValue("?", name);

                int filasAfectadas = dbCommand.ExecuteNonQuery();

                if (filasAfectadas > 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al eliminar el producto: " + ex.Message);
                return false;
            }
            finally
            {
                dataReader.Close();
            }
        }

        // ----------------------------------------------------------------------------------------------------
        // ---------------------------------- METODO PARA GENERAR EL REPORTE ----------------------------------
        // ----------------------------------------------------------------------------------------------------
        public void generateReport(Chart chart)
        {
            try
            {
                chart.Series.Clear();
                chart.Legends.Clear();

                Series serieStock = new Series("StockXCategoria");
                serieStock.ChartType = SeriesChartType.Pie;

                dbCommand = new OleDbCommand();
                dbCommand.Connection = dbConnection;
                dbCommand.CommandText = "SELECT c.Nombre AS Categoria, SUM(p.Stock) AS TotalStock " +
                                        "FROM (Productos AS p " +
                                        "INNER JOIN Categorias AS c ON p.Categoria = c.ID) " +
                                        "GROUP BY c.Nombre";

                dataReader = dbCommand.ExecuteReader();

                while (dataReader.Read())
                {
                    string categoria = dataReader["Categoria"].ToString();
                    int totalStock = Convert.ToInt32(dataReader["TotalStock"]);

                    int pointIndex = serieStock.Points.AddXY(categoria, totalStock);

                    serieStock.Points[pointIndex].LegendText = categoria;
                }
                chart.Series.Add(serieStock);
                chart.Legends.Add(new Legend("Reporte"));
                serieStock.Legend = "Reporte";

                // Muestro los datos en el grafico.
                serieStock.IsValueShownAsLabel = true;
                // Formatea el numero sin decimales y le agrega el simbolo de porcentaje.
                serieStock.LabelFormat = "{0:0} %";
                // Hace que el grafico calcule el porcentaje para que sepa que cantidad del grafico tomar.
                serieStock.Label = "#PERCENT";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al generar el reporte: " + ex.Message);
            }
        }
    }
}

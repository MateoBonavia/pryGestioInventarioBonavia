using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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

                MessageBox.Show("Conectado a " + dbName);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Tiene un errorcito - " + ex.Message);
            }
        }
    }
}

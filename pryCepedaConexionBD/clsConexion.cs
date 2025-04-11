using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pryCepedaConexionBD
{
    internal class clsConexion
    {
        internal class ClsConexion
        {
            private static string connectionString =
                "Server=localhost\\SQLEXPRESS;Database=Comercio;Trusted_Connection=True;";

            public static SqlConnection ObtenerConexion()
            {
                SqlConnection connection = new SqlConnection(connectionString);

                try
                {
                    connection.Open();
                    MessageBox.Show("✅ Conexión exitosa a la base de datos.");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("❌ Error al conectar: " + ex.Message);
                }

                return connection;
            }

        }
    }
}

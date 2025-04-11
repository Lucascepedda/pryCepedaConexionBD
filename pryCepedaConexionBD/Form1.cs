using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
namespace pryCepedaConexionBD
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void CargarProductos(object sender, EventArgs e)
        {
            string connectionString = "Server=PC143;Database=Comercio;Trusted_Connection=True;";
            using (SqlConnection connection = new SqlConnection(connectionString))
                try
                {
                    connection.Open();
                    string query = @"SELECT p.Codigo, p.Nombre, p.Descripcion, p.Precio, p.Stock, c.Nombre as Categoria;
                    FROM Productos p
                    INNER JOIN Categorias c ON p.CategoriaId = c.Id";

                    SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);

                    dgvConexion.DataSource = dataTable;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al conectar: " + ex.Message);
                }
        }

        private void btnMostrar_Click(object sender, EventArgs e)
        {
            CargarProductos();
        }

        private void CargarProductos()
        {
            throw new NotImplementedException();
        }
    }
    

}

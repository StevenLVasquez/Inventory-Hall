using Microsoft.Data.SqlClient;
using System;
using System.Data;
using System.Windows.Forms;

namespace Inventory_Hall
{
    public partial class consuplidor : Form
    {
        private DatabaseManager databaseManager;

        public consuplidor()
        {
            InitializeComponent();
            databaseManager = new DatabaseManager();

        }

        private void consuplidor_Load(object sender, EventArgs e)
        {
            // Cargar todos los proveedores inicialmente
            LoadSuppliers();
        }

        private void buscartxt_TextChanged(object sender, EventArgs e)
        {


        }


        private void buscarbtn_Click(object sender, EventArgs e)
        {
            // Realizar la búsqueda
            PerformSearch();
        }

        private void PerformSearch()
        {
            try
            {
                // Obtener el término de búsqueda del cuadro de texto
                string searchTerm = buscartxt.Text.Trim();

                // Verificar si el término de búsqueda no está vacío
                if (!string.IsNullOrEmpty(searchTerm))
                {
                    // Determinar si el término de búsqueda es numérico para buscar por ID
                    if (int.TryParse(searchTerm, out int supplierId))
                    {
                        // Buscar por ID
                        string query = "SELECT * FROM suplidor WHERE ID = @supplierId";

                        using (DataTable dataTable = new DataTable())
                        {
                            using (var adapter = new SqlDataAdapter(query, databaseManager.GetConnection()))
                            {
                                // Agregar parámetro para el ID del proveedor
                                adapter.SelectCommand.Parameters.AddWithValue("@supplierId", supplierId);

                                // Abrir la conexión antes de ejecutar la consulta

                                int rowsAffected = adapter.Fill(dataTable);

                                if (rowsAffected == 0)
                                {
                                    MessageBox.Show("Este ID no está ingresado");
                                }
                                else
                                {
                                    // Vincular la DataTable al DataGridView
                                    dataGridView1.DataSource = dataTable;
                                }
                            }
                        }
                    }
                    else
                    {
                        // Verificar si el término de búsqueda tiene formato de RNC (puedes ajustar según tus necesidades)
                        if (searchTerm.Length == 9 || searchTerm.Length == 11)
                        {
                            // Buscar por RNC
                            string query = "SELECT * FROM suplidor WHERE RNC = @rnc";

                            using (DataTable dataTable = new DataTable())
                            {
                                using (var adapter = new SqlDataAdapter(query, databaseManager.GetConnection()))
                                {
                                    // Agregar parámetro para el RNC del proveedor
                                    adapter.SelectCommand.Parameters.AddWithValue("@rnc", searchTerm);

                                    // Abrir la conexión antes de ejecutar la consulta

                                    int rowsAffected = adapter.Fill(dataTable);

                                    if (rowsAffected == 0)
                                    {
                                        MessageBox.Show("Este RNC no está ingresado");
                                    }
                                    else
                                    {
                                        // Vincular la DataTable al DataGridView
                                        dataGridView1.DataSource = dataTable;
                                    }
                                }
                            }
                        }
                        else
                        {
                            // Buscar por Nombre
                            string query = "SELECT * FROM suplidor WHERE Nombre LIKE @searchTerm";

                            using (DataTable dataTable = new DataTable())
                            {
                                using (var adapter = new SqlDataAdapter(query, databaseManager.GetConnection()))
                                {
                                    // Agregar parámetro para el término de búsqueda
                                    adapter.SelectCommand.Parameters.AddWithValue("@searchTerm", "%" + searchTerm + "%");

                                    // Abrir la conexión antes de ejecutar la consulta

                                    int rowsAffected = adapter.Fill(dataTable);

                                    if (rowsAffected == 0)
                                    {
                                        MessageBox.Show("Este Nombre no está ingresado");
                                    }
                                    else
                                    {
                                        // Vincular la DataTable al DataGridView
                                        dataGridView1.DataSource = dataTable;
                                    }
                                }
                            }
                        }
                    }
                }
                else
                {
                    // Si el término de búsqueda está vacío, recargar todos los proveedores
                    LoadSuppliers();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            finally
            {
                // Cerrar la conexión en el bloque finally para asegurar que se cierre incluso si ocurre una excepción
                databaseManager.CloseConnection();
            }
        }

        private void LoadSuppliers()
        {
            string query = "SELECT * FROM suplidor";

            using (DataTable dataTable = new DataTable())
            {
                using (var adapter = new SqlDataAdapter(query, databaseManager.GetConnection()))
                {
                    adapter.Fill(dataTable);

                    // Vincular la DataTable al DataGridView
                    dataGridView1.DataSource = dataTable;
                }
            }

            // Cerrar la conexión cuando haya terminado
            databaseManager.CloseConnection();
        }

        private void refreshbtn_Click(object sender, EventArgs e)
        {
            // Recargar todos los proveedores
            LoadSuppliers();
        }
    }
}

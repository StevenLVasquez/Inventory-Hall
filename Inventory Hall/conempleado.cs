using System;
using System.Data;
using System.Windows.Forms;
using System.Data.SqlClient;
using Microsoft.Data.SqlClient;

namespace Inventory_Hall
{
    public partial class conempleado : Form
    {
        private DatabaseManager databaseManager;

        public conempleado()
        {
            InitializeComponent();
            databaseManager = new DatabaseManager();
        }

        private void conempleado_Load(object sender, EventArgs e)
        {
            // Load all employees initially
            LoadEmployees();

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
                // Get the search term from the textbox
                string searchTerm = buscartxt.Text.Trim();

                // Check if the search term is not empty
                if (!string.IsNullOrEmpty(searchTerm))
                {
                    // Determine if the search term is numeric to search by ID
                    if (int.TryParse(searchTerm, out int employeeId))
                    {
                        // Search by ID
                        string query = "SELECT * FROM empleado WHERE ID = @employeeId";

                        using (DataTable dataTable = new DataTable())
                        {
                            using (var adapter = new SqlDataAdapter(query, databaseManager.GetConnection()))
                            {
                                // Add parameter for the employee ID
                                adapter.SelectCommand.Parameters.AddWithValue("@employeeId", employeeId);

                                // Open the connection before executing the query

                                int rowsAffected = adapter.Fill(dataTable);

                                if (rowsAffected == 0)
                                {
                                    MessageBox.Show("ID no existe");
                                }
                                else
                                {
                                    // Bind the DataTable to the DataGridView
                                    dataGridView1.DataSource = dataTable;
                                }
                            }
                        }
                    }
                    else
                    {
                        // Search by Nombre
                        string query = "SELECT * FROM empleado WHERE Nombre LIKE @searchTerm";

                        using (DataTable dataTable = new DataTable())
                        {
                            using (var adapter = new SqlDataAdapter(query, databaseManager.GetConnection()))
                            {
                                // Add parameter for the search term
                                adapter.SelectCommand.Parameters.AddWithValue("@searchTerm", "%" + searchTerm + "%");

                                // Open the connection before executing the query

                                int rowsAffected = adapter.Fill(dataTable);

                                if (rowsAffected == 0)
                                {
                                    MessageBox.Show("Este nombre no está ingresado");
                                }
                                else
                                {
                                    // Bind the DataTable to the DataGridView
                                    dataGridView1.DataSource = dataTable;
                                }
                            }
                        }
                    }
                }
                else
                {
                    // If the search term is empty, reload all employees
                    LoadEmployees();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            finally
            {
                // Close the connection in the finally block to ensure it's closed even if an exception occurs
                databaseManager.CloseConnection();
            }
        }

        private void LoadEmployees()
        {
            string query = "SELECT * FROM empleado";

            using (DataTable dataTable = new DataTable())
            {
                using (var adapter = new SqlDataAdapter(query, databaseManager.GetConnection()))
                {
                    adapter.Fill(dataTable);

                    // Bind the DataTable to the DataGridView
                    dataGridView1.DataSource = dataTable;
                }
            }

            // Close the connection when done
            databaseManager.CloseConnection();
        }

        private void refreshbtn_Click(object sender, EventArgs e)
        {
            // Reload all employees
            LoadEmployees();
        }
    }
}

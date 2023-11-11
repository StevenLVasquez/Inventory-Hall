using Microsoft.Data.SqlClient;
using System;
using System.Data;
using System.Windows.Forms;

namespace Inventory_Hall
{
    public partial class conproducto : Form
    {
        private DatabaseManager databaseManager;

        public conproducto()
        {
            InitializeComponent();
            databaseManager = new DatabaseManager();
        }

        private void conproducto_Load(object sender, EventArgs e)
        {
            // Assuming you have a table named "producto" in your database
            LoadData();
        }

        private void LoadData()
        {
            string query = "SELECT * FROM producto";

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

        private void buscarbtn_Click(object sender, EventArgs e)
        {
            // Get the ID from the TextBox
            if (int.TryParse(txtID.Text, out int id))
            {
                // Modify the query to include the ID filter
                string query = $"SELECT * FROM producto WHERE ID = {id}";

                using (DataTable dataTable = new DataTable())
                {
                    using (var adapter = new SqlDataAdapter(query, databaseManager.GetConnection()))
                    {
                        adapter.Fill(dataTable);

                        if (dataTable.Rows.Count > 0)
                        {
                            // Bind the DataTable to the DataGridView
                            dataGridView1.DataSource = dataTable;
                        }
                        else
                        {
                            MessageBox.Show("Este producto no está ingresado.", "Producto no encontrado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                }

                // Close the connection when done
                databaseManager.CloseConnection();
            }
            else
            {
                MessageBox.Show("Por favor, ingrese un ID válido para la búsqueda.", "ID no válido", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void refreshbtn_Click(object sender, EventArgs e)
        {



            string query = "SELECT * FROM producto";

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
    }
}

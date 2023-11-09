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

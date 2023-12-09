using System;
using System.Data;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;

namespace Inventory_Hall
{
    public partial class prodistribucion : Form
    {
        private DatabaseManager dbManager = new DatabaseManager();
        private SqlConnection connection;

        public prodistribucion()
        {
            InitializeComponent();
        }

        private void prodistribucion_Load(object sender, EventArgs e)
        {
            // Open the connection to the database
            connection = dbManager.GetConnection();
            if (connection.State == System.Data.ConnectionState.Closed)
            {
                connection.Open();
            }
            //haciendo algo 
            //TODO Populate the ComboBox with product IDs from the "producto" table
            string query = "SELECT id FROM producto";
            using (SqlCommand command = new SqlCommand(query, connection))
            {
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    comboBoxProductIDs.Items.Add(reader["id"].ToString());
                }
            }

            //TODO Display data in the DataGridView
            RefreshDataGridView();
        }

        private void buttonseccionupdate_Click(object sender, EventArgs e)
        {
            if (comboBoxProductIDs.SelectedItem != null)
            {
                string selectedProductID = comboBoxProductIDs.SelectedItem.ToString();
                string newSeccionValue = textBoxNewSeccion.Text;

                // Check if the new section value is empty
                if (string.IsNullOrWhiteSpace(newSeccionValue))
                {
                    MessageBox.Show("Favor elegir una seccion.");
                }
                else
                {

                    // Update the "seccion" column in the "producto" table
                    string updateQuery = "UPDATE producto SET seccion = @newSeccion WHERE id = @productID";
                    using (SqlCommand command = new SqlCommand(updateQuery, connection))
                    {
                        command.Parameters.AddWithValue("@newSeccion", newSeccionValue);
                        command.Parameters.AddWithValue("@productID", selectedProductID);

                        command.ExecuteNonQuery();
                    }

                    MessageBox.Show("Seccion Actualizada Con Exito.");

                    // Refresh the DataGridView to display updated data
                    RefreshDataGridView();
                }
            }
            else
            {
                MessageBox.Show("Please select a product ID from the ComboBox.");
            }
        }

        private void RefreshDataGridView()
        {
            // Check if there's already a DataReader open and close it
            if (connection.State == ConnectionState.Open)
            {
                connection.Close();
            }

            // Retrieve data from the "producto" table
            string query = "SELECT * FROM producto";
            using (SqlCommand command = new SqlCommand(query, connection))
            {
                if (connection.State == ConnectionState.Closed)
                {
                    connection.Open();
                }

                SqlDataAdapter adapter = new SqlDataAdapter(command);
                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);

                // Bind the DataTable to the DataGridView
                dataGridView1.DataSource = dataTable;
            }
        }


        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            // Close the database connection when the form is closed
            dbManager.CloseConnection();
            base.OnFormClosing(e);
        }
    }
}

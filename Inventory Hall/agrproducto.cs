using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Inventory_Hall
{
    public partial class agrproducto : Form
    {
        private DatabaseManager databaseManager;
        public agrproducto()
        {
            InitializeComponent();

            // the database manager here is private bc we are only calling it in this form , meaning the data entered here stays here in this specific sqlconnection
            databaseManager = new DatabaseManager();

            // Populate the ComboBox with data from the "categoria" table when the form loads
            PopulateCategoriaComboBox();

            // Populate the idsuplidortxt ComboBox with data from the "suplidor" table when the form loads
            PopulateSuplidorComboBox();

        }

        private void PopulateCategoriaComboBox()
        {
            categoriabox.Items.Clear(); // Clear any existing items

            // SQL query to select id and tipo from the 'categoria' table

            string query = "SELECT id, tipo FROM categoria";

            // Create a SqlCommand with the query and the database connection


            using (SqlCommand command = new SqlCommand(query, databaseManager.GetConnection()))
            {
                // Execute the query and read the results

                using (SqlDataReader reader = command.ExecuteReader())
                {
                    // Iterate through the results

                    while (reader.Read())
                    {
                        // Extract id and tipo from the current row

                        string id = reader["id"].ToString();
                        string tipo = reader["tipo"].ToString();

                        // Combine id and tipo to create display text

                        string displayText = $"{id} - {tipo}"; // Combine id and tipo
                        // Add the display text to the ComboBox items
                        categoriabox.Items.Add(displayText);
                    }
                }
            }
        }

        private void PopulateSuplidorComboBox()
        {
            // Assuming that idsuplidortxt is the name of your ComboBox
            idsuplidortxt.Items.Clear(); // Clear any existing items
            string query = "SELECT id, nombre FROM suplidor";
            using (SqlCommand command = new SqlCommand(query, databaseManager.GetConnection()))
            {
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        string id = reader["id"].ToString();
                        string nombre = reader["nombre"].ToString();
                        string displayText = $"{id} - {nombre}"; // Combine id and nombre
                        idsuplidortxt.Items.Add(displayText);
                    }
                }
            }
        }

        private void insertarbtn_Click(object sender, EventArgs e)
        {
            nombretxt.Enabled = true;
            descripciontxt.Enabled = true;
            stocktxt.Enabled = true;
            idsuplidortxt.Enabled = true;
            secciontxt.Enabled = true;
            categoriabox.Enabled = true;

            nombretxt.BackColor = Color.White;
            descripciontxt.BackColor = Color.White;
            stocktxt.BackColor = Color.White;
            idsuplidortxt.BackColor = Color.White;
            secciontxt.BackColor = Color.White;
            categoriabox.BackColor = Color.White;
            // Execute an Sql command using the DatabaseManager class i created earlier

            // Also, populate the ComboBox with "categoria" data when you click the insert button
            PopulateCategoriaComboBox();

        }

        private void agrproducto_Load(object sender, EventArgs e)
        {
            // Call the method to populate the ComboBox when the form loads
            PopulateCategoriaComboBox();
            PopulateSuplidorComboBox();



        }

        private void guardarbtn_Click(object sender, EventArgs e)
        {
            try
            {
                // Check if any of the required fields are empty
                if (string.IsNullOrWhiteSpace(nombretxt.Text) ||
                    categoriabox.SelectedItem == null ||
                    string.IsNullOrWhiteSpace(descripciontxt.Text) ||
                    string.IsNullOrWhiteSpace(stocktxt.Text) ||
                    idsuplidortxt.SelectedItem == null ||
                    string.IsNullOrWhiteSpace(secciontxt.Text))
                {
                    MessageBox.Show("Favor completar el formulario. Todos los campos son obligatorios.");
                    return; // Exit the method if any field is empty
                }

                // Check if the stock value is numeric
                if (!int.TryParse(stocktxt.Text, out _))
                {
                    MessageBox.Show("Favor introduzca un dato numérico en el campo Stock.");
                    return; // Exit the method if stock is not numeric
                }

                string insertQuery = "insert into producto (nombre, categoria, descripcion, stock, idsuplidor, seccion) " +
                    "VALUES (@nombre, @categoria, @descripcion, @stock, @idsuplidor, @seccion)";

                using (SqlCommand command = new SqlCommand(insertQuery, databaseManager.GetConnection()))
                {
                    // Add parameters using AddWithValue
                    command.Parameters.AddWithValue("@nombre", nombretxt.Text);
                    string selectedCategory = categoriabox.SelectedItem.ToString();
                    string[] parts = selectedCategory.Split(new[] { " - " }, StringSplitOptions.None);
                    string selectedCategoryId = parts[0]; // Extract the "id" part
                    command.Parameters.AddWithValue("@categoria", selectedCategoryId);

                    command.Parameters.AddWithValue("@descripcion", descripciontxt.Text);
                    command.Parameters.AddWithValue("@stock", stocktxt.Text);

                    string selectedSuplidor = idsuplidortxt.SelectedItem.ToString();
                    string[] suplidorParts = selectedSuplidor.Split(new[] { " - " }, StringSplitOptions.None);
                    string selectedSuplidorId = suplidorParts[0]; // Extract the "id" part
                    command.Parameters.AddWithValue("@idsuplidor", selectedSuplidorId);

                    command.Parameters.AddWithValue("@seccion", secciontxt.Text);

                    // Execute the SQL command
                    command.ExecuteNonQuery();
                }

                MessageBox.Show("Data insertada correctamente.");

                categoriabox.SelectedIndex = -1;
                idsuplidortxt.SelectedIndex = -1;

                nombretxt.Text = "";
                categoriabox.Text = "";
                descripciontxt.Text = "";
                stocktxt.Text = "";
                idsuplidortxt.Text = "";
                secciontxt.Text = "";
            }
            catch (Exception ex)
            {
                MessageBox.Show("ERROR: " + ex.Message);
            }
        }




        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedCategory = categoriabox.SelectedItem?.ToString();

        }


        private void idsuplidortxt_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Retrieve the selected item as a string from the idsuplidortxt ComboBox

            string selectedSuplidor = idsuplidortxt.SelectedItem?.ToString();

        }

        private void agrproducto_Load_1(object sender, EventArgs e)
        {

        }
    }
}

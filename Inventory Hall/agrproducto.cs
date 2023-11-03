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
        }

        private void PopulateCategoriaComboBox()
        {
            // Assuming that comboBox1 is the name of your ComboBox
            categoriabox.Items.Clear(); // Clear any existing items

            string query = "SELECT id, tipo FROM categoria";

            using (SqlCommand command = new SqlCommand(query, databaseManager.GetConnection()))
            {
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        string id = reader["id"].ToString();
                        string tipo = reader["tipo"].ToString();
                        string displayText = $"{id} - {tipo}"; // Combine id and tipo
                        categoriabox.Items.Add(displayText);
                    }
                }
            }
        }

        private void insertarbtn_Click(object sender, EventArgs e)
        {
            nombretxt.Enabled = true;
            descripciontxt.Enabled = true;
            stocktxt.Enabled = true;
            suplidortxt.Enabled = true;
            secciontxt.Enabled = true;
            categoriabox.Enabled = true;

            nombretxt.BackColor = Color.White;
            descripciontxt.BackColor = Color.White;
            stocktxt.BackColor = Color.White;
            suplidortxt.BackColor = Color.White;
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

        }

        private void guardarbtn_Click(object sender, EventArgs e)
        {
            try
            {
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
                    command.Parameters.AddWithValue("@idsuplidor", suplidortxt.Text);
                    command.Parameters.AddWithValue("@seccion", secciontxt.Text);

                    // Execute the SQL command
                    command.ExecuteNonQuery();
                }

                MessageBox.Show("Data insertada correctamente.");
            }

            catch (Exception ex)
            {
                MessageBox.Show("ERROR: " + ex.Message);
            }
        }



        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            // You can access the selected category from the ComboBox like this:
            string selectedCategory = categoriabox.SelectedItem.ToString();

            // Use the selected category as needed in your code
        }
    }
}

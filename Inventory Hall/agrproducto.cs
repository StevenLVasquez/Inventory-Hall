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
        }

        private void insertarbtn_Click(object sender, EventArgs e)
        {
            nombretxt.Enabled = true;
            categoriatxt.Enabled = true;
            descripciontxt.Enabled = true;
            stocktxt.Enabled = true;
            suplidortxt.Enabled = true;
            secciontxt.Enabled = true;

            nombretxt.BackColor = Color.White;
            categoriatxt.BackColor = Color.White;
            descripciontxt.BackColor = Color.White;
            stocktxt.BackColor = Color.White;
            suplidortxt.BackColor = Color.White;
            secciontxt.BackColor = Color.White;

            // Execute an Sql command using the DatabaseManager class i created earlier


        }

        private void agrproducto_Load(object sender, EventArgs e)
        {

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
                    command.Parameters.AddWithValue("@categoria", categoriatxt.Text);
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
    }
}

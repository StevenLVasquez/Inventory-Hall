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
    public partial class agrempleado : Form
    {
        private DatabaseManager databaseManager;

        public agrempleado()
        {
            InitializeComponent();

            databaseManager = new DatabaseManager();

        }

        private void nuevobtn_Click(object sender, EventArgs e)
        {
            nombretxt.Enabled = true;
            apellidotxt.Enabled = true;
            direcciontxt.Enabled = true;
            maskeddni.Enabled = true;
            emailtxt.Enabled = true;
            maskedtel.Enabled = true;
            maskedcel.Enabled = true;
            cargotxt.Enabled = true;

            nombretxt.BackColor = Color.White;
            apellidotxt.BackColor = Color.White;
            direcciontxt.BackColor = Color.White;
            maskeddni.BackColor = Color.White;
            emailtxt.BackColor = Color.White;
            maskedtel.BackColor = Color.White;
            maskedcel.BackColor = Color.White;
            cargotxt.BackColor = Color.White;


        }

        private void nombretxt_TextChanged(object sender, EventArgs e)
        {

        }

        private void guardarbtn_Click(object sender, EventArgs e)
        {
            try
            {
                string insertQuery = "INSERT INTO empleado (nombre, apellido, direccion, dni, email, telefono, celular, cargo) " +
                   "VALUES (@nombre, @apellido, @direccion, @dni, @email, @telefono, @celular, @cargo)";


                using (SqlCommand command = new SqlCommand(insertQuery, databaseManager.GetConnection()))
                {
                    // Add parameters using AddWithValue
                    command.Parameters.AddWithValue("@nombre", nombretxt.Text);
                    command.Parameters.AddWithValue("@apellido", apellidotxt.Text);
                    command.Parameters.AddWithValue("@direccion", direcciontxt.Text);



                    string dni = maskeddni.Text.Replace("-", " "); // Remove spaces or any other formatting
                    command.Parameters.AddWithValue("@dni", dni);


                    command.Parameters.AddWithValue("@email", emailtxt.Text);


                    string phoneNumber = maskedtel.Text.Replace("-", ""); // Remove hyphens or any other formatting
                    command.Parameters.AddWithValue("@telefono", phoneNumber);

                    string cellphoneNumber = maskedcel.Text.Replace("-", ""); // Remove hyphens or any other formatting
                    command.Parameters.AddWithValue("@celular", cellphoneNumber);

                    command.Parameters.AddWithValue("@cargo", cargotxt.Text);

                    // Execute the SQL command
                    command.ExecuteNonQuery();
                }

                MessageBox.Show("Data insertada correctamente.");

                nombretxt.Clear();
                apellidotxt.Clear();
                direcciontxt.Clear();
                maskeddni.Clear();
                emailtxt.Clear();
                maskedtel.Clear();
                maskedcel.Clear();
                cargotxt.Clear();
            }

            catch (Exception ex)
            {
                MessageBox.Show("ERROR HAS INSERTADO UN DATO MAL: " + ex.Message);
            }
        }
    }

}

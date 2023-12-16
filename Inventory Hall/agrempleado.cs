// aqui estamos usando las librerias , (Importando)

using Microsoft.Data.SqlClient;
using System;
using System.Windows.Forms;
using System.Text;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Collections.Generic;
using System.ComponentModel;


// aqui estamos seccionando el codigo , en los demas forms este comentario no lo pondre porque ya sabemos para que es 

namespace Inventory_Hall
{
    public partial class agrempleado : Form
    {
        private DatabaseManager databaseManager;
        //Inizializadores 
        public agrempleado()
        {
            InitializeComponent();
            databaseManager = new DatabaseManager();
            //Aqui hice un constructor para llamar a la clase de la base de datos DatabaseManager que cree

        }

        //Propiedades del textbox para habilitar e inhabilitar.
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
                // Check if any of the required fields is empty
                if (string.IsNullOrWhiteSpace(nombretxt.Text) || string.IsNullOrWhiteSpace(apellidotxt.Text) ||
                    string.IsNullOrWhiteSpace(direcciontxt.Text) || string.IsNullOrWhiteSpace(GetUnmaskedText(maskeddni)) ||
                    string.IsNullOrWhiteSpace(emailtxt.Text) || string.IsNullOrWhiteSpace(GetUnmaskedText(maskedtel)) ||
                    string.IsNullOrWhiteSpace(GetUnmaskedText(maskedcel)) || string.IsNullOrWhiteSpace(cargotxt.Text))
                {
                    MessageBox.Show("Por favor llenar todos los campos.");
                    return; // Exit the method without proceeding to database insertion
                }

                //This is just inserting the query into the database

                string insertQuery = "INSERT INTO empleado (nombre, apellido, direccion, dni, email, telefono, celular, cargo) " +
                   "VALUES (@nombre, @apellido, @direccion, @dni, @email, @telefono, @celular, @cargo)";

                //Parameters for the insertion
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
                // This is one of many ways to clear out the textboxs after insertion 

                nombretxt.Clear();
                apellidotxt.Clear();
                direcciontxt.Clear();
                maskeddni.Clear();
                emailtxt.Clear();
                maskedtel.Clear();
                maskedcel.Clear();
                cargotxt.Clear();
            }//esto es una captura de error 
            catch (Exception ex)
            {
                MessageBox.Show("ERROR HAS INSERTADO UN DATO MAL: " + ex.Message);
            }
        }
        
        //
        private string GetUnmaskedText(MaskedTextBox maskedTextBox)
        {
            // Get the text from the MaskedTextBox

            string unmaskedText = maskedTextBox.Text;
            foreach (char maskChar in maskedTextBox.Mask)
            {
                // Remove the current mask character from the unmasked text

                unmaskedText = unmaskedText.Replace(maskChar.ToString(), "");
            }
            // Return the resulting unmasked text

            return unmaskedText;
        }
    }
}

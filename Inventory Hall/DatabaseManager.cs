using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;

namespace Inventory_Hall
{
    public class DatabaseManager
    {
        private SqlConnection connection;

        // A class responsible for managing database interactions
        // Represents the connection to the database
        // Constructor initializes the DatabaseManager and establishes a database connection

        public DatabaseManager()
        {
            // Retrieve the connection string from the configuration file

            string connectionString = ConfigurationManager.ConnectionStrings["InventoryHall"].ConnectionString;
            // Create a new SqlConnection using the retrieved connection string

            connection = new SqlConnection(connectionString);

        }

        // Returns the SqlConnection, ensuring it is open before returning

        public SqlConnection GetConnection()
        {
            // Check if the connection is closed and open it if necessary

            if (connection.State == System.Data.ConnectionState.Closed)
            {
                connection.Open();
            }
            // Return the open connection

            return connection;
        }

        // Closes the SqlConnection if it is currently open
        public void CloseConnection()
        {
            // Check if the connection is open and close it if necessary

            if (connection.State == System.Data.ConnectionState.Open)
            {
                connection.Close();
            }
        }

        // Executes a non-query SQL command on the database
        public void ExecuteNonQuery(string query)
        {
            // Use SqlCommand to execute the provided query using the open 
            using (SqlCommand command = new SqlCommand(query, GetConnection()))
            {
                command.ExecuteNonQuery();
            }
        }
    }
}

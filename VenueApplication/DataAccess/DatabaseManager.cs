using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using Npgsql;
using System.Diagnostics;

namespace VenueApplication.DataAccess
{
    internal class DatabaseManager
    {
        private readonly string _connectionString;

        public DatabaseManager(string host, string username, string password, string databaseName)
        {
            _connectionString = BuildConnectionString(host, username, password, databaseName);
        }

        private string BuildConnectionString(string host, string username, string password, string databaseName)
        {
            return $"Host={host};Username={username};Password={password};Database={databaseName}";
        }

        public NpgsqlConnection GetConnection()
        {
            var connection = new NpgsqlConnection(_connectionString);

            return connection;
        }

        public void ExecuteTestQuery()
        {
            string query = "SELECT * FROM login_credentials;";

            using (var dbConnection = this.GetConnection())
            {
                // Create a command object to execute the query
                var command = new NpgsqlCommand(query, dbConnection);

                try
                {
                    dbConnection.Open();

                    // Execute the query and get a reader to read the results
                    using (var reader = command.ExecuteReader())
                    {
                        // Iterate through the rows returned by the query
                        while (reader.Read())
                        {
                            // Example: Assuming your table has a 'trans_id' and 'trans_quantity'
                            string lgn_username = reader.GetString(reader.GetOrdinal("lgn_username"));
                            string lgn_password = reader.GetString(reader.GetOrdinal("lgn_password"));

                            // You can then use this data as needed, for example, printing to console
                            Debug.WriteLine($"lgn_username: {lgn_username}, lgn_password: {lgn_password}");
                        }
                    }
                }
                catch (Exception ex)
                {
                    // Handle any errors that occur during the query execution
                    MessageBox.Show($"Error executing query: {ex.Message}");
                }
                finally
                {
                    dbConnection.Close();
                }
            }
        }
    }
}

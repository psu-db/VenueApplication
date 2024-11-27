using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Npgsql;
using VenueApplication.DataAccess;

namespace VenueApplication.Services
{






    using Npgsql;
    using System.Text;

    public class QueryDebugging
    {
        // Method to return SQL query with parameter values inserted
        public static string GetSqlWithParameters(string query, NpgsqlCommand command)
        {
            var finalQuery = new StringBuilder(query);

            // Loop through each parameter and replace its placeholder with the actual value
            foreach (NpgsqlParameter param in command.Parameters)
            {
                finalQuery.Replace(param.ParameterName, param.Value.ToString());
            }

            return finalQuery.ToString();
        }
    }


    internal class NewUserService
    {
        public static bool attemptSignup(string firstName, string lastName, string email, string birthday, string username, string password, string confirmPassword, DatabaseManager databaseManager)
        {



            string query = @"
                DO $$ 
                DECLARE
                    new_user_id INT;
                BEGIN
                    -- Insert into app_user and store the user_id in the variable
                    INSERT INTO app_user(user_fname, user_lname, user_birthday, user_balance, user_type)
                    VALUES ('@firstName', '@lastName', '@birthday', 0, 'user')
                    RETURNING user_id INTO new_user_id;

                    -- Insert into login_credentials using the new_user_id
                    INSERT INTO login_credentials(lgn_user_id, lgn_username, lgn_password, lgn_email)
                    VALUES (new_user_id, '@username', '@password', '@email');

                    -- Insert into user_wallet using the new_user_id
                    INSERT INTO user_wallet(wallet_user_id)
                    VALUES (new_user_id);
                END $$;";


            using (var dbConnection = databaseManager.GetConnection())
            {
                // Create a command object to execute the query
                var command = new NpgsqlCommand(query, dbConnection);
                Debug.WriteLine("Made command, adding the parameters");
                // Add parameters to the query
                command.Parameters.AddWithValue("@firstName", firstName);
                command.Parameters.AddWithValue("@lastName", lastName);
                command.Parameters.AddWithValue("@email", email);
                command.Parameters.AddWithValue("@username", username);
                command.Parameters.AddWithValue("@password", password);

                //string[] splitBirthday = birthday.Split('-');
                //DateOnly queryBirthday = new DateOnly(int.Parse(splitBirthday[0]), int.Parse(splitBirthday[1]), int.Parse(splitBirthday[2]));
                //command.Parameters.AddWithValue("@birthday", queryBirthday);
                command.Parameters.AddWithValue("@birthday", birthday);

                string finalQuery = QueryDebugging.GetSqlWithParameters(query, command);
                Debug.WriteLine("Final Query: " + finalQuery);
                try
                {
                    dbConnection.Open();
                    Debug.WriteLine("opened connection");
                    // Execute the query and get a reader to read the results
                    int inserted = command.ExecuteNonQuery();

                    {
                        // Check that the number of rows affected by the insert is 3
                        // login_credentals, app_user, and user_wallet all get 1 record inserted
                        if (inserted == 3)
                        {

                            Debug.WriteLine("Successful Signup!");
                            return true;
                        }
                        else
                        {

                            Debug.WriteLine("Signup failed");
                            return false;
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error executing query: {ex.Message}");

                    return false;
                }
            }
        }








    }
}

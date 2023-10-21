using System;
using System.Collections.Generic;
using System.Data.Linq;
using System.Data.SqlClient;
using System.Linq;

namespace week7_rpruitt
{
    public static class DBHelper
    {
        private static readonly string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Administrator\Desktop\Ucla\Week7\week7_rpruitt\Database.mdf;Integrated Security=True";

        public static string ConnectionString { get => connectionString; }

        public static int GuestSave(string firstName, string lastName, string apartmentId)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "INSERT INTO dbo.guests (FirstName,LastName,SignedInStatus,LastModified, ApartmentId) VALUES (@firstname,@lastname,@signedinstatus, @lastmodified, @apartmentId)";

                try
                {
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@firstname", firstName);
                        command.Parameters.AddWithValue("@lastname", lastName);
                        command.Parameters.AddWithValue("@signedinstatus", 1);
                        command.Parameters.AddWithValue("@lastmodified", DateTime.Now);
                        command.Parameters.AddWithValue("@apartmentId", apartmentId);

                        connection.Open();
                        int result = command.ExecuteNonQuery();

                        // Check Error
                        if (result < 0)
                        {
                            Console.WriteLine("Error inserting data into Database!");
                        }

                        return result;
                    }
                }
                catch (Exception ex)
                {
                    throw new Exception("Exception inserting data: " + ex.Message);
                }
            }
        }
        public static int GuestUpdate(string firstName, string lastName)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "UPDATE dbo.guests SET SignedInStatus=@signedinstatus, LastModified=@lastmodified WHERE FirstName=@firstname AND LastName=@lastName";

                try
                {
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@firstname", firstName);
                        command.Parameters.AddWithValue("@lastname", lastName);
                        command.Parameters.AddWithValue("@signedinstatus", 0);
                        command.Parameters.AddWithValue("@lastmodified", DateTime.Now);

                        connection.Open();
                        int result = command.ExecuteNonQuery();

                        // Check Error
                        if (result < 0)
                        {
                            Console.WriteLine("Error updating data into Database!");
                        }

                        return result;
                    }
                }
                catch (Exception ex)
                {
                    throw new Exception("Exception updating data: " + ex.Message);
                }
            }
        }
        public static IEnumerable<Guests> GuestGet()
        {
            DataContext guestContext = new DataContext(connectionString);
            var guests = guestContext.GetTable<Guests>();
            return guests as IEnumerable<Guests>;
        }
    }
}

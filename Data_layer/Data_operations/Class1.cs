using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace clsData1
{
    public class clsData
    {
        static string connection_string = "Server=.;Database=ContactsDB;User Id=sa;Password=123456";
        public static bool is_found(int id, ref string fn,ref string ln,ref string email,
            ref string phone ,ref string address,ref int countryid)
        {
            bool found = false;
            SqlConnection connection = new SqlConnection(connection_string);
            string query = @"select * from Contacts where ContactId=@id";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@id", id);
            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                if(reader.Read())
                {
                    found = true;
                    fn = (string)reader["FirstName"];
                    ln = (string)reader["LastName"];
                    email = (string)reader["Email"];
                    phone = (string)reader["Phone"];
                    address = (string)reader["Address"];
                    countryid = (int)reader["CountryID"];
                }

            }
            catch (Exception ex)
            {
                Console.WriteLine("error " + ex);
            }
            finally
            {
                connection.Close();
            }
            return found;
        }

    }

}

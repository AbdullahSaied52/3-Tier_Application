using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

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

        public static int add_new(string fn, string ln, string email,
    string phone, string address, int countryid)
        {
            SqlConnection connection = new SqlConnection(connection_string);
            string query = @"INSERT INTO Contacts
                                           (FirstName
                                           ,LastName
                                           ,Email
                                           ,Phone
                                           ,Address
                                           ,CountryID)
                                     VALUES
                                           (@FirstName,
                                            @LastName, 
                                            @Email, 
                                            @Phone, 
                                            @Address, 
                                            @CountryID);
		                                   select SCOPE_IDENTITY();";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("FirstName", fn);
            command.Parameters.AddWithValue("LastName", ln);
            command.Parameters.AddWithValue("Email", email);
            command.Parameters.AddWithValue("Phone", phone);
            command.Parameters.AddWithValue("Address", address);
            command.Parameters.AddWithValue("CountryID", countryid);
            try
            {
                connection.Open();
                object result = command.ExecuteScalar();
                if (result != null && int.TryParse(result.ToString(), out int insertedID))
                    return insertedID;
                else
                    return -1;
            }
            catch (Exception ex)
            {
                Console.WriteLine("error " + ex);
            }
            finally
            {
                connection.Close();
            }
            return -1;
        }

        public static bool update(int id, string fn, string ln, string email,
            string phone, string address, int countryid)
        {
            SqlConnection connection = new SqlConnection(connection_string);
            string query = @"UPDATE Contacts
                           SET FirstName= @FirstName		
                              ,LastName = @LastName		
                              ,Email=	  @Email			
                              ,Phone =	  @Phone			
                              ,Address =  @Address		
                              ,CountryID= @CountryID		
                         WHERE ContactID= @ContactID";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("FirstName", fn);
            command.Parameters.AddWithValue("LastName", ln);
            command.Parameters.AddWithValue("Email", email);
            command.Parameters.AddWithValue("Phone", phone);
            command.Parameters.AddWithValue("Address", address);
            command.Parameters.AddWithValue("CountryID", countryid);
            command.Parameters.AddWithValue("ContactID", id);

            try
            {
                connection.Open();
                int result = command.ExecuteNonQuery();
                if (result > 0)
                    return true;
                else
                    return false;
            }
            catch (Exception ex)
            {
                Console.WriteLine("error " + ex);
            }
            finally
            {
                connection.Close();
            }
            return false;
        }

        public static bool delete(int id)
        {
            SqlConnection connection = new SqlConnection(connection_string);
            string query = @"delete Contacts 
                                            where ContactID=@id";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("id", id);
            try
            {
                connection.Open();
                int result = command.ExecuteNonQuery();
                if (result > 0)
                    return true;
                else
                    return false;
            }
            catch (Exception ex)
            {
                Console.WriteLine("error " + ex);
            }
            finally
            {
                connection.Close();
            }
            return false;

        }
        public static DataTable list_all()
        {
            DataTable dt = new DataTable();
            SqlConnection connection = new SqlConnection(connection_string);
            string query = "select *from Contacts";
            SqlCommand command = new SqlCommand(query, connection);
            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                if (reader.HasRows)
                    dt.Load(reader);
                else
                    reader.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine("error " + ex);
            }
            finally
            {
                connection.Close();
            }
            return dt;
        }

        public static bool is_exist(int id)
        {
            bool exist = false;
            SqlConnection connection = new SqlConnection(connection_string);
            string query = @"select FirstName from Contacts where ContactID=@id";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("id", id);
            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                if (reader.HasRows)
                    exist = true;
                else
                {
                    reader.Close();
                    exist = false;
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
            return exist;
        }

    }

}

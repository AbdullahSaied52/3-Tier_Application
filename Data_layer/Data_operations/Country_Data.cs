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
    public class clscountry_data
    {
        static string connection_string = "Server=.;Database=ContactsDB;User Id=sa;Password=123456";
        public static bool found_by_id( int id,ref string name,ref string code)
        {
            bool found = false;

            SqlConnection connection = new SqlConnection(connection_string);
            string query = @"select * from Countries where CountryID=@id";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@id", id);
            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                if (reader.Read())
                {
                    found = true;
                    name = (string)reader["CountryName"];
                    
                    if (reader["Code"] != DBNull.Value)
                        code = (string)reader["Code"];
                    else
                        code = "";
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

        public static bool found_by_name(ref int id, string name, ref string code)
        {
            bool found = false;

            SqlConnection connection = new SqlConnection(connection_string);
            string query = @"select * from Countries where CountryName=@name";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@name", name);
            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                if (reader.Read())
                {
                    found = true;
                    id = (int)reader["CountryID"];

                    if (reader["Code"] != DBNull.Value)
                        code = (string)reader["Code"];
                    else
                        code = "";
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

        public static int add_new(string name,string code)
        {
            SqlConnection connection = new SqlConnection(connection_string);
            string query = @"INSERT INTO Countries
           (CountryName,Code)
     VALUES
           (@name,@code);
            select SCOPE_IDENTITY();";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@name", name);
            if (code != "")
                command.Parameters.AddWithValue("@Code", code);
            else
                command.Parameters.AddWithValue("@Code", System.DBNull.Value);
            try
            {
                connection.Open();
                object result = command.ExecuteNonQuery();
                if (result != null && int.TryParse(result.ToString(), out int insertedID))
                {
                    return insertedID;
                }
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

        public static bool update(int id,string name,string code)
        {
            int result = 0;
            SqlConnection connection = new SqlConnection(connection_string);
            string query = @"UPDATE Countries
                                SET CountryName= @name,
                                    Code=@code
                                 WHERE CountryID=@id";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@name", name);
            if (code != "")
                command.Parameters.AddWithValue("@Code", code);
            else
                command.Parameters.AddWithValue("@Code", System.DBNull.Value);
            command.Parameters.AddWithValue("@id", id);
            try
            {
                connection.Open();
                result = command.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                Console.WriteLine("error " + ex);
            }
            finally
            {
                connection.Close();
            }
            return (result > 0);
        }

        public static bool delete(string name)
        {
            int result = -1;
            SqlConnection connection = new SqlConnection(connection_string);
            string query = @" DELETE FROM Countries
                             WHERE CountryName=@name";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@name", name);
            try
            {
                connection.Open();
                result = command.ExecuteNonQuery();
            }
            catch(Exception ex)
            {
                Console.WriteLine("error " + ex);
            }
            finally
            {
                connection.Close();
            }
            return result>0;
        }

        public static DataTable list()
        {
            DataTable dt = new DataTable();
            SqlConnection connection = new SqlConnection(connection_string);
            string query = @" select * FROM Countries";
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

        public static bool is_exist(string name)
        {
            int result = -1;
            SqlConnection connection = new SqlConnection(connection_string);
            string query = @" select CountryName FROM Countries
                                                        where CountryName=@name";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("name", name);
            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                if (reader.HasRows)
                    result = 1;
            }
            catch (Exception ex)
            {
                Console.WriteLine("error " + ex);
            }
            finally
            {
                connection.Close();
            }
            return result > 0;
        }
    }
}

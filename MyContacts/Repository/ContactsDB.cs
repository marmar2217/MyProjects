using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace MyContacts
{
    class ContactsDB : IContactsDB
    {
        private static string ConnectionString = @"Data Source = . ;Initial Catalog = Unknown ; Integrated Security=true";

        public bool Delete(int ID)
        {
            string query = "Delete from MyContacts Where ContactID = @ID";
            SqlConnection connection = new SqlConnection(ConnectionString);
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@ID", ID);

            try
            {
                connection.Open();
                command.ExecuteNonQuery();
                return true;
            }
            catch
            {
                connection.Close();
                return false;
            }
        }

        public bool Insert(string Name, string Family, int Age, string Mobile, string Email, string Address)
        {
            string query = "Insert Into MyContacts (Name, Family, Age, Mobile, Email, Address) VALUES (@Name1, @Family1, @Age1, @Mobile1, @Email1, @Address1)";
            
            SqlConnection connection = new SqlConnection(ConnectionString);

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@Name1", Name);
            command.Parameters.AddWithValue("@Family1", Family);
            command.Parameters.AddWithValue("@Age1", Age);
            command.Parameters.AddWithValue("@Mobile1", Mobile);
            command.Parameters.AddWithValue("@Email1", Email);
            command.Parameters.AddWithValue("@Address1", Address);
            connection.Open();
            try
            {
                command.ExecuteNonQuery();
                return true;
            }
            catch
            {
                return false;
            }
            finally
            {
                connection.Close();
            }
        }

        public DataTable SelectAll()
        {
            SqlConnection connection = new SqlConnection(ConnectionString);

            string query = "Select * from MyContacts";

            SqlDataAdapter data = new SqlDataAdapter(query, connection);

            DataTable dt = new DataTable();

            data.Fill(dt);

            return dt;
        }

        public DataTable SelectRow(int ContactID)
        {
            SqlConnection connection = new SqlConnection(ConnectionString);

            string query = "Select * from MyContacts where ContactID="+ ContactID;

            SqlDataAdapter adapter = new SqlDataAdapter(query, connection);

            DataTable data = new DataTable();

            adapter.Fill(data);

            return data;
        }

        public bool Update(int ID, string Name,string Family, int Age, string Mobile, string Email, string Address)
        {
            SqlConnection connection = new SqlConnection(ConnectionString);
            string Query = "Update MyContacts Set Name=@Name1,Family=@Family1, Age=@Age1, Mobile=@Mobile1, Email=@Email1, Address=@Address1  Where ContactID = @ID";
           
            try
            {
                SqlCommand command = new SqlCommand(Query, connection);
                command.Parameters.AddWithValue("@ID", ID);
                command.Parameters.AddWithValue("@Name1", Name);
                command.Parameters.AddWithValue("@Family1", Family);
                command.Parameters.AddWithValue("@Age1", Age);
                command.Parameters.AddWithValue("@Mobile1", Mobile);
                command.Parameters.AddWithValue("@Email1", Email);
                command.Parameters.AddWithValue("@Address1", Address);
                connection.Open();
                command.ExecuteNonQuery();
                return true;
            }
            catch
            {
                return false;
            }
            finally
            {
                connection.Close();
            }

        }

    }
}

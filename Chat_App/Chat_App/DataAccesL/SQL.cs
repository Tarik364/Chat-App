using System;
using System.Collections;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;


namespace Chat_App.DataAccesL
{
    public class SQL
    {
        public string connectionString = "Server=31.207.87.147;Database=QBarSupport;User Id=Qbar;Password=1234qbar.;";
        public List<Tuple<string, string>> customerlist = new List<Tuple<string, string>>();
        List<string> userlist = new List<string>();
        public List<Tuple<string, string>> GetCustomer()
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string query = $"SELECT CustomerID as ID, CustomerName as CustomerName FROM [QBarSupport].[dbo].[tblCompany] WITH(NOLOCK)";
                SqlCommand command = new SqlCommand(query, connection);
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    {
                        string ID = reader["ID"].ToString();
                        string CustomerName = reader["CustomerName"].ToString();
                        customerlist.Add(new Tuple<string, string>(ID, CustomerName));
                    };
                }
                reader.Close();
                connection.Close();
            }
            return customerlist;
        }

        public List<User> GetUser()
        {
            List<User> users = new List<User>(); 
            using (SqlConnection connection = new SqlConnection(connectionString))
            {

                connection.Open();
                string query = $"SELECT CustomerID as ID, UserName as UserName FROM [QBarSupport].[dbo].[tblChatUsers] WITH(NOLOCK)";
                SqlCommand command = new SqlCommand(query, connection);
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    {
                        User user = new User();
                        user.UserId = (int)reader["ID"];
                        user.UserName = reader["UserName"].ToString();
                        users.Add(user);
                    };
                }
                reader.Close();
                connection.Close();
            }
            return users;
        }

        public List<ChatMessages> GetMessages(int customerID)
        {
            List<ChatMessages> messages = new List<ChatMessages>();

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string query = "SELECT [messageTime],[messageClient],[message] FROM [QBarSupport].[dbo].[tblMessages] WITH(NOLOCK) WHERE CustomerID = @CustomerID";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@CustomerID", customerID);
                    SqlDataReader reader = command.ExecuteReader();

                    while (reader.Read())
                    {
                        ChatMessages message = new ChatMessages
                        {
                            MessageTime = (DateTime)reader["messageTime"],
                            MessageClient = reader["messageClient"].ToString(),
                            MessageText = reader["message"].ToString()
                        };

                        messages.Add(message);
                    }

                    reader.Close();
                }

                connection.Close();
            }
            return messages;
        }

        public void InsertMessage(int customerId, string messageClient, string messageContent)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                string query = @"INSERT INTO [QBarSupport].[dbo].[tblMessages] ([CustomerID], [messageTime], [messageClient], [message])
                         VALUES (@CustomerId, GETDATE(), @MessageClient, @MessageContent)";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@CustomerId", customerId);
                    command.Parameters.AddWithValue("@MessageClient", messageClient);
                    command.Parameters.AddWithValue("@MessageContent", messageContent);

                    command.ExecuteNonQuery();
                }

                connection.Close();
            }
        }

    }
}

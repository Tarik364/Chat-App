using System;
using System.Collections;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Chat_App.DataAccesL
{
    public class SQL
    {
        public string connectionString = "Server=31.207.87.147;Database=QBarSupport;User Id=Qbar;Password=1234qbar.;";
        public List<Tuple<string, string>> list = new List<Tuple<string, string>>();
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
                        list.Add(new Tuple<string, string>(ID, CustomerName));
                    };
                }
                reader.Close();
                connection.Close();
            }
            return list;
        }
    }
}

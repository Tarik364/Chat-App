using System;
using System.Collections;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chat_App.DataAccesL
{
    internal class SQL
    {
        public string connectionString = "Server=31.207.87.147;Database=QBarSupport;User Id=Qbar;Password=1234qbar.;";
        public ArrayList CustomerList = new ArrayList();
        public int GetCustomer()
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string query = $"SELECT CustomerID as ID, CustomerName as CustomerName FROM tblCustomers WITH(NOLOCK)";
                SqlCommand command = new SqlCommand(query, connection);
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    {
                        CustomerList.Add(reader.) = Convert.ToInt32(reader["ID"]);
                        return rows;
                    };
                }
                reader.Close();
            }
            return 0;
        }

        //VERİTABANINA GİDER KOD ILE SORGUSUNU YAPIP ONUN ADRESİNİ RETURN EDER
        public string GetDegerfromKod(string kod)
        {
            string deger = "";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string query = $"SELECT DEGER FROM PLC_INFO WHERE KOD='{kod}'";
                SqlCommand command = new SqlCommand(query, connection);
                SqlDataReader reader = command.ExecuteReader();

                if (reader.Read())
                {
                    deger = reader["DEGER"].ToString();
                }

                reader.Close();
            }

            return deger;
        }
    }
}

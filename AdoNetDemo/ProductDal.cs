using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdoNetDemo
{
    public class ProductDal
    {
        public DataTable GetAll()
        {

            SqlConnection connection = new SqlConnection(@"server=DESKTOP-HJ161GJ\SQLEXPRESS;initial catalog=ETrade;integrated security=true"
            );
            if (connection.State==ConnectionState.Closed)
            {
                connection.Open();
            }
            SqlCommand command = new SqlCommand("Select * from Products", connection);

            SqlDataReader reader = command.ExecuteReader();

            List<Product> products = new List<Product>();

            while (reader.Read())
            {

            }

            reader.Close();
            connection.Close();
            return dataTable;
        }

        public DataTable GetAll2()
        {

            SqlConnection connection = new SqlConnection(@"server=DESKTOP-HJ161GJ\SQLEXPRESS;initial catalog=ETrade;integrated security=true"
            );
            if (connection.State == ConnectionState.Closed)
            {
                connection.Open();
            }
            SqlCommand command = new SqlCommand("Select * from Products", connection);

            SqlDataReader reader = command.ExecuteReader();

            DataTable dataTable = new DataTable();
            dataTable.Load(reader);
            reader.Close();
            connection.Close();
            return dataTable;
        }
    }
}

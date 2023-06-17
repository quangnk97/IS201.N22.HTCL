using System.Data.SqlClient;

namespace IS201_N22_HTCL.Service
{
    internal class SQLConnection
    {

        public static string connectionString = @"Data Source=DESKTOP-9GL03A9;Initial Catalog=DISC_SHOP_MANAGEMEN;Integrated Security=True";
        public static string GetFieldValues(string SQL)
        {
            string result = "";
            SqlConnection connection = new SqlConnection(connectionString);
            SqlCommand cmd = new SqlCommand(SQL, connection);
            SqlDataReader reader;

            connection.Open();
            reader = cmd.ExecuteReader();
            while (reader.Read())
                result = reader.GetValue(0).ToString();
            reader.Close();
            connection.Close();

            return result;
        }
    }
}

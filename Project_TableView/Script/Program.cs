using Microsoft.Data.SqlClient;

namespace Program {
    class Program {

        static void Main() {
            // Config Sql String
            var sqlStringBuilder = new SqlConnectionStringBuilder();
            sqlStringBuilder.Add("Database", "xtlab");
            sqlStringBuilder.Add("UID", "sa");
            sqlStringBuilder.Add("PWD", "Password123");
            sqlStringBuilder.Add("Server", "localhost,1433");

            // Connect Object 
            using var connection = new SqlConnection(sqlStringBuilder.ToString());

            // Open Connection
            connection.Open();

            Console.WriteLine(connection);
            // Close Connection
            connection.Close();
        }
    }
}
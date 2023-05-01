using System.Data.Common;
using System.Data.SqlClient;
namespace Program
{
    class Program{
        public static void Main() {

            // StringBuild
            var sqlStringBuild = new SqlConnectionStringBuilder();
            sqlStringBuild["Server"] = "localhost";
            sqlStringBuild["Database"] = "xtlab";
            sqlStringBuild["UID"] = "sa";
            sqlStringBuild["PWD"] = "Password123";

            string sqlString = sqlStringBuild.ToString();
            Console.WriteLine(sqlString);

            using var sqlConnection = new SqlConnection(sqlString);

            // Open Connection
            sqlConnection.Open();

            // Query Command
            using DbCommand command = new SqlCommand();
            command.Connection = sqlConnection;
            /*   Connection
                 Command     ----->   ListCommand */
            
            // Sql Text
            // command.CommandText = "SQL";
            command.CommandText = "SELECT * FROM Sanpham WHERE Gia > 100000.00";
            var dataReader = command.ExecuteReader();
            while (dataReader.Read()){
                Console.WriteLine($"{dataReader["TenSanPham"], 50} co gia la : {dataReader["Gia"], 10}");
            }


            // Close Connection
            sqlConnection.Close();
        }
    }
}

using System.Net;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
namespace Program
{
    class ProgramADO {
        // public static void ShowDataTable(DataTable dt) {
            
        //     Console.WriteLine($"TableName : {dt.TableName}");

        //     foreach (DataColumn col in dt.Columns){
        //         Console.Write($"{col.ColumnName, 20}");
        //     }

        //     Console.WriteLine();
        //     int noColumn = dt.Columns.Count;

        //     foreach (DataRow row in dt.Rows){
        //         for (int i = 0; i < noColumn; i++){
        //             Console.Write($"{row[i], 20}");
        //         }
        //         Console.WriteLine();
        //     }
        // }
        public static string getStringBuilder() {
            var stringBuild = "Server:localhost;Database:NorthwindStore;UID:sa;PWD:Password123";
            return stringBuild;
        }

        public static void Main() {
            var stringConnection = new SqlConnectionStringBuilder();
            stringConnection["Server"] = "localhost";
            stringConnection["Database"] = "NorthwindStore";
            stringConnection["UID"] = "sa";
            stringConnection["PWD"] = "Password123";

            using var connection = new SqlConnection(stringConnection.ToString());
            connection.Open();

            SqlDataAdapter adapter = new SqlDataAdapter();
            

            DataTable table = new DataTable("Table");
            DataSet dataSet = new DataSet("DataSet");
            dataSet.Tables.Add(table);
            
            adapter.TableMappings.Add("Ordedr", "Table");
            
            Console.WriteLine(table.DataSet);


            connection.Close();
            


            // // StringBuild
            // var sqlStringBuild = new SqlConnectionStringBuilder();
            // sqlStringBuild["Server"] = "localhost";
            // sqlStringBuild["Database"] = "xtlab";
            // sqlStringBuild["UID"] = "sa";
            // sqlStringBuild["PWD"] = "Password123";

            // string sqlString = sqlStringBuild.ToString();
            // // Console.WriteLine(sqlString);

            // using var sqlConnection = new SqlConnection(sqlString);

            // // Open Connection
            // sqlConnection.Open();

            // // Query Command
            // using DbCommand command = new SqlCommand();
            // command.Connection = sqlConnection;
            // /*   Connection
            //      Command     ----->   ListCommand => Data Adapter */
            
            // // Sql Text
            // // command.CommandText = "SQL";
            // command.CommandText = "SELECT * FROM Sanpham WHERE Gia > 100000.00";
            // // using var dataReader = command.ExecuteReader(); 
            // // while (dataReader.Read()){
            // //     Console.WriteLine($"{dataReader["TenSanPham"], 50} co gia la : {dataReader["Gia"], 10}");
            // // }


            // // //  Command ---> DataTable => DataSet
            // // var dataSet = new DataSet();
            // // // DataTables => Data Collection => DataSet (Local)
            // // // DataStore (DB)
            // // var sanPhamTable = new DataTable("SanPham");
            // // dataSet.Tables.Add(sanPhamTable);
            // // sanPhamTable.Columns.Add("ID");
            // // sanPhamTable.Columns.Add("Ten");
            // // sanPhamTable.Columns.Add("Gia");

            // // sanPhamTable.Rows.Add(1, "Tach tra", 12);
            // // sanPhamTable.Rows.Add(2, "Am chen", 10);
            // // sanPhamTable.Rows.Add(3, "Cay mini", 8);

            // // ShowDataTable(sanPhamTable);


            // // DataAdapter
            // var dataAdapter = new SqlDataAdapter();
            // dataAdapter.TableMappings.Add("Table", "SanPham");
            // dataAdapter.SelectCommand = new SqlCommand("SELECT SanphamID, Gia FROM Sanpham", sqlConnection);
            // // InsertCommand
            // dataAdapter.InsertCommand = new SqlCommand("insert into Sanpham (SanphamID, Gia) values (@SanphamID, @Gia)", sqlConnection);
            // dataAdapter.InsertCommand.Parameters.Add("@Gia", SqlDbType.Int, 13, "Gia");
            // dataAdapter.InsertCommand.Parameters.Add("@SanphamID", SqlDbType.Decimal, 13, "SanphamID");



            // var dataSet = new DataSet();
            // // Đổ dữ liệu từ dataAdapter vào DataSet
            // dataAdapter.Fill(dataSet);
            // DataTable ?table = dataSet.Tables["SanPham"];
            // var row = table?.Rows.Add();
            // row["Gia"] = "280000";
            // row["SanphamID"] = "82";
            // if (table != null) ShowDataTable(table);

            // // Update
            // dataAdapter.Update(dataSet);


            // // Close Connection
            // sqlConnection.Close();
        }
    }
}

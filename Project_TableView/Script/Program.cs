using System.Data;
using System.Data.Common;
using System.Data.SqlClient;

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
            connection.Open();
            
            // Create DataSet
            using var dataSet = new DataSet();

            // Create DataTable
            DataTable nhanVienTable = new DataTable("dtNhanvien");

            // Create DataAdapter
            using var adapter = new SqlDataAdapter();
            adapter.TableMappings.Add("Table", "dtNhanvien");
            // Select Command
            adapter.SelectCommand = new SqlCommand("SELECT NhanviennID, Ten, Ho FROM Nhanvien", connection);
            // InsertCommand
            adapter.InsertCommand = new SqlCommand("INSERT INTO Nhanvien (Ho, Ten) VALUES (@Ho, @Ten)", connection);
            adapter.InsertCommand.Parameters.Add("@Ho", SqlDbType.NVarChar, 255, "Ho");
            adapter.InsertCommand.Parameters.Add("@Ten", SqlDbType.NVarChar, 255, "Ten");
            // var insParam = adapter.InsertCommand.Parameters.Add(new SqlParameter("@NhanviennID",  SqlDbType.Int));
            // insParam.SourceColumn = "NhanviennID";
            // insParam.SourceVersion = DataRowVersion.Original;

            // Delete Command
            adapter.DeleteCommand = new SqlCommand("DELETE FROM Nhanvien WHERE NhanviennID = @NhanviennID", connection);
            var delPar = adapter.DeleteCommand.Parameters.Add(new SqlParameter("@NhanviennID", SqlDbType.Int));
            delPar.SourceColumn = "NhanviennID";
            delPar.SourceVersion = DataRowVersion.Original;

            // Update Command
            adapter.UpdateCommand = new SqlCommand("UPDATE Nhanvien SET Ho=@Ho, Ten=@Ten WHERE NhanviennID = @NhanviennID", connection);
            adapter.UpdateCommand.Parameters.Add("@Ho", SqlDbType.NVarChar, 255, "Ho");
            adapter.UpdateCommand.Parameters.Add("@Ten", SqlDbType.NVarChar, 255, "Ten");
            var upPar = adapter.UpdateCommand.Parameters.Add("@NhanviennID", SqlDbType.Int);
            upPar.SourceColumn = "NhanviennID";
            upPar.SourceVersion = DataRowVersion.Original;

            // Open Connection
            adapter.Fill(nhanVienTable);

            ShowDataTable(nhanVienTable);
            Console.WriteLine(nhanVienTable.DefaultView);
            /**/
            // DataRow newRow = nhanVienTable.Rows.Add();
            // newRow["Ho"] = "Nguyet";
            // newRow["Ten"] = "Quynh";
            // newRow["NhanviennID"] = nhanVienTable.Rows.Count;
            
            //nhanVienTable.Rows[10].Delete();
            
            // var selectRow = nhanVienTable.Rows[10];
            // selectRow["Ho"] = "Tran";
            /**/

            adapter.Update(nhanVienTable);
            // Close Connection
            connection.Close();
        }

        static void ShowDataTable(DataTable dt) {
            foreach (DataColumn col in dt.Columns) {
                Console.Write($"{col.ColumnName, 15}");
            }
            Console.WriteLine();
            int noColumn = dt.Columns.Count;
            foreach (DataRow row in dt.Rows) {
                for (int i = 0; i < noColumn; i++){
                    Console.Write($"{row[i], 15}");
                }
                Console.WriteLine();
            }


        }
    }
}
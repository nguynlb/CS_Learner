using System.Windows;
using System.Data.SqlClient;
using System.Data;
using System;

namespace WindowApp
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        private SqlConnection? connection;
        private DataSet dataSet = new DataSet();
        private DataTable nhanVienTable = new DataTable("dtNhanvien");
        private SqlDataAdapter adapter = new SqlDataAdapter();


        public MainWindow()
        {
            initConnection();
            InitializeComponent();
        }

        // Connection
        private void initConnection()
        {
            // Connect Object 
            connection = new SqlConnection(GetConnectionString());
            connection.Open();

            // Create DataAdapter
            adapter.TableMappings.Add("Table", "dtNhanvien");
            // Select Command
            adapter.SelectCommand = new SqlCommand("SELECT NhanviennID, Ho, Ten FROM Nhanvien", connection);
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

    }

        private string GetConnectionString()
        {
            var sqlStringBuilder = new SqlConnectionStringBuilder();
            sqlStringBuilder.Add("Database", "xtlab");
            sqlStringBuilder.Add("UID", "sa");
            sqlStringBuilder.Add("PWD", "Password123");
            sqlStringBuilder.Add("Server", "localhost,1433");

            return sqlStringBuilder.ToString();
        }

        private void LoadData()
        {
            nhanVienTable.Rows.Clear();
            adapter.Fill(nhanVienTable);
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            LoadData();
            tableView.DataContext = nhanVienTable.DefaultView;
        }


        private void loadBtn_Click(object sender, RoutedEventArgs e)
        {
            LoadData();
        }

        private void updateBtn_Click(object sender, RoutedEventArgs e)
        {
            adapter.Update(nhanVienTable);
            LoadData();
        }

        private void deleteBtn_Click(object sender, RoutedEventArgs e)
        {
            // DataRowView
            DataRowView selectedRow = (DataRowView)tableView.SelectedItem;
            if (selectedRow != null)
            {
                selectedRow.Delete();
            }
        }


    }
}

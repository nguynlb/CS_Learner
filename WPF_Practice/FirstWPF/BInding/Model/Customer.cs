using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Linq;
using System.Security.Permissions;
using System.Text;
using System.Threading.Tasks;

namespace BInding.Model
{
    public class Customer
    {
        private int _id;
        private string _firstName;
        private string _lastName;
        private int _totalOrder;

        private DataSet _dataSet;
        public DataTable _customerTable;
        public Customer()
        {
            _customerTable = new DataTable("CustomerOrder");
            _dataSet = new DataSet();
            _dataSet.Tables.Add(_customerTable);
        }
        public Customer(int id, string firstName, string lastName, int totalOrder)
        {
            _customerTable = new DataTable("CustomerOrder");
            _dataSet = new DataSet();
            _dataSet.Tables.Add(_customerTable);
            Id = id;
            FirstName = firstName;
            LastName = lastName;
            TotalOrder = totalOrder;
        }

        public int Id
        {
            get { return _id; }
            set { _id = value; }
        }
        public string FirstName
        {
            get { return _firstName; }
            set { _firstName = value; }
        }
        public string LastName { get => _lastName; set => _lastName = value; }
        public int TotalOrder { get => _totalOrder; set => _totalOrder = value; }


        public void LoadCustomer()
        {
            var sqlString = new SqlConnectionStringBuilder();
            sqlString["Server"] = "localhost";
            sqlString["Database"] = "NorthwindStore";
            sqlString["UID"] = "sa";
            sqlString["PWD"] = "Password123";

            using SqlConnection connection = new SqlConnection(sqlString.ToString());
            connection.Open();

            using SqlDataAdapter adapter = new SqlDataAdapter();
            adapter.SelectCommand = new SqlCommand(@"SELECT Id, ISNULL(TotalOrder, 0) as TotalOrder, c.LastName, c.FirstName 
                                                     FROM [Customer] c   
                                                     LEFT JOIN (SELECT count([Order].[CustomerId]) as TotalOrder, [Order].CustomerID
                                                     FROM [Order] GROUP BY [Order].CustomerID) o 
                                                     ON o.CustomerID = c.Id", 
                                                     connection);
            adapter.TableMappings.Add("Table", "CustomerOrder");
            adapter.Fill(_customerTable);

            connection.Close();

        }

    }
}

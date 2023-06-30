using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Markup;
using System.DirectoryServices.ActiveDirectory;

namespace WpfDisconnectedModels
{
    internal class Data
    {
        // fields
        private SqlConnection _conn;
        private SqlDataAdapter _adapter;
        private SqlCommandBuilder _commandBuilder;
        private DataSet? _dataSet;
        private DataTable? _dataTable;

        private static string _connStr = @"Data Source=(LocalDB)\MSSQLLocalDB;
                                        Initial Catalog=Northwind;
                                        Integrated Security = True;";



        public static string ConnectionStr { get => _connStr; }

        // Constructor      ////
        public Data()
        {
            string query = "Select p.ProductID, p.ProductName, c.CategoryName, c.CategoryID  from Products p INNER JOIN Categories c ON p.CategoryID = c.CategoryID";

            _conn = new SqlConnection(ConnectionStr);
            _adapter = new SqlDataAdapter(query, _conn);
            _commandBuilder = new SqlCommandBuilder(_adapter);          //

            FillDataSet();
        }

        // Methods

        private void FillDataSet()      //////////
        {
            // reset DataSet
            _dataSet = new DataSet();

            _adapter.Fill(_dataSet);
            _dataTable = _dataSet.Tables[0];

            // Define Primary Key
            DataColumn[] pk = new DataColumn[1];
            pk[0] = _dataTable.Columns["ProductID"];
            pk[0].AutoIncrement = true;
            _dataTable.PrimaryKey = pk;




        }
        public DataTable GetAllProducts()
        {
            SqlConnection conn = new SqlConnection(ConnectionStr);
            string query = "Select p.ProductID, p.ProductName, c.CategoryName, c.CategoryID  from Products p INNER JOIN Categories c ON p.CategoryID = c.CategoryID";
            SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
            DataSet ds = new DataSet();

            adapter.Fill(ds, "Products");
            DataTable tblProducts = ds.Tables["Products"];
            return tblProducts;



        }

        public DataRow GetProductById(int id)
        {
            // find a row based on its primary key
            DataRow row = _dataTable.Rows.Find(id);         //DataTable > DataRow 

            return row;
        }









        ///
        public DataTable GetAllProductsByCategoryId(int catId)
        {
            SqlConnection conn = new SqlConnection(ConnectionStr);
            string query = "Select p.ProductID, p.ProductName, c.CategoryName, c.CategoryID from Products p INNER JOIN Categories c ON p.CategoryID = c.CategoryID WHERE c.CategoryID = @CategoryID";

  


            SqlDataAdapter adapter = new SqlDataAdapter(query, conn);

            adapter.SelectCommand.Parameters.AddWithValue("CategoryID", catId);         /////


            DataSet ds = new DataSet();

            adapter.Fill(ds, "Products");
            DataTable tblProducts = ds.Tables["Products"];
            return tblProducts;



        }

        public DataTable GetAllCategories()
        {

            SqlConnection conn = new SqlConnection(ConnectionStr);
            string query = "Select CategoryName, CategoryID  from Categories";
            SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
            DataSet ds = new DataSet();

            adapter.Fill(ds, "Categories");
            DataTable tblCategories = ds.Tables["Categories"];

            //tblCategories.Columns[0].ColumnName = "CategoryName";
            //tblCategories.Columns[1].ColumnName = "CategoryID"; 

            return tblCategories; 
        }

    }


}

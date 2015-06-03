using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using ConnectDB;

namespace ConnectDB.SQLServer
{
    public class FetchData
        : IDataSource
    {
        public string ReturnData { get; set; }

        public SqlConnection Connection { get; set; }


        public void GetData()
        {

            string sqlString = "SELECT name FROM dbo.table1";

            var cmd = Connection.CreateCommand();
            cmd.CommandText = sqlString;

            cmd.Connection = Connection;

            var reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                ReturnData = reader["name"].ToString();

            }

        }

        public void ConnectToDataSource()
        {
            SqlConnection _sqlcon = new SqlConnection("server=(localdb)\\v11.0;integrated security=yes;Database=ConnectTest");

            Connection = _sqlcon;

            using (Connection)
            {
                _sqlcon.Open();

                Console.WriteLine("SQL Server connection state: {0}", _sqlcon.State);

                GetData();


            }

        }
    }
}

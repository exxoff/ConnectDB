using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Common;
using System.Data.SqlClient;
using System.Data;


namespace ConnectDB
{
    class SqlServerGetData
        : IDataRetriver
    {

        private string _returnData;
        private IDbConnection _connection;


        public string ReturnData
        {
            get
            {
                return _returnData;
            }
            set
            {
                _returnData = value;

            }
        }

        public System.Data.IDbConnection Connection
        {
            get
            {
                return _connection;
            }
            set
            {
                _connection = value;
            }
        }

        public void GetData()
        {
            string sqlString = "SELECT name FROM dbo.table1";

            var cmd = Connection.CreateCommand();
            cmd.CommandText = sqlString;

            cmd.Connection = Connection;

            var reader = cmd.ExecuteReader();

            while(reader.Read())
            {
                ReturnData = reader["name"].ToString();

            }
                
            
            
        }
    }
}

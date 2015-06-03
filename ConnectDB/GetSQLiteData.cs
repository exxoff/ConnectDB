using System;
using System.Data.SQLite;


namespace ConnectDB
{
    //class GetSQLiteData
    //    : IOpenDataConnection
    //{
    //    public string ReturnData { get; set; }

    //    public SQLiteConnection Connection { get; set; }
 
    //    public void GetData()
    //    {
    //        string sqlString = "SELECT name FROM table1";

    //        var cmd = Connection.CreateCommand();
    //        cmd.CommandText = sqlString;

    //        cmd.Connection = Connection;

    //        var reader = cmd.ExecuteReader();

    //        while (reader.Read())
    //        {
    //            ReturnData = reader["name"].ToString();

    //        }
    //    }

    //    public void ConnectToDataSource()
    //    {
    //        SQLiteConnection _sqLiteCon = new SQLiteConnection("Data source=c:\\temp\\ConnectTest.sqlite; Version=3");

    //        Connection = _sqLiteCon;

    //        using (Connection)
    //        {
    //            Connection.Open();

    //            Console.WriteLine("SQLite connection state: {0}", Connection.State);

    //            GetData();

    //        }
            
    //    }
    //}
}

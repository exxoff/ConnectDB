using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace ConnectDB
{
    interface IDataRetriver
    {
        string ReturnData { get; set; }
        IDbConnection Connection { get; set; }
        void GetData();
        
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConnectDB
{
    public interface IDataSource
    {
        string ReturnData { get; set; }
        void GetData();
        void ConnectToDataSource();
        
    }
}

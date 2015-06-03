using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;


namespace ConnectDB
{
    class DataFactory
    {
        public static IDataSource GetConnectionType()
        {
            


            string typeName = ConfigurationManager.AppSettings["RepositoryType"];

            Type repoType = Type.GetType(typeName);

            object repoInstance = Activator.CreateInstance(repoType);

            IDataSource conn = repoInstance as IDataSource;
            
            return conn;
        }
    }
}

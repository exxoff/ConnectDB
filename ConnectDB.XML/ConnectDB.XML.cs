using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using ConnectDB;


namespace ConnectDB.XML
{
    class FetchData
        : IDataSource
    {

        public string ReturnData { get; set; }

        public void GetData()
        {
            XDocument doc = XDocument.Load("I:\\MyData\\Development\\Visual Studio\\C#\\Utbildning\\ConnectDB\\ConnectDB\\ConnectTest.xml");


            var names = from x in doc.Descendants("root")
                        select x.Element("name").Value;

            
            foreach (var name in names)
            {
                ReturnData = name;

            }
        }

        public void ConnectToDataSource()
        {

            // There's nothing to connect to here so we just move on to data retrieval.
            GetData();

        }
    }
}

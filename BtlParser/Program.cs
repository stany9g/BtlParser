using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BtlParser
{
    class Program
    {
        static void Main(string[] args)
        {
            string filePath = "C:\\Users\\stany\\Downloads\\BaseXMLs\\Copy of R_T001.BA91M11.134.807.216.916 v1.0 T001 2012-01-01_1#BA91M11.134807216916.xml";
            IStatementsParser xml = new XmlStatementsParser(filePath);
        }
    }
}

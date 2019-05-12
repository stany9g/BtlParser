using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Linq;

namespace BtlParser
{
    public class XmlStatements : IStatements
    {
        public IEnumerable<string> Morphology { get; private set; }

        public IEnumerable<string> Rhythms { get; private set; }

        public XmlStatements(string filePath)
        {
            Rhythms = XmlParser.GetStatements(filePath, "Rhythm");
            Morphology = XmlParser.GetStatements(filePath, "Morphology");
        }
    }
}

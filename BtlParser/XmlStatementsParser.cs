using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Linq;

namespace BtlParser
{
    public class XmlStatementsParser : IXmlStatementsParser
    {
        public IEnumerable<string> Morphology { get; private set; }

        public IEnumerable<string> Rhythms { get; private set; }

        public XmlStatementsParser(string filePath)
        {
            var xml = XDocument.Load(filePath);
            Rhythms = GetStatements(xml, "Rhythm");
            Morphology = GetStatements(xml, "Morphology");
        }


        private IEnumerable<string> GetStatements(XDocument xml, string statementType)
        {
            return xml.Descendants("statement").Where(x => x.FirstAttribute.Value == statementType).Select(x => x.Value).ToList();
        }
    }
}

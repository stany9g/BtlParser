using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace BtlParser
{
    public static class XmlParser
    {
        public static IEnumerable<string> GetStatements(string filePath, string statementType)
        {
            var xml = XDocument.Load(filePath);
            return xml.Descendants("statement").Where(x => x.FirstAttribute.Value == statementType).Select(x => x.Value).ToList();
        }

        public static string GetValueOfAttribute(string filePath, string element, string attribute)
        {
            var xml = XDocument.Load(filePath);
            return xml.Descendants(element).Attributes(attribute).Select(x => x.Value).Single();
        }
    }
}

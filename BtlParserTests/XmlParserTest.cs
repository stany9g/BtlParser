using BtlParser;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BtlParserTests
{
    [TestClass]
    public class XmlParserTest
    {
        [DataTestMethod]
        [DeploymentItem("Resources\\test.xml")]
        [DataRow("test.xml")]
        public void GetValueOfAttributeTest(string filePath)
        {
            // Arrange
            var expectedFirstName = "1100 T.0v";
            var expectedSurName = "60916B297M81413..101.A1..01T";


            // Assert & Act
            Assert.AreEqual(expectedFirstName, XmlParser.GetValueOfAttribute(filePath, "patient", "firstName"));
            Assert.AreEqual(expectedSurName, XmlParser.GetValueOfAttribute(filePath, "patient", "surname"));
        }
    }
}

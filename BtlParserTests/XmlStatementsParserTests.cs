using System;
using System.Collections.Generic;
using System.Linq;
using BtlParser;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace BtlParserTests
{
    [TestClass]
    public class XmlStatementsParserTests
    {
        [DataTestMethod]
        [DeploymentItem("Resources\\test.xml")]
        [DataRow("test.xml")]
        public void StatementsDataTest(string filePath)
        {
            // Arrange
            var expectedMorphology = new List<string>
            {
                "VCLVH - Left ventricular hypertrophy-amplit.crit.only",
                "BNECG - Borderline normal ECG"
            };
            var expectedRhytms = new List<string>
            {
                "SR - Sinus rhythm"
            };


            // Act
            IStatements xmlStatementsParser = new XmlStatements(filePath);


            // Assert
            CollectionAssert.AreEqual(expectedMorphology, xmlStatementsParser.Morphology.ToList(), "Testing Morphology statements");
            CollectionAssert.AreEqual(expectedRhytms, xmlStatementsParser.Rhythms.ToList(), "Testing Rhythms statements");
        }

        [DataTestMethod]
        [DeploymentItem("Resources\\tests.xml")]
        [DataRow("tests.xml")]
        public void NoStatementsDataTest(string filePath)
        {
            // Arrange
            var expectedMorphology = new List<string>();
            var expectedRhytms = new List<string>();

            // Act
            IStatements xmlStatementsParser = new XmlStatements(filePath);

            // Assert
            CollectionAssert.AreEqual(expectedMorphology, xmlStatementsParser.Morphology.ToList(), "Testing Morphology statements");
            CollectionAssert.AreEqual(expectedRhytms, xmlStatementsParser.Rhythms.ToList(), "Testing Rhythms statements");

        }
    }
}

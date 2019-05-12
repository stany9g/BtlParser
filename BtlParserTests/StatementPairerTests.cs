using BtlParser;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BtlParserTests
{
    [TestClass]
    public class StatementPairerTests
    {
        [TestMethod]
        public void RightPairingTest()
        {
            // Arrange
            string testPath = Directory.GetCurrentDirectory();

            IStatementsPairer statementsPairer = new StatementsPairer();

            // Act
            statementsPairer.MakePairs(testPath, testPath);

            // Assert
            Assert.IsTrue(statementsPairer.Pairs.Count() == 2);
        }

        [TestMethod]
        public void RightPairingPatientTest()
        {
            // Arrange
            string testPath = Directory.GetCurrentDirectory();

            IStatementsPairer statementsPairer = new StatementsPatientPairer();

            // Act
            statementsPairer.MakePairs(testPath, testPath);

            // Assert
            Assert.IsTrue(statementsPairer.Pairs.Count() == 2);
        }
    }
}

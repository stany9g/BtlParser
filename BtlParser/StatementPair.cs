using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BtlParser
{
    public class StatementPair : IStatementsPair
    {
        public string ReferencePath { get; }

        public string AnalysisPath { get; }

        public IStatementsParser ReferenceStatements { get; }

        public IStatementsParser AnalysisStatements { get; }

        public StatementPair(string referencePath, string analysisPath)
        {
            ReferencePath = referencePath;
            AnalysisPath = analysisPath;
            ReferenceStatements = new XmlStatementsParser(referencePath);
            AnalysisStatements = new XmlStatementsParser(analysisPath);
        }
    }
}

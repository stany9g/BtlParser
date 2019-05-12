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

        public IStatements ReferenceStatements { get; }

        public IStatements AnalysisStatements { get; }

        public bool Paired { get; private set; }

        public StatementPair(string referencePath, string analysisPath, bool paired)
        {
            ReferencePath = referencePath;
            AnalysisPath = analysisPath;
            ReferenceStatements = new XmlStatements(referencePath);
            AnalysisStatements = new XmlStatements(analysisPath);
        }
    }
}

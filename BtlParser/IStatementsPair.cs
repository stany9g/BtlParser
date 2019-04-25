using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BtlParser
{
    public interface IStatementsPair
    {
        /// <summary>
        /// The path of the reference Xml
        /// </summary>
        string ReferencePath { get; }

        /// <summary>
        /// The path of the analysis Xml
        /// </summary>
        string AnalysisPath { get;  }

        /// <summary>
        /// Contains reference statements of one xml
        /// </summary>
        IStatementsParser ReferenceStatements { get;  }

        /// <summary>
        /// Contains analysis statements of one xml
        /// </summary>
        IStatementsParser AnalysisStatements { get; }
    }
}

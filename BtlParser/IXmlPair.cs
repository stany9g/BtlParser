using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BtlParser
{
    interface IXmlPair
    {
        /// <summary>
        /// The reference path of the current Xml
        /// </summary>
        string ReferencePath { get; }

        /// <summary>
        /// The analysis path of the current Xml
        /// </summary>
        string AnalysisPath { get;  }

        /// <summary>
        /// Contains reference statements of one xml
        /// </summary>
        IXmlStatementsParser ReferenceStatements { get;  }

        /// <summary>
        /// Contains analysis statements of one xml
        /// </summary>
        IXmlStatementsParser AnalysisStatements { get; }

    }
}

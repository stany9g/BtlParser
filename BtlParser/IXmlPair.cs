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
        /// The path of the current Xml
        /// </summary>
        string FilePath { get; set; }

        /// <summary>
        /// Contains statements of one xml
        /// </summary>
        IXmlStatementsParser Statements { get; set; }

    }
}

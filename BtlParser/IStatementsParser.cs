using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BtlParser
{
    public interface IStatementsParser
    {
        /// <summary>
        /// Contains all the morphology statements
        /// </summary>
        IEnumerable<string> Morphology { get; }

        /// <summary>
        /// Contains all the rhythm statements
        /// </summary>
        IEnumerable<string> Rhythms { get; }
    }
}

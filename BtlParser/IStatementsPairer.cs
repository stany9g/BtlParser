using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BtlParser
{
    public interface IStatementsPairer
    {
        /// <summary>
        /// Contains all the morphology statements
        /// </summary>
        IEnumerable<IStatementsPair> Pairs { get; }

        /// <summary>
        /// Fill the <see cref="Pairs"/> with the data from directory
        /// </summary>
        /// <param name="referenceDirectory"></param>
        /// <param name="analysisDirectory"></param>
        void MakePairs(string referenceDirectory, string analysisDirectory);
    }
}

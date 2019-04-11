using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BtlParser
{
    interface IXmlPairer
    {
        /// <summary>
        /// Contains all the morphology statements
        /// </summary>
        IEnumerable<IXmlPair> Pairs { get; }

        /// <summary>
        /// Fill the <see cref="Pairs"/> with the data from directory
        /// </summary>
        /// <param name="referenceDirectory"></param>
        /// <param name="analysisDirectory"></param>
        void MakePairs(string referenceDirectory, string analysisDirectory);
    }
}

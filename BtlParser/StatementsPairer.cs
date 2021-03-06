﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BtlParser
{
    public class StatementsPairer : IStatementsPairer
    {
        public IEnumerable<IStatementsPair> Pairs { get; private set; }

        public void MakePairs(string referenceDirectory, string analysisDirectory)
        {
            if (!Directory.Exists(referenceDirectory))
            {
                throw new DirectoryNotFoundException($"{referenceDirectory} does not exists");
            }
            if (!Directory.Exists(analysisDirectory))
            {
                throw new DirectoryNotFoundException($"{analysisDirectory} does not exists");
            }

           var referenceFiles = Directory.GetFiles(referenceDirectory, "*.xml");
           var analysisFiles = Directory.GetFiles(analysisDirectory, "*.xml");

            if(referenceFiles.Count() != analysisFiles.Count())
            {
                throw new InvalidOperationException($"Počet souborů není totožný, neporovnávate stejně velké složky.");
            }
           var pairs = new List<IStatementsPair>();
           for (int i = 0; i < referenceFiles.Count(); i++)
           {
                var pair = new StatementPair(referenceFiles[i], analysisFiles[i], true);
                pairs.Add(pair);
           }
           Pairs = pairs;
        }
    }
}

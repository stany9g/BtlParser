using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BtlParser
{
    public class StatementsPatientPairer : IStatementsPairer
    {
        public IEnumerable<IStatementsPair> Pairs { get { return _pairs; } }

        private List<IStatementsPair> _pairs;

        /// <summary>
        /// Pairs the files by patient firstName and lastName
        /// </summary>
        /// <param name="referenceDirectory"></param>
        /// <param name="analysisDirectory"></param>
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

            var referenceNames = GetPatientsNames(referenceFiles);
            var analysisNames = GetPatientsNames(analysisFiles);

            _pairs = new List<IStatementsPair>();

            referenceNames.ToList().ForEach(x =>
            {
                _pairs.Add(FindPair(x, analysisNames));
            });
        }


        private IEnumerable<XmlInfosForPairing> GetPatientsNames(IEnumerable<string> files)
        {
            List<XmlInfosForPairing> xmlInfos = new List<XmlInfosForPairing>();
            string patient = "patient";
            files.ToList().ForEach(x =>
            {
                var xmlInfo = new XmlInfosForPairing
                {
                    FilePath = x,
                    FirstName = XmlParser.GetValueOfAttribute(x, patient, "firstName"),
                    Surname = XmlParser.GetValueOfAttribute(x, patient, "surname")
                };
                xmlInfos.Add(xmlInfo);
            });
            return xmlInfos;
        }


        private IStatementsPair FindPair(XmlInfosForPairing reference, IEnumerable<XmlInfosForPairing> analyses)
        {
            foreach(var analysis in analyses)
            {
                if(string.Equals(reference.FirstName,analysis.FirstName) && string.Equals(reference.Surname, analysis.Surname))
                {
                    return new StatementPair(reference.FilePath, analysis.FilePath, true);
                }
                else
                {
                    return new StatementPair(reference.FilePath, "", false);
                }
            }
            throw new InvalidOperationException("Analyses can not be empty");
        }
    }

    struct XmlInfosForPairing
    {
        public string FilePath { get;  set; }
        public string FirstName { get;  set; }
        public string Surname { get;  set; }
        public bool Paired { get; set; }
    }
}

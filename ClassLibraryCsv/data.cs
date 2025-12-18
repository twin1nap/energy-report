using ClassLibraryCsv.models;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibraryCsv
{
    public class data
    {
        //string csvPath = "meterstanden_gas_2022.csv";

        public List<GasData> GetGas(string csvPath)
        {
            List<GasData> gasFromCsvs = new List<GasData>();
            List<GasData> gasParced = new List<GasData>();

            string[] GasLines = File.ReadAllLines(csvPath);
            for (int i = GasLines.Length - 1; i > 0; i--)
            {
                string line = GasLines[i];
                string[] parts = line.Split(';');

                GasData row = new GasData
                {
                    OpnameDatum = DateTime.Parse(parts[0]),
                    Gas = int.Parse(parts[1])
                };
                gasFromCsvs.Add(row);
            }

            for (int i = 1; i < gasFromCsvs.Count; i++)
            {
                GasData row = new GasData
                {
                    OpnameDatum = gasFromCsvs[i].OpnameDatum,
                    Gas = (gasFromCsvs[i].Gas - gasFromCsvs[i - 1].Gas)
                };
                gasParced.Add(row);
            }

            return gasParced;
        }

        public List<StroomData> GetStroom(string csvPath)
        {
            List<StroomData> stroomFromCsvs = new List<StroomData>();
            List<StroomData> StroomParced = new List<StroomData>();

            string[] StroomLines = File.ReadAllLines(csvPath);
            for (int i = StroomLines.Length - 1; i > 0; i--)
            {
                string line = StroomLines[i];
                string[] parts = line.Split(';');

                StroomData row = new StroomData
                {
                    OpnameDatum = DateTime.Parse(parts[0]),
                    StandNormaal = int.Parse(parts[1]),
                    StandDal = int.Parse(parts[2]),
                    TerugleveringNormaal = int.Parse(parts[3]),
                    TerugleveringDal = int.Parse(parts[4])
                    //Gas = int.Parse(parts[1])
                };
                stroomFromCsvs.Add(row);
            }

            for (int i = 1; i < stroomFromCsvs.Count; i++)
            {
                StroomData row = new StroomData
                {
                    OpnameDatum = stroomFromCsvs[i].OpnameDatum,
                    StandNormaal = (stroomFromCsvs[i].StandNormaal - stroomFromCsvs[i - 1].StandNormaal),
                    StandDal = (stroomFromCsvs[i].StandDal - stroomFromCsvs[i - 1].StandDal),
                    TerugleveringNormaal = (stroomFromCsvs[i].TerugleveringNormaal - stroomFromCsvs[i - 1].TerugleveringNormaal),
                    TerugleveringDal = (stroomFromCsvs[i].TerugleveringDal - stroomFromCsvs[i - 1].TerugleveringDal)
                };
                StroomParced.Add(row);
            }

            return StroomParced;
        }
    }
}

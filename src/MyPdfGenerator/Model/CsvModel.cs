using Microsoft.VisualBasic.FileIO;
using System;
using System.Collections.Generic;

namespace Model
{
    public class CsvModel
    {
        private List<string[]> table;

        public void LoadCsv(string csvFilePath)
        {
            table = new List<string[]>();
            using (TextFieldParser parser = new TextFieldParser(csvFilePath))
            {
                parser.Delimiters = new string[] { "," };
                while (!parser.EndOfData)
                {
                    string[] fields = parser.ReadFields();
                    this.table.Add(fields);
                }
            }
        }

        public List<string> GetHeaderList()
        {
            if (table == null) throw new NotSupportedException("Call LoadCsv method before calling GetHeaderList method.");

            return new List<string>(this.table[0]);
        }
    }
}

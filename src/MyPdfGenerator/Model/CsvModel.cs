using Microsoft.VisualBasic.FileIO;
using System;
using System.Collections.Generic;

namespace Model
{
    public class CsvModel
    {
        private List<string[]> table;

        public List<CheckItem> HeaderItems { get; set; }

        public void LoadCsv(string csvFilePath)
        {
            this.table = new List<string[]>();
            using (TextFieldParser parser = new TextFieldParser(csvFilePath))
            {
                parser.Delimiters = new string[] { "," };
                while (!parser.EndOfData)
                {
                    string[] fields = parser.ReadFields();
                    this.table.Add(fields);
                }
            }

            this.HeaderItems = new List<CheckItem>();
            foreach(string head in this.table[0])
            {
                CheckItem item = new CheckItem();
                item.Text = head;
                item.IsChecked = true;
                this.HeaderItems.Add(item);
            }
        }

        public List<CheckItem> GetHeaderList()
        {
            if (this.HeaderItems.Count == 0) throw new NotSupportedException("Call LoadCsv method before calling GetHeaderList method.");

            return this.HeaderItems;
        }

        public List<string[]> GetContentTable()
        {
            if (this.table.Count == 0) throw new NotSupportedException("Call LoadCsv method before calling GetHeaderList method.");

            return table.GetRange(1, table.Count - 1);
        }
    }
}

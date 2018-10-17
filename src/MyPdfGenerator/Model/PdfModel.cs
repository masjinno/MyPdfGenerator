using iTextSharp.text;
using PdfLib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class PdfModel
    {
        private IPdfLogic pdfLogic;

        public void Init()
        {
            pdfLogic = new PdfLogic();
        }

        public void ConvertCsvToPdf(string csvFilePath, string pdfFilePath)
        {
            throw new NotImplementedException();
        }

        public void SetDstPageSize(PageSize pageSize)
        {

        }
    }
}

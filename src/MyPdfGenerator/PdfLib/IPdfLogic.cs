using iTextSharp.text;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PdfLogic
{
    public interface IPdfLogic
    {
        void Init();
        void ConvertCsvToPdf(string csvFile, string pdfFile);
        void SetDstPageSize(PageSize pageSize);
        void SetDstMargin(Margin margin);
        void SetDstFontSize(float fontSize);
        void SetDstFontFamily(string fontName);
        PageSize[] GetPageSizeList();
    }
}

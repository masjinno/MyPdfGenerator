using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using iTextSharp.text;

namespace PdfLib
{
    public class PdfLogic : IPdfLogic
    {
        private PageSize dstPageSize;
        private Margin dstMargin;
        private float dstFontSize;
        private string dstFontName;

        public void Init()
        {
            throw new NotImplementedException();
        }

        public void ConvertCsvToPdf(string csvFile, string pdfFile)
        {
            throw new NotImplementedException();
        }

        public void SetDstPageSize(PageSize pageSize)
        {
            this.dstPageSize = pageSize;
        }

        public void SetDstMargin(Margin margin)
        {
            this.dstMargin = margin;
        }

        public void SetDstFontSize(float fontSize)
        {
            this.dstFontSize = fontSize;
        }

        public void SetDstFontFamily(string fontName)
        {
            this.dstFontName = fontName;
        }

        public PageSize[] GetPageSizeList()
        {
            Array pageSizes = Enum.GetValues(typeof(PageSize));
            PageSize[] ret = new PageSize[pageSizes.Length];
            for (int index=0; index< pageSizes.Length; index++)
            {
                ret[index] = (PageSize)pageSizes.GetValue(index);
            }
            return ret;
        }
    }
}

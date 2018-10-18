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
        private float dstHeaderFontSize;
        private string dstHeaderFontName;
        private string dstHeaderMarkupStart;
        private string dstHeaderMarkupEnd;
        private float dstContentFontSize;
        private string dstContentFontName;

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

        public void SetDstHeaderFontSize(float fontSize)
        {
            this.dstHeaderFontSize = fontSize;
        }

        public void SetDstHeaderFontFamily(string fontName)
        {
            this.dstHeaderFontName = fontName;
        }

        public void SetDstHeaderMarkupStart(string markupStart)
        {
            this.dstHeaderMarkupStart = markupStart;
        }

        public void SetDstHeaderMarkupEnd(string markupEnd)
        {
            this.dstHeaderMarkupEnd = markupEnd;
        }

        public void SetDstContentFontSize(float fontSize)
        {
            this.dstContentFontSize = fontSize;
        }

        public void SetDstContentFontFamily(string fontName)
        {
            this.dstContentFontName = fontName;
        }

        public List<PageSize> GetPageSizeList()
        {
            Array pageSizes = Enum.GetValues(typeof(PageSize));
            List<PageSize> ret = new List<PageSize>();
            foreach (PageSize ps in pageSizes)
            {
                ret.Add(ps);
            }
            return ret;
        }
    }
}

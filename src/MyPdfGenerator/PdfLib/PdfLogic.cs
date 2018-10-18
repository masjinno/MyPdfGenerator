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
        private Rectangle dstPageSize;
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

        public void SetDstPageSize(Rectangle pageSize)
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

        public List<Rectangle> GetPageSizeList()
        {
            List<Rectangle> ret = new List<Rectangle>()
            {
                PageSize.A0, PageSize.A1, PageSize.A2, PageSize.A3,
                PageSize.A4, PageSize.A5, PageSize.A6, PageSize.A7,
                PageSize.A8, PageSize.A9, PageSize.A10,
                PageSize.B0, PageSize.B1, PageSize.B2, PageSize.B3,
                PageSize.B4, PageSize.B5, PageSize.B6, PageSize.B7,
                PageSize.B8, PageSize.B9, PageSize.B10,
            };
            return ret;
        }
    }
}

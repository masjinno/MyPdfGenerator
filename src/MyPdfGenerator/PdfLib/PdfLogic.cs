using iTextSharp.text;
using System;

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
    }
}

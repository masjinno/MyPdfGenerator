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
        private List<PageSize> pageSizeList;
        private List<string> fontNameList;

        public PdfModel()
        {
            this.Init();
        }

        public void Init()
        {
            // Initialize this.pdfLogic
            this.pdfLogic = new PdfLogic();

            // Initialize this.pageSizeList
            this.pageSizeList = this.pdfLogic.GetPageSizeList();

            // Initialize this.fontNames
            this.fontNameList = new List<string>();
            FontFactory.RegisterDirectory("C:\\WINDOWS\\Fonts");
            foreach (string fontname in FontFactory.RegisteredFonts)
            {
                fontNameList.Add(fontname);
            }
        }

        public void ConvertCsvToPdf(string csvFilePath, string pdfFilePath)
        {
            throw new NotImplementedException();
        }

        public void SetDstPageSize(string pageSize)
        {
            if (pageSize == null) throw new ArgumentNullException();
            if (string.IsNullOrEmpty(pageSize)) throw new ArgumentException();

            foreach (PageSize ps in this.pageSizeList)
            {
                if (pageSize.Equals(ps))
                {
                    this.pdfLogic.SetDstPageSize(ps);
                    return;
                }
            }

            throw new ArgumentOutOfRangeException(
                new StringBuilder()
                .Append("Argument '")
                .Append(nameof(pageSize))
                .Append("' is illegal value.")
                .ToString());
        }

        public void SetDstMargin(float top, float left, float right, float bottom)
        {
            this.pdfLogic.SetDstMargin(new Margin(top, left, right, bottom));
        }

        public void SetDstHeaderFontSize(float fontSize)
        {
            this.pdfLogic.SetDstHeaderFontSize(fontSize);
        }

        public void SetDstHeaderFontFamily(string fontName)
        {
            this.pdfLogic.SetDstHeaderFontFamily(fontName);
        }

        public void SetDstHeaderMarkupStart(string markupStart)
        {
            this.pdfLogic.SetDstHeaderMarkupStart(markupStart);
        }

        public void SetDstHeaderMarkupEnd(string markupEnd)
        {
            this.pdfLogic.SetDstHeaderMarkupEnd(markupEnd);
        }

        public void SetDstContentFontSize(float fontSize)
        {
            this.pdfLogic.SetDstContentFontSize(fontSize);
        }

        public void SetDstContentFontFamily(string fontName)
        {
            this.pdfLogic.SetDstContentFontFamily(fontName);
        }

        public List<string> GetPageSizeList()
        {
            List<string> ret = new List<string>();
            foreach (PageSize ps in this.pageSizeList)
            {
                ret.Add(ps.ToString());
            }
            return ret;
        }

        public List<string> GetFontFamilyList()
        {
            return this.fontNameList;
        }
    }
}

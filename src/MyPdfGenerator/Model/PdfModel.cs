using iTextSharp.text;
using PdfLib;
using System;
using System.Collections.Generic;
using Microsoft.Win32;
using System.Windows;
using System.IO;

namespace Model
{
    public class PdfModel
    {
        private IPdfLogic pdfLogic;
        private readonly List<string> pageSizeList = new List<string>()
            {
                nameof(PageSize.A0), nameof(PageSize.A1), nameof(PageSize.A2), nameof(PageSize.A3),
                nameof(PageSize.A4), nameof(PageSize.A5), nameof(PageSize.A6), nameof(PageSize.A7),
                nameof(PageSize.A8), nameof(PageSize.A9), nameof(PageSize.A10),
                nameof(PageSize.B0), nameof(PageSize.B1), nameof(PageSize.B2), nameof(PageSize.B3),
                nameof(PageSize.B4), nameof(PageSize.B5), nameof(PageSize.B6), nameof(PageSize.B7),
                nameof(PageSize.B8), nameof(PageSize.B9), nameof(PageSize.B10),
            };
        private List<string> fontNameList;

        public PdfModel()
        {
            this.Init();
        }

        public void Init()
        {
            // Initialize this.pdfLogic
            this.pdfLogic = new PdfLogic();

            // Initialize this.fontNames
            this.fontNameList = new List<string>();
            FontFactory.RegisterDirectory("C:\\WINDOWS\\Fonts");
            foreach (string fontname in FontFactory.RegisteredFonts)
            {
                fontNameList.Add(fontname);
            }
            this.fontNameList.Sort();
        }

        public void ConvertCsvToPdf(string csvFilePath, string pdfFilePath)
        {
            if (string.IsNullOrEmpty(csvFilePath) || string.IsNullOrEmpty(pdfFilePath)) throw new ArgumentNullException();



            throw new NotImplementedException();
        }

        public void SetDstPageSize(string pageSize)
        {
            if (pageSize == null) throw new ArgumentNullException();
            if (string.IsNullOrEmpty(pageSize)) throw new ArgumentException();
            
            this.pdfLogic.SetDstPageSize(PageSize.GetRectangle(pageSize));
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
            return this.pageSizeList;
        }

        public List<string> GetFontFamilyList()
        {
            return this.fontNameList;
        }
    }
}

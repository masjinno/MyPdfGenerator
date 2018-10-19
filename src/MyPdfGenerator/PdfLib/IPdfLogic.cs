using iTextSharp.text;

namespace PdfLib
{
    public interface IPdfLogic
    {
        void Init();
        void ConvertCsvToPdf(string csvFile, string pdfFile);
        void SetDstPageSize(Rectangle pageSize);
        void SetIsDstPageRotate(bool rotate);
        void SetDstMargin(Margin margin);
        void SetDstHeaderFontSize(float fontSize);
        void SetDstHeaderFontFamily(string fontName);
        void SetDstHeaderMarkupStart(string markupStart);
        void SetDstHeaderMarkupEnd(string markupEnd);
        void SetDstContentFontSize(float fontSize);
        void SetDstContentFontFamily(string fontName);
    }
}

using Prism.Mvvm;
using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyPdfGeneratorWpf.ViewModel
{
    class ConvertCsvVM : BindableBase
    {
        #region Binding用プロパティ

        private string[] _pageSizeList;
        public string[] PageSizeList
        {
            get { return this._pageSizeList; }
            set { this.SetProperty(ref this._pageSizeList, value); }
        }

        private string _marginTop;
        public string MarginTop
        {
            get { return this._marginTop; }
            set { this.SetProperty(ref this._marginTop, value); }
        }

        private string _marginLeft;
        public string MarginLeft
        {
            get { return this._marginLeft; }
            set { this.SetProperty(ref this._marginLeft, value); }
        }

        private string _marginRight;
        public string MarginRight
        {
            get { return this._marginRight; }
            set { this.SetProperty(ref this._marginRight, value); }
        }

        private string _marginBottom;
        public string MarginBottom
        {
            get { return this._marginBottom; }
            set { this.SetProperty(ref this._marginBottom, value); }
        }

        private string _headerFontSize;
        public string HeaderFontSize
        {
            get { return this._headerFontSize; }
            set { this.SetProperty(ref this._headerFontSize, value); }
        }

        private string[] _headerFontNameList;
        public string[] HeaderFontNameList
        {
            get { return this._headerFontNameList; }
            set { this.SetProperty(ref this._headerFontNameList, value); }
        }

        private string _headerMarkupStart;
        public string HeaderMarkupStart
        {
            get { return this._headerMarkupStart; }
            set { this.SetProperty(ref this._headerMarkupStart, value); }
        }

        private string _headerMarkupEnd;
        public string HeaderMarkupEnd
        {
            get { return this._headerMarkupEnd; }
            set { this.SetProperty(ref this._headerMarkupEnd, value); }
        }

        private string _contentFontSize;
        public string ContentFontSize
        {
            get { return this._contentFontSize; }
            set { this.SetProperty(ref this._contentFontSize, value); }
        }

        private string _contentFontNameList;
        public string ContentFontNameList
        {
            get { return this._contentFontNameList; }
            set { this.SetProperty(ref this._contentFontNameList, value); }
        }

        private string _inputCsvFilePath;
        public string InputCsvFilePath
        {
            get { return this._inputCsvFilePath; }
            set { this.SetProperty(ref this._inputCsvFilePath, value); }
        }

        private string _outputCsvFilePath;
        public string OutputCsvFilePath
        {
            get { return this._outputCsvFilePath; }
            set { this.SetProperty(ref this._outputCsvFilePath, value); }
        }

        #endregion

        private PdfModel pdfModel;

        public ConvertCsvVM()
        {
            this.Init();
        }
        
        private void Init()
        {
            this.pdfModel = new PdfModel();
        }
    }
}

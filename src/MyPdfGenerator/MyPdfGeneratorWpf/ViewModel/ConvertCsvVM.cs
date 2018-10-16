using Prism.Mvvm;
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

        private string _pageSize;
        public string PageSize
        {
            get { return this._pageSize; }
            set { this.SetProperty(ref this._pageSize, value); }
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

        private string _headerFontName;
        public string HeaderFontName
        {
            get { return this._headerFontName; }
            set { this.SetProperty(ref this._headerFontName, value); }
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

        private string _contentFontName;
        public string ContentFontName
        {
            get { return this._contentFontName; }
            set { this.SetProperty(ref this._contentFontName, value); }
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
    }
}

using Model;
using Prism.Commands;
using Prism.Mvvm;
using System;
using System.Collections.Generic;
using System.Windows.Input;

namespace MyPdfGeneratorWpf.ViewModel
{
    class ConvertCsvVM : BindableBase
    {
        #region Binding用プロパティ

        private List<string> _pageSizeList;
        public List<string> PageSizeList
        {
            get { return this._pageSizeList; }
            set { this.SetProperty(ref this._pageSizeList, value); }
        }

        private string _pageSizeSelected = "A4";
        public string PageSizeSelected
        {
            get { return this._pageSizeSelected; }
            set { this.SetProperty(ref this._pageSizeSelected, value); }
        }

        private bool _isPortrait = true;
        public bool IsPortrait
        {
            get { return this._isPortrait; }
            set { this.SetProperty(ref this._isPortrait, value); }
        }

        private bool _isLandscape = false;
        public bool IsLandscape
        {
            get { return this._isLandscape; }
            set { this.SetProperty(ref this._isLandscape, value); }
        }

        private string _marginTop = 0F.ToString();
        public string MarginTop
        {
            get { return this._marginTop; }
            set { this.SetProperty(ref this._marginTop, value); }
        }

        private string _marginLeft = 0F.ToString();
        public string MarginLeft
        {
            get { return this._marginLeft; }
            set { this.SetProperty(ref this._marginLeft, value); }
        }

        private string _marginRight = 0F.ToString();
        public string MarginRight
        {
            get { return this._marginRight; }
            set { this.SetProperty(ref this._marginRight, value); }
        }

        private string _marginBottom = 0F.ToString();
        public string MarginBottom
        {
            get { return this._marginBottom; }
            set { this.SetProperty(ref this._marginBottom, value); }
        }

        private string _headerFontSize = 14F.ToString();
        public string HeaderFontSize
        {
            get { return this._headerFontSize; }
            set { this.SetProperty(ref this._headerFontSize, value); }
        }

        private List<string> _headerFontNameList;
        public List<string> HeaderFontNameList
        {
            get { return this._headerFontNameList; }
            set { this.SetProperty(ref this._headerFontNameList, value); }
        }
        private string _headerFontNameSelected = "メイリオ";
        public string HeaderFontNameSelected
        {
            get { return this._headerFontNameSelected; }
            set { this.SetProperty(ref this._headerFontNameSelected, value); }
        }

        private string _headerMarkupStart = "【";
        public string HeaderMarkupStart
        {
            get { return this._headerMarkupStart; }
            set { this.SetProperty(ref this._headerMarkupStart, value); }
        }

        private string _headerMarkupEnd = "】";
        public string HeaderMarkupEnd
        {
            get { return this._headerMarkupEnd; }
            set { this.SetProperty(ref this._headerMarkupEnd, value); }
        }

        private string _contentFontSize = 12F.ToString();
        public string ContentFontSize
        {
            get { return this._contentFontSize; }
            set { this.SetProperty(ref this._contentFontSize, value); }
        }

        private List<string> _contentFontNameList;
        public List<string> ContentFontNameList
        {
            get { return this._contentFontNameList; }
            set { this.SetProperty(ref this._contentFontNameList, value); }
        }

        private string _contentFontNameSelected = "メイリオ";
        public string ContentFontNameSelected
        {
            get { return this._contentFontNameSelected; }
            set { this.SetProperty(ref this._contentFontNameSelected, value); }
        }

        private string _inputCsvFilePath;
        public string InputCsvFilePath
        {
            get { return this._inputCsvFilePath; }
            set { this.SetProperty(ref this._inputCsvFilePath, value); }
        }

        private string _outputPdfFilePath;
        public string OutputPdfFilePath
        {
            get { return this._outputPdfFilePath; }
            set { this.SetProperty(ref this._outputPdfFilePath, value); }
        }

        #endregion
        
        private PdfModel pdfModel;
        private FileModel fileModel;

        #region Binding用コマンド

        public ICommand BrowseInputCsv
        {
            get
            {
                return new DelegateCommand(() =>
                {
                    try
                    {
                        this.InputCsvFilePath = this.fileModel.GetOpenFilePath("CSV", "csv");
                    }
                    catch (OperationCanceledException e)
                    {
                        // do nothing
                    }
                });
            }
        }

        public ICommand BrowseOutputPdf
        {
            get
            {
                return new DelegateCommand(() =>
                {
                    try
                    {
                        this.OutputPdfFilePath = this.fileModel.GetSaveFilePath("PDF", "pdf");
                    }
                    catch (OperationCanceledException e)
                    {
                        // do nothing
                    }
                });
            }
        }

        public ICommand ConvertCsvToPdf
        {
            get
            {
                return new DelegateCommand(() =>
                {
                    this.pdfModel.ConvertCsvToPdf(this.InputCsvFilePath, this.OutputPdfFilePath);
                });
            }
        }

        #endregion

        public ConvertCsvVM()
        {
            this.Init();
        }
        
        private void Init()
        {
            this.pdfModel = new PdfModel();
            this.fileModel = new FileModel();

            this.PageSizeList = this.pdfModel.GetPageSizeList();

            this.HeaderFontNameList = this.pdfModel.GetFontFamilyList();
            this.ContentFontNameList = this.pdfModel.GetFontFamilyList();
        }
    }
}

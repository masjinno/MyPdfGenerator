using Model;
using Prism.Commands;
using Prism.Mvvm;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace MyPdfGeneratorWpf.ViewModel
{
    class ConcatenationVM : BindableBase
    {
        #region Binding用プロパティ

        private List<OpenFileItemVM> _inputPdfPathList;
        public List<OpenFileItemVM> InputPdfPathList
        {
            get { return this._inputPdfPathList; }
            set
            {
                this.SetProperty(ref this._inputPdfPathList, value);
                this.RaisePropertyChanged(nameof(this.InputPdfPathList));
            }
        }

        #endregion

        #region Binding用コマンド

        #endregion

        public ConcatenationVM()
        {
            this.InputPdfPathList = new List<OpenFileItemVM>();
            this.InputPdfPathList.Add(new OpenFileItemVM());
        }





        public class OpenFileItemVM : BindableBase
        {
            private FileModel fileModel;
            public string FilePath { get; set; }
            
            #region Binding用コマンド

            public ICommand BrowseOpenFile
            {
                get
                {
                    return new DelegateCommand(() =>
                    {
                        try
                        {
                            this.FilePath = this.fileModel.GetOpenFilePath("PDF", "pdf");
                            this.RaisePropertyChanged(nameof(this.FilePath));
                        }
                        catch (OperationCanceledException)
                        {
                            // do nothing
                        }
                    });
                }
            }

            #endregion

            public OpenFileItemVM()
            {
                this.fileModel = new FileModel();
            }
        }
    }
}

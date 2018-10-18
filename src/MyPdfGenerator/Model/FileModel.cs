using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class FileModel
    {
        public string GetOpenFilePath()
        {
            return this.GetOpenFilePath("すべての", "*");
        }
        public string GetOpenFilePath(string fileDescription, string extension)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = new StringBuilder().Append(fileDescription).Append("ファイル(*.").Append(extension).Append(")|*.").Append(extension).ToString();
            if (ofd.ShowDialog() == true)
            {
                return ofd.FileName;
            }
            throw new OperationCanceledException();
        }

        public string GetSaveFilePath()
        {
            return this.GetSaveFilePath("すべての", "*");
        }
        public string GetSaveFilePath(string fileDescription, string extension)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = new StringBuilder().Append(fileDescription).Append("ファイル(*.").Append(extension).Append(")|*.").Append(extension).ToString();
            if (sfd.ShowDialog() == true)
            {
                return sfd.FileName;
            }
            throw new OperationCanceledException();
        }
    }
}

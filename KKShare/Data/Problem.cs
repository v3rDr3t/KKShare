using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KKShare.Data
{
    public class Problem
    {
        private string parentPath;
        private string dirPath;
        private string text;

        public Problem(string parentPath, string dirPath, string text)
        {
            this.parentPath = parentPath;
            this.dirPath = dirPath;
            this.text = text;
        }

        #region Field Accessors
        public string ParentPath
        {
            get { return this.parentPath; }
        }

        public string DirPath
        {
            get { return this.dirPath; }
        }

        public string Text
        {
            get { return this.text; }
        }
        #endregion
    }
}

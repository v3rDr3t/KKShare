using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using KKShare.Data;
using System.Drawing;
using System.IO;
using BrightIdeasSoftware;

namespace KKShare.View
{
    public partial class MainView
    {
        /// <summary>
        /// Configures all columns of the 'Share' list view.
        /// </summary>
        private void setupSharesColumns()
        {
            // 'Size' column
            this.shareSizeOLVCol.AspectToStringConverter = delegate (object cellValue)
            {
                long bytesToFormat = (long)cellValue;
                return formatSize(bytesToFormat);
            };
        }

        /// <summary>
        /// Configures the 'Search' tree list view.
        /// </summary>
        private void setupSearchTLV()
        {
            this.searchTLV.CanExpandGetter = delegate (object node) {
                return ((Node)node).HasChildren();
            };

            this.searchTLV.ChildrenGetter = delegate (object node) {
                return ((Node)node).Children;
            };
        }

        /// <summary>
        /// Configures all columns of the 'Search' tree list view.
        /// </summary>
        private void setupSearchTLVColumns()
        {
            // 'Folder' column
            this.searchFolderCol.AspectGetter = delegate (object rowObject) {
                if (rowObject is Node)
                {
                    return ((Node)rowObject).Name;
                }
                else {
                    return "";
                }
            };

            this.searchFolderCol.ImageGetter = delegate (object rowObject)
            {
                return getIconFor(((Node)rowObject), this.searchTLV);
            };

            // 'Files' column
            this.searchFilesCol.AspectGetter = delegate (object rowObject)
            {
                Node node = (Node)rowObject;
                return (node.IsDirectory) ? node.FilesOnlyCount.ToString() : "";
            };

            // 'Size' column
            this.searchSizeCol.AspectGetter = delegate (object rowObject)
            {
                return ((Node)rowObject).AccSize;
            };

            this.searchSizeCol.AspectToStringConverter = delegate (object cellValue)
            {
                long bytesToFormat = (long)cellValue;
                return formatSize(bytesToFormat);
            };
        }

        /// <summary>
        /// Returns the icon to use for the given node.
        /// </summary>
        /// <param name="node">The given node.</param>
        /// <param name="treeListView">The tree list view.</param>
        /// <returns>The key (as string) of the icon.</returns>
        private string getIconFor(Node node, TreeListView treeListView)
        {
            // Set a default icon for the file.
            string ext = "file";
            Image img = Properties.Resources.file16;
            if (node.IsDirectory)
            {
                ext = "folder";
                img = Properties.Resources.folder16;
            }
            // check to see if the image collection contains an image for this extension, using the extension as a key
            if (!treeListView.SmallImageList.Images.ContainsKey(ext))
            {
                try
                {
                    treeListView.SmallImageList.Images.Add(ext, img);
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.ToString());
                }
            }
            return ext;
        }

        /// <summary>
        /// Creates a formated (readable) string from the given bytes.
        /// </summary>
        /// <param name="bytesToFormat">The given bytes.</param>
        /// <returns>The formated folder size string.</returns>
        private string formatSize(long bytesToFormat)
        {
            string[] suffixes = { "B", "KB", "MB", "GB", "TB", "PB", "EB" };
            if (bytesToFormat == 0)
            {
                return "0 " + suffixes[0];
            }
            long bytes = Math.Abs(bytesToFormat);
            int dimension = Convert.ToInt32(Math.Floor(Math.Log(bytes, 1024)));
            double fileSize = Math.Round(bytes / Math.Pow(1024, dimension), 2);
            return (Math.Sign(bytesToFormat) * fileSize).ToString() + " " + suffixes[dimension];
        }
    }
}

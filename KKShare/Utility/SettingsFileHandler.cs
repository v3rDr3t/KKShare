using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Linq;
using System.IO;

using KKShare.Data;

namespace KKShare.Utility
{
    public class SettingsFileHandler
    {
        private XDocument xmlDocument;

        /// <summary>
        /// Default constructor.
        /// </summary>
        public SettingsFileHandler()
        {
            xmlDocument = new XDocument();
        }

        /// <summary>
        /// Tries to load the settings file.
        /// </summary>
        /// <returns>
        /// <code>True</code> in case the file could be loaded, <code>false</code> otherwise.
        /// </returns>
        public bool LoadSettingsFile()
        {
            try
            {
                xmlDocument = XDocument.Load(Constants.SETTINGS_FILE_NAME);
                return true;
            }
            catch (FileNotFoundException)
            {
                return false;
            }
            catch (XmlException)
            {
                return false;
            }
        }

        /// <summary>
        /// Creates a settings file with given values.
        /// </summary>
        /// <param name="name">The name.</param>
        /// <param name="name">The shares.</param>
        internal void CreateSettingsFile(string name, List<Share> shares)
        {
            xmlDocument.RemoveNodes();
            // add settings
            XElement rootNode = new XElement(Constants.SETTINGS_FILE_ROOT_NAME);
            xmlDocument.AddFirst(rootNode);
            // add network
            XElement networkNode = new XElement(Constants.SETTINGS_FILE_NETWORK_NAME);
            rootNode.AddFirst(networkNode);
            // add name
            XElement nameNode = new XElement(Constants.SETTINGS_FILE_NAME_NAME, name);
            networkNode.Add(nameNode);
            // add shares
            XElement sharesNode = new XElement(Constants.SETTINGS_FILE_SHARES_NAME);
            rootNode.Add(sharesNode);
            // add share paths
            foreach (Share share in shares)
            {
                XElement shareNode = new XElement(Constants.SETTINGS_FILE_SHARE_PATH_NAME, share.FolderPath);
                sharesNode.Add(shareNode);
            }

            xmlDocument.Save(Constants.SETTINGS_FILE_NAME);
        }

        /// <summary>
        /// Reads the <code>Name</code> value from settings file.
        /// </summary>
        /// <returns>
        /// The <code>Name</code> value or the default value.
        /// </returns>
        internal string ReadName()
        {
            XElement nameNode = xmlDocument.Root.Element(Constants.SETTINGS_FILE_NETWORK_NAME)
                .Element(Constants.SETTINGS_FILE_NAME_NAME);
            if (nameNode != null)
            {
                return nameNode.Value;
            }
            else
            {
                return System.Environment.MachineName;
            }
        }

        internal List<string> ReadShares()
        {
            List<string> sharePaths = new List<string>();
            XElement sharesNode = xmlDocument.Root.Element(Constants.SETTINGS_FILE_SHARES_NAME);
            if (sharesNode != null)
            {
                foreach (var sharePathNode in sharesNode.Elements())
                {
                    if (sharePathNode.Name.ToString().Equals(Constants.SETTINGS_FILE_SHARE_PATH_NAME))
                    {
                        sharePaths.Add(sharePathNode.Value);
                    }
                }
            }
            return sharePaths;
        }
    }
}

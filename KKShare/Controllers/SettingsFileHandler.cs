using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Linq;
using System.IO;

using KKShare.Data;

namespace KKShare.Controllers
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
        internal void CreateSettingsFile(string name)
        {
            xmlDocument.RemoveNodes();
            XElement rootNode = new XElement(Constants.SETTINGS_FILE_ROOT_NAME);
            xmlDocument.AddFirst(rootNode);
            XElement networkNode = new XElement(Constants.SETTINGS_FILE_NETWORK_NAME);
            rootNode.AddFirst(networkNode);
            XElement nameNode = new XElement(Constants.SETTINGS_FILE_NAME_NAME, name);
            networkNode.Add(nameNode);
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
    }
}

using System.IO;
using System.Xml.Serialization;

namespace CustomControlCollection.Settings
{
    public class SettingsManager<T> where T : new()
    {
        #region CREATE_OR_LOAD
        public static T CreateOrLoad(string filePath)
        {
            CreateDirectory(filePath);

            if (File.Exists(filePath))
            {
                return CreateOrLoad(File.OpenRead(filePath));
            }
            else
            {
                return (new T());
            }
        }

        public static T CreateOrLoad(Stream readStream)
        {
            if (readStream != null)
            {
                using (StreamReader streamReader = new StreamReader(readStream))
                {
                    return ((T)new XmlSerializer(typeof(T)).Deserialize(streamReader));
                }
            }
            else
            {
                return (new T());
            }
        }
        #endregion

        #region SAVE
        public void Save(string filePath)
        {
            CreateDirectory(filePath);

            Save(File.OpenWrite(filePath));
        }

        public void Save(Stream writeStream)
        {
            using (StreamWriter streamWriter = new StreamWriter(writeStream))
            {
                new XmlSerializer(typeof(T)).Serialize(streamWriter, this);
            }
        }
        #endregion

        #region DIRECTORY
        private static void CreateDirectory(string filePath)
        {
            string directoryName = Path.GetDirectoryName(filePath);

            if ((!string.IsNullOrEmpty(directoryName)) && (!Directory.Exists(directoryName)))
            {
                Directory.CreateDirectory(directoryName);
            }
        }
        #endregion
    }
}

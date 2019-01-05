using System.IO;
using System.Xml.Serialization;

namespace CustomControlCollection.Settings
{
    public class SettingsManager<T> where T : new()
    {
        #region CREATELOAD
        public static T CreateOrLoad(string filePath)
        {
            return (File.Exists(filePath) ? CreateOrLoad(File.OpenRead(filePath)) : new T());
        }

        public static T CreateOrLoad(Stream readStream)
        {
            T genericSettings = default(T);

            if (readStream != null)
            {
                using (StreamReader streamReader = new StreamReader(readStream))
                {
                    genericSettings = ((T)new XmlSerializer(typeof(T)).Deserialize(streamReader));
                }
            }
            else
            {
                genericSettings = new T();
            }

            return genericSettings;
        }
        #endregion

        #region SAVE
        public void Save(string filePath)
        {
            string directoryName = Path.GetDirectoryName(filePath);

            if ((!string.IsNullOrEmpty(directoryName)) && (!Directory.Exists(directoryName)))
            {
                Directory.CreateDirectory(directoryName);
            }

            Save(File.Create(filePath));
        }

        public void Save(Stream writeStream)
        {
            using (StreamWriter streamWriter = new StreamWriter(writeStream))
            {
                new XmlSerializer(typeof(T)).Serialize(streamWriter, this);
            }
        }
        #endregion
    }
}

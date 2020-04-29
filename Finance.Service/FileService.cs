using System;
using System.Configuration;
using System.IO;
using System.Xml.Serialization;

namespace Finance.Service
{
    public static class FileService
    {
        public static string TranFilePath;
        public static string ContFilePath;
        public static string EvntFilePath;
        public static string UserFilePath;
        public static void Init()
        {
            TranFilePath = ConfigurationManager.AppSettings["TranPath"];
            ContFilePath = ConfigurationManager.AppSettings["ContPath"];
            EvntFilePath = ConfigurationManager.AppSettings["EvntPath"];
            UserFilePath = ConfigurationManager.AppSettings["UserPath"];

            if (!Directory.Exists(TranFilePath))
            {
                Directory.CreateDirectory(TranFilePath);
            }

            if (!Directory.Exists(ContFilePath))
            {
                Directory.CreateDirectory(ContFilePath);
            }

            if (!Directory.Exists(EvntFilePath))
            {
                Directory.CreateDirectory(EvntFilePath);
            }

            if (!Directory.Exists(UserFilePath))
            {
                Directory.CreateDirectory(UserFilePath);
            }
        }

        public static void SaveOrUpdateEntityToFile <T>(T entity, string path)
        {
            if (!File.Exists(path))
            {
                var xmlSerial = new XmlSerializer(typeof(T));
                using (var sw = new StreamWriter(path))
                {
                    xmlSerial.Serialize(sw, entity);
                }
            }
            else
            {
                File.Delete(path);
                var xmlSerial = new XmlSerializer(typeof(T));
                using (var sw = new StreamWriter(path))
                {
                    xmlSerial.Serialize(sw, entity);
                }
            }
        }

        public static void DeleteEntityFile(string path)
        {
            if (File.Exists(path))
            {
                File.Delete(path);
            }
        }

        public static T GetEntityFromFile<T>(string path)
        {
            if (File.Exists(path))
            {
                var xmlSerial = new XmlSerializer(typeof(T));
                using (var fs = new FileStream(path, FileMode.Open))
                {
                    var entity = (T)xmlSerial.Deserialize(fs);
                    return entity;
                }
            }

            return (T)Activator.CreateInstance(typeof(T));
        }
    }
}

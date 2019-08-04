using System;
using System.IO;
using System.IO.IsolatedStorage;
using System.Runtime.Serialization.Formatters.Binary;
using System.Xml.Serialization;

namespace Apteka.Utils.Serialization
{

    public static class CObjectXmlSerializer<T> where T : class
    {
        public static T Load(string path)
        {
            T serializableObject = LoadFromDocumentFormat(null, path, null);
            return serializableObject;
        }

        public static void Save(T serializableObject, string path)
        {
            SaveToDocumentFormat(serializableObject, null, path, null);
        }

        public static T LoadFromDocumentFormat(System.Type[] extraTypes, string path, IsolatedStorageFile isolatedStorageFolder)
        {
            T serializableObject = null;

            using (var textReader = CreateTextReader(isolatedStorageFolder, path))
            {
                var xmlSerializer = CreateXmlSerializer(extraTypes);
                serializableObject = xmlSerializer.Deserialize(textReader) as T;

            }
            return serializableObject;
        }

        public static XmlSerializer CreateXmlSerializer(System.Type[] extraTypes)
        {
            Type objectType = typeof(T);

            XmlSerializer xmlSerializer = null;

            xmlSerializer = extraTypes != null ? new XmlSerializer(objectType, extraTypes) : new XmlSerializer(objectType);

            return xmlSerializer;
        }

        public static void SaveToDocumentFormat(T serializableObject, System.Type[] extraTypes, string path, IsolatedStorageFile isolatedStorageFolder)
        {
            using (TextWriter textWriter = CreateTextWriter(isolatedStorageFolder, path))
            {
                XmlSerializer xmlSerializer = CreateXmlSerializer(extraTypes);
                xmlSerializer.Serialize(textWriter, serializableObject);
            }
        }
        private static TextReader CreateTextReader(IsolatedStorageFile isolatedStorageFolder, string path)
        {
            TextReader textReader = null;

            textReader = isolatedStorageFolder == null ? new StreamReader(path) : new StreamReader(new IsolatedStorageFileStream(path, FileMode.Open, isolatedStorageFolder));

            return textReader;
        }

        private static TextWriter CreateTextWriter(IsolatedStorageFile isolatedStorageFolder, string path)
        {
            TextWriter textWriter = null;

            textWriter = isolatedStorageFolder == null ? new StreamWriter(path) : new StreamWriter(new IsolatedStorageFileStream(path, FileMode.OpenOrCreate, isolatedStorageFolder));

            return textWriter;
        }
    }

    public static class CBinSerializer<T> where T : class
    {
        public static T LoadFromBinaryMem(byte[] bin)
        {
            T serializableObject = null;

            using (MemoryStream ms = new MemoryStream(bin))
            {
                BinaryFormatter binaryFormatter = new BinaryFormatter();
                serializableObject = binaryFormatter.Deserialize(ms) as T;
            }

            return serializableObject;
        }

        public static byte[] SaveToBinaryMem(T serializableObject)
        {
            using (MemoryStream ms = new MemoryStream())
            {
                BinaryFormatter binaryFormatter = new BinaryFormatter();
                binaryFormatter.Serialize(ms, serializableObject);
                return ms.GetBuffer();
            }
        }

        public static T LoadFromBinaryFormat(string path, IsolatedStorageFile isolatedStorageFolder)
        {
            T serializableObject = null;

            using (FileStream fileStream = CreateFileStream(isolatedStorageFolder, path))
            {
                BinaryFormatter binaryFormatter = new BinaryFormatter();
                serializableObject = binaryFormatter.Deserialize(fileStream) as T;
            }

            return serializableObject;
        }

        public static FileStream CreateFileStream(IsolatedStorageFile isolatedStorageFolder, string path)
        {
            FileStream fileStream = null;

            if (isolatedStorageFolder == null)
                fileStream = new FileStream(path, FileMode.OpenOrCreate);
            else
                fileStream = new IsolatedStorageFileStream(path, FileMode.OpenOrCreate, isolatedStorageFolder);

            return fileStream;
        }
    }
}

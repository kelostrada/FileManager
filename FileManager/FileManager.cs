#region Using
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Serialization;
using System.Xml;
using System.IO;
#endregion

namespace FileManager
{
    public static class FileManager
    {
        public static T Deserialize<T>(string File)
        {
            try
            {
                XmlSerializer serializer = new XmlSerializer(typeof(T));
                TextReader textReader = new StreamReader(File);
                T Obj = (T)serializer.Deserialize(textReader);
                textReader.Close();
                return Obj;
            }
            catch (FileNotFoundException e)
            {
                Serialize<T>(File, default(T));
                XmlSerializer serializer = new XmlSerializer(typeof(T));
                TextReader textReader = new StreamReader(File);
                T Obj = (T)serializer.Deserialize(textReader);
                textReader.Close();
                return Obj;
            }
        }

        public static void Serialize<T>(string File, T Obj)
        {
            XmlSerializer serializer = new XmlSerializer(typeof(T));
            TextWriter textWriter = new StreamWriter(File);
            serializer.Serialize(textWriter, Obj);
            textWriter.Close();
        }

    }
}

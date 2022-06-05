using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Serialization;

namespace WpfAnimalsProject
{
    public class FileData<T>
    {
        public List<T> objects { get; set; }
        private string file_name { get; set; }
        public FileData(List<T> lst, string file_name)
        {
            this.objects = new List<T>();
            this.objects = lst;
            this.file_name = file_name;
        }

        public async void XmlSerialize()
        {
            XmlWriter writer = new XmlTextWriter(file_name, System.Text.Encoding.UTF8);
            await Task.Run(() => {
                XmlSerializer serializer = new XmlSerializer(typeof(List<T>));
                serializer.Serialize(writer, objects);
            });
            writer.Close();
        }

        public async Task<List<T>> Deserialize()
        {
            var doc = new XmlDocument();
            try
            {
                //doc.LoadXml(file_name);
                if (new FileInfo(file_name).Length == 0)
                {
                    return new List<T>();
                }
         
                List<T> LF = new List<T>();
                XmlReader reader = new XmlTextReader(file_name);
                await Task.Run(() => {
                    XmlSerializer dserializer = new XmlSerializer(typeof(List<T>));
                    LF = (List<T>)dserializer.Deserialize(reader);
                });
                reader.Close();
                return LF;
            }
            catch (XmlException e)
            {
                return new List<T>();
            }
        }
    }
}

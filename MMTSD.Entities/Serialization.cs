using System.IO;
using System.Xml.Serialization;

namespace MMTSD.Entities
{
    public class Serialization<T>
    {
        public string path { get; set; }
        public T obj { get; set; }
        XmlSerializer formatter;
        public Serialization(string path, T obj)
        {
            this.path = path;
            this.obj = obj;

            formatter = new XmlSerializer(typeof(T));

        }

        public bool Serialize()
        {
            using (FileStream fs = new FileStream(path, FileMode.OpenOrCreate))
            {
                formatter.Serialize(fs, obj);

                return true;
            }
            return false;
        }
        public T Deserialize()
        {
            using (FileStream fs = new FileStream(path, FileMode.OpenOrCreate))
            {
                T newObject = (T)formatter.Deserialize(fs);
                return newObject;
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Lesson_12_1
{
    [Serializable]
    public class Person
    {
        public string? Name { get; set; }
        public int Age { get; set; }
    }
    public class XMLSerializationExample
    {
        public static void SerializePerson(Person person, string filePath)
        {
            XmlSerializer serializer = new XmlSerializer(typeof(Person));
            using (StreamWriter writer = new StreamWriter(filePath))
            {
                serializer.Serialize(writer, person);
            }
        }
        public static Person DeserializePerson(string filePath)
        {
            XmlSerializer serializer = new XmlSerializer (typeof(Person));
            using (StreamReader reader = new StreamReader(filePath))
            {
                return (Person)serializer.Deserialize(reader);
            }
        }

    }
}

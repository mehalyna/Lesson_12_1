using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace Lesson_12_1
{
    
    
    public class JsonSerializationExample
    {
        public static void SerializePerson(Person person, string filePath)
        {
            string jsonString = JsonSerializer.Serialize(person);
            File.WriteAllText(filePath, jsonString);
        }

        public static Person DeserializePerson(string filePath)
        {
            string jsonString = File.ReadAllText(filePath);
            return JsonSerializer.Deserialize<Person>(jsonString);
        }
    }

}

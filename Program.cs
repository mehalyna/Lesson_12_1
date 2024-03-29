namespace Lesson_12_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Person person = new Person { Name = "Jhon Doe", Age = 30};
            
            Console.WriteLine("XML Serialization!");
            string XMLFile = "person.xml";
            XMLSerializationExample.SerializePerson(person, XMLFile);
            Person xmlPerson = XMLSerializationExample.DeserializePerson(XMLFile);
            Console.WriteLine($"{xmlPerson.Name} : {xmlPerson.Age}");

            string jsonFile = "person.json";
            JsonSerializationExample.SerializePerson(person, jsonFile);
            Person jsonPerson = JsonSerializationExample.DeserializePerson(jsonFile);
            Console.WriteLine($"{jsonPerson.Name} : {jsonPerson.Age}");
            Console.ReadKey();



        }
    }
}
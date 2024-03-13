using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
//using System.Runtime.Serialization.Json;

namespace JsonSerializeDeserialize
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var person = new Person
            {
                Name = "Serge Klokov",
                Age = 40,
                DOB = new DateTime(1999, 10, 23),
                Kids = new List<Kid> { 
                    new Kid
                    {
                        Name = "Tristan",
                        Age = 13
                    },
                    new Kid
                    {
                        Name = "McKayla",
                        Age = 11
                    },                
                }
            };

            // System.IO.FileNotFoundException: 'Could not load file or assembly 'System.Memory, Version=4.0.1.1, Culture=neutral, 

            string json = JsonSerializer.Serialize(person);
            Console.WriteLine(json);

            Person deserializedPerson = JsonSerializer.Deserialize<Person>(json); // works because it's right JSON
            Console.WriteLine(deserializedPerson);

            // Correct JSON
            // {"Name":"Serge Klokov","Age":40,"DOB":"1999-10-23T00:00:00","Kids":[{"Name":"Tristan","Age":13},{"Name":"McKayla","Age":11}]}

            // I made Age as string "40" instead of 40. It cause an error.
            string jsonWithIncorrectType = "{\"Name\":\"Serge Klokov\",\"Age\":\"40\",\"DOB\":\"1999-10-23T00:00:00\",\"Kids\":[{\"Name\":\"Tristan\",\"Age\":13},{\"Name\":\"McKayla\",\"Age\":11}]}";

            try
            {
                Person deserializedPerson2 = JsonSerializer.Deserialize<Person>(jsonWithIncorrectType);  
                Console.WriteLine(deserializedPerson2);
            }
            catch (Exception ex)
            {
                // System.Text.Json.JsonException: 'The JSON value could not be converted to System.Int32. Path: $.Age | LineNumber: 0 | BytePositionInLine: 33.'
                Console.Write(ex);
            }


            Console.WriteLine("Please press any key");
            Console.ReadKey();
        }
    }
}

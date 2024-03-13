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

            // JSON
            // {"Name":"Serge Klokov","Age":40,"DOB":"1999-10-23T00:00:00","Kids":[{"Name":"Tristan","Age":13},{"Name":"McKayla","Age":11}]}

            Person deserializedPerson = JsonSerializer.Deserialize<Person>(json);
            Console.WriteLine(deserializedPerson);

            Console.WriteLine("Please press any key");
            Console.ReadKey();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JsonSerializeDeserialize
{
    internal class Person
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public DateTime DOB { get; set; }
        public List<Kid> Kids { get; set; }
    }

    internal class Kid
    {
        public string Name { get; set; }
        public int Age { get; set; }
    }
}

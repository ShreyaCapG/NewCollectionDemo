using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectionsDemo
{
    class Person
    {
        public int PersonId { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public string Address { get; set; }

        void ShowPersonDetails(int PersonId, string Name, int Age)
        {
            Console.WriteLine(PersonId+" - " +Name+" - "+ Age);
        }

        static void Main(string[] args)
        {
            Person person = new Person();
            
        }
    }
}

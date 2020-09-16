using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectionsDemo
{
    class ListDemo
    {
        static void Main(string[] args)
        {
            List<string> Cities = new List<string>();
            Cities.Add("Mumbai");
            Cities.Add("Pune");
            Cities.Add("Delhi");
            Cities.Add("Chennai");

            Console.WriteLine("Before Sorting:");
            foreach (var item in Cities)
            {
                Console.WriteLine(item);
            }
            Cities.Sort();
            Console.WriteLine("After Sorting:");
            foreach (var item in Cities)
            {
                Console.WriteLine(item);
            }
            if (Cities.Contains("Pune1"))
            {
                Console.WriteLine("Pune exists in the list.");
            }
        }
    }
}

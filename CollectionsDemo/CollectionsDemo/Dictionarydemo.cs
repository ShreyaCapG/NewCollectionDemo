using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectionsDemo
{
    class Dictionarydemo
    {
        static void Main(string[] args)
        {
            Dictionary<int, string> PinCodeWithCity = new Dictionary<int, string>();
            PinCodeWithCity.Add(123456, "Mumbai");
            PinCodeWithCity.Add(234567, "Pune");
            PinCodeWithCity.Add(345678, "Delhi");
            PinCodeWithCity.Add(456789, "Chennai");

            foreach (KeyValuePair<int,string> item in PinCodeWithCity)
            {
                Console.WriteLine(item.Key+" - "+item.Value);
            }
        }
    }
}

using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectionsDemo
{
    class HashTableDemo
    {
        static void Main(string[] args)
        {
            Hashtable hashtable = new Hashtable();
            hashtable.Add(1, "Manish");
            hashtable.Add("2", "Ganesh");
            hashtable.Add(3, false);

            foreach (DictionaryEntry item in hashtable)
            {
                Console.WriteLine(item.Key+" -" +item.Value);
            }

        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectionsDemo
{
    class QueueDemo
    {
        static void Main(string[] args)
        {
            Queue<string> Cities = new Queue<string>();
            Cities.Enqueue("Mumbai");
            Cities.Enqueue("Pune");
            Cities.Enqueue("Delhi");
            Cities.Enqueue("Chennai");

            foreach (var item in Cities)
            {
                Console.WriteLine(item);
            }

            Cities.Dequeue();
            Console.WriteLine("Elements After Dequeue:");
            foreach (var item in Cities)
            {
                Console.WriteLine(item);
            }
        }
    }
}

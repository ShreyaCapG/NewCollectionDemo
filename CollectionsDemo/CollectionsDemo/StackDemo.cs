using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectionsDemo
{
    class StackDemo
    {
        static void Main(string[] args)
        {
            Stack<string> Names = new Stack<string>();

            Names.Push("Manish");
            Names.Push("Ganesh");
            Names.Push("Hari");
            Names.Push("Priya");
            Names.Push("Rose");

            Console.WriteLine("All Data:");
            foreach (var item in Names)
            {
                Console.WriteLine(item);
            }

            Names.Pop();
            Console.WriteLine("All Data after popping 1 element:");
            foreach (var item in Names)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("Next poppable Element:" +Names.Peek());
            foreach (var item in Names)
            {
                Console.WriteLine(item);
            }
        }
    }
}

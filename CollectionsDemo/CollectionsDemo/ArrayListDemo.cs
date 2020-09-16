using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace CollectionsDemo
{
    class ArrayListDemo
    {

        static void Main(string[] args)
        {
            ArrayList myArrayList = new ArrayList();
            myArrayList.Add(10);
            myArrayList.Add("HelloWorld");
            myArrayList.Add(false);

            //foreach (object item in myArrayList)
            //{
            //    Console.WriteLine(item.ToString());
            //}

            int FirstValue = Int32.Parse(myArrayList[0].ToString());
            
        }
    }
}

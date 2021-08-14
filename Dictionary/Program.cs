using System;
using System.Collections.Generic;

namespace Dictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            MyDictionary<int, string> myDictionary = new MyDictionary<int, string>();
            myDictionary.Add(1, "slm cnm");
            myDictionary.Add(2, "kmsn sn be");
            myDictionary.Listed();
            Console.WriteLine(myDictionary.Count);
        }
    }
}

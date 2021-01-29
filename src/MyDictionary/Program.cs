using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyDictionary
{
    public class Program
    {
        public static void Main(string[] args)
        {
            //Dictionary<string, int> dict = new Dictionary<string, int>();
            //dict.Add("Yas", 16);

            MyDictionary<int, string> myDictionary = new MyDictionary<int, string>();
            myDictionary.Add(1, "Ali");
            myDictionary.Add(2, "Veli");
            myDictionary.Add(3, "Mehmet");
        }
    }
}

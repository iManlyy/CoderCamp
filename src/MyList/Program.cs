using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyList
{
    public class Program
    {
        public static void Main(string[] args)
        {
            //List<string> hazirListe = new List<string> { "fghfg", "skjsj", "cvcv", "qwe", "asd" };
            //Console.WriteLine(hazirListe[2]);

            MyList<int> myList = new MyList<int>();
            myList.Add(10);
            myList.Add(20);
            myList.Add(40);
            myList.Add(70);
            Console.WriteLine(myList.Length);
            myList.Add(20);
            Console.WriteLine(myList.Length);
            Console.ReadKey();
        }
    }
}

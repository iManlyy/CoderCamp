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
            List<string> hazirListe = new List<string> { "fghfg", "skjsj", "cvcv", "qwe", "asd" };
            Console.WriteLine(hazirListe[2]);
            Console.ReadKey();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strings
{
    class Program
    {
        static void Main(string[] args)
        {
            // Intro();
            string sentence = "My name is İrem Özdemir";

            var result = sentence.Length;
            var result2 = sentence.Clone();
            //sentence = "My name is Emre Hanoğlu";

            bool result3 = sentence.EndsWith("r");
            bool result4 = sentence.StartsWith("My");

            var result5 = sentence.IndexOf("name"); 
            var result6 = sentence.IndexOf(" ");
            var result7 = sentence.LastIndexOf(" ");
            var result8 = sentence.Insert(0, "Hello, ");
            var result9 = sentence.Substring(3);
            Console.WriteLine(result9);
            Console.ReadLine();
        }

        private static void Intro()
        {
            string city = "Ankara";
            //Console.WriteLine(city[0]);

            foreach (var item in city)
            {
                Console.WriteLine(item);
            }

            string city2 = "İstanbul";

            Console.WriteLine(String.Format("{0} {1} ", city, city2));
        }
    }
}

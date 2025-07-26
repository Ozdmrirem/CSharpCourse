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
            var result9 = sentence.Substring(3,4);
            var result10 = sentence.ToLower(); // butun karakterleri kucuk harfe cevirir
            var result11 = sentence.ToUpper(); // butun karakterleri buyuk harfe cevirir
            var result12 = sentence.Replace(" ", "-"); // verilen kelimeyi degistirir
            var result13 = sentence.Remove(2); // verilen karakterden sonrasını siler
            var result14 = sentence.Remove(2, 5); // 3. karakterden baslayarak 4 karakter siler
            Console.WriteLine(result14);
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

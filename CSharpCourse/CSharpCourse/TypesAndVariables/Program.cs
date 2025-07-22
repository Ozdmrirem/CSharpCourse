using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TypesAndVariables
{
     class Program
    {
        static void Main(string[] args)
        {
            //Value types
            //Console.WriteLine("Hello World!");
            int number1 = 2147483647; //tam sayi
            long number2 = -9223372036854775808;
            short number3 = 32767; 
            byte number4 = 255; //0-255 arasi
            bool condition = false; //t-f
            char character = 'A';
            double number5 = 10.4; //ondalikli sayilar icin
            decimal number6 = 10.4m;
            var number7 = 10; //var keywordu ile deger atama
            number7 = 'A';
            Console.WriteLine("Number1 is {0}",number1);
            Console.WriteLine("Number2 is {0}",number2);
            Console.WriteLine("Number3 is {0}",number3);
            Console.WriteLine("Number4 is {0}",number4);
            Console.WriteLine("Number5 is {0}",number5);
            Console.WriteLine("Number6 is {0}",number6);
            Console.WriteLine("Number7 is {0}", number7);
            Console.WriteLine("Character is : {0}",(int)character);
            Console.WriteLine((int)Days.Friday);
            
            Console.ReadLine();
        }
    }
    enum Days
    {
       Monday,Tuesday,Wednesday,Thursday,Friday,Saturday, Sunday
    }
}

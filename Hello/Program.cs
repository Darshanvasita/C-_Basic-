using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Hello
{
   class Program
    {
        static void Main(string[] args)
        {

            //Basic Console Output
            //THis is Imporatant For debugging .Do Not Remove

            /*
           THis is Multi-line Comment 
            Spanning Multiple lines 
          */

            Console.WriteLine("Hello, World!");
            Console.Write("Hello, Darshan ");
            Console.WriteLine("I Love C # ");
            

            //DataTypes of C#

            int Value = 51; //Integer Variable Data Type

            Console.WriteLine("Number of Value "+ Value); //Output the value of Some

            /* Datatype in C# 
             * Integer - int Value; ---> 4 bytes
             * Floating Point Number - float that (99.98);  ---> 4 bytes
             * Charachter - char a='A';   ---> 2 bytes
             * Boolean - bool isGreat =true;  ---> 1 byte
             * String  -string inp ="Darshan"  ---> 2 bytes per character
             * Long Integer - long bigNumber = 1234567890; ---> 8 bytes
             Double - double bigDecimal = 12345.6789; ---> 8 bytes
             */

            string inp =Console.ReadLine();
            Console.WriteLine("You have entered " + inp); //Output the value of Some

            //TypeCast

            int a = 45;
            float b = 35.4F;
            double c = 63.4D;

            Console.WriteLine(a);
            Console.WriteLine(b);
            Console.WriteLine(c);

            Console.ReadLine();

        }
    }
}

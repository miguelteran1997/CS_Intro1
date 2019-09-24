using System;

namespace CS_Intro1
{
    class Program
    {
        static void Main(string[] args)
        {
            string tech = "is" + "awsome";
            int num1 = 2 + 2;
            int num2 = 1 + 3;
            float num3 = 4.56f + 2f;
            float numfool = 3 * 5;
            float numfools = 6 * 6;
            double num4 = 2.2 + 2;
            bool num5 = false;
            string chubbycats = num1 + " " + num2;
            string chubbycamels = num3 + " " + num1;

            const bool tall = true;
            const  double cont1 = 45;


            Console.WriteLine("Hello World!");
            Console.WriteLine(numfool);
            Console.WriteLine("ram !");
            Console.WriteLine(numfools);
            Console.WriteLine("motherboard");
            Console.WriteLine("cpu!");
            Console.WriteLine("graphics card!");
            Console.WriteLine("ghrtz!");
            Console.WriteLine("intel!");
            Console.WriteLine("powersupply!");

            Console.WriteLine(chubbycats);
            Console.WriteLine(chubbycamels);

            Console.WriteLine(" {0}. num: {1}, num: {2},",chubbycats,chubbycamels, num3);
            
        }
    }
}

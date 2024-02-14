using System;
using System.Collections.Generic;
class Program
{
    static void Main(string[] args)
    {
        bool kör = true;
        while (kör == true)
        {
            Console.WriteLine("1. Addera tre tal");
            Console.WriteLine("2. Störtsta talet av två tal");
            Console.WriteLine("3. Avsluta programet");
            string svar = Console.ReadLine();
            switch (svar)
            {
                case "1":
                    Console.WriteLine("Skriv i ett tal");
                    int a = int.Parse(Console.ReadLine());
                    Console.WriteLine("Skriv i ett tal");
                    int b = int.Parse(Console.ReadLine());
                    Console.WriteLine("Skriv i ett tal");
                    int c = int.Parse(Console.ReadLine());
                    Console.WriteLine("Summan av de tre talen blir " + Addera(a, b, c));
            break;
                case "2":
                    Console.WriteLine("Skriv in ett tal");
                    a = int.Parse(Console.ReadLine());
                    Console.WriteLine("Skriv in ett tal");
                    b = int.Parse(Console.ReadLine());
                    Console.WriteLine(Störst(a, b) + " är det största talet");
                    break;
                case "3":
                    kör = false;
                    break;
            }
        }
        static int Addera(int a, int b, int c)
        {
            return a + b + c;
        }
        static int Störst(int x, int y)
        {
            if (x >= y)
            {
                return x;
            }
            else
            {
                return y;
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Karra_jadvali
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //MohirDev platformasidagi DotNet kursida berib boriladigan topshiriqlar
            //For loop sikli mavzusi bo'yicha "karra jadvali"
            Console.WriteLine("Karra jadvali");

            for(int a = 1; a <= 10; a++ )
            {
                for(int b = 1; b <= 10; b++ )
                {
                    Console.WriteLine($"{a} * {b} = {a * b}");
                }
                Console.WriteLine(" ");
            }
            Console.ReadKey();
        }
    }
}

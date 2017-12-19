using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp18
{
    class Program
    {     

      

        static void Main(string[] args)
        {

            string isim;
            Console.Write("isminizi giriniz lütfen:");
            isim = Console.ReadLine();
            foreach (char ad in isim)
            {
                Console.Write((char)(ad + 10));
            }
            Console.ReadLine();
        }
    }
}

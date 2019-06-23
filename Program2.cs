using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace university
{
    class Program
    {
        static void Main(string[] args)
        {
            string Secim;
            Console.WriteLine("1-API");
            Console.WriteLine("2-MAA");
            Console.WriteLine("Seciminiz: ");
            Secim = Console.ReadLine();
            switch (Secim)
            {
                case "1":
                    API api = new API();
                    Console.WriteLine(api.uni);
                    Console.ReadKey();
                    break;
                case "2":
                    MAA maa = new MAA();
                    Console.WriteLine(maa.uni);
                    Console.ReadKey();
                    break;


            }

        }
    }
}

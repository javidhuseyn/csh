using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace c23._06method
{
    class Program
    {
        
        static void Main(string[] args)
        {
            DELISHKA deli = new DELISHKA();
                int res1 = deli.RESULT(15, 12);
                int res2 = deli.RESULT(2, 5, 6, 7);
            Console.WriteLine("2 ededin cemi: {0}",res1);
            Console.WriteLine("4 ededin cemi: {0}",res2);
            Console.Read();

        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace c23._06._19
{
    class Program
    {
        static void Main(string[] args)
        {
            ulong id;
            int otaqno;
            Musteri m1 = new Musteri();
            m1.adsoyad = Console.ReadLine();
            string Id = Console.ReadLine();
            string otaqNo = Console.ReadLine();
            if (ulong.TryParse(Id,out id))
            {
                m1.Idno = id;
            }
            if(int.TryParse(otaqNo,out otaqno))
            {
                m1.otaqnO = otaqno;
            }
            Console.WriteLine("AdSoyad: {0}",m1.adsoyad);
            Console.WriteLine("IdNo: {0}", m1.idno);
            Console.WriteLine("OtagNomresi: {0}", m1.otaqnO);
            Console.Read();
        }
    }
}

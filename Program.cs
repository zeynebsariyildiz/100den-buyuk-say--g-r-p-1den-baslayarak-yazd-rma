using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _100den_buyuk_sayı_gırıp_1den_baslayarak_yazdırma
{
    internal class Program
    {
        static void Main(string[] args)
        {
             
            Console.WriteLine("Lütfen 100 den Büyük Bir Sayı Giriniz");
            int sayi = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < sayi; i++)
            {
                Console.WriteLine(i);
                
            }
            Console.ReadLine();

        }
    }
}

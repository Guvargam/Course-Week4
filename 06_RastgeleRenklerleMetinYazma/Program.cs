using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06_RastgeleRenklerleMetinYazma
{
    class Program
    {
        static void Main(string[] args)
        {

            /*
            Girilen bir metni rastgele bir sayıda rastgele renklerle ekrana yazdır (her satır farklı renk olacak )


            dışardan metin girilsin
            rastgele bir sayı uretilsin (adet)

        dongu bası.
            rastgele bir renk üretilsin satır orenge donsun
            metin yazılsın
            adet 1 eksilsin
            adet 0 dan byukse tekrar edilsin

      

    */

            string metin;
            Console.Write("Bir Metin Girin : ");
            metin = Console.ReadLine();
            Random rastgele = new Random(); // random sınıfından bir nesne türet
            // bir main bloğunda bir defa random sınıfınddan nesne turetmemiz yeterli
            int rastgeleadet = rastgele.Next(30);
        dongubasi:
            int rastgelerenk = rastgele.Next(1,16);
            Console.BackgroundColor = (ConsoleColor)rastgelerenk;
            Console.WriteLine(metin);
            rastgeleadet--;
            if (rastgeleadet > 0) goto dongubasi;


            Console.ReadKey();


        }
    }
}

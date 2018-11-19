using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_İsimBulmayaCalis
{
    class Program
    {
        static void Main(string[] args)
        {
            // KULLANICIDAN "AHMET" GİRİLENE KADAR İSİM İSTEYEN PROGRAM
            // ahmet girildiğinde kaç denemede bildiğini sorun

            byte sayac = 0;

            const string sabitisim = "ahmet";
            string girilenisim;
            isimal:
            Console.Write("İsim Girin : ");
            girilenisim = Console.ReadLine().Trim().ToLower();
            sayac++;
            // sayac = sayac + 1;  
            // byte değişkenler kucuk değerlerle çalıştıgı ıcın toplama , çartpma gibi işlemlerde hata verebilir.
            if (girilenisim == sabitisim)
            {
                Console.WriteLine($"DOĞRU BİLDİN. Deneme Sayısı {sayac}");
            }
            else
            {
                Console.WriteLine("YANLIŞ.. ");goto isimal;
            }




            Console.ReadKey();


        }
    }
}

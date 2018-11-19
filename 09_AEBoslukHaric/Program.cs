using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09_AEBoslukHaric
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            girilen bir metni içinde 
boşluk olmadan a ve e harfleri kırmızı diğer harfler sarı olacak şekilde ekrana yazdır

Merhaba dünya
merhabadünya*/

            baslangic:
            string metin;
            Console.Write("Metni Girin: ");
            metin = Console.ReadLine().Trim().ToUpper();
            if(metin.Length<2)
            {
                Console.WriteLine("Metin en az 2 karakter olmalı");
                goto baslangic;
            }
            int index = 0;
        yazdirma:
            if (metin[index] != ' ')
            {
                if (metin[index] == 'A' || metin[index] == 'E')
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Yellow;
                }
                Console.Write(metin[index]);
            }
            index++;
            if (index < metin.Length) goto yazdirma;
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.WriteLine("\n------------------------");
            goto baslangic;





        }
    }
}

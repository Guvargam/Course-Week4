using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_StringIcindekiCharaErisme
{
    class Program
    {
        static void Main(string[] args)
        {


            //  string değişkenler char lardan oluşan bir küme gibi düşünülebilir
            // herhangi bir string içinde bir char a char in bulundugu index numarası ile ulaşabiliriz
            //  index nuamrası 0 dan başlayarak karakter sayısına kadar devam eder

            string metin = "FATİH BİLİŞİM OKULU";
            Console.WriteLine(metin[0]);    /// stringdegisken[index numarası] ile char olarak ulaşırız
            Console.WriteLine(metin[5]);
            /// son karakteri çaağırmak ?

            //string ifadelerin karakter sayılarına .Lenght ile ulaşılır

            Console.WriteLine("metin {0} karakterlidi", metin.Length); // int  değer döndürür
            Console.WriteLine("metnin son karakteri : {0}", metin[metin.Length - 1]);
            int sayi = 7;
            Console.WriteLine(metin[sayi]);

            // index numarası int bir değer veya değişken olarak girilebilir
            //NOT: herhangi bir metot yada ozellıkle calısırken int değer istiyorsa bunu ister değer ister değişken olarak gireriz. 


            // şndex numarası ile ulaşılan karakter char dondugu ıcın sorgularken tipine göre sorgula !

            // metnin ilka harfi S mi ?
            //1.YOl  iki türlü sorgula:

            if (metin[0] == 's' || metin[0] == 'S')
            { }
            // 2.Yol metni kucuk harfe dondur . Orjinali lazım olursa? 
            metin = metin.ToLower();
            if (metin[0] == 's')
            { }
            // metnin bakılacak karakterini kucuk harfe dondur
            if (metin[0].ToString().ToLower()=="s")
            //char bir ifadede string bir metot çağırmak istersek once .ToString() ile onun string e donmesini saglarız sonra string metotları gorebılırz
            { }

                Console.ReadKey();





        }
    }
}

using System;

namespace diziler
{
    class Program
    {
        static void Main(string[] args)
        {
            //Dizi tanımlama
            string[] renkler = new string[5];//1. şekil.

            string[] hayvanlar = {"kedi","köpek","kuş","maymun"};//2. şekil.

            int [] dizi;
            dizi = new int [5];//3. şekil.
            
            //Dizelere atama ve erişim.
            renkler[0] = "Mavi";
            Console.WriteLine(hayvanlar[0]);
            dizi[3] = 10;
            Console.WriteLine(dizi[3]);
            Console.WriteLine(renkler[0]);

            //Döngülerle dizi kullanımı
            //Kalvyeden girilen n tane sayının ortalamasını alan program
            Console.Write("Lütfen dizinin eleman sayısını giriniz: ");
            int diziUzunlugu = int.Parse(Console.ReadLine());//Kullanıcıdan dizi uzunluğunu belirlemesini istedik.
            int[] sayiDizisi = new int[diziUzunlugu];//Sayı dizisinin eleman sayısını uzunluğa bağladık.

            for (int i = 0; i < diziUzunlugu; i++)
            {
                Console.WriteLine("Lütfen {0}. sayıyı giriniz:", i+1);//0. indexsi 1. index olarak gösterdik
                sayiDizisi[i] = int.Parse(Console.ReadLine());
            }
            int toplam = 0;//Elemanları toplayacak değer
            foreach (var sayi in sayiDizisi)
                toplam += sayi;
            Console.Write("Ortalama: " + toplam/diziUzunlugu);

        }
    }
}
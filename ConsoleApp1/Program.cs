using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            // type safety - tip güvenliği
            // Do not repeat yourself - Kendini tekrarlama

            // değer tutucu, alias
            string katagoriEtiketi = "Kategori";
            int ogrenciSayisi = 32000;
            double faizOrani = 1.45;
            bool sistemeGirisYapmisMi = false;
            double dolardun = 7.35;
            double dolarbugun = 7.45;

            if (sistemeGirisYapmisMi)
            {
                Console.WriteLine("Kullanıcı Ayarları Butonu");
            }
            else
            {
                Console.WriteLine("Giriş Yap Butonu");
            }
            if (dolardun>dolarbugun)
            {
                Console.WriteLine("Azalış Butonu");
            }
            else if (dolardun < dolarbugun)
            {
                Console.WriteLine("Artış Butonu");
            }
            else
            {
                Console.WriteLine("Değişmedi Butonu");
            }
            //Console.WriteLine(katagoriEtiketi);




        }
    }
}

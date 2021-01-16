using System;

namespace Donguler
{
    class Program
    {
        static void Main(string[] args)
        {

            string kurs1 = "yazilim gelistirici yetiştirme kampi";
            string kurs2 = "Programlamaya başlangıç için temel kurs";

            //aarray - dizi


            string[] kurslar = new string[] { "yazilim gelistirici yetiştirme kampi",
            "Programlamaya başlangıç için temel kurs",
            "java","Python"};


            for (int i = 0; i < kurslar.Length; i++)
            {
                Console.WriteLine(kurslar[i]);
            }

            foreach (string kurs in kurslar)
            {
                Console.WriteLine();
            }

            Console.WriteLine("Sayfa Sonu");
        }
    }
}

using System;

namespace Donguler_WhileForeach
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //While

            //1'den başlayarak konsoldan girilen sayı dahil ortalama hesaplayan program
            Console.WriteLine("Sayi Giriniz");
            int girilenSayi = int.Parse(Console.ReadLine());
            int sayac = 1;
            int toplam =  0;

            while(sayac <= girilenSayi)
            {
                toplam += sayac;
                sayac++;
            }

            Console.WriteLine("Ortalama :" + toplam / girilenSayi);

            char character = 'a';
            while (character <= 'z')
            {
                Console.Write(character);
                character++;
            }
            

            //Foreach

            string[] arabalar = { "BMW", "Tesla", "Ford", "Toyota", "Lamborghini" };
            foreach (string araba in arabalar)
            {
                Console.WriteLine(araba);
            }
        }
    }
}

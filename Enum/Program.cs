using System;

namespace Enum
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Gunler.Pazar);
            Console.WriteLine((int)Gunler.Cumartesi); //numeric degeri verir.

            int sicaklik = 32;

            if(sicaklik <= (int)HavaSicakligi.Normal)
            {
                Console.WriteLine("Hava biraz soguk.");
            }
            //Diger Hava Sicakligi degerlerine gore else if ve else yazilabilir.
        }
    }

    enum Gunler
    {
        Pazartesi,
        Sali,
        Carsamba,
        Persembe,
        Cuma,
        Cumartesi,
        Pazar
    }

    enum HavaSicakligi
    {
        Soguk = 5,
        Normal = 20,
        Sicak = 25,
        CokSicak = 30
    }
}

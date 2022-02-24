using System;

namespace StaticSinifVeUyeler
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Calisan Sayisi: {0}", Calisan.CalisanSayisi);

            Calisan calisan = new Calisan("Anil", "Pak", "IT");
            Console.WriteLine("Calisan Sayisi: {0}", Calisan.CalisanSayisi);
            Calisan calisan2 = new Calisan("Anil", "Pak", "IK");
            Console.WriteLine("Calisan Sayisi: {0}", Calisan.CalisanSayisi);
        }
    }

    class Calisan
    {
        private static int calisanSayisi;

        public static int CalisanSayisi { get; }

        private string Isim;
        private string Soyisim;
        private string Department;

        static Calisan()
        {
            calisanSayisi = 0;
        }

        public Calisan(string isim, string soyisim, string department)
        {
            this.Isim = isim;
            this.Soyisim = soyisim;
            this.Department = department;
            calisanSayisi++;
        }
    }

    static class Islemler
    {
        public static long Topla(int sayi1, int sayi2)
        {
            return sayi1 + sayi2;
        }

        public static long Cikar(int sayi1, int sayi2)
        {
            return sayi1 - sayi2;
        }
    }
}

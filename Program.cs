using System;

namespace SinifKavrami
{
    class Program
    {
        static void Main(string[] args)
        {
          //1. Public : Her yerden erişilebilir.
          //2. Private : Sadece tanımlandığı sınıf içerisinden erişilebilir.
          // 3. Internal : Sadece bulunduğu proje içerisinden erişilebilir
          //4. Protected : Sadece tanımlandığı sınıfta ya da o sınıfı miras alan sınıflardan erişilebilir.

          Calisan calisan1 = new Calisan("Anil", "Pak", 12345678, "IT");
          // calisan1.Ad = "Anil";
          // calisan1.Soyad = "Pak";
          // calisan1.No = 12345678;
          // calisan1.Department = "IT";

          calisan1.CalisanBilgileri();
        }
    }

    class Calisan
    {
        public string Ad;
        public string Soyad;
        public int No;
        public string Department;

        public Calisan(string ad, string soyad, int no, string department)
        {
            this.Ad = ad;
            this.Soyad = soyad;
            this.No = no;
            this.Department = department;
        }

        //Ayni isim ile farkli argumanlar alan constructorlar olusuturulabilir ve over loading yapilabilir.

        public void CalisanBilgileri()
        {
            Console.WriteLine("Calisanin Adi:{0}", Ad);
            Console.WriteLine("Calisanin Soyadi:{0}", Soyad);
            Console.WriteLine("Calisanin Numarasi:{0}", No);
            Console.WriteLine("Calisanin Departmani:{0}", Department);
        }
    }
}

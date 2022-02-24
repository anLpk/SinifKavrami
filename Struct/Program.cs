using System;

namespace Struct
{
    class Program
    {
        static void Main(string[] args)
        {
            Dikdortgen dikdortgen = new Dikdortgen();
            dikdortgen.KisaKenar = 3;
            dikdortgen.UzunKenar = 4;

            Console.WriteLine("Class Alan Hesabi : {0}", dikdortgen.DikdortgenAlanHesabi());

            Dikdortgen_Struct dikdortgen_Struct;
            dikdortgen_Struct.KisaKenar = 3;
            dikdortgen_Struct.UzunKenar = 4;

            Console.WriteLine("Class Alan Hesabi : {0}", dikdortgen_Struct.DikdortgenAlanHesabi());
        }
    }

    class Dikdortgen
    {
        public int KisaKenar;
        public int UzunKenar;

        public long DikdortgenAlanHesabi()
        {
            return this.KisaKenar * this.UzunKenar;
        }
    }

    struct Dikdortgen_Struct
    {
        public int KisaKenar;
        public int UzunKenar;

        public long DikdortgenAlanHesabi()
        {
            return this.KisaKenar * this.UzunKenar;
        }
    }
}

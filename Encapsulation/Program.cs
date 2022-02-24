using System;

namespace Encapsulation
{
    class Program
    {
        static void Main(string[] args)
        {
            Ogrenci ogrenci = new Ogrenci("Anil", "Pak", 123456, 12);
            ogrenci.DisplayStudentInformation();
            ogrenci.PromotionToHigherGrade();
            ogrenci.DisplayStudentInformation();
            ogrenci.Plough();
            ogrenci.Plough();
            ogrenci.Plough();
            ogrenci.Plough();
            ogrenci.DisplayStudentInformation();
            ogrenci.Classroom = 10; //Yeni deger atayabiliyorum Set'den dolayi
        }
    }

    class Ogrenci
    {
        private string name;
        private string surname;
        private int studentID;
        private int classroom;

        public string Name { get; set; }
        public string Surname { get; set ; }
        public int StudentID { get ; set ; }
        public int Classroom { get; set; }

        public Ogrenci(string name, string surname, int studentID, int classroom)
        {
            this.name = name;
            this.surname = surname;
            this.studentID = studentID;
            this.classroom = classroom;
        }

        public Ogrenci(){}

        public void DisplayStudentInformation()
        {
            Console.WriteLine("**** Student Information ****");
            Console.WriteLine("Name : {0}", this.name);
            Console.WriteLine("Surname : {0}", this.surname);
            Console.WriteLine("Student ID : {0}", this.studentID);
            Console.WriteLine("Classroom : {0}", this.classroom);
        }

        public void PromotionToHigherGrade()
        {
            this.Classroom++;
        }

        public void Plough()
        {
            this.Classroom--;
        }
    }
}

using System;

class Student
    {
        public string Imie { get; set; }
        public string Nazwisko { get; set; }
        public int Pesel { get; set; }
        public string Kierunek { get; set; }
        public Student(string imie, string nazwisko, int pesel, string kierunek)
        {
            Imie = imie;
            Nazwisko = nazwisko;
            Pesel = pesel;
            Kierunek = kierunek;
        }
        public virtual void wyswietl_dane()
        {
            Console.WriteLine($"Imie: {Imie} Nazwisko: {Nazwisko} Pesel: {Pesel} Kierunek: {Kierunek}");
        }
    }
    class StudentWIiK : Student
    {
        public string AdreMAC { get; set; }
        public StudentWIiK(string imie, string nazwisko, int pesel, string kierunek, string adresmac) : base(imie, nazwisko, pesel, kierunek)
        {
            AdreMAC = adresmac;
        }
        public string PobUstAdresMAC
        {
            get { return AdreMAC; }
            set { AdreMAC = Console.ReadLine(); }
        }
        public override void wyswietl_dane()
        {
            base.wyswietl_dane();
            Console.WriteLine($"Adres MAC: {AdreMAC}");
        }
    }
    abstract class StudentUE : Student
    {
        const string uczelnia = "uek";
        public StudentUE(string imie, string nazwisko, int pesel, string kierunek):base(imie, nazwisko, pesel, kierunek){}
        public static void studiuje_()
        {
            Console.WriteLine(uczelnia);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Prosze podać dla studentów Imie, Nazwisko, Pesel, Kierunek i przy drugim studencie Adres MAC.");
            Student[] tab = { new Student("Michał", "Matuszak", 1234567890, "Informatyka"),
                              new StudentWIiK("Adam", "Kowalski", 1236547809, "Informatyka","1-E-7-M-3"),
                              new Student("Adam", "Kowalski", 1236547809, "Informatyka")
                            };
            foreach (Student student in tab)
            {
                student.wyswietl_dane();
            }
            StudentUE.studiuje_();
            Console.ReadKey();
        }
    }
using System;
using System.Collections.Generic;

namespace zad3
{
    class Program
    {
        static void Main()
        {
            // Tablica z elementami typu IPremia
            // Podczas definicji tablicy użyto rzutowania, które stanowi zabezpieczenie na wypadek 
            // próby wpisania obiektu klasy, która nie implementuje danego interfejsu (jak np. klasa Klient).
            IPremia[] tab = { new Pracownik("Kowalski", "Jan",1000) as IPremia,
                new Dyrektor("Nowak", "Adam",10000) as IPremia,
                new Klient("Testowy", "Tomasz") as IPremia};

            // W pętli  wyświetli się premia dla dwóch obiektów (z klasy Pracownik i klasy Dyrektor), 
            // przy czym dla każdego z tych obiektów wywoła się właściwa wersja wirtualnej metody Premia.
            // Natomiast dla obiektu trzeciego (z klasy Klient) nic się nie wyświetli - dla tego obiektu 
            // próba rzutowania na typ IPremia zwraca null. 
            /*foreach (IPremia i1 in tab)
            {
                if (i1 != null)
                {
                    Console.WriteLine($"{i1.GetType().Name} {i1.Premia()}");
                }
            }*/
            List<IPremia> list = new List<IPremia>()
            {
                new Dyrektor("Żulczyk","Irena",10000),
                new Pracownik("Kowalski", "Jan", 1000),
                new Dyrektor("Nowak", "Adam", 10000),
            };
            list.Sort();
            foreach (IPremia premia in list)
            {
                Console.WriteLine(premia.Nazwisko);
            }
            Console.ReadKey();
        }
    }
}

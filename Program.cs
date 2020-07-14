using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gra
{
    class Program
    {
        static void Main(string[] args)
        {
            start();
        }


        static void start()
        {
            Random rnd = new Random();
            int liczbaDoZgadniecia = rnd.Next(1, 101);
            int pozostaleProby = 7;
            bool wygrana = false;

            while (pozostaleProby > 0)
            {
                Console.WriteLine("Zgadnij liczbę od 1 - 100.  Pozostałe próby: " + pozostaleProby);

                int podanaLiczba = 0;
                string input = Console.ReadLine();

             
                {
                    Console.WriteLine("Nie podano poprawnej liczby.");
                }

            }
            if (wygrana != true)
            {
                Console.WriteLine("Niestety nie udało ci się, szukana liczba to " + liczbaDoZgadniecia);
            }
        }
    }

}
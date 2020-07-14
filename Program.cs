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

                if (!Int32.TryParse(input, out podanaLiczba))
                {
                    Console.WriteLine("Nie podano liczby.");
                }

                if (podanaLiczba > 1 && podanaLiczba < 101)
                {
                    if (podanaLiczba < liczbaDoZgadniecia)
                    {
                        Console.WriteLine("Podana liczba jest zbyt mała.");
                        pozostaleProby -= 1;
                        continue;
                    }
                    else if (podanaLiczba > liczbaDoZgadniecia)
                    {
                        Console.WriteLine("Podana liczba jest zbyt duża.");
                        pozostaleProby -= 1;
                        continue;
                    }
                    else
                    {
                        Console.WriteLine("Gratulacje! Liczba to " + liczbaDoZgadniecia);
                        wygrana = true;
                        pozostaleProby = 0;
                        break;
                    }
                }
                else
                {
                    Console.WriteLine("Nie podano poprawnej liczby.");
                }

            }
            if (wygrana != true)
            {
                Console.WriteLine("Niestety nie udało ci się, szukana liczba to " + liczbaDoZgadniecia);
            }
            Console.WriteLine("Nacisnij dowolny klawisz aby zagrać jeszcze raz.");
            Console.ReadKey();
            start();
        }
    }

}
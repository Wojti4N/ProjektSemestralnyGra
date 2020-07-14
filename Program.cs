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
            Dictionary<int, int> trudnosc = new Dictionary<int, int>();
            trudnosc.Add(1, 100);
            trudnosc.Add(2, 500);
            trudnosc.Add(3, 1000);


            Random rnd = new Random();

            int pozostaleProby = 7;
            bool wygrana = false;
            int liczbaDoZgadniecia = 1;

            Console.Write("Wybierz poziom trudności(1/2/3): ");
            int poziom = Convert.ToInt32(Console.ReadLine());
            if (poziom >= 1 && poziom <= 3)
            {
               liczbaDoZgadniecia = rnd.Next(1, trudnosc[poziom]);
            }
            else
            {
                start();
            }



            while (pozostaleProby > 0)
            {
                Console.WriteLine("Zgadnij liczbę od 1 - " + trudnosc[poziom] + ".  Pozostałe próby: " + pozostaleProby);

                int podanaLiczba = 0;
                string input = Console.ReadLine();

                if (!Int32.TryParse(input, out podanaLiczba))
                {
                    Console.WriteLine("Nie podano liczby.");
                }

                if (podanaLiczba > 1 && podanaLiczba < trudnosc[poziom])
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
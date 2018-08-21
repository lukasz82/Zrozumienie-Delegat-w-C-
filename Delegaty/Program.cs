using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegaty
{
    class Program
    {
        static void Main(string[] args)
        {
            Samochod skoda = new Samochod();
            // Wskazuję funkcję, która ma być wywołana podczas wywołania delegatu w środku klasy
            skoda.delegat += Funkcja;
            // Dołączam nastepną funkcję, która ma być wywołana podczas wywołania delegatu w środku klasy Samochod (a tak naprawde podczas wywołania metody Jedź)
            skoda.delegat += Informacja;
            skoda.Jedz(15);
            skoda.Jedz(0);
            skoda.Jedz(40);
            Console.ReadKey();

        }

        private static void Funkcja(int km)
        {
            Console.WriteLine("Samochód przejechał pomyślnie dystans " + km + " km \n");
        }

        private static void Informacja(int km)
        {
            if (km == 0)
            {
                Console.WriteLine(km + " km - ten samochód nie przejechał ani kilometra \n\n");
            }

            if (km > 0 & km < 20)
            {
                Console.WriteLine(km + " km - ten samochód przejechał dosyć którki dystans \n\n");
            }

            if (km > 20)
            {
                Console.WriteLine(km + " km  -ten samochód przejechał dosyć długi dystans \n\n");
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegaty
{
    class Samochod
    {

        private double przebieg;
        private double iloscPaliwa;
        private double spalanie;

        // Deklaruję delegat, w sumie można to zrobić w oosbnym pliku, żeby móc używać tego delegatu w różnych innych klasach
        public delegate void Delegat_Do_Samochodu(int km);
        // Tworzę obiekt delegatu
        public Delegat_Do_Samochodu delegat;

        public Samochod()
        {
            iloscPaliwa = 40;
            przebieg = 0;
            spalanie = 0.05;
        }

        public void Jedz(int km)
        {
            double spalono = km * spalanie;
            przebieg = przebieg + km;
            iloscPaliwa = iloscPaliwa - spalono;
            Console.WriteLine("Przejechalem: " + km + ", Spalilem: " + spalono + ", Pozostalo paliwa: " + iloscPaliwa + "\n");
            // Wywołuję delegat, ten delegat następnie wywoła funkcję na zewnątrz, która nie jest bezpośrednio związana z tą klasą
            // Tak naprawde ten delegat wysyła sygnał "Hej! zostałem wywołany, więc sam wywołam inną funkcję ;-]
            delegat(km);
        }



    }
}

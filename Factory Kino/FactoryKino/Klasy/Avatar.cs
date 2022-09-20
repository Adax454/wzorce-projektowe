using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryKino.Klasy
{
    internal class Avatar : Interfejs
    {
        public void Stan(String sala, String godzina, String rodzaj)
        {
           Console.WriteLine("FILM AVATAR\n\nsala: " + sala + "\ngodzina: " + godzina + "\nanimacja: " + rodzaj + "\n--------");
        }
    }
}

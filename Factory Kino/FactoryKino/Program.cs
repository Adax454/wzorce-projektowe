using FactoryKino.Klasy;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryKino
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Factory fabryka = new Sprawdzanie();

            Interfejs Avatar = fabryka.GetFilm("Avatar");
            Avatar.Stan("15", "12:30", "3D, lektor");

            Interfejs Hobbit = fabryka.GetFilm("Hobbit");
            Hobbit.Stan("7", "16:15", "2D, lektor");

            Interfejs Joker = fabryka.GetFilm("Joker");
            Joker.Stan("11", "19:00", "2D, napisy");
            
            Interfejs Joker2 = fabryka.GetFilm("Joker");
            Joker2.Stan("17", "20:10", "3D, lektor");

            Console.ReadKey();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingletonKino
{ 

    internal class Program
    {
        static void Main(string[] args)
        {
            Singleton singleton = Singleton.Instancja;
            Console.WriteLine("Podaj swoje imię i nazwisko:");
            singleton.dane = Console.ReadLine();
            Console.WriteLine("Podaj nazwę filmu:");
            singleton.nazwa_filmu = Console.ReadLine();
            Console.WriteLine("Jaki rodzaj filmu (2D lub 3D):");
            string zmienna = Convert.ToString(Console.ReadLine());
            while (zmienna != ("2D") || zmienna != ("3D"))
            {
                if (zmienna == ("2D") || zmienna == ("3D"))
                {
                    singleton.rodzaj = zmienna;
                    break;
                }
                Console.WriteLine("PODAJ PRAWIDŁOWY RODZAJ FILMU!!(2D lub 3D)");
                zmienna = Convert.ToString(Console.ReadLine());
            }

            singleton.czas = "Czas rejestracji: "+DateTime.Now;
            Console.WriteLine("\n------------\nWitaj " + singleton.dane + ", \nWłaśnie zarezerwowałeś/aś bilet na film " + singleton.nazwa_filmu + ", w animacji " + singleton.rodzaj + ".\nBilet jest ważny przez najbliższe 24 godziny od rejestracji.\n" + singleton.czas + "\n------------");

            Console.ReadLine();
        }
    }

    public class Singleton
    {
        private static Singleton instancja = new Singleton();
        private static readonly object _lock = new object();
        private Singleton() { }

        public string dane, nazwa_filmu, rodzaj, czas;
     
        public static Singleton Instancja
        {
            get 
            {
                if (instancja == null)
                {
                    lock (_lock)
                    {
                        if (instancja == null)
                        {
                            instancja = new Singleton();
                        }
                    }
                }
                return instancja; 
            }
        }
    }
}

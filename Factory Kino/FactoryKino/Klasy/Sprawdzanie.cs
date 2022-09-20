using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryKino.Klasy
{
    internal class Sprawdzanie : Factory
    {
        public override Interfejs GetFilm(String Film)
        {
            switch (Film)
            {
                case "Avatar":
                    return new Avatar();
                case "Hobbit":
                    return new Hobbit();
                case "Joker":
                    return new Joker();
                default:
                    throw new ApplicationException(String.Format(" ", Film));
            }
        }
    }
}

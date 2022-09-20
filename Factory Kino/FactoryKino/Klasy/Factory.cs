using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryKino.Klasy
{
    abstract class Factory
    {
        public abstract Interfejs GetFilm(String Film);
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MedicinskaKlinika.Entiteti
{
    internal class Laborant : Zaposlen
    {
        public virtual int JMBG { get; set; }
    }
}

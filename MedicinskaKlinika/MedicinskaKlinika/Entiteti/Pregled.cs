using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MedicinskaKlinika.Entiteti
{
    public class Pregled
    {
        public virtual DateTime Datum { get; set; }

        public virtual DateTime Vreme { get; set; }

        public virtual String OpisTegoba { get; set; }

        public virtual String Dijagnoza { get; set; }

        public virtual String Terapija { get; set; }

        public virtual String PreporukaZaLecenje { get; set; }

        public virtual String VrstaPregleda { get; set; }

        public virtual DateTime DatumTermina { get; set; }

        public virtual DateTime VremeTermina { get; set; }

        public virtual DateTime DatumDodatnogPregleda { get; set; }

        public virtual DateTime VremeDodatnogPregleda { get; set; }

    }
}

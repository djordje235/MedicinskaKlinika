using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MedicinskaKlinika.Entiteti
{
    public class Zaposlen
    {
        public virtual int JMBG { get; set; }
        public virtual DateTime DatumZaposlenja { get; set; }
        public virtual String Pozicija { get; set; }

        public virtual DateTime DatumRodjenja { get; set; }

        public virtual String Ime { get; set; }

        public virtual String Prezime { get; set; }

        public virtual String Adresa { get; set; }

        public virtual int Smena { get; set; }

        public virtual Lokacija AdresaLokacije { get; set; }

    }
}

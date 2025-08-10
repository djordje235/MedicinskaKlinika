using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MedicinskaKlinika.Entiteti
{
    public class Pacijent
    {
        public virtual String Adresa { get; set; }

        public virtual int IdKartona { get; set; }

        public virtual String Ime { get; set; }

        public virtual String Prezime { get; set; }


        public virtual DateTime DatumRodjenja { get; set; }

        public virtual String Pol { get; set; }

        public virtual Lekar Lekar { get; set; }

    }
}

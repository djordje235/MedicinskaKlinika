using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MedicinskaKlinika.Entiteti
{
    public class Termin
    {
        public virtual DateTime Datum { get; set; }

        public virtual DateTime Vreme { get; set; }

        public virtual String NazivOdeljenja { get; set; }

        public virtual Pacijent Pacijent { get; set; }

        public virtual Lekar Lekar { get; set; }
    }
}

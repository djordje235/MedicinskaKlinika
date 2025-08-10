using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MedicinskaKlinika.Entiteti
{
    public class Odeljenje
    {
        public virtual int Id { get; set; }

        public virtual String Naziv { get; set; }


        public virtual int BrProstorije {get; set; }

        public virtual String RadnoVreme { get; set; }

        
    }
}

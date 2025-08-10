using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MedicinskaKlinika.Entiteti
{
    public class Placanje
    {
        public virtual int Id { get; set; }
        public virtual int IdPlacanja { get; set; }

        public virtual int ProcenatPacijenta { get; set; }

        public virtual String NacinPlacanja { get; set; }

        public virtual Boolean PlatioPacijent { get; set; }


    }
}

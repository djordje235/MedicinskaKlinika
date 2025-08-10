using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MedicinskaKlinika.Entiteti
{
    public class NalaziSe
    {
        public virtual Lokacija Lokacija { get; set; }

        public virtual Odeljenje Odeljenje { get; set; }
    }
}

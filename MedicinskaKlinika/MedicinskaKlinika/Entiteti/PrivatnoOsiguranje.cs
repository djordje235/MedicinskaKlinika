using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MedicinskaKlinika.Entiteti
{
    public class PrivatnoOsiguranje
    {
        public virtual int BrPolise { get; set; }

        public virtual String OsiguravajucaKuca { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MedicinskaKlinika.Entiteti
{
    public class RadiU
    {
        public virtual Lekar Lekar { get; set; }
        public virtual Odeljenje Odeljenje { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MedicinskaKlinika.Entiteti
{
    internal class Lekar : Zaposlen
    {
        public virtual int JMBG {  get; set; }
        public virtual String Specijalizacija { get; set; }
        public virtual int BrLicence { get; set; }
    }
}

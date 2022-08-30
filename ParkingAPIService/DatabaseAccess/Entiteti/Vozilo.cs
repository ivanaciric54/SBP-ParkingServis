using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseAccess.Entiteti
{
    public class Vozilo
    {
        public virtual int ID { get; protected set; }
        public virtual String registracija { get; set; }
        public virtual long br_saobracajne { get; set; }
        public virtual String proizvodjac { get; set; }
        public virtual String model { get; set; }
        public virtual IList<Jednokratna> jednokratne { get; set; }
        public virtual IList<Odnosi_se_na_P> odnosi_se_na_p { get; set; }
        public virtual IList<Zakup> zakupi { get; set; }
        public Vozilo()
        {
            this.jednokratne = new List<Jednokratna>();
            this.odnosi_se_na_p = new List<Odnosi_se_na_P>();
            this.zakupi = new List<Zakup>();
        }
    }
}

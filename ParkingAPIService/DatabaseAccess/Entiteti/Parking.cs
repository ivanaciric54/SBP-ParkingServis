using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseAccess.Entiteti
{
    public class Parking
    {
        public virtual int ID { get; protected set; }
        public virtual Zona zona { get; set; }
        public virtual int br_mesta { get; set; }
        public virtual String adresa { get; set; }
        public virtual String naziv { get; set; }
        public virtual DateTime radno_vreme_od { get; set; }
        public virtual DateTime radno_vreme_do { get; set; }
        public virtual IList<Garazno_mesto> garazna_mesta { get; set; }
        public Parking()
        {
            this.garazna_mesta = new List<Garazno_mesto>();
        }

        public Parking(Parking p)
        {
            ID = p.ID;
            zona = p.zona;
            br_mesta = p.br_mesta;
            adresa = p.adresa;
            naziv = p.naziv;
            radno_vreme_od = p.radno_vreme_od;
            radno_vreme_do = p.radno_vreme_do;

            //this.garazna_mesta = new List<Garazno_mesto>();
        }
    }
}

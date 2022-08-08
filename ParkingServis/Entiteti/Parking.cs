using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParkingServis.Entiteti
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

        public Parking(Zona z, int brM, String adresa, String naziv, DateTime vOD, DateTime vDO)
        {
            this.zona = z;
            this.br_mesta = brM;
            this.adresa = adresa;
            this.naziv = naziv;
            this.radno_vreme_od = vOD;
            this.radno_vreme_do = vDO;

            this.garazna_mesta = new List<Garazno_mesto>();
        }
    }
}

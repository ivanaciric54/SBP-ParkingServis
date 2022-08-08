using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParkingServis.Entiteti
{
    public class Javna_garaza : Parking
    {
        public virtual int ID { get; set; }
        public virtual int br_nivoa { get; set; }
        public virtual String montazni_objekat { get; set; }
        public virtual String tip { get; set; }
        public Javna_garaza() : base()
        {

        }

        public Javna_garaza(int id, Zona z, int brM, String adresa, String naziv, DateTime vOD, DateTime vDO, int brn, String mo, String tip): base()
        {
            this.br_nivoa = brn;
            this.montazni_objekat = mo;
            this.tip = tip;

            this.ID = id;
            this.zona = z;
            this.br_mesta = brM;
            this.adresa = adresa;
            this.naziv = naziv;
            this.radno_vreme_od = vOD;
            this.radno_vreme_do = vDO;
        }
    }
}

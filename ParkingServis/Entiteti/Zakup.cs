using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParkingServis.Entiteti
{
    public class Zakup
    {
        public virtual int ID { get; protected set; }
        public virtual Klijent klijent { get; set; }
        public virtual Vozilo vozilo { get; set; }
        public virtual Parking_mesto parking_mesto { get; set; }
        public virtual DateTime datum_ugovora { get; set; }
        public virtual DateTime zakup_od { get; set; }
        public virtual DateTime zakup_do { get; set; }

        public Zakup()
        {

        }
    }
}

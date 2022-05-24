using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParkingServis.Entiteti
{
    public class Ulicno_mesto : Parking_mesto
    {
        //public virtual int ID { get; protected set; }
        public virtual Zona zona { get; set; }
        public virtual String naziv_ulice { get; set; }
        public Ulicno_mesto() : base()
        {

        }
        public Ulicno_mesto(String s):base(s)
        {

        }
    }
}

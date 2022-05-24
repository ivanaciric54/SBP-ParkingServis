using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParkingServis.Entiteti
{
    public class Javna_garaza : Parking
    {
        //public virtual int ID { get; protected set; }
        public virtual int br_nivoa { get; set; }
        public virtual String montazni_objekat { get; set; }
        public virtual String tip { get; set; }
        //public Javna_garaza() : base()
        //{

        //}
    }
}

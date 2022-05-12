using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParkingServis.Entiteti
{
    public class Vozilo
    {
        public virtual int ID { get; protected set; }
        public virtual String registracija { get; set; }
        public virtual int br_saobracajne { get; set; }
        public virtual String proizvodjac { get; set; }
        public virtual String model { get; set; }
        public Vozilo()
        {

        }
    }
}

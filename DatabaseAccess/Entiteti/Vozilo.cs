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
        public Vozilo()
        {

        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParkingServis.Entiteti
{
    public class Telefon
    {
        public virtual int ID { get; protected set; }
        public virtual String broj { get; set; }
        public virtual int id_klijenta { get; set; }
        public Telefon()
        {

        }
    }
}

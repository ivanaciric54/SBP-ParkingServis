using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParkingServis.Entiteti
{
    public class Zone_pretplatne
    {
        public virtual int ID { get; protected set; }
        public virtual Zona zona { get; set; }
        public virtual Pretplatna pretplatna_karta { get; set; }
        public Zone_pretplatne()
        {

        }
    }
}

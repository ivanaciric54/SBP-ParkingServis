using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParkingServis.Entiteti
{
    public class Garazno_mesto : Parking_mesto
    {
        //public virtual int ID { get; protected set; }
        public virtual int nivo {get; set; }
        public virtual int redni_br {get; set; }
        public virtual int id_parkinga {get; set; }
        public Garazno_mesto() : base()
        {

        }
        public Garazno_mesto(String s):base(s)
        {
                
        }
    }
}

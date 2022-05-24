using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParkingServis.Entiteti
{
    public class Zona
    {
        public virtual int ID { get; set; }
        public virtual IList<Parking> parkinzi { get; set; }
        public virtual IList<Zone_pretplatne> zone_pretplatne { get; set; }

        public Zona()
        {
            this.parkinzi = new List<Parking>();
            this.zone_pretplatne = new List<Zone_pretplatne>();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParkingServis.Entiteti
{
    public class Parking_mesto
    {
        public virtual int ID { get; protected set; }
        public virtual String zausetost { get; set; }
        public Parking_mesto()
        {
            
        }
        public Parking_mesto(String s)
        {
            this.zausetost = s;
        }
    }
}

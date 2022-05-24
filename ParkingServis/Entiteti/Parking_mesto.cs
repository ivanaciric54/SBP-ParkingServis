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
        public virtual IList<Zakup> zakupi { get; set; }
        public Parking_mesto()
        {
            this.zakupi = new List<Zakup>();
        }
        public Parking_mesto(String s)
        {
            this.zausetost = s;
            this.zakupi = new List<Zakup>();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParkingServis.Entiteti
{
    public class Klijent
    {
        public virtual int ID { get; protected set; }
        public virtual IList<Telefon> telefoni { get; set; }
        public virtual IList<Jednokratna> jednokratne { get; set; }
        public virtual IList<Pretplatna> pretplatne { get; set; }
        public virtual IList<Zakup> zakupi { get; set; }
        public Klijent()
        {
            this.telefoni = new List<Telefon>();
            this.jednokratne = new List<Jednokratna>();
            this.pretplatne = new List<Pretplatna>();
            this.zakupi = new List<Zakup>();
        }
    }
}

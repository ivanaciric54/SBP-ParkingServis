using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParkingServis.Entiteti
{
    public class Fizicko_lice : Klijent
    {
        //public virtual int ID { get; protected set; }

        public virtual int JMBG { get; set; }
        public virtual int LK { get; set; }
        public virtual String mesto_izdavanja_lk { get; set; }
        public virtual String licno_ime { get; set; }
        public virtual String ime_roditelja { get; set; }
        public virtual String prezime { get; set; }
        public virtual String adresa { get; set; }
        public virtual String prebivaliste { get; set; }
        public virtual int broj_vozacke { get; set; }

    public Fizicko_lice() : base()
        {
            
        }
    }
}

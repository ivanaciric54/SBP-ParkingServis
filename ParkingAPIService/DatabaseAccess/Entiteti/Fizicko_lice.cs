using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseAccess.Entiteti
{
    public class Fizicko_lice : Klijent
    {
        //public virtual int ID { get; protected set; }

        public virtual long JMBG { get; set; }
        public virtual long LK { get; set; }
        public virtual String mesto_izdavanja_lk { get; set; }
        public virtual String ime { get; set; }
        public virtual String ime_roditelja { get; set; }
        public virtual String prezime { get; set; }
        public virtual String adresa { get; set; }
        public virtual String prebivaliste { get; set; }
        public virtual long broj_vozacke { get; set; }
        public virtual IList<Telefon> telefoni { get; set; }

    public Fizicko_lice() : base()
        {
            this.telefoni = new List<Telefon>();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseAccess.Entiteti
{
    public class Pravno_lice : Klijent
    {
        //public virtual int ID { get; protected set; }
        public virtual long PIB { get; set; }
        public virtual String Naziv { get; set; }
        public virtual String Adresa { get; set; }
        public virtual String Ovlasceno_lice { get; set; }
    public Pravno_lice() : base()
        {

        }
    }
}

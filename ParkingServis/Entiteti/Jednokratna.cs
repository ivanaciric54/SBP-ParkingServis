using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParkingServis.Entiteti
{
    public class Jednokratna
    {
        public virtual int ID { get; protected set; }
        public virtual int id_klijenta { get; set; }
        public virtual int id_vozila { get; set; }

        //TIMESTAMP
        public virtual DateTime period_parkiranja_od { get; set; }
        public virtual DateTime period_parkiranja_do { get; set; }
        public virtual DateTime vreme_kontrole { get; set; }
        public Jednokratna()
        {

        }
    }
}

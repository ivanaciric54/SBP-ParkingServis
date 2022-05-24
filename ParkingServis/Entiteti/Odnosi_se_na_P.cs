using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParkingServis.Entiteti
{
    public class Odnosi_se_na_P
    {
        public virtual int ID { get; protected set; }
        public virtual Pretplatna id_pretplatne { get; set; }
        public virtual Vozilo id_vozila { get; set; }

        public Odnosi_se_na_P()
        {

        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseAccess.Entiteti
{
    public class Pretplatna
    {
        public virtual int ID { get; protected set; }
        public virtual DateTime datum { get; set; }
        public virtual DateTime period_vazenja_od { get; set; }
        public virtual DateTime period_vazenja_do { get; set; }
        public virtual int id_klijenta  { get; set; }
        public Pretplatna()
        {

        }
    }
}

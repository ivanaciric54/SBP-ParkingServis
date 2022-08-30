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
        public virtual Klijent id_klijenta  { get; set; }
        public virtual IList<Zone_pretplatne> zone_pretplatne { get; set; }
        public virtual IList<Odnosi_se_na_P> odnosi_se_na_p { get; set; }
        public Pretplatna()
        {
            this.zone_pretplatne = new List<Zone_pretplatne>();
            this.odnosi_se_na_p = new List<Odnosi_se_na_P>();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseAccess.Entiteti
{
    public class Odnosi_se_na_P
    {
        public virtual int ID { get; protected set; }
        public virtual int id_pretplatne { get; set; }
        public virtual int id_vozila { get; set; }

        public Odnosi_se_na_P()
        {

        }
    }
}

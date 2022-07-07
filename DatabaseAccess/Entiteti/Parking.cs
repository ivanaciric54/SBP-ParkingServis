using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseAccess.Entiteti
{
    public class Parking
    {
        public virtual int ID { get; protected set; }
        public virtual int zona { get; set; }
        public virtual int br_mesta { get; set; }
        public virtual String adresa { get; set; }
        public virtual String naziv { get; set; }
        public virtual DateTime radno_vreme_od { get; set; }
        public virtual DateTime radno_vreme_do { get; set; }

        public virtual IList<Garazno_mesto> GaraznaMesta { get; set; }

        public Parking()
        {
            GaraznaMesta = new List<Garazno_mesto>();
        }
    }
}

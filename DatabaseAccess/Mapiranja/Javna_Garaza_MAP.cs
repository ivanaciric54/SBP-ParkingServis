using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentNHibernate.Mapping;
using DatabaseAccess.Entiteti;

namespace DatabaseAccess.Mapiranja
{
    class Javna_garaza_MAP : ClassMap<DatabaseAccess.Entiteti.Javna_garaza>
    {
        public Javna_garaza_MAP()
        {
            //ime tabele
            Table("JAVNA_GARAZA");

            //primarni kljuc
            Id(x => x.ID, "ID").GeneratedBy.TriggerIdentity();

            Map(x => x.br_nivoa, "BR_NIVOA");
            Map(x => x.montazni_objekat, "MONTAZNI_OBJEKAT");
            Map(x => x.tip, "TIP");
        }
    }
}

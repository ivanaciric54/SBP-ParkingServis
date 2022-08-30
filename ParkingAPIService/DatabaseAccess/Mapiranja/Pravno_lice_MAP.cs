using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentNHibernate.Mapping;
using DatabaseAccess.Entiteti;

namespace DatabaseAccess.Mapiranja
{
    class Pravno_lice_MAP : ClassMap<DatabaseAccess.Entiteti.Pravno_lice>
    {

        public Pravno_lice_MAP()
        {
            //ime tabele
            Table("PRAVNO_LICE");

            //primarni kljuc
            Id(x => x.ID, "ID").GeneratedBy.TriggerIdentity();

            Map(x => x.PIB, "PIB");
            Map(x => x.Naziv, "NAZIV");
            Map(x => x.Adresa, "ADRESA");
            Map(x => x.Ovlasceno_lice, "OVLASCENO_LICE");
        }
    }
}

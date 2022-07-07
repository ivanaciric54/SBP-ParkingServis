using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentNHibernate.Mapping;
using DatabaseAccess.Entiteti;

namespace DatabaseAccess.Mapiranja
{
    class Garazno_mesto_MAP : ClassMap<DatabaseAccess.Entiteti.Garazno_mesto>
    {
        public Garazno_mesto_MAP()
        {
            //ime tabele
            Table("GARAZNO_MESTO");

            //primarni kljuc
            Id(x => x.ID, "ID").GeneratedBy.TriggerIdentity();

            //ostali atributi
            Map(x => x.nivo, "NIVO");
            Map(x => x.redni_br, "REDNI_BR");
            //Map(x => x.id_parkinga, "ID_PARKINGA");

            References(x => x.PripadaParkingu).Column("ID_PARKINGA").LazyLoad();
        }
    }
}

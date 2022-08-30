using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentNHibernate.Mapping;
using DatabaseAccess.Entiteti;

namespace DatabaseAccess.Mapiranja
{
    class Garazno_mesto_MAP : SubclassMap<DatabaseAccess.Entiteti.Garazno_mesto>
    {
        public Garazno_mesto_MAP()
        {
            //ime tabele
            Table("GARAZNO_MESTO");

            //primarni kljuc
            //Id(x => x.ID, "ID").GeneratedBy.Assigned();
            KeyColumn("ID");

            //ostali atributi
            Map(x => x.nivo, "NIVO");
            Map(x => x.redni_br, "REDNI_BR");
            References(x => x.id_parkinga).Column("ID_Parkinga").LazyLoad();
        }
    }
}

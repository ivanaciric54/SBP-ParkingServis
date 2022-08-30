using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentNHibernate.Mapping;
using DatabaseAccess.Entiteti;

namespace DatabaseAccess.Mapiranja
{
    class Jednokratna_MAP : ClassMap<DatabaseAccess.Entiteti.Jednokratna>
    {
        public Jednokratna_MAP()
        {
            //ime tabele
            Table("JEDNOKRATNA");

            //primarni kljuc
            Id(x => x.ID, "ID").GeneratedBy.TriggerIdentity();

            //TIMESTAMP
            Map(x => x.period_parkiranja_od, "PERIOD_PARKIRANJA_OD");
            Map(x => x.period_parkiranja_do, "PERIOD_PARKIRANJA_DO");
            Map(x => x.vreme_kontrole, "VREME_KONTROLE");

            // mapiranja vozila na ovoj jednolratnoj karti
            References(x => x.vozilo).Column("ID_VOZILA").LazyLoad();

            // mapiranja klijenta na ovoj jednolratnoj karti
            References(x => x.id_klijenta).Column("ID_KlIJENTA").LazyLoad();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentNHibernate.Mapping;
using ParkingServis.Entiteti;

namespace ParkingServis.Mapiranja
{
    class Jednokratna_MAP : ClassMap<ParkingServis.Entiteti.Jednokratna>
    {
        public Jednokratna_MAP()
        {
            //ime tabele
            Table("JEDNOKRATNA");

            //primarni kljuc
            Id(x => x.ID, "ID").GeneratedBy.TriggerIdentity();

            Map(x=>x.id_klijenta, "ID_KLIJENTA");
            Map(x => x.id_vozila, "ID_VOZILA");
            //TIMESTAMP
            Map(x => x.period_parkiranja_od, "PERIOD_PARKIRANJA_OD");
            Map(x => x.period_parkiranja_do, "PERIOD_PARKIRANJA_DO");
            Map(x => x.vreme_kontrole, "VREME_KONTROLE");
        }
    }
}

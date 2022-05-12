using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentNHibernate.Mapping;
using ParkingServis.Entiteti;

namespace ParkingServis.Mapiranja
{
    class Pretplatna_MAP : ClassMap<ParkingServis.Entiteti.Pretplatna>
    {
        public Pretplatna_MAP()
        {
            //ime tabele
            Table("PRETPLATNA");

            //primarni kljuc
            Id(x => x.ID, "ID").GeneratedBy.TriggerIdentity();

            Map(x => x.id_klijenta, "ID_KLIJENTA");
            Map(x => x.period_vazenja_od, "PERIOD_VAZENJA_OD");
            Map(x => x.period_vazenja_do, "PERIOD_vAZENJA_DO");
            Map(x => x.datum, "DATUM");

        }
    }
}

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

            Map(x => x.period_vazenja_od, "PERIOD_VAZENJA_OD");
            Map(x => x.period_vazenja_do, "PERIOD_vAZENJA_DO");
            Map(x => x.datum, "DATUM");

            // mapiranja klijenta na ovoj pretplatnoj karti
            References(x => x.id_klijenta).Column("ID_KlIJENTA").LazyLoad();

            // mapiranja zona_pretplanih
            HasMany(x => x.zone_pretplatne).KeyColumn("PRETPLATNA_KARTA").LazyLoad().Cascade.All().Inverse();

            // mapiranja odnosi_se_na_p
            HasMany(x => x.odnosi_se_na_p).KeyColumn("ID_PRETPLATNE").LazyLoad().Cascade.All().Inverse();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentNHibernate.Mapping;
using ParkingServis.Entiteti;

namespace ParkingServis.Mapiranja
{
    class Zona_MAP : ClassMap<ParkingServis.Entiteti.Zona>
    {
        public Zona_MAP()
        {
            //ime tabele
            Table("ZONA");

            //primarni kljuc
            Id(x => x.ID, "ID").GeneratedBy.Assigned();//TriggerIdentity();

            // mapiranja parking na ovoj zoni
            HasMany(x => x.parkinzi).KeyColumn("ZONA").LazyLoad().Cascade.All().Inverse();

            // mapiranja zona_pretplanih
            HasMany(x => x.zone_pretplatne).KeyColumn("ZONA").LazyLoad().Cascade.All().Inverse();
        }
    }
}

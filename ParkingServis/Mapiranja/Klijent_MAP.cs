using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentNHibernate.Mapping;
using ParkingServis.Entiteti;

namespace ParkingServis.Mapiranja
{
    class Klijent_MAP : ClassMap<ParkingServis.Entiteti.Klijent>
    {
        public Klijent_MAP()
        {
            //ime tabele
            Table("KLIJENT");

            //primarni kljuc
            Id(x => x.ID, "ID").GeneratedBy.TriggerIdentity();

            // mapiranja telefona vezanih za ovog klijenta
            HasMany(x => x.telefoni).KeyColumn("ID_KLIJENTA").LazyLoad().Cascade.All().Inverse();

            // mapiranja jednokratnih karata vezanih za ovog klijenta
            HasMany(x => x.jednokratne).KeyColumn("ID_KLIJENTA").LazyLoad().Cascade.All().Inverse();

            // mapiranja pretplatnih karata vezanih za ovog klijenta
            HasMany(x => x.pretplatne).KeyColumn("ID_KLIJENTA").LazyLoad().Cascade.All().Inverse();

            // mapiranja zakupa
            HasMany(x => x.zakupi).KeyColumn("ID_KLIJENTA").LazyLoad().Cascade.All().Inverse();
        }
    }
}

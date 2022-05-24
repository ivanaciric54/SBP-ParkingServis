using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentNHibernate.Mapping;
using ParkingServis.Entiteti;

namespace ParkingServis.Mapiranja
{
    class Ulicno_mesto_MAP : ClassMap<ParkingServis.Entiteti.Ulicno_mesto>
    {
        public Ulicno_mesto_MAP()
        {
            //ime tabele
            Table("ULICNO_MESTO");

            //primarni kljuc
            Id(x => x.ID, "ID").GeneratedBy.TriggerIdentity();

            References(x => x.zona).Column("Zona").LazyLoad();
            Map(x => x.naziv_ulice, "NAZIV_ULICE");
        }
    }
}

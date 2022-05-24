using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentNHibernate.Mapping;
using ParkingServis.Entiteti;

namespace ParkingServis.Mapiranja
{
    class Zakup_MAP : ClassMap<ParkingServis.Entiteti.Zakup>
    {
        public Zakup_MAP()
        {
            //ime tabele
            Table("Zakup");

            //primarni kljuc
            Id(x => x.ID, "ID").GeneratedBy.TriggerIdentity();

            //ostali atributi 
            Map(x => x.datum_ugovora, "DATUM_UGOVORA");
            Map(x => x.zakup_od, "PERIOD_ZAKUPA_OD");
            Map(x => x.zakup_do, "PERIOD_ZAKUPA_DO");

            References(x => x.klijent).Column("ID_KLIJENTA").LazyLoad();
            References(x => x.vozilo).Column("ID_VOZILA").LazyLoad();
            References(x => x.parking_mesto).Column("ID_PARKING_MESTA").LazyLoad();
        }
    }
}

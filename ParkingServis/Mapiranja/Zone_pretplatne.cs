using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentNHibernate.Mapping;
using ParkingServis.Entiteti;

namespace ParkingServis.Mapiranja
{
    class Zone_pretplatne_MAP : ClassMap<ParkingServis.Entiteti.Zone_pretplatne>
    {
        public Zone_pretplatne_MAP()
        {
            //ime tabele
            Table("ZONE_PRETPLATNE");

            //primarni kljuc
            Id(x => x.ID, "ID").GeneratedBy.TriggerIdentity();

            //ostali atributi
            References(x => x.zona).Column("ZONA").LazyLoad();
            References(x => x.pretplatna_karta).Column("PRETPLATNA_KARTA").LazyLoad(); 
        }
    }
}

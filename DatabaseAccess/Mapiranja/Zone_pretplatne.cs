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
            Map(x => x.zona, "ZONA");
            Map(x => x.pretplatna_karta, "PRETPLATNA_KARTA");
        }
    }
}

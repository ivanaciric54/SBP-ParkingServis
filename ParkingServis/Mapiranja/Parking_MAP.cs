using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentNHibernate.Mapping;
using ParkingServis.Entiteti;

namespace ParkingServis.Mapiranja
{
    class Parking_MAP : ClassMap<ParkingServis.Entiteti.Parking>
    {
        public Parking_MAP()
        {
            //ime tabele
            Table("PARKING");

            //primarni kljuc
            Id(x => x.ID, "ID").GeneratedBy.TriggerIdentity();

            Map(x => x.zona, "ZONA");
            Map(x => x.adresa, "ADRESA");
            Map(x => x.br_mesta, "BR_MESTA");
            Map(x => x.naziv, "NAZIV");
            Map(x => x.radno_vreme_od, "RADNO_VREME_OD");
            Map(x => x.radno_vreme_do, "RADNO_VREME_DO");
        }
    }
}

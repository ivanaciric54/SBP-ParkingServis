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

        }
    }
}

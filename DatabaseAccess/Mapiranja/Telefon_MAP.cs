using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentNHibernate.Mapping;
using ParkingServis.Entiteti;

namespace ParkingServis.Mapiranja
{
    class Telefon_MAP : ClassMap<ParkingServis.Entiteti.Telefon>
    {
        public Telefon_MAP()
        {
            //ime tabele
            Table("TELEFON");

            //primarni kljuc
            Id(x => x.ID, "ID").GeneratedBy.TriggerIdentity();

            //ostali atributi
            Map(x => x.broj, "BROJ");
            Map(x => x.id_klijenta, "ID_KLIJENTA");
        }
    }
}

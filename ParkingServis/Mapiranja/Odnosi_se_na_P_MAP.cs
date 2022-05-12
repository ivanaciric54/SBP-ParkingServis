using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentNHibernate.Mapping;
using ParkingServis.Entiteti;

namespace ParkingServis.Mapiranja
{
    class Odnosi_se_na_P_MAP : ClassMap<ParkingServis.Entiteti.Odnosi_se_na_P>
    {
        public Odnosi_se_na_P_MAP()
        {
            //ime tabele
            Table("ODNOSI_SE_NA_P");

            //primarni kljuc
            Id(x => x.ID, "ID").GeneratedBy.TriggerIdentity();

            //ostali atributi
            Map(x => x.id_pretplatne, "ID_PRETPLATNE");
            Map(x => x.id_vozila, "ID_VOZILA");

        }
    }
}

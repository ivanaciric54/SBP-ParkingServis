using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentNHibernate.Mapping;
using DatabaseAccess.Entiteti;

namespace DatabaseAccess.Mapiranja
{
    class Telefon_MAP : ClassMap<DatabaseAccess.Entiteti.Telefon>
    {
        public Telefon_MAP()
        {
            //ime tabele
            Table("TELEFON");

            //primarni kljuc
            Id(x => x.ID, "ID").GeneratedBy.TriggerIdentity();

            //ostali atributi
            Map(x => x.broj, "BROJ");
            //Map(x => x.id_klijenta, "ID_KLIJENTA");
            References(x => x.id_klijenta).Column("ID_KLIJENTA").LazyLoad();
        }
    }
}

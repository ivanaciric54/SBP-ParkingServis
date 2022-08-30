using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentNHibernate.Mapping;
using DatabaseAccess.Entiteti;

namespace DatabaseAccess.Mapiranja
{
    class Odnosi_se_na_P_MAP : ClassMap<DatabaseAccess.Entiteti.Odnosi_se_na_P>
    {
        public Odnosi_se_na_P_MAP()
        {
            //ime tabele
            Table("ODNOSI_SE_NA_P");

            //primarni kljuc
            Id(x => x.ID, "ID").GeneratedBy.TriggerIdentity();

            //ostali atributi
            References(x => x.id_pretplatne).Column("ID_PRETPLATNE").LazyLoad();
            References(x => x.id_vozila).Column("ID_VOZILA").LazyLoad();

        }
    }
}

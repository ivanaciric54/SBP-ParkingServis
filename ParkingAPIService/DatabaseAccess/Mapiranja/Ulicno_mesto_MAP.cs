using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentNHibernate.Mapping;
using DatabaseAccess.Entiteti;

namespace DatabaseAccess.Mapiranja
{
    class Ulicno_mesto_MAP : SubclassMap<DatabaseAccess.Entiteti.Ulicno_mesto>
    {
        public Ulicno_mesto_MAP()
        {
            //ime tabele
            Table("ULICNO_MESTO");

            //primarni kljuc
            //Id(x => x.ID, "ID").GeneratedBy.Assigned();
            KeyColumn("ID");

            // Zato sto su Zona i Ulicna mesta nezavisna, kada se brise zona:
            // 1. Dodeliti valjanu zonu svim Ulicnim mestima koja pripadaju zoni koja treba da se obrise
            // 2. Obrisati zonu
            References(x => x.zona).Column("Zona").LazyLoad();
            Map(x => x.naziv_ulice, "NAZIV_ULICE");
        }
    }
}

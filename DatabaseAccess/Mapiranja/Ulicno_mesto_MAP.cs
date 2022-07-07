using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentNHibernate.Mapping;
using DatabaseAccess.Entiteti;

namespace DatabaseAccess.Mapiranja
{
    class Ulicno_mesto_MAP : ClassMap<DatabaseAccess.Entiteti.Ulicno_mesto>
    {
        public Ulicno_mesto_MAP()
        {
            //ime tabele
            Table("ULICNO_MESTO");

            //primarni kljuc
            Id(x => x.ID, "ID").GeneratedBy.TriggerIdentity();

            Map(x => x.zona, "ZONA");
            Map(x => x.naziv_ulice, "NAZIV_ULICE");
        }
    }
}

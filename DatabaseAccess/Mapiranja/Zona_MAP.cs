using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentNHibernate.Mapping;
using DatabaseAccess.Entiteti;

namespace DatabaseAccess.Mapiranja
{
    class Zona_MAP : ClassMap<DatabaseAccess.Entiteti.Zona>
    {
        public Zona_MAP()
        {
            //ime tabele
            Table("ZONA");

            //primarni kljuc
            Id(x => x.ID, "ID").GeneratedBy.TriggerIdentity();
        }
    }
}

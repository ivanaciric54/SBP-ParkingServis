using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentNHibernate.Mapping;
using DatabaseAccess.Entiteti;

namespace DatabaseAccess.Mapiranja
{
    class Parking_mesto_MAP : ClassMap<DatabaseAccess.Entiteti.Parking_mesto>
    {
        public Parking_mesto_MAP()
        {
            //ime tabele
            Table("PARKING_MESTO");

            //primarni kljuc
            Id(x => x.ID, "ID").GeneratedBy.SequenceIdentity("PARKING_MESTO_ID_SEQ");

            Map(x => x.zausetost, "ZAUZETOST");

            // mapiranja zakupa
            HasMany(x => x.zakupi).KeyColumn("ID_PARKING_MESTA").LazyLoad().Cascade.All().Inverse();
        }
    }
}

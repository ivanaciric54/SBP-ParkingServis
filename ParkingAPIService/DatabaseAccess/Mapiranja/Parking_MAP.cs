using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentNHibernate.Mapping;
using DatabaseAccess.Entiteti;

namespace DatabaseAccess.Mapiranja
{
    class Parking_MAP : ClassMap<DatabaseAccess.Entiteti.Parking>
    {
        public Parking_MAP()
        {
            //ime tabele
            Table("PARKING");

            //primarni kljuc
            //Id(x => x.ID, "ID").GeneratedBy.TriggerIdentity();
            Id(x => x.ID, "ID").GeneratedBy.SequenceIdentity("PARKING_ID_SEQ");

            Map(x => x.adresa, "ADRESA");
            Map(x => x.br_mesta, "BR_MESTA");
            Map(x => x.naziv, "NAZIV");
            Map(x => x.radno_vreme_od, "RADNO_VREME_OD");
            Map(x => x.radno_vreme_do, "RADNO_VREME_DO");

            HasMany(x => x.garazna_mesta).KeyColumn("ID_PARKINGA").LazyLoad().Cascade.All();

            // mapiranja zone
            References(x => x.zona).Column("ZONA").LazyLoad();
        }
    }
}

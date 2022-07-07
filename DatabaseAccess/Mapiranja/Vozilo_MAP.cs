﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentNHibernate.Mapping;
using DatabaseAccess.Entiteti;

namespace DatabaseAccess.Mapiranja
{
    class Vozilo_MAP : ClassMap<DatabaseAccess.Entiteti.Vozilo>
    {
        public Vozilo_MAP()
        {
            //ime tabele
            Table("VOZILO");

            //primarni kljuc
            Id(x => x.ID, "ID").GeneratedBy.TriggerIdentity();

            //ostali atributi
            Map(x => x.registracija, "REGISTRACIJA");
            Map(x => x.br_saobracajne, "BR_SAOBRACAJNE");
            Map(x => x.proizvodjac, "PROIZVODJAC");
            Map(x => x.model, "MODEL_VOZILA");
        }
    }
}

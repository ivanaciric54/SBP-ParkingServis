using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentNHibernate.Mapping;
using ParkingServis.Entiteti;

namespace ParkingServis.Mapiranja
{
    class Fizicko_lice_MAP : ClassMap<ParkingServis.Entiteti.Fizicko_lice>
    {
        public Fizicko_lice_MAP()
        {
            //ime tabele
            Table("FIZICKO_LICE");

            //primarni kljuc
            Id(x => x.ID, "ID").GeneratedBy.TriggerIdentity();

            //ostali atributi
            Map(x => x.JMBG, "JMBG");
            Map(x => x.LK, "LK");
            Map(x => x.mesto_izdavanja_lk, "MESTO_IZDAVANJA_LK");
            Map(x => x.prebivaliste, "PREBIVALISTE");
            Map(x => x.adresa, "ADRESA");
            Map(x => x.licno_ime, "LICNO_IME");
            Map(x => x.ime_roditelja, "IME_RODITELJA");
            Map(x => x.prezime, "PREZIME");
            Map(x => x.broj_vozacke, "BROJ_VOZACKE");

            // mapiranja telefona vezanih za ovog klijenta
            //HasMany(x => x.telefoni).KeyColumn("ID_KLIJENTA").LazyLoad().Cascade.All();
        }
    }
}

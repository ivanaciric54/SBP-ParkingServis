using DatabaseAccess.Entiteti;
using DatabaseAccess.Entiteti;
using System;
//using DatabaseAccess.Entiteti;
using System.Collections.Generic;

namespace DatabaseAccess.DTOs
{
    public class ParkingView
    {
        public  int ID { get; protected set; }
        public  int zona { get; set; }
        public  int br_mesta { get; set; }
        public  String adresa { get; set; }
        public  String naziv { get; set; }
        public  DateTime radno_vreme_od { get; set; }
        public  DateTime radno_vreme_do { get; set; }


        public virtual IList<Garazno_mestoView> GaraznaMesta { get; set; }


        public ParkingView()
        {

        }

        public ParkingView(Parking p)
        {
            ID = p.ID;
            zona = p.zona;
            br_mesta = p.br_mesta;
            adresa = p.adresa;
            naziv = p.naziv;
            radno_vreme_od = p.radno_vreme_od;
            radno_vreme_do = p.radno_vreme_do;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;
using DatabaseAccess.Entiteti;
using DatabaseAccess.Entiteti;

namespace DatabaseAccess.DTOs
{
    public class Garazno_mestoView
    {
        public int gmID { get; set; }
        public int nivo { get; set; }
        public int redni_br { get; set; }
        public int id_parkinga { get; set; }

        public ParkingView Parking { get; set; }


        public Garazno_mestoView()
        {

        }

        public Garazno_mestoView(Garazno_mesto g)
        {
            nivo = g.nivo;
            redni_br = g.redni_br;
            id_parkinga = g.id_parkinga;
        }
    }
}

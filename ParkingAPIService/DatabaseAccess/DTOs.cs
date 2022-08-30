using DatabaseAccess.Entiteti;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseAccess
{
    #region FizickoLice
    public class FizickoLicePregled
    {
        public int ID { get; set; }
        public String Ime { get; set; }
        public String Prezime { get; set; }
        public String Adresa { get; set; }
        public String Prebivaliste { get; set; }
        public String Telefon { get; set; }
        public FizickoLicePregled Lice { get; set; }

        public FizickoLicePregled()
        {

        }

        public FizickoLicePregled(Fizicko_lice f)
        {
            ID = f.ID;
            Ime = f.ime;
            Prezime = f.prezime;
            Adresa = f.adresa;
            Prebivaliste = f.prebivaliste;
   //         Telefon = f.telefoni;
        }
    }
    #endregion FizickoLice

    #region PravnoLice
    public class PravnoLicePregled
    {
        public int ID { get; set; }
        public String Naziv { get; set; }
        public String Adresa { get; set; }
        public PravnoLicePregled Lice { get; set; }

        public PravnoLicePregled()
        {

        }

        public PravnoLicePregled(Pravno_lice p)
        {
            ID = p.ID;
            Naziv = p.Naziv;
            Adresa = p.Adresa;
        }
    }
    #endregion PravnoLice

    #region Klijent
    public class KlijentPregled
    {
        public int ID;
        public String Ime;

        public KlijentPregled()
        {

        }

        public KlijentPregled(int id, string ime)
        {
            this.ID = id;
            this.Ime = ime;
        }
    }
    #endregion KLijent

    #region Telefon
    public class TelefonPregled
    {
        public int ID;
        public String ImeKlijenta;
        public String broj;

        public TelefonPregled()
        {

        }

        public TelefonPregled(int id, String imeKlijenta, String broj)
        {
            this.ID = id;
            this.ImeKlijenta = imeKlijenta;
            this.broj = broj;
        }
    }
    #endregion Telefon

    #region Zona
    public class ZonaPregled
    {
        public int ID;
        public int br_parkinga;

        public ZonaPregled()
        {

        }

        public ZonaPregled(int id, int brpm)
        {
            this.ID = id;
            this.br_parkinga = brpm;
        }
    }
    #endregion Zona

    #region Parking
    public class ParkingPregled
    {
        public int ID { get; protected set; }
        public Zona zona { get; set; }
        public String naziv { get; set; }
        public String adresa { get; set; }
        public int br_mesta { get; set; }
        public DateTime radno_vreme_od { get; set; }
        public DateTime radno_vreme_do { get; set; }

        public ParkingPregled()
        {

        }

        public ParkingPregled(Parking p)
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
    #endregion Parking

    #region JavnaGaraza
    public class JavnaGarazaPregled
    {
        public int ID;
        public int zona;
        public String naziv;
        public String adresa;
        public int br_mesta;
        public String vremeOtvaranja;
        public String vremeZatvaranja;
        public int br_nivoa;
        public String podnad;

        public JavnaGarazaPregled()
        {

        }

        public JavnaGarazaPregled(int id, int z, String n, String a, int brm, String vremeO, String vremeZ, int brn, String pn)
        {
            this.ID = id;
            this.zona = z;
            this.naziv = n;
            this.adresa = a;
            this.br_mesta = brm;
            this.vremeOtvaranja = vremeO;
            this.vremeZatvaranja = vremeZ;
            this.br_nivoa = brn;
            this.podnad = pn;
        }
    }
    #endregion JavnaGaraza

    #region GaraznoMesto
    public class GaraznoMestoPregled
    {
        public int ID { get; set; }
  //      public String zauzetost { get; set; }
        public int nivo { get; set; }
        public int redni_br { get; set; }
        public int id_parkinga { get; set; }
        //     public String adresa { get; set; }

        public ParkingPregled Parking { get; set; }

        public GaraznoMestoPregled()
        {

        }

        public GaraznoMestoPregled(Garazno_mesto g)
        {
            ID = g.ID;
  //          zauzetost = g.zauzetost;
            nivo = g.nivo;
            redni_br = g.redni_br;
            id_parkinga = g.id_parkinga;
  //          adresa = g.adresa;
        }
    }
    #endregion GaraznoMesto

    #region UlicnoMesto
    public class UlicnoMestoPregled
    {
        public int ID { get; set; }
        public String zauzetost { get; set; }
        public Zona zona { get; set; }
        public String naziv_ulice { get; set; }

        public ParkingPregled Parking { get; set; }

        public UlicnoMestoPregled()
        {

        }

        public UlicnoMestoPregled(Ulicno_mesto u)
        {
            ID = u.ID;
      //      zauzetost = u.zauzetost;
            zona = u.zona;
            naziv_ulice = u.naziv_ulice;
        }
    }
    #endregion UlicnoMesto

    #region Vozilo
    public class VoziloPregled
    {
        public int ID;
        public String registracija { get; set; }
        public virtual long br_saobracajne { get; set; }
        public String odgovornolice { get; set; }
        public int parkingmesta { get; set; }
        public  String proizvodjac { get; set; }
        public  String model { get; set; }
        public VoziloPregled Vozilo { get; set; }

        public VoziloPregled()
        {

        }

        public VoziloPregled(Vozilo v)
        {
            ID = ID;
            registracija = v.registracija;
            br_saobracajne = v.br_saobracajne;
  //          parkingmesta = v.parkingmesta;
        }
    }
    #endregion Vozilo

    #region Jednokratna
    public class JednokratnaPregled
    {
        public int ID;
        public String voziloRegistracija;
        public String ovlascenolice;

        public JednokratnaPregled()
        {

        }
        public JednokratnaPregled(int id, String vr, String ol)
        {
            this.ID = id;
            this.voziloRegistracija = vr;
            this.ovlascenolice = ol;
        }
    }
    #endregion Jednokratna

    #region Pretplatna
    public class PretplatnaPregled
    {
        public int ID;
        public String vaziOD;
        public String vaziDO;
        public String zona;
        public String registracijaVozila;
        public String ol;

        public PretplatnaPregled()
        {

        }

        public PretplatnaPregled(int id, String vOD, String vDO, String z, String rv, String ol)
        {
            this.ID = id;
            this.vaziOD = vOD;
            this.vaziDO = vDO;
            this.zona = z;
            this.registracijaVozila = rv;
            this.ol = ol;
        }
    }
    #endregion Pretplatna

    #region ZakupPregled
    public class ZakupPregled
    {
        public int ID;
        public String registracija;
        public String ol;
        public int br_mesta;

        public ZakupPregled()
        {

        }

        public ZakupPregled(int id, String r, String ol, int brm)
        {
            this.ID = id;
            this.registracija = r;
            this.ol = ol;
            this.br_mesta = brm;
        }
    }
    #endregion ZakupPregled
}

using ParkingServis.Entiteti;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParkingServis
{
    #region FizickoLice
    public class FizickoLicePregled
    {
        public int ID;
        public String Ime;
        public String Prezime;
        public String Adresa;
        public String Prebivaliste;
        public String Telefon;

        public FizickoLicePregled()
        {

        }

        public FizickoLicePregled(int id, String ime, String prezime, String adresa, String prebivaliste, String telefon)
        {
            this.ID = id;
            this.Ime = ime;
            this.Prezime = prezime;
            this.Adresa = adresa;
            this.Prebivaliste = prebivaliste;
            this.Telefon = telefon;
        }
    }
    #endregion FizickoLice

    #region PravnoLice
    public class PravnoLicePregled
    {
        public int ID;
        public String Naziv;
        public String Adresa;

        public PravnoLicePregled()
        {

        }

        public PravnoLicePregled(int id, String naziv, String adresa)
        {
            this.ID = id;
            this.Naziv = naziv;
            this.Adresa = adresa;
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
        public int ID;
        public int zona;
        public String naziv;
        public String adresa;
        public int br_mesta;
        public String vremeOtvaranja;
        public String vremeZatvaranja;

        public ParkingPregled()
        {

        }

        public ParkingPregled(int id, int z, String n, String a, int brm, String vremeO, String vremeZ)
        {
            this.ID = id;
            this.zona = z;
            this.naziv = n;
            this.adresa = a;
            this.br_mesta = brm;
            this.vremeOtvaranja = vremeO;
            this.vremeZatvaranja = vremeZ;
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
        public int ID;
        public String zauzetost;
        public int nivo;
        public int r_br;
        public String parking;
        public String adresa;

        public GaraznoMestoPregled()
        {

        }

        public GaraznoMestoPregled(int id, string z, int n, int rbr, String p, String a)
        {
            this.ID = id;
            this.zauzetost = z;
            this.nivo = n;
            this.r_br = rbr;
            this.parking = p;
            this.adresa = a;
        }
    }
    #endregion GaraznoMesto

    #region UlicnoMesto
    public class UlicnoMestoPregled
    {
        public int ID;
        public String zauzetost;
        public int zona;
        public String ulica;

        public UlicnoMestoPregled()
        {

        }

        public UlicnoMestoPregled(int id, String z, int zo, String ul)
        {
            this.ID = id;
            this.zauzetost = z;
            this.zona = zo;
            this.ulica = ul;
        }
    }
    #endregion UlicnoMesto

    #region Vozilo
    #endregion Vozilo

    #region Jednokratna
    #endregion Jednokratna

    #region Pretplatna
    #endregion Pretplatna
}

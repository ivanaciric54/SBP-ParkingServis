using System;
using System.Collections.Generic;
using System.Linq;
using NHibernate;
using DatabaseAccess.Entiteti;

namespace DatabaseAccess
{
    public class DataProvider
    {

        #region FizickoLice
        public static List<FizickoLicePregled> vratiSvaFizickaLica()
        {
            List<FizickoLicePregled> fizickalica = new List<FizickoLicePregled>();
            try
            {
                ISession s = DataLayer.GetSession();
                IEnumerable<Fizicko_lice> svaFizickaLica = from o in s.Query<Fizicko_lice>() select o;

                foreach (Fizicko_lice f in svaFizickaLica)
                {
                    fizickalica.Add(new FizickoLicePregled(f));

                }
                s.Close();
            }
            catch (Exception)
            {
                //handle exceptions
                throw;
            }
            return fizickalica;
        }

        public static FizickoLicePregled vratiFizickoLice(int id)
        {
            FizickoLicePregled lice;
            try
            {
                ISession s = DataLayer.GetSession();

                Fizicko_lice f = s.Load<Fizicko_lice>(id);

                lice = new FizickoLicePregled(f);


                s.Close();
            }
            catch (Exception)
            {
                //handle exceptions
                throw;
            }
            return lice;
        }

        public static void dodajFizickoLice(FizickoLicePregled fl)
        {
            try
            {
                ISession s = DataLayer.GetSession();


                Fizicko_lice f = new Fizicko_lice
                {
                    ime = fl.Ime,
                    prezime = fl.Prezime,
                    adresa = fl.Adresa,
                    prebivaliste = fl.Prebivaliste,
                };
            }
            catch (Exception)
            {
                //handle exceptions
                throw;
            }
        }

        public static void izmeniFizickoLice(FizickoLicePregled f)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                Fizicko_lice fl = s.Load<Fizicko_lice>(f.ID);
      //          fl.JMBG = f.JMBG;
       //         fl.LK = f.LK;
       //         fl.mesto_izdavanja_lk = f.mesto_izdavanja_lk;
                fl.ime = f.Ime;
      //          fl.ime_roditelja = f.ime_roditelja;
                fl.prezime = f.Prezime;
                fl.adresa = f.Adresa;
                fl.prebivaliste = f.Prebivaliste;
      //          fl.broj_vozacke = f.broj_vozacke;

                s.SaveOrUpdate(fl);
                s.Flush();
                s.Close();
            }
            catch (Exception)
            {
                //handle exceptions
                throw;
            }
            return;


        }

        public static void izbrisiFizickoLice(int id)
        {
            try
            {
                ISession s = DataLayer.GetSession();
                Entiteti.Fizicko_lice fl = s.Load<Fizicko_lice>(id);

                IEnumerable<Telefon> br_telefona = from o in s.Query<Telefon>()
                                                   where o.id_klijenta.ID == fl.ID
                                                   select o;

                foreach (Telefon t in br_telefona)
                {
                    s.Delete(t);
                    s.Flush();
                }

                s.Delete(fl);
                s.Flush();

                s.Close();
            }
            catch (Exception)
            {
                //handle exceptions
                throw;
            }
        }
        #endregion FizickoLice

        #region PravnoLice
        public static List<PravnoLicePregled> vratiSvaPravnaLica()
        {
            List<PravnoLicePregled> pravnalica = new List<PravnoLicePregled>();
            try
            {
                ISession s = DataLayer.GetSession();
                IEnumerable<Pravno_lice> svaPravnaLica = from o in s.Query<Pravno_lice>() select o;

                foreach (Pravno_lice p in svaPravnaLica)
                {

                    pravnalica.Add(new PravnoLicePregled(p));
                }
                s.Close();
            }
            catch (Exception)
            {
                //handle exceptions
                throw;
            }
            return pravnalica;
        }

        public static PravnoLicePregled vratiPravnoLice(int id)
        {
            PravnoLicePregled pravnalica;
      //      List<PravnoLicePregled> pravnalica = new List<PravnoLicePregled>();
            try
            {
                ISession s = DataLayer.GetSession();

                Pravno_lice pl = s.Load<Pravno_lice>(id);

                pravnalica = new PravnoLicePregled(pl);

                s.Close();
            }
            catch (Exception)
            {
                //handle exceptions
                throw;
            }
            return pravnalica;
        }

        public static void dodajPravnoLice(PravnoLicePregled pl)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                Pravno_lice p = new Pravno_lice
                {
                    Naziv = pl.Naziv,
                    Adresa = pl.Adresa,
      //              Ovlasceno_lice = pl.Ovlasceno_lice,
                };

                s.SaveOrUpdate(p);
                s.Flush();

                s.Close();

            }
            catch (Exception)
            {
                //handle exceptions
                throw;
            }
        }

        public static void izmeniPravnoLice(PravnoLicePregled p)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                Pravno_lice pl = s.Load<Pravno_lice>(p.ID);
      //          pl.PIB = p.PIB;
                pl.Naziv = p.Naziv;
                pl.Adresa = p.Adresa;
      //          pl.Ovlasceno_lice = p.Ovlasceno_lice;

                s.SaveOrUpdate(pl);
                s.Flush();

                s.Close();

            }
            catch (Exception)
            {
                //handle exceptions
                throw;
            }
        }

        public static void izbrisiPravnoLice(int id)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                Pravno_lice pl = s.Load<Pravno_lice>(id);

                IEnumerable<Telefon> br_telefona = from o in s.Query<Telefon>()
                                                   where o.id_klijenta.ID == pl.ID
                                                   select o;

                foreach (Telefon t in br_telefona)
                {
                    s.Delete(t);
                    s.Flush();
                }

                s.Delete(pl);
                s.Flush();

                s.Close();

            }
            catch (Exception)
            {
                //handle exceptions
                throw;
            }
        }

        #endregion PravnoLice

        #region Telefon
        public static List<TelefonPregled> vratiSveTelefone()
        {
            List<TelefonPregled> telefoni = new List<TelefonPregled>();
            try
            {
                ISession s = DataLayer.GetSession();
                IEnumerable<Telefon> sviTelefoni = from o in s.Query<Telefon>() select o;

                foreach (Telefon t in sviTelefoni)
                {
                    IEnumerable<Fizicko_lice> fl = from o in s.Query<Fizicko_lice>()
                                                   where o.ID == t.id_klijenta.ID
                                                   select o;

                    if (fl.Count() != 0)
                    {
                        String ime = fl.First().ime + " (" + fl.First().ime_roditelja + ") " + fl.First().prezime;
                        telefoni.Add(new TelefonPregled(t.ID, ime, t.broj));
                    }

                    IEnumerable<Pravno_lice> pl = from o in s.Query<Pravno_lice>()
                                                  where o.ID == t.id_klijenta.ID
                                                  select o;
                    if (pl.Count() != 0)
                    {
                        telefoni.Add(new TelefonPregled(t.ID, pl.First().Naziv, t.broj));
                    }


                }
                s.Close();
            }
            catch (Exception)
            {
                //handle exceptions
                throw;
            }
            return telefoni;

        }

        public static void vratiTelefon(int id, String ime)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                Telefon t = s.Load<Telefon>(id);

                

                s.Close();
            }
            catch (Exception)
            {
                //handle exceptions
                throw;
            }
            return;

        }

        public static void dodajTelefon(int id, String broj)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                Telefon t = new Telefon();
                t.broj = broj;
                Klijent k = s.Load<Klijent>(id);
                t.id_klijenta = k;

                s.SaveOrUpdate(t);
                s.Flush();
                s.Close();
            }
            catch (Exception)
            {
                //handle exceptions
                throw;
            }
            return;
        }

        public static void izmeniTelefon(int id, string broj)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                Telefon t = s.Load<Telefon>(id);

                t.broj = broj;

                s.SaveOrUpdate(t);
                s.Flush();
                s.Close();
            }
            catch (Exception)
            {
                //handle exceptions
                throw;
            }
            return;


        }

        public static void izbrisiTelefon(int id)
        {
            try
            {
                ISession s = DataLayer.GetSession();
                Entiteti.Telefon t = s.Load<Telefon>(id);

                s.Delete(t);
                s.Flush();

                s.Close();
            }
            catch (Exception)
            {
                //handle exceptions
                throw;
            }
        }


        #endregion Telefon

        #region Klijent
        public static List<KlijentPregled> vratiSveKlijente()
        {
            List<KlijentPregled> klijenti = new List<KlijentPregled>();
            try
            {
                ISession s = DataLayer.GetSession();

                IEnumerable<Fizicko_lice> svaFizickaLica = from o in s.Query<Fizicko_lice>() select o;

                foreach (Fizicko_lice m in svaFizickaLica)
                {
                    String ime = m.ime + " (" + m.ime_roditelja + ") " + m.prezime;
                    klijenti.Add(new KlijentPregled(m.ID, ime));
                }

                IEnumerable<Pravno_lice> svaPravnaLica = from o in s.Query<Pravno_lice>() select o;

                foreach (Pravno_lice m in svaPravnaLica)
                {
                    klijenti.Add(new KlijentPregled(m.ID, m.Naziv));
                }

                s.Close();
            }
            catch (Exception)
            {
                //handle exceptions
                throw;
            }
            return klijenti;
        }
        #endregion Klijent

        #region Zona
        public static List<ZonaPregled> vratiSveZone()
        {
            List<ZonaPregled> zone = new List<ZonaPregled>();
            try
            {
                ISession s = DataLayer.GetSession();
                IEnumerable<Zona> sveZone = from o in s.Query<Zona>() select o;
                Javna_garaza j = new Javna_garaza();

                foreach (Zona z in sveZone)
                {
                    IEnumerable<Parking> br_parkinga = from o in s.Query<Parking>()
                                                           //where o.zona.ID==z.ID
                                                       select o;
                    IEnumerable<Javna_garaza> br_jgaraza = from o in s.Query<Javna_garaza>()
                                                               //where o.zona.ID==z.ID
                                                           select o;
                    List<Parking> lista_parkinga = br_parkinga.ToList();

                    lista_parkinga.RemoveRange(0, br_jgaraza.Count());
                    List<Parking> krajnja = new List<Parking>();

                    foreach (Parking p in lista_parkinga)
                    {
                        if (p.zona.ID == z.ID)
                            krajnja.Add(p);
                    }


                    //MessageBox.Show((krajnja.Count().ToString()));

                    zone.Add(new ZonaPregled(z.ID, krajnja.Count()));
                }
                s.Close();
            }
            catch (Exception )
            {
                //handle exceptions
                throw;
            }
            return zone;
        }

        public static void vratiZonu(int id)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                Zona z = s.Load<Zona>(id);

                IEnumerable<Parking> br_parkinga = from o in s.Query<Parking>()
                                                       //where o.zona.ID==z.ID
                                                   select o;
                IEnumerable<Javna_garaza> br_jgaraza = from o in s.Query<Javna_garaza>()
                                                           //where o.zona.ID==z.ID
                                                       select o;
                List<Parking> lista_parkinga = br_parkinga.ToList();

                lista_parkinga.RemoveRange(0, br_jgaraza.Count());
                List<Parking> krajnja = new List<Parking>();

                foreach (Parking p in lista_parkinga)
                {
                    if (p.zona.ID == z.ID)
                        krajnja.Add(p);
                }

                String str = "";

                foreach (Parking p in krajnja)
                {
                    str += "NAZIV: " + p.naziv + " | ADRESA: " + p.adresa + " | BR.MESTA: " + p.br_mesta + "\n";
                }


                s.Close();
            }
            catch (Exception )
            {
                //handle exceptions
                throw;
            }
        }

        public static void dodajZonu(Zona z)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                s.SaveOrUpdate(z);
                s.Flush();
                s.Close();
            }
            catch (Exception)
            {
                //handle exceptions
                throw;
            }
            return;
        }

        public static void izmeniZonu(int id, int broj)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                Zona z = s.Load<Zona>(id);

                z.ID = broj;

                s.SaveOrUpdate(z);
                s.Flush();
                s.Close();
            }
            catch (Exception )
            {
                //handle exceptions
                throw;
            }
            return;
        }

        public static void izbrisiZonu(int id)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                Zona z = s.Load<Zona>(id);

                s.Delete(z);
                s.Flush();
                s.Close();
            }
            catch (Exception)            
            {
                //handle exceptions
                throw;
            }
        }
        #endregion Zona

        #region Parking
        public static List<ParkingPregled> vratiSveParkinge()
        {
            List<ParkingPregled> parkinzi = new List<ParkingPregled>();
            try
            {
                ISession s = DataLayer.GetSession();
                IEnumerable<Parking> sviparkinzi = from o in s.Query<Parking>() select o;

                if(sviparkinzi.Count() > 0)
                    foreach (Parking p in sviparkinzi.ToList())
                    {
                        parkinzi.Add(new ParkingPregled(p));
                        //parkinzi.Add(new ParkingPregled(1, "AA", "AA", 3, "AA", "AA"));
                    }

                //MessageBox.Show(lista_parkinga.Count().ToString());
                s.Close();
            }
            catch (Exception )
            {
                //handle exceptions
                throw;
            }
            return parkinzi;
        }

        public static ParkingPregled vratiParking(int id)
        {
            ParkingPregled parkingPregled;

            try
            {
                ISession s = DataLayer.GetSession();

                Parking o = s.Load<Parking>(id);
                parkingPregled = new ParkingPregled(o);

                s.Close();

            }
            catch (Exception)
            {
                //handle exceptions
                throw;
            }
            return parkingPregled;
        }

        public static void dodajParking(ParkingPregled p)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                Parking o = new Parking
                {
                    zona = p.zona,
                    br_mesta = p.br_mesta,
                    adresa = p.adresa,
                    naziv = p.naziv,
                    radno_vreme_od = p.radno_vreme_od,
                    radno_vreme_do = p.radno_vreme_do
                };

                s.SaveOrUpdate(o);
                s.Flush();
                s.Close();
            }
            catch (Exception )
            {
                //handle exceptions
                throw;
            }
        }

        public static void izmeniParking(ParkingPregled p)
        {
            try
            {

                ISession s = DataLayer.GetSession();

                Parking o = s.Load<Parking>(p.ID);
                o.zona = p.zona;
                o.br_mesta = p.br_mesta;
                o.adresa = p.adresa;
                o.naziv = p.naziv;
                o.radno_vreme_od = p.radno_vreme_od;
                o.radno_vreme_do = p.radno_vreme_do;

                s.Update(o);
                s.Flush();
                s.Close();
            }

            catch (Exception )
            {
                //handle exceptions
                throw;
            }
        }


        public static void izbrisiParking(int id)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                Parking o = s.Load<Parking>(id);

                s.Delete(o);
                s.Flush();
                s.Close();
            }

            catch (Exception )
            {
                //handle exceptions
                throw;
            }
        }
        #endregion Parking

        #region JavnaGaraza
        public static List<JavnaGarazaPregled> vratiSveJavneGaraze()
        {
            List<JavnaGarazaPregled> garaze = new List<JavnaGarazaPregled>();
            try
            {
                ISession s = DataLayer.GetSession();
                IEnumerable<Javna_garaza> svegaraze = from o in s.Query<Javna_garaza>() select o;
               
                foreach(Javna_garaza jg in svegaraze.ToList())
                {
                    garaze.Add(new JavnaGarazaPregled(jg.ID, jg.zona.ID, jg.naziv, jg.adresa, jg.br_mesta, jg.radno_vreme_od.ToString(), jg.radno_vreme_do.ToString(), jg.br_nivoa, jg.tip));
                }
               

                //MessageBox.Show(lista_parkinga.Count().ToString());
                s.Close();
            }
            catch (Exception )
            {
                //handle exceptions
                throw;
            }
            return garaze;
        }

        public static void vratiJavnuGarazu(int id)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                if (s.Query<Javna_garaza>().Any(x => x.ID == id))
                {
                    Javna_garaza jg = s.Load<Javna_garaza>(id);
                    
                }
                else


                s.Close();
            }
            catch (Exception )
            {
                //handle exceptions
                throw;
            }
        }

        public static void dodajJavnuGarazu(Javna_garaza jg, int z)
        {
            try
            {
                ISession s = DataLayer.GetSession();
                if (s.Query<Zona>().Any(x => x.ID == z))
                {
                    Zona zona = s.Load<Zona>(z);
                    jg.zona = zona;
                    s.SaveOrUpdate(jg);
                    s.Flush();
                }
                else

                s.Close();
            }
            catch (Exception )
            {
                //handle exceptions
                throw;
            }
        }

        public static void izmeniJavnuGarazu(int id, Javna_garaza jg, int z)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                if (s.Query<Zona>().Any(x => x.ID == z) && s.Query<Javna_garaza>().Any(x => x.ID == id) )
                {
                    Zona zona = s.Load<Zona>(z);
                    Javna_garaza j = s.Load<Javna_garaza>(id);

                    j.zona = zona;
                    j.adresa = jg.adresa;
                    j.br_mesta = jg.br_mesta;
                    j.naziv = jg.naziv;
                    j.radno_vreme_od = jg.radno_vreme_od;
                    j.radno_vreme_do = jg.radno_vreme_do;
                    j.br_nivoa = jg.br_nivoa;
                    j.montazni_objekat = jg.montazni_objekat;
                    j.tip = jg.tip;

                    s.SaveOrUpdate(j);
                    s.Flush();
                }
                else

                s.Close();
            }
            catch (Exception )
            {
                //handle exceptions
                throw;
            }
        }


        public static void izbrisiJavnuGarazu(int id)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                if (s.Query<Javna_garaza>().Any(x => x.ID == id))
                {
                    Javna_garaza j = s.Load<Javna_garaza>(id);
                    s.Delete(j);
                    s.Flush();
                }
                else

                s.Close();
            }

            catch (Exception )
            {
                //handle exceptions
                throw;
            }
        }
        #endregion JavnaGaraza

        #region GaraznoMesto

        public static List<GaraznoMestoPregled> vratiSvaGaraznaMesta(int gmId)
        {
            List<GaraznoMestoPregled> odInfos = new List<GaraznoMestoPregled>();

            try
            {
                ISession s = DataLayer.GetSession();

                IEnumerable<Garazno_mesto> mesta = from g in s.Query<Garazno_mesto>()
                                                   where g.PripadaParkingu.ID == gmId
                                                   select g;

                foreach (Garazno_mesto g in mesta)
                {
                    var gm = new GaraznoMestoPregled(g)
                    {
                        Parking = new ParkingPregled(g.PripadaParkingu)
                    };

                    odInfos.Add(gm);
                }

                s.Close();
            }
            catch (Exception )
            {
                //handle exceptions
                throw;
            }
            return odInfos;
        }

        public static void vratiGaraznoMesto (int id)
        {
            try
            {
                ISession s = DataLayer.GetSession();
                Garazno_mesto gMesto = s.Load<Garazno_mesto>(id);

                s.Delete(gMesto);
                s.Flush();

                s.Close();
            }
            catch (Exception )
            {
                //handle exceptions
                throw;
            }
        }

        public static void dodajGaraznoMesto(Garazno_mesto gm, int park, String z)
        {
            try
            {
                ISession s = DataLayer.GetSession();
                if (s.Query<Parking>().Any(x => x.ID == park))
                {
                    Parking p = s.Load<Parking>(park);
                    gm.zausetost = z;
                    p.garazna_mesta.Add(gm);
                    s.SaveOrUpdate(p);
                    s.Flush();
                }
                else
                
                s.Close();
            }
            catch (Exception )
            {
                //handle exceptions
                throw;
            }
        }

        public static void SacuvajGaraznoMesto(GaraznoMestoPregled gm)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                Garazno_mesto g = new Garazno_mesto
                {
                    nivo = gm.nivo,
                    redni_br = gm.redni_br,
                    id_parkinga = gm.id_parkinga
                };

                s.Save(g);
                s.Flush();
                s.Close();
            }
            catch (Exception)
            {
                //handle exceptions
                throw;
            }
        }

        public static void izmeniGaraznoMesto(GaraznoMestoPregled gm)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                Garazno_mesto g = s.Load<Garazno_mesto>(gm.ID);

                g.nivo = gm.nivo;
                g.redni_br = gm.redni_br;
                g.id_parkinga = gm.id_parkinga;

                s.SaveOrUpdate(g);
                s.Flush();
                s.Close();
            }
            catch (Exception)            
            {
                //handle exceptions
                throw;
            }
        }

        public static void izbrisiGaraznoMesto (int id)
        {
            try
            {
                ISession s = DataLayer.GetSession();
                Garazno_mesto gMesto = s.Load<Garazno_mesto>(id);

                s.Delete(gMesto);
                s.Flush();

                s.Close();
            }
            catch (Exception)           
            {
                //handle exceptions
                throw;
            }
        }

        #endregion GaraznMesto

        #region UlicnoMesto

        public static List<UlicnoMestoPregled> vratiSvaUlicnaMesta()
        {
            List<UlicnoMestoPregled> ulicnamesta = new List<UlicnoMestoPregled>();
            try
            {
                ISession s = DataLayer.GetSession();

                IEnumerable<Ulicno_mesto> svaUlicnaMesta = from o in s.Query<Ulicno_mesto>() select o;

                foreach( Ulicno_mesto u in svaUlicnaMesta.ToList())
                    ulicnamesta.Add(new UlicnoMestoPregled(u));
               
                s.Close();
            }
            catch (Exception )
            {
                //handle exceptions
                throw;
            }
            return ulicnamesta;
        }

        public static void vratiUlicnoMesto(int id)
        {
            try
            {
                ISession s = DataLayer.GetSession();
                if (s.Query<Ulicno_mesto>().Any(x => x.ID == id))
                {
                    Ulicno_mesto um = s.Load<Ulicno_mesto>(id);
                    
                }
                else
                    
               
                s.Close();
            }
            catch (Exception)
            {
                //handle exceptions
                throw;
            }
        }

        public static void dodajUlicnoMesto(UlicnoMestoPregled g)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                Ulicno_mesto a = new Ulicno_mesto
                {
                    zona = g.zona,
                    naziv_ulice = g.naziv_ulice
                };

                s.Save(a);
                s.Flush();
                s.Close();
            }
            catch (Exception )
            {
                //handle exceptions
                throw;
            }
        }

        public static void izmeniUlicnoMesto(UlicnoMestoPregled u)
        {
            try
            {
                ISession s = DataLayer.GetSession();
                Ulicno_mesto g = s.Load<Ulicno_mesto>(u.ID);

                g.zona = u.zona;
                g.naziv_ulice = u.naziv_ulice;

                s.SaveOrUpdate(g);
                s.Flush();
                s.Close();
            }
            catch (Exception )
            {
                //handle exceptions
                throw;
            }
        }

        public static void izbrisiUlicnoMesto(int id)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                Ulicno_mesto uMesto = s.Load<Ulicno_mesto>(id);

                s.Delete(uMesto);
                s.Flush();

                s.Close();
            }
            catch (Exception)
            {
                //handle exceptions
                throw;
            }
        }

        #endregion UlicnoMesto

        #region Vozilo
        public static List<VoziloPregled> vratiSvaVozila()
        {
            List<VoziloPregled> vozila = new List<VoziloPregled>();
            try
            {
                ISession s = DataLayer.GetSession();

                IEnumerable<Vozilo> svavozila = from o in s.Query<Vozilo>() select o;

                foreach (Vozilo v in svavozila)
                {
                    bool existZ = s.Query<Zakup>().Any(x => x.vozilo.ID == v.ID);

                    if (existZ == true)
                    {
                        IEnumerable<Zakup> zakupi = from o in s.Query<Zakup>() where o.vozilo.ID == v.ID select o;
                        List<Zakup> lista_zakupi = zakupi.ToList();

                        bool existFL = s.Query<Fizicko_lice>().Any(x => x.ID == lista_zakupi[0].klijent.ID);
                        if (existFL == true)
                        {
                            Fizicko_lice fl = s.Load<Fizicko_lice>(lista_zakupi[0].klijent.ID);
                            String ime = fl.ime + " (" + fl.ime_roditelja + ") " + fl.prezime;
                            vozila.Add(new VoziloPregled(v));
                        }

                        bool existPL = s.Query<Pravno_lice>().Any(x => x.ID == lista_zakupi[0].klijent.ID);
                        if (existPL == true)
                        {
                            Pravno_lice pl = s.Load<Pravno_lice>(lista_zakupi[0].klijent.ID);
                            String ime = pl.Naziv;
                            vozila.Add(new VoziloPregled(v));
                        }

                    }
                    else
                    {
                        vozila.Add(new VoziloPregled(v));
                    }
                }


                s.Close();
            }
            catch (Exception )
            {
                //handle exceptions
                throw;
            }
            return vozila;

        }

        public static VoziloPregled vratiVozilo(int id)
        {
            VoziloPregled vozilo = new VoziloPregled();
            try
            {
                ISession s = DataLayer.GetSession();
                Vozilo v = s.Load<Vozilo>(id);

                String ime = "NEPOZNATO";

                bool existZ = s.Query<Zakup>().Any(x => x.vozilo.ID == v.ID);

                if (existZ == true)
                {
                    IEnumerable<Zakup> zakupi = from o in s.Query<Zakup>() where o.vozilo.ID==v.ID select o;
                    List<Zakup> lista_zakupi = zakupi.ToList();

                    bool existFL = s.Query<Fizicko_lice>().Any(x => x.ID == lista_zakupi[0].klijent.ID);
                    if (existFL == true)
                    {
                        Fizicko_lice fl = s.Load<Fizicko_lice>(lista_zakupi[0].klijent.ID);
                        ime = "";
                        ime = fl.ime + " (" + fl.ime_roditelja + ") " + fl.prezime;
                    }

                    bool existPL = s.Query<Pravno_lice>().Any(x => x.ID == lista_zakupi[0].klijent.ID);
                    if (existPL == true)
                    {
                        Pravno_lice pl = s.Load<Pravno_lice>(lista_zakupi[0].klijent.ID);
                        ime = "";
                        ime = pl.Naziv;
                    }
                    
                }

                s.Close();
            }
            catch (Exception )
            {
                //handle exceptions
                throw;
            }
            return vozilo;
        }

        public static void dodajVozilo(VoziloPregled v)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                s.SaveOrUpdate(v);

                s.Flush();
                s.Close();
            }
            catch (Exception)            
            {
                //handle exceptions
                throw;
            }
        }

        public static void izmeniVozilo(VoziloPregled vo)
        {
            try
            {
                ISession s = DataLayer.GetSession();
                Vozilo v = s.Load<Vozilo>(vo.ID);
                v.registracija = vo.registracija;
                v.br_saobracajne = vo.br_saobracajne;
                v.proizvodjac = vo.proizvodjac;
                v.model = vo.model;

                s.SaveOrUpdate(v);

                s.Flush();
                s.Close();
            }
            catch (Exception )
            {
                //handle exceptions
                throw;
            }
        }

        public static void izbrisiVozilo(int id)
        {
            try
            {
                ISession s = DataLayer.GetSession();
                Vozilo v = s.Load<Vozilo>(id);

                // Zakup ne mora rucno da se brise jer Cascade.All u Vozilo_MAP to sam radi
                IEnumerable<Zakup> zakupi = from o in s.Query<Zakup>() where o.vozilo.ID == v.ID select o;

                foreach (Zakup z in zakupi)
                {
                    s.Delete(z);
                    s.Flush();
                }

                s.Delete(v);

                s.Flush();
                s.Close();
            }
            catch (Exception )
            {
                //handle exceptions
                throw;
            }
        }
        #endregion Vozilo

        #region Jednokratna
        public static List<JednokratnaPregled> vratiSveJednokratne()
        {
            List<JednokratnaPregled> jednokratne = new List<JednokratnaPregled>();

            try
            {
                ISession s = DataLayer.GetSession();

                IEnumerable<Jednokratna> karte = from o in s.Query<Jednokratna>() select o;
                String ime = "NEPOZNATO";
                String registracija = "NEPOZNATA";

                foreach (Jednokratna j in karte)
                {
                    bool existFL = s.Query<Fizicko_lice>().Any(x => x.ID == j.id_klijenta.ID);
                    if (existFL == true)
                    {
                        Fizicko_lice fl = s.Load<Fizicko_lice>(j.id_klijenta.ID);
                        ime = fl.ime + " (" + fl.ime_roditelja + ") " + fl.prezime;
                    }

                    bool existPL = s.Query<Pravno_lice>().Any(x => x.ID == j.id_klijenta.ID);
                    if (existPL == true)
                    {
                        Pravno_lice pl = s.Load<Pravno_lice>(j.id_klijenta.ID);
                        ime = pl.Naziv;
                    }


                    bool existV = s.Query<Vozilo>().Any(x => x.ID == j.vozilo.ID);
                    if (existPL == true)
                    {
                        Vozilo v = s.Load<Vozilo>(j.vozilo.ID);
                        registracija = v.registracija;
                    }

                    jednokratne.Add(new JednokratnaPregled(j.ID, registracija, ime));
                }

                s.Close();
            }
            catch (Exception )
            {
                //handle exceptions
                throw;
            }

            return jednokratne;
        }

        public static void vratiJednokratnu(int id, String ol)
        {
            try
            {
                ISession s = DataLayer.GetSession();
                Jednokratna j = s.Load<Jednokratna>(id);

               

                s.Close();
            }
            catch (Exception )
            {
                //handle exceptions
                throw;
            }
        }

        public static void dodajJednokratnu(DateTime o, DateTime d, DateTime vk, int id_k, int id_v)
        {
            try
            {
                ISession s = DataLayer.GetSession();
                Klijent k = s.Load<Klijent>(id_k);
                Vozilo v = s.Load<Vozilo>(id_v);

                Jednokratna j = new Jednokratna();
                j.id_klijenta = k;
                j.vozilo = v;
                j.period_parkiranja_od = o;
                j.period_parkiranja_do = d;
                j.vreme_kontrole = vk;

                s.SaveOrUpdate(j);

                s.Flush();
                s.Close();
            }
            catch (Exception )
            {
                //handle exceptions
                throw;
            }
        }

        public static void izmeniJednokratnu(int id, DateTime o, DateTime d, DateTime vk)
        {
            try
            {
                ISession s = DataLayer.GetSession();
                Jednokratna j = s.Load<Jednokratna>(id);
                j.period_parkiranja_od = o;
                j.period_parkiranja_do = d;
                j.vreme_kontrole = vk;

                s.SaveOrUpdate(j);

                s.Flush();
                s.Close();
            }
            catch (Exception )
            {
                //handle exceptions
                throw;
            }
        }

        public static void izbrisiJenokratnu(int id)
        {
            try
            {
                ISession s = DataLayer.GetSession();
                Jednokratna j = s.Load<Jednokratna>(id);

                s.Delete(j);

                s.Flush();
                s.Close();
            }
            catch (Exception )
            {
                //handle exceptions
                throw;
            }
        }
        #endregion Jednokratna

        #region Pretplatna
        public static List<PretplatnaPregled> vratiSvePretplatne()
        {
            List<PretplatnaPregled> pretplatne = new List<PretplatnaPregled>();

            try
            {
                ISession s = DataLayer.GetSession();

                IEnumerable<Pretplatna> karte = from o in s.Query<Pretplatna>() select o;

                foreach (Pretplatna p in karte)
                {
                    String ime = "NEPOZNATO";
                    String registracija = "NEPOZNATA";
                    String zone = "NEPOZNATE";

                    bool existFL = s.Query<Fizicko_lice>().Any(x => x.ID == p.id_klijenta.ID);
                    if (existFL == true)
                    {
                        Fizicko_lice fl = s.Load<Fizicko_lice>(p.id_klijenta.ID);
                        ime = fl.ime + " (" + fl.ime_roditelja + ") " + fl.prezime;
                    }

                    bool existPL = s.Query<Pravno_lice>().Any(x => x.ID == p.id_klijenta.ID);
                    if (existPL == true)
                    {
                        Pravno_lice pl = s.Load<Pravno_lice>(p.id_klijenta.ID);
                        ime = pl.Naziv;
                    }
                    

                    bool existV = s.Query<Odnosi_se_na_P>().Any(x => x.id_pretplatne.ID == p.ID);
                    if (existV == true)
                    {
                        IEnumerable<Odnosi_se_na_P> op = from o in s.Query<Odnosi_se_na_P>() where o.id_pretplatne.ID==p.ID select o;
                        List<Odnosi_se_na_P> lista_op = op.ToList();
                        if (lista_op.Count() == 1)
                        {
                            registracija = lista_op[0].id_vozila.registracija;
                        }
                        else
                        {
                            registracija = "VIŠE VOZILA" ;
                        }
                        
                    }

                    bool existP = s.Query<Zone_pretplatne>().Any(x => x.pretplatna_karta.ID == p.ID);
                    if (existP == true)
                    {
                        IEnumerable<Zone_pretplatne> zp = from o in s.Query<Zone_pretplatne>() where o.pretplatna_karta.ID==p.ID select o;
                        zone = zp.Count().ToString();
                    }

                    pretplatne.Add(new PretplatnaPregled(p.ID, p.period_vazenja_od.ToString(), p.period_vazenja_do.ToString(), zone, registracija, ime));
                }

                s.Close();
            }
            catch (Exception )
            {
                //handle exceptions
                throw;
            }

            return pretplatne;
        }

        public static void vratiPretplatnu(int id, String ol)
        {
            try
            {
                ISession s = DataLayer.GetSession();
                Pretplatna p = s.Load<Pretplatna>(id);
                String registracija = "";
                String zone = "";

                IEnumerable<Odnosi_se_na_P> op = from o in s.Query<Odnosi_se_na_P>() where o.id_pretplatne.ID==p.ID select o;
                foreach(Odnosi_se_na_P o in op)
                {
                    registracija += o.id_vozila.registracija + "\n" + "\t" + "                 ";
                }

                IEnumerable<Zone_pretplatne> zo = from o in s.Query<Zone_pretplatne>() where o.pretplatna_karta.ID == p.ID select o;
                foreach (Zone_pretplatne z in zo)
                {
                    zone += z.zona.ID + "\n" + "\t" ;
                }

                

                s.Close();
            }
            catch (Exception )
            {
                //handle exceptions
                throw;
            }
        }

        public static void dodajPretplatnu(DateTime o, DateTime d, DateTime vk, int id_k, int id_v, int zo)
        {
            try
            {
                ISession s = DataLayer.GetSession();
                Klijent k = s.Load<Klijent>(id_k);
                Vozilo v = s.Load<Vozilo>(id_v);

                Pretplatna p = new Pretplatna();
                p.id_klijenta = k;

                p.period_vazenja_od = o;
                p.period_vazenja_do = d;
                p.datum = vk;

                s.SaveOrUpdate(p);
                s.Flush();

                Odnosi_se_na_P op = new Odnosi_se_na_P();
                op.id_pretplatne = p;
                op.id_vozila = v;
                s.SaveOrUpdate(op);
                s.Flush();

                Zone_pretplatne zp = new Zone_pretplatne();
                zp.zona = s.Load<Zona>(zo);
                zp.pretplatna_karta = p;

                s.SaveOrUpdate(zp);
                s.Flush();

                s.Close();
            }
            catch (Exception)             
            {
                //handle exceptions
                throw;
            }
        }

        public static void izmeniPretplatnu(int id, DateTime o, DateTime d)
        {
            try
            {
                ISession s = DataLayer.GetSession();
                Pretplatna p = s.Load<Pretplatna>(id);
                p.period_vazenja_od = o;
                p.period_vazenja_do = d;
           
                s.SaveOrUpdate(p);

                s.Flush();
                s.Close();
            }
            catch (Exception )
            {
                //handle exceptions
                throw;
            }
        }

        public static void izbrisiPretplatnu(int id)
        {
            try
            {
                ISession s = DataLayer.GetSession();
                Pretplatna p = s.Load<Pretplatna>(id);

                // Odnosi_se_na_P i Zone_pretplatne ne moraju rucno da se brisu jer Cascade.All u Pretplatna_MAP to sam radi 
                IEnumerable<Zone_pretplatne> zo = from o in s.Query<Zone_pretplatne>() where o.pretplatna_karta.ID == p.ID select o;
                foreach(Zone_pretplatne z in zo)
                {
                    s.Delete(z);
                    s.Flush();
                }

                IEnumerable<Odnosi_se_na_P> op = from o in s.Query<Odnosi_se_na_P>() where o.id_pretplatne.ID == p.ID select o;
                foreach (Odnosi_se_na_P o in op)
                {
                    s.Delete(o);
                    s.Flush();
                }

                s.Delete(p);

                s.Flush();
                s.Close();
            }
            catch (Exception )
            {
                //handle exceptions
                throw;
            }
        }
        #endregion Pretplatna

        #region Zakup
        public static List<ZakupPregled> vratiSveZakupe()
        {
            List<ZakupPregled> zakupi = new List<ZakupPregled>();
            try
            {
                ISession s = DataLayer.GetSession();

                IEnumerable<Zakup> svizakupi = from o in s.Query<Zakup>() select o;
                foreach(Zakup z in svizakupi)
                {
                    String ime = "NEPOZNATO";
                    int br = 0;

                    bool existFL = s.Query<Fizicko_lice>().Any(x => x.ID == z.klijent.ID);
                    if (existFL == true)
                    {
                        Fizicko_lice fl = s.Load<Fizicko_lice>(z.klijent.ID);
                        ime = fl.ime + " (" + fl.ime_roditelja + ") " + fl.prezime;
                    }

                    bool existPL = s.Query<Pravno_lice>().Any(x => x.ID == z.klijent.ID);
                    if (existPL == true)
                    {
                        Pravno_lice pl = s.Load<Pravno_lice>(z.klijent.ID);
                        ime = pl.Naziv;
                    }

                    foreach(Zakup za in svizakupi)
                    {
                        if(z.klijent.ID==za.klijent.ID && z.vozilo.registracija == za.vozilo.registracija)
                        {
                            br++;
                        }
                    }

                    zakupi.Add(new ZakupPregled(z.ID, z.vozilo.registracija, ime, br));
                }


                s.Close();
            }
            catch(Exception )
            {
                //handle exceptions
                throw;
            }
            return zakupi;
        }

        public static void vratiZakup(int id, String ol)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                Zakup z = s.Load<Zakup>(id);

                

                s.Close();
            }
            catch (Exception)           
            {
                //handle exceptions
                throw;
            }
        }

        public static void dodajZakup(Zakup z, int k, int v, int pm)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                Klijent kl = s.Load<Klijent>(k);
                Vozilo vo = s.Load<Vozilo>(v);
                Parking_mesto pme = s.Load<Parking_mesto>(pm);

                z.klijent = kl;
                z.vozilo = vo;
                z.parking_mesto = pme;

                s.SaveOrUpdate(z);
                s.Flush();

                s.Close();
            }
            catch (Exception )
            {
                //handle exceptions
                throw;
            }
        }

        public static void izmeniZakup(int id, DateTime o, DateTime d)
        {
            try
            {
                ISession s = DataLayer.GetSession();
                Zakup z = s.Load<Zakup>(id);
                z.zakup_od = o;
                z.zakup_do = d;

                s.SaveOrUpdate(z);
                s.Flush();

                s.Close();
            }
            catch (Exception) 
            {
                //handle exceptions
                throw;
            }
        }

        public static void izbrisiZakup(int id)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                Zakup z = s.Load<Zakup>(id);
                s.Delete(z);
                s.Flush();

                s.Close();
            }
            catch (Exception )
            {
                //handle exceptions
                throw;
            }
        }
        #endregion Zakup
    }
}
        
    


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NHibernate;
using NHibernate.Linq;
using ParkingServis.Entiteti;
using ParkingServis.Forms.Save_forms;
using System.Windows.Forms;

namespace ParkingServis
{
    class DTOManager
    {
        #region FizickoLice
        public static List<FizickoLicePregled> vratiSvaFizickaLica()
        {
            List<FizickoLicePregled> fizickalica = new List<FizickoLicePregled>();
            try
            {
                ISession s = DataLayer.GetSession();
                IEnumerable<Fizicko_lice> svaFizickaLica = from o in s.Query<Fizicko_lice>() select o;

                foreach (Fizicko_lice m in svaFizickaLica)
                {
                    IEnumerable<Telefon> br_telefona = from o in s.Query<Telefon>()
                                                       where o.id_klijenta.ID == m.ID
                                                       select o;

                    if (br_telefona.Count() == 1)
                    {
                        fizickalica.Add(new FizickoLicePregled(m.ID, m.licno_ime, m.prezime, m.adresa, m.prebivaliste, br_telefona.Single().broj.ToString()));
                    }
                    else if (br_telefona.Count() == 0)
                    {
                        fizickalica.Add(new FizickoLicePregled(m.ID, m.licno_ime, m.prezime, m.adresa, m.prebivaliste, "NEMA BROJA"));
                    }
                    else
                    {
                        fizickalica.Add(new FizickoLicePregled(m.ID, m.licno_ime, m.prezime, m.adresa, m.prebivaliste, "VIŠE BROJEVA"));
                    }


                }
                s.Close();
            }
            catch (Exception ec)
            {
                System.Windows.Forms.MessageBox.Show(ec.Message);
            }
            return fizickalica;
        }

        public static void vratiFizickoLice(int id)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                Fizicko_lice f = s.Load<Fizicko_lice>(id);
                IEnumerable<Telefon> br_telefona = from o in s.Query<Telefon>()
                                                   where o.id_klijenta.ID == f.ID
                                                   select o;
                String brtel = "";
                foreach (Telefon br in br_telefona)
                {
                    brtel += br.broj;
                    brtel += "\n" + "\t" + "        ";

                }

                MessageBox.Show("ID: " + f.ID + "\n" + "Ime: " + f.licno_ime + " (" + f.ime_roditelja + ") " + f.prezime + "\n" + "JMBG: " + f.JMBG + "\n" + "LK: " + f.LK + "\n" + "Mesto izdavanja LK: " + f.mesto_izdavanja_lk + "\n" + "Broj vozačke: " + f.broj_vozacke + "\n" + "Adresa: " + f.adresa + "\n" + "Prebivalište: " + f.prebivaliste + "\n" + "Broj telefona: " + brtel);

                s.Close();
            }
            catch (Exception ec)
            {
                System.Windows.Forms.MessageBox.Show(ec.Message);
            }
            return;
        }

        public static void dodajFizickoLice(Fizicko_lice fl, String tel)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                s.SaveOrUpdate(fl);
                s.Flush();

                Telefon t = new Telefon();
                t.broj = tel;
                t.id_klijenta = s.Load<Klijent>(fl.ID);

                s.SaveOrUpdate(t);
                s.Flush();

                //fl.telefoni.Add(t);

                s.Close();
            }
            catch (Exception ec)
            {
                MessageBox.Show(ec.Message);
            }
        }

        public static void izmeniFizickoLice(int id, Fizicko_lice f)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                Fizicko_lice fl = s.Load<Fizicko_lice>(id);
                fl.JMBG = f.JMBG;
                fl.LK = f.LK;
                fl.mesto_izdavanja_lk = f.mesto_izdavanja_lk;
                fl.licno_ime = f.licno_ime;
                fl.ime_roditelja = f.ime_roditelja;
                fl.prezime = f.prezime;
                fl.adresa = f.adresa;
                fl.prebivaliste = f.prebivaliste;
                fl.broj_vozacke = f.broj_vozacke;

                s.SaveOrUpdate(fl);
                s.Flush();
                s.Close();
            }
            catch (Exception ec)
            {
                System.Windows.Forms.MessageBox.Show(ec.Message);
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
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message);
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

                foreach (Pravno_lice m in svaPravnaLica)
                {

                    pravnalica.Add(new PravnoLicePregled(m.ID, m.Naziv, m.Adresa));
                }
                s.Close();
            }
            catch (Exception ec)
            {
                System.Windows.Forms.MessageBox.Show(ec.Message);
            }
            return pravnalica;
        }

        public static void vratiPravnoLice(int id)
        {
            List<PravnoLicePregled> pravnalica = new List<PravnoLicePregled>();
            try
            {
                ISession s = DataLayer.GetSession();

                Pravno_lice pl = s.Load<Pravno_lice>(id);
                MessageBox.Show("ID:" + pl.ID + "\n" +
                                "PIB:" + pl.PIB + "\n" +
                                "Naziv:" + pl.Naziv + "\n" +
                                "Adresa:" + pl.Adresa + "\n" +
                                "Ovlašćeno lice:" + pl.Ovlasceno_lice + "\n");

                s.Close();
            }
            catch (Exception ec)
            {
                System.Windows.Forms.MessageBox.Show(ec.Message);
            }
        }

        public static void dodajPravnoLice(Pravno_lice pl, String tel)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                s.SaveOrUpdate(pl);
                s.Flush();

                Telefon t = new Telefon();
                t.broj = tel;
                t.id_klijenta = s.Load<Klijent>(pl.ID);

                s.SaveOrUpdate(t);
                s.Flush();

                s.Close();

            }
            catch (Exception ec)
            {
                MessageBox.Show(ec.Message);
            }
        }

        public static void izmeniPravnoLice(int id, Pravno_lice p)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                Pravno_lice pl = s.Load<Pravno_lice>(id);
                pl.PIB = p.PIB;
                pl.Naziv = p.Naziv;
                pl.Adresa = p.Adresa;
                pl.Ovlasceno_lice = p.Ovlasceno_lice;

                s.SaveOrUpdate(pl);
                s.Flush();

                s.Close();

            }
            catch (Exception ec)
            {
                MessageBox.Show(ec.Message);
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
            catch (Exception ec)
            {
                MessageBox.Show(ec.Message);
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
                        String ime = fl.First().licno_ime + " (" + fl.First().ime_roditelja + ") " + fl.First().prezime;
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
            catch (Exception ec)
            {
                System.Windows.Forms.MessageBox.Show(ec.Message);
            }
            return telefoni;

        }

        public static void vratiTelefon(int id, String ime)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                Telefon t = s.Load<Telefon>(id);

                MessageBox.Show("ID: " + t.ID + "\n" +
                    "ID klijenta: " + t.id_klijenta.ID + "\n" +
                    "Klijent: " + ime + "\n" +
                    "ID: " + t.broj + "\n");

                s.Close();
            }
            catch (Exception ec)
            {
                System.Windows.Forms.MessageBox.Show(ec.Message);
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
            catch (Exception ec)
            {
                System.Windows.Forms.MessageBox.Show(ec.Message);
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
            catch (Exception ec)
            {
                System.Windows.Forms.MessageBox.Show(ec.Message);
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
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message);
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
                    String ime = m.licno_ime + " (" + m.ime_roditelja + ") " + m.prezime;
                    klijenti.Add(new KlijentPregled(m.ID, ime));
                }

                IEnumerable<Pravno_lice> svaPravnaLica = from o in s.Query<Pravno_lice>() select o;

                foreach (Pravno_lice m in svaPravnaLica)
                {
                    klijenti.Add(new KlijentPregled(m.ID, m.Naziv));
                }

                s.Close();
            }
            catch (Exception ec)
            {
                System.Windows.Forms.MessageBox.Show(ec.Message);
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
            catch (Exception ec)
            {
                System.Windows.Forms.MessageBox.Show(ec.Message);
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

                MessageBox.Show("ID: " + z.ID + "\n" + str);

                s.Close();
            }
            catch (Exception ec)
            {
                System.Windows.Forms.MessageBox.Show(ec.Message);
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
            catch (Exception ec)
            {
                System.Windows.Forms.MessageBox.Show(ec.Message);
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
                MessageBox.Show(z.ID.ToString());

                s.SaveOrUpdate(z);
                s.Flush();
                s.Close();
            }
            catch (Exception ec)
            {
                System.Windows.Forms.MessageBox.Show(ec.Message);
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
            catch (Exception ec)
            {
                System.Windows.Forms.MessageBox.Show(ec.Message);
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

                IEnumerable<Javna_garaza> br_jgaraza = from o in s.Query<Javna_garaza>()
                                                           //where o.zona.ID==z.ID
                                                       select o;

                List<Parking> lista_parkinga = sviparkinzi.ToList();

                lista_parkinga.RemoveRange(0, br_jgaraza.Count());

                foreach (Parking p in lista_parkinga)
                {
                    parkinzi.Add(new ParkingPregled(p.ID, p.zona.ID, p.naziv, p.adresa, p.br_mesta, p.radno_vreme_od.ToString(), p.radno_vreme_do.ToString()));
                    //parkinzi.Add(new ParkingPregled(1, "AA", "AA", 3, "AA", "AA"));
                }

                //MessageBox.Show(lista_parkinga.Count().ToString());
                s.Close();
            }
            catch (Exception ec)
            {
                System.Windows.Forms.MessageBox.Show(ec.Message);
            }
            return parkinzi;
        }

        public static void vratiParking(int id)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                Parking p = s.Load<Parking>(id);

                MessageBox.Show("ID: " + p.ID + "\n" +
                    "Zona: " + p.zona.ID + "\n" +
                    "Naziv: " + p.naziv + "\n" +
                    "Adresa: " + p.adresa + "\n" +
                    "Broj mesta: " + p.br_mesta + "\n" +
                    "Radi od: " + p.radno_vreme_od + "\n" +
                    "Radi do: " + p.radno_vreme_do + "\n");

                s.Close();
            }
            catch (Exception ec)
            {
                System.Windows.Forms.MessageBox.Show(ec.Message);
            }
        }

        public static void dodajParking(Parking p, int z)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                Zona zona = s.Load<Zona>(z);
                p.zona = zona;

                s.SaveOrUpdate(p);
                s.Flush();

                s.Close();
            }
            catch (Exception ec)
            {
                System.Windows.Forms.MessageBox.Show(ec.Message);
            }
        }

        public static void izmeniParking(int id, Parking pa, int z)
        {
            try
            {

                ISession s = DataLayer.GetSession();

                Parking p = s.Load<Parking>(id);

                Zona zona = s.Load<Zona>(z);
                p.zona = zona;
                p.naziv = pa.naziv;
                p.adresa = pa.adresa;
                p.br_mesta = pa.br_mesta;
                p.radno_vreme_od = pa.radno_vreme_od;
                p.radno_vreme_do = pa.radno_vreme_do;

                s.SaveOrUpdate(p);
                s.Flush();

                s.Close();
            }

            catch (Exception ec)
            {
                System.Windows.Forms.MessageBox.Show(ec.Message);
            }
        }


        public static void izbrisiParking(int id)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                Parking p = s.Load<Parking>(id);

                bool exist = s.Query<Javna_garaza>().Any(x => x.ID == p.ID);

                if (exist==true)
                {
                    Javna_garaza j = s.Load<Javna_garaza>(id);
                    s.Delete(j);
                    s.Flush();
                }
                

                s.Delete(p);
                s.Flush();

                s.Close();
            }

            catch (Exception ec)
            {
                System.Windows.Forms.MessageBox.Show(ec.Message);
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

                List<ParkingPregled> parkinzi = new List<ParkingPregled>();

                IEnumerable<Parking> sviparkinzi = from o in s.Query<Parking>() select o;

                IEnumerable<Javna_garaza> br_jgaraza = from o in s.Query<Javna_garaza>()
                                                               //where o.zona.ID==z.ID
                                                           select o;

                List<Parking> lista_parkinga = sviparkinzi.ToList();

                lista_parkinga.RemoveRange(0, br_jgaraza.Count());

                List<Javna_garaza> lista_jgaraza = new List<Javna_garaza>();


                for (int i = 0; i < lista_parkinga.Count(); i++)
                {
                    foreach(Javna_garaza jg in br_jgaraza)
                    {
                        if (jg.ID==lista_parkinga[i].ID)
                        {
                            garaze.Add(new JavnaGarazaPregled(lista_parkinga[i].ID, lista_parkinga[i].zona.ID, lista_parkinga[i].naziv, lista_parkinga[i].adresa, lista_parkinga[i].br_mesta, lista_parkinga[i].radno_vreme_od.ToString(), lista_parkinga[i].radno_vreme_do.ToString(), jg.br_nivoa, jg.tip));
                        }    
                    }
                }

                //MessageBox.Show(lista_parkinga.Count().ToString());
                s.Close();
            }
            catch (Exception ec)
            {
                System.Windows.Forms.MessageBox.Show(ec.Message);
            }
            return garaze;
        }

        public static void vratiJavnuGarazu(int id)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                Parking p = s.Load<Parking>(id);
                Javna_garaza jg = s.Load<Javna_garaza>(id);

                MessageBox.Show("ID: " + p.ID + "\n" +
                                "Zona: " + p.zona.ID + "\n" +
                                "Naziv: " + p.naziv + "\n" +
                                "Adresa:" + p.adresa + "\n" +
                                "Broj mesta: " + p.br_mesta + "\n" +
                                "Radio od: " + p.radno_vreme_od + "\n" +
                                "Radi do: " + p.radno_vreme_do + "\n" +
                                "Broj nivoa: " + jg.br_nivoa + "\n" +
                                "Montažni objekat: " + jg.montazni_objekat + "\n" +
                                "Tip: " + jg.tip + "\n" );

                s.Close();
            }
            catch (Exception ec)
            {
                System.Windows.Forms.MessageBox.Show(ec.Message);
            }
        }

        public static void dodajJavnuGarazu(Javna_garaza jg, int z)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                Zona zona = s.Load<Zona>(z);
                jg.zona = zona;

                Parking p = new Parking(zona, jg.br_mesta, jg.adresa, jg.naziv, jg.radno_vreme_od, jg.radno_vreme_do);

                s.SaveOrUpdate(p);
                s.Flush();

                jg.ID = p.ID;

                s.SaveOrUpdate(jg);
                s.Flush();

                s.Close();
            }
            catch (Exception ec)
            {
                System.Windows.Forms.MessageBox.Show(ec.Message);
            }
        }

        public static void izmeniJavnuGarazu(int id, Javna_garaza jg, int z)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                Zona zona = s.Load<Zona>(z);

                Parking p = s.Load<Parking>(id);
                p.zona = zona;
                p.adresa = jg.adresa;
                p.br_mesta = jg.br_mesta;
                p.naziv = jg.naziv;
                p.radno_vreme_od = jg.radno_vreme_od;
                p.radno_vreme_do = jg.radno_vreme_do;

                s.SaveOrUpdate(p);
                s.Flush();

                Javna_garaza j = s.Load<Javna_garaza>(id);
                j.br_nivoa = jg.br_nivoa;
                j.montazni_objekat = jg.montazni_objekat;
                j.tip = jg.tip;

                s.SaveOrUpdate(j);
                s.Flush();

                s.Close();
            }
            catch (Exception ec)
            {
                System.Windows.Forms.MessageBox.Show(ec.Message);
            }
        }


        public static void izbrisiJavnuGarazu(int id)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                Javna_garaza j = s.Load<Javna_garaza>(id);
                s.Delete(j);
                s.Flush();

                Parking p = s.Load<Parking>(id);
                s.Delete(p);
                s.Flush();

                s.Close();
            }

            catch (Exception ec)
            {
                System.Windows.Forms.MessageBox.Show(ec.Message);
            }
        }
        #endregion JavnaGaraza

        #region GaraznoMesto

        public static List<GaraznoMestoPregled> vratiSvaGaraznaMesta()
        {
            List<GaraznoMestoPregled> garaznamesta = new List<GaraznoMestoPregled>();
            try
            {
                ISession s = DataLayer.GetSession();
                IEnumerable<Garazno_mesto> svaGaraznaMesta = from o in s.Query<Garazno_mesto>() select o;

                foreach (Garazno_mesto g in svaGaraznaMesta)
                {
                    Parking_mesto pm = s.Load<Parking_mesto>(g.ID);

                    garaznamesta.Add(new GaraznoMestoPregled(g.ID, pm.zausetost, g.nivo, g.redni_br, g.id_parkinga.naziv, g.id_parkinga.adresa));
                }
                s.Close();
            }
            catch (Exception ec)
            {
                System.Windows.Forms.MessageBox.Show(ec.Message);
            }
            return garaznamesta;
        }

        public static void vratiGaraznoMesto (int id)
        {
            try
            {
                ISession s = DataLayer.GetSession();
                Garazno_mesto gm = s.Load<Garazno_mesto>(id);

                MessageBox.Show("ID: " + gm.ID + "\n" +
                                "Nivo: " + gm.nivo + "\n" +
                                "Redni broj: " + gm.redni_br + "\n");
                s.Close();
            }
            catch (Exception ec)
            {
                System.Windows.Forms.MessageBox.Show(ec.Message);
            }
        }

        public static void dodajGaraznoMesto(Garazno_mesto gm, int park, String z)
        {
            try
            {
                ISession s = DataLayer.GetSession();
                Parking p = s.Load<Parking>(park);

                Parking_mesto pm = new Parking_mesto(z);

                s.SaveOrUpdate(pm);
                s.Flush();

                gm.ID = pm.ID;
                gm.id_parkinga = p;
                s.SaveOrUpdate(gm);
                s.Flush();

                s.Close();
            }
            catch (Exception ec)
            {
                MessageBox.Show(ec.Message);
            }
        }

        public static void izmeniGaraznoMesto (int id, String z, int park, Garazno_mesto g)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                Parking_mesto pm = s.Load<Parking_mesto>(id);
                pm.zausetost = z;
                s.SaveOrUpdate(pm);
                s.Flush();

                Garazno_mesto gm = s.Load<Garazno_mesto>(id);
                gm.nivo = g.nivo;
                gm.redni_br = g.redni_br;
                Parking p = s.Load<Parking>(park);
                gm.id_parkinga = p;

                s.SaveOrUpdate(gm);
                s.Flush();

                s.Close();
            }
            catch (Exception ec)
            {
                MessageBox.Show(ec.Message);
            }
        }

        public static void izbrisiGaraznoMesto (int id)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                Garazno_mesto gm = s.Load<Garazno_mesto>(id);
                s.Delete(gm);
                s.Flush();

                Parking_mesto pm = s.Load<Parking_mesto>(id);
                s.Delete(pm);
                s.Flush();

                s.Close();
            }
            catch (Exception ec)
            {
                MessageBox.Show(ec.Message);
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

                foreach (Ulicno_mesto u in svaUlicnaMesta)
                {
                    Parking_mesto pm = s.Load<Parking_mesto>(u.ID);

                    ulicnamesta.Add(new UlicnoMestoPregled(u.ID, pm.zausetost, u.zona.ID, u.naziv_ulice));
                }
                s.Close();
            }
            catch (Exception ec)
            {
                System.Windows.Forms.MessageBox.Show(ec.Message);
            }
            return ulicnamesta;
        }

        public static void vratiUlicnoMesto(int id)
        {
            try
            {
                ISession s = DataLayer.GetSession();
                Ulicno_mesto gm = s.Load<Ulicno_mesto>(id);

                MessageBox.Show("ID: " + gm.ID + "\n" +
                                "Zona: " + gm.zona.ID + "\n" +
                                "Ulica: " + gm.naziv_ulice + "\n");
                s.Close();
            }
            catch (Exception ec)
            {
                System.Windows.Forms.MessageBox.Show(ec.Message);
            }
        }

        public static void dodajUlicnoMesto(Ulicno_mesto u, String zau, int zo)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                Parking_mesto pm = new Parking_mesto(zau);

                Zona zona = s.Load<Zona>(zo);

                s.SaveOrUpdate(pm);
                s.Flush();

                u.ID = pm.ID;
                u.zona = zona;
                s.SaveOrUpdate(u);
                s.Flush();

                s.Close();
            }
            catch (Exception ec)
            {
                MessageBox.Show(ec.Message);
            }
        }

        public static void izmeniUlicnoMesto(int id, int zo, String zau, String ulica)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                Ulicno_mesto um = s.Load<Ulicno_mesto>(id);
                Parking_mesto pm = s.Load<Parking_mesto>(id);
                pm.zausetost = zau;
                s.SaveOrUpdate(pm);
                s.Flush();

                Zona zona = s.Load<Zona>(zo);
                um.zona = zona;
                um.naziv_ulice = ulica;

                s.SaveOrUpdate(um);
                s.Flush();

                s.Close();
            }
            catch (Exception ec)
            {
                MessageBox.Show(ec.Message);
            }
        }

        public static void izbrisiUlicnoMesto(int id)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                Ulicno_mesto um = s.Load<Ulicno_mesto>(id);
                s.Delete(um);
                s.Flush();

                Parking_mesto pm = s.Load<Parking_mesto>(id);
                s.Delete(pm);
                s.Flush();

                s.Close();
            }
            catch (Exception ec)
            {
                MessageBox.Show(ec.Message);
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
}
        
    


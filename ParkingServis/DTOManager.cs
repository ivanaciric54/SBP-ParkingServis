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
                            String ime = fl.licno_ime + " (" + fl.ime_roditelja + ") " + fl.prezime;
                            vozila.Add(new VoziloPregled(v.ID, v.registracija, ime, zakupi.Count()));
                        }

                        bool existPL = s.Query<Pravno_lice>().Any(x => x.ID == lista_zakupi[0].klijent.ID);
                        if (existPL == true)
                        {
                            Pravno_lice pl = s.Load<Pravno_lice>(lista_zakupi[0].klijent.ID);
                            String ime = pl.Naziv;
                            vozila.Add(new VoziloPregled(v.ID, v.registracija, ime, zakupi.Count()));
                        }

                    }
                    else
                    {
                        vozila.Add(new VoziloPregled(v.ID, v.registracija, "NEPOZNATO", 0));
                    }
                }


                s.Close();
            }
            catch (Exception ec)
            {
                MessageBox.Show(ec.Message);
            }
            return vozila;

        }

        public static void vratiVozilo(int id)
        {
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
                        ime = fl.licno_ime + " (" + fl.ime_roditelja + ") " + fl.prezime;
                    }

                    bool existPL = s.Query<Pravno_lice>().Any(x => x.ID == lista_zakupi[0].klijent.ID);
                    if (existPL == true)
                    {
                        Pravno_lice pl = s.Load<Pravno_lice>(lista_zakupi[0].klijent.ID);
                        ime = "";
                        ime = pl.Naziv;
                    }
                    
                }

                MessageBox.Show("ID: " + v.ID + "\n" +
                                "Registracija: " + v.registracija + "\n" +
                                "Proizvođač: " + v.proizvodjac + "\n" +
                                "Model: " + v.model + "\n" +
                                "Broj saobraćajne: " + v.br_saobracajne + "\n" +
                                "Odgovorni za vozilo: " + ime + "\n" );

                s.Close();
            }
            catch (Exception ec)
            {
                MessageBox.Show(ec.Message);
            }
        }

        public static void dodajVozilo(Vozilo v)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                s.SaveOrUpdate(v);

                s.Flush();
                s.Close();
            }
            catch (Exception ec)
            {
                MessageBox.Show(ec.Message);
            }
        }

        public static void izmeniVozilo(int id, Vozilo vo)
        {
            try
            {
                ISession s = DataLayer.GetSession();
                Vozilo v = s.Load<Vozilo>(id);
                v.registracija = vo.registracija;
                v.br_saobracajne = vo.br_saobracajne;
                v.proizvodjac = vo.proizvodjac;
                v.model = vo.model;

                s.SaveOrUpdate(v);

                s.Flush();
                s.Close();
            }
            catch (Exception ec)
            {
                MessageBox.Show(ec.Message);
            }
        }

        public static void izbrisiVozilo(int id)
        {
            try
            {
                ISession s = DataLayer.GetSession();
                Vozilo v = s.Load<Vozilo>(id);

                IEnumerable<Zakup> zakupi = from o in s.Query<Zakup>() where o.vozilo.ID == v.ID select o;

                foreach(Zakup z in zakupi)
                {
                    s.Delete(z);
                    s.Flush();
                }

                s.Delete(v);

                s.Flush();
                s.Close();
            }
            catch (Exception ec)
            {
                MessageBox.Show(ec.Message);
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
                        ime = fl.licno_ime + " (" + fl.ime_roditelja + ") " + fl.prezime;
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
            catch (Exception ec)
            {
                System.Windows.Forms.MessageBox.Show(ec.Message);
            }

            return jednokratne;
        }

        public static void vratiJednokratnu(int id, String ol)
        {
            try
            {
                ISession s = DataLayer.GetSession();
                Jednokratna j = s.Load<Jednokratna>(id);

                MessageBox.Show("ID: " + j.ID + "\n" +
                                "Parkirano od: " + j.period_parkiranja_od + "\n" +
                                "Parkirano do: " + j.period_parkiranja_do + "\n" +
                                "Vreme kontrole: " + j.vreme_kontrole + "\n" +
                                "Registracija vozila: " + j.vozilo.registracija + "\n" +
                                "Vozilo: " + j.vozilo.proizvodjac + ", " + j.vozilo.model + "\n" +
                                "Ovlašćeno lice: " + ol + "\n");

                s.Close();
            }
            catch (Exception ec)
            {
                MessageBox.Show(ec.Message);
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
            catch (Exception ec)
            {
                MessageBox.Show(ec.Message);
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
            catch (Exception ec)
            {
                MessageBox.Show(ec.Message);
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
            catch (Exception ec)
            {
                MessageBox.Show(ec.Message);
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
                        ime = fl.licno_ime + " (" + fl.ime_roditelja + ") " + fl.prezime;
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
            catch (Exception ec)
            {
                System.Windows.Forms.MessageBox.Show(ec.Message);
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

                MessageBox.Show("ID: " + p.ID + "\n" +
                                "Važi od: " + p.period_vazenja_od + "\n" +
                                "Važi do: " + p.period_vazenja_do + "\n" +
                                "Datum ugovora: " + p.datum + "\n" +
                                "Registracija vozila: " + registracija + "\n" +
                                "Zone: " + zone + "\n" +
                                "Ovlašćeno lice: " + ol + "\n");

                s.Close();
            }
            catch (Exception ec)
            {
                MessageBox.Show(ec.Message);
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
            catch (Exception ec)
            {
                MessageBox.Show(ec.Message);
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
            catch (Exception ec)
            {
                MessageBox.Show(ec.Message);
            }
        }

        public static void izbrisiPretplatnu(int id)
        {
            try
            {
                ISession s = DataLayer.GetSession();
                Pretplatna p = s.Load<Pretplatna>(id);

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
            catch (Exception ec)
            {
                MessageBox.Show(ec.Message);
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



                s.Close();
            }
            catch(Exception ec)
            {
                MessageBox.Show(ec.Message);
            }
            return zakupi;
        }

        public static void vratiZakup(int id, String ol)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                Zakup z = s.Load<Zakup>(id);

                MessageBox.Show("ID: " + z.ID + "\n" +
                "Zakupljeno od: " + z.zakup_od + "\n" +
                "Zakupljeno do: " + z.zakup_do + "\n" +
                "Datum ugovora: " + z.datum_ugovora + "\n" +
                "Registracija vozila: " + z.vozilo.registracija + "\n" +
                "Broj mesta:" + z.parking_mesto.ID + "\n" +
                "Ovlašćeno lice: " + ol + "\n");

                s.Close();
            }
            catch (Exception ec)
            {
                MessageBox.Show(ec.Message);
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
            catch (Exception ec)
            {
                MessageBox.Show(ec.Message);
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
            catch (Exception ec)
            {
                MessageBox.Show(ec.Message);
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
            catch (Exception ec)
            {
                MessageBox.Show(ec.Message);
            }
        }
        #endregion Zakup
    }
}
        
    


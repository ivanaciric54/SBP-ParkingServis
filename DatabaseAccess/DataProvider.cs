using NHibernate;
using ParkingLibrary.DTOs;
using DatabaseAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using DatabaseAccess.Entiteti;
using DatabaseAccess.DTOs;
using DatabaseAccess.Entiteti;

namespace ParkingLibrary.DTOs

{
    public class DataProvider
    {

        #region Parking
        public static List<ParkingView> VratiSveParkinge()
        {
            List<ParkingView> parkinzi = new List<ParkingView>();

            try
            {
                ISession s = DataLayer.GetSession();

                IEnumerable<Parking> sviParkinzi = from o in s.Query<Parking>()
                                                        select o;

                foreach (Parking p in sviParkinzi)
                {
                    parkinzi.Add(new ParkingView(p));

                }

                s.Close();
            }
            catch (Exception)
            {
                //handle exceptions
                throw;
            }

            return parkinzi;
        }

        public static void DodajParking(ParkingView p)
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
            catch (Exception)
            {
                //handle exceptions
                throw;
            }
        }

        public static ParkingView AzurirajParking(ParkingView p)
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
            catch (Exception)
            {
                //handle exceptions
                throw;
            }

            return p;
        }

        public static ParkingView VratiParking(int id)
        {
            ParkingView prodavnicaView;

            try
            {
                ISession s = DataLayer.GetSession();

                Parking o = s.Load<Parking>(id);
                prodavnicaView = new ParkingView(o);

                s.Close();
            }
            catch (Exception)
            {
                //handle exceptions
                throw;
            }

            return prodavnicaView;
        }

        public static void ObrisiParking(int id)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                Parking o = s.Load<Parking>(id);

                s.Delete(o);
                s.Flush();
                s.Close();
            }
            catch (Exception)
            {
                //handle exceptions
                throw;
            }
        }
        #endregion


        #region GaraznoMesto

        public static void ObrisiGaraznoMesto(int id)
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
        
        public static Garazno_mestoView VratiGaraznoMesto(int id)
        {
            Garazno_mestoView g = new Garazno_mestoView();

            try
            {
                ISession s = DataLayer.GetSession();

                Garazno_mesto gMesto = s.Load<Garazno_mesto>(id);

                g.nivo = gMesto.nivo;
                g.redni_br = gMesto.redni_br;
                g.id_parkinga = gMesto.id_parkinga;

                s.Close();

            }
            catch (Exception)
            {
                //handle exceptions
                throw;
            }

            return g;
        }

        public static List<Garazno_mestoView> GetOdInfos(int gmId)
        {
            List<Garazno_mestoView> odInfos = new List<Garazno_mestoView>();

            try
            {
                ISession s = DataLayer.GetSession();

                IEnumerable<Garazno_mesto> odeljenja = from g in s.Query<Garazno_mesto>()
                                                   where g.PripadaParkingu.ID == gmId
                                                   select g;

                foreach (Garazno_mesto g in odeljenja)
                {
                    odInfos.Add(new Garazno_mestoView(g));
                }

                s.Close();

            }
            catch (Exception)
            {
                //handle exceptions
                throw;
            }

            return odInfos;
        }


        public static List<Garazno_mestoView> VratiGaraznaMestaParkinga(int gmId)
        {
            List<Garazno_mestoView> odInfos = new List<Garazno_mestoView>();

            try
            {
                ISession s = DataLayer.GetSession();

                IEnumerable<Garazno_mesto> mesta = from g in s.Query<Garazno_mesto>()
                                                      where g.PripadaParkingu.ID == gmId
                                                      select g;

                foreach (Garazno_mesto g in mesta)
                {
                    var gm = new Garazno_mestoView(g)
                    {
                        Parking = new ParkingView(g.PripadaParkingu)
                    };

                    odInfos.Add(gm);
                }

                s.Close();

            }
            catch (Exception)
            {
                //handle exceptions
                throw;
            }

            return odInfos;
        }


        public static void IzmeniGaraznoMesto(Garazno_mestoView gm)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                Garazno_mesto g = s.Load<Garazno_mesto>(gm.gmID);

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

        public static void SacuvajGaraznoMestoParkinga(Garazno_mestoView gm)
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

        public static void PoveziGaraznoMestoIParking(int gmID, int parkingID)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                Garazno_mesto gm = s.Load<Garazno_mesto>(gmID);
                Parking parking = s.Load<Parking>(parkingID);

                gm.PripadaParkingu = parking;

                s.Update(gm);
                s.Flush();
                s.Close();
            }
            catch (Exception)
            {
                //handle exceptions
                throw;
            }
        }

        public static void SacuvajGaraznoMesto(Garazno_mestoView gm)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                Garazno_mesto g = new Garazno_mesto();
                Parking p = s.Load<Parking>(gm.Parking.ID);

                g.nivo = gm.nivo;
                g.redni_br = gm.redni_br;
                g.id_parkinga = gm.id_parkinga;
                g.PripadaParkingu = p;

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

        #endregion
    }
}

using NHibernate;
using ParkingLibrary.DTOs;
using DatabaseAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using ParkingServis.Entiteti;

namespace ParkingLibrary

{
    public class DataProvider
    {
        public static List<ParkingView> VratiSveParkinge()
        {
            List<ParkingView> prodavnice = new List<ParkingView>();

            try
            {
                ISession s = DataLayer.GetSession();

                IEnumerable<Parking> sviParkinzi = from o in s.Query<Parking>()
                                                        select o;

                foreach (Parking p in sviParkinzi)
                {
                    prodavnice.Add(new ParkingView(p));
                }

                s.Close();
            }
            catch (Exception)
            {
                //handle exceptions
                throw;
            }

            return prodavnice;
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
    }
}

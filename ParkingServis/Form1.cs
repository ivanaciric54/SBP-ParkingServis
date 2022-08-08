using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using NHibernate;
using ParkingServis.Entiteti;
using ParkingServis.Forms.Load_forms;
using ParkingServis.Forms.Save_forms;
using ParkingServis.Forms.Change_forms;
using ParkingServis.Forms.Delete_forms;
using ParkingServis.Forms.Entity_forms;

namespace ParkingServis
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void cmdUcitavanjeVozila_Click(object sender, EventArgs e)
        {
            try
            {
                ISession s = DataLayer.GetSession();
                Vozilo v = s.Load<Vozilo>(10);
                MessageBox.Show(v.proizvodjac);
                s.Close();
            }
            catch(Exception exc)
            {
                MessageBox.Show(exc.Message);
            }
        }

        private void cmdUcitavanjeZone_Click(object sender, EventArgs e)
        {
            try
            {
                ISession s = DataLayer.GetSession();
                Zona z = s.Load<Zona>(4);
                MessageBox.Show(z.ID.ToString());
                s.Close();
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message);
            }
        }

        private void cmdUcitavanjeFizickogLica_Click(object sender, EventArgs e)
        {
            try
            {
                ISession s = DataLayer.GetSession();
                Fizicko_lice f = s.Load<Fizicko_lice>(11);
                MessageBox.Show(f.licno_ime+ " (" +f.ime_roditelja + ") " + f.prezime);
                s.Close();
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message);
            }
        }

        private void cmdUcitavnjePravnogLica_Click(object sender, EventArgs e)
        {
            try
            {
                ISession s = DataLayer.GetSession();
                Pravno_lice p = s.Load<Pravno_lice>(36);
                MessageBox.Show(p.Naziv);
                s.Close();
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message);
            }
        }

        private void cmdUcitavanjeGaraznogMesta_Click(object sender, EventArgs e)
        {
            try
            {
                ISession s = DataLayer.GetSession();
                Garazno_mesto p = s.Load<Garazno_mesto>(25);
                MessageBox.Show(p.redni_br.ToString());
                s.Close();
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message);
            }
        }

        private void cmdUcitavanjeParkingMesta_Click(object sender, EventArgs e)
        {
            try
            {
                ISession s = DataLayer.GetSession();
                Parking_mesto p = s.Load<Parking_mesto>(27);
                MessageBox.Show(p.zausetost);
                s.Close();
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message);
            }
        }

        private void cmdUcitavanjeUlicnogMesta_Click(object sender, EventArgs e)
        {
            try
            {
                ISession s = DataLayer.GetSession();
                Ulicno_mesto p = s.Load<Ulicno_mesto>(17);
                MessageBox.Show(p.naziv_ulice);
                s.Close();
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message);
            }
        }

        private void cmdUcitajKlijenta_Click(object sender, EventArgs e)
        {
            try
            {
                ISession s = DataLayer.GetSession();
                Klijent k = s.Load<Klijent>(30);
                MessageBox.Show(k.ID.ToString());
                s.Close();
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message);
            }
        }

        private void cmdUcitavanjeJednokratne_Click(object sender, EventArgs e)
        {
            try
            {
                ISession s = DataLayer.GetSession();
                Jednokratna k = s.Load<Jednokratna>(15);
                MessageBox.Show(k.period_parkiranja_od.ToString() + " - " + k.period_parkiranja_do.ToString());
                s.Close();
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message);
            }
        }

        private void cmdUcitavanjePretplatne_Click(object sender, EventArgs e)
        {
            try
            {
                ISession s = DataLayer.GetSession();
                Pretplatna k = s.Load<Pretplatna>(14);
                MessageBox.Show(k.period_vazenja_od.ToString() + " - " + k.period_vazenja_do.ToString());
                s.Close();
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message);
            }
        }

        private void cmdUcitavanjeParking_Click(object sender, EventArgs e)
        {
            try
            {
                ISession s = DataLayer.GetSession();
                Parking k = s.Load<Parking>(13);
                MessageBox.Show(k.naziv);
                s.Close();
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message);
            }
        }

        private void cmdUcitavanjeJavneGaraze_Click(object sender, EventArgs e)
        {
            try
            {
                ISession s = DataLayer.GetSession();
                Javna_garaza k = s.Load<Javna_garaza>(12);
                MessageBox.Show(k.tip);
                s.Close();
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message);
            }
        }

        private void cmdUcitavanjeZonaPretplatne_Click(object sender, EventArgs e)
        {
            try
            {
                ISession s = DataLayer.GetSession();
                Zone_pretplatne k = s.Load<Zone_pretplatne>(9);
                MessageBox.Show(k.pretplatna_karta.ToString());
                s.Close();
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message);
            }
        }

        private void cmdUcitavanjeTelefona_Click(object sender, EventArgs e)
        {
            try
            {
                ISession s = DataLayer.GetSession();
                Telefon k = s.Load<Telefon>(8);
                MessageBox.Show(k.broj);
                s.Close();
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message);
            }
        }

        private void cmdUcitavanjeOdnosiSeNaP_Click(object sender, EventArgs e)
        {
            try
            {
                ISession s = DataLayer.GetSession();
                Odnosi_se_na_P k = s.Load<Odnosi_se_na_P>(8);
                MessageBox.Show(k.id_vozila.ToString() + ", " + k.id_pretplatne.ToString());
                s.Close();
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message);
            }
        }

        private void LOAD_Click(object sender, EventArgs e)
        {
            
        }

        private void SAVE_Click(object sender, EventArgs e)
        {

        }

        private void CHANGE_Click(object sender, EventArgs e)
        {
            
        }

        private void DELETE_Click(object sender, EventArgs e)
        {

        }

        private void btnPrikazi_Click(object sender, EventArgs e)
        {
            String item = izborEntitetaBox.Text;
            switch (item)
            {
                case "Pravno lice":
                    {
                        PravnoLiceForm nova = new PravnoLiceForm();
                        nova.Show();
                        break;
                    }
                case "Fizičko lice":
                    {
                        FizickoLiceForm nova = new FizickoLiceForm();
                        nova.Show();
                        break;
                    }
                case "Telefon":
                    {
                        TelefonForm nova = new TelefonForm();
                        nova.Show();
                        break;
                    }
                case "Zona":
                    {
                        ZonaForm nova = new ZonaForm();
                        nova.Show();
                        break;
                    }
                case "Parking":
                    {
                        ParkingForm nova = new ParkingForm();
                        nova.Show();
                        break;
                    }
                case "Javna garaža":
                    {
                        JavnaGarazaForm nova = new JavnaGarazaForm();
                        nova.Show();
                        break;
                    }
                case "Garažno mesto":
                    {
                        GaraznoMestoForm nova = new GaraznoMestoForm();
                        nova.Show();
                        break;
                    }
                case "Ulično mesto":
                    {
                        UlicnoMestoForm nova = new UlicnoMestoForm();
                        nova.Show();
                        break;
                    }
                case "Vozilo":
                    {
                        VoziloForm nova = new VoziloForm();
                        nova.Show();
                        break;
                    }
                case "Pretplatna":
                    {
                        PretplatnaForm nova = new PretplatnaForm();
                        nova.Show();
                        break;
                    }
                case "Jednokratna":
                    {
                        JednokratnaForm nova = new JednokratnaForm();
                        nova.Show();
                        break;
                    }
            }

        }
    }
}

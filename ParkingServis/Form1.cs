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
            String item = izborEntitetaBox.Text;
            switch (item)
            {
                case "Klijent":
                    { 
                        Form nova = new LoadKlijent();
                        nova.Show();
                        break;
                    }
                case "Pravno lice":
                    {
                        Form nova = new LoadPravno_lice();
                        nova.Show();
                        break;
                    }
                case "Fizičko lice":
                    {
                        Form nova = new LoadFizicko_lice();
                        nova.Show();
                        break;
                    }
                case "Pretplatna":
                    {
                        Form nova = new LoadPretplatna();
                        nova.Show();
                        break;
                    }
                case "Jednokratna":
                    {
                        Form nova = new LoadJednokratna();
                        nova.Show();
                        break;
                    }
                case "Parking mesto":
                    {
                        Form nova = new LoadParking_mesto();
                        nova.Show();
                        break;
                    }
                case "Garažno mesto":
                    {
                        Form nova = new LoadGarazno_mesto();
                        nova.Show();
                        break;
                    }
                case "Ulično mesto":
                    {
                        Form nova = new LoadUlicno_mesto();
                        nova.Show();
                        break;
                    }
                case "Parking":
                    {
                        Form nova = new LoadParking();
                        nova.Show();
                        break;
                    }
                case "Javna garaža":
                    {
                        Form nova = new LoadJavna_garaza();
                        nova.Show();
                        break;
                    }
                case "Vozilo":
                    {
                        Form nova = new LoadVozilo();
                        nova.Show();
                        break;
                    }
                case "Telefon":
                    {
                        Form nova = new LoadTelefon();
                        nova.Show();
                        break;
                    }
                case "Odnosi se na P":
                    {
                        Form nova = new LoadOdnosi_se_na_P();
                        nova.Show();
                        break;
                    }
                case "Zona":
                    {
                        Form nova = new LoadZona();
                        nova.Show();
                        break;
                    }
                case "Zone pretplatne":
                    {
                        Form nova = new LoadZone_pretplatne();
                        nova.Show();
                        break;
                    }
            }
            
        }

        private void SAVE_Click(object sender, EventArgs e)
        {
            String item = izborEntitetaBox.Text;
            switch (item)
            {
                case "Klijent":
                    {
                        Form nova = new SaveKlijent();
                        nova.Show();
                        break;
                    }
                case "Pravno lice":
                    {
                        Form nova = new SavePravno_lice();
                        nova.Show();
                        break;
                    }
                case "Fizičko lice":
                    {
                        Form nova = new SaveFizicko_lice();
                        nova.Show();
                        break;
                    }
                case "Pretplatna":
                    {
                        Form nova = new SavePretplatna();
                        nova.Show();
                        break;
                    }
                case "Jednokratna":
                    {
                        Form nova = new SaveJednokratna();
                        nova.Show();
                        break;
                    }
                case "Parking mesto":
                    {
                        Form nova = new SaveParking_mesto();
                        nova.Show();
                        break;
                    }
                case "Garažno mesto":
                    {
                        Form nova = new SaveGarazno_mesto();
                        nova.Show();
                        break;
                    }
                case "Ulično mesto":
                    {
                        Form nova = new SaveUlicno_mesto();
                        nova.Show();
                        break;
                    }
                case "Parking":
                    {
                        Form nova = new SaveParking();
                        nova.Show();
                        break;
                    }
                case "Javna garaža":
                    {
                        Form nova = new SaveJavna_garaza();
                        nova.Show();
                        break;
                    }
                case "Vozilo":
                    {
                        Form nova = new SaveVozilo();
                        nova.Show();
                        break;
                    }
                case "Telefon":
                    {
                        Form nova = new SaveTelefon();
                        nova.Show();
                        break;
                    }
                case "Odnosi se na P":
                    {
                        Form nova = new SaveOdnosi_se_na_P();
                        nova.Show();
                        break;
                    }
                case "Zona":
                    {
                        Form nova = new SaveZona();
                        nova.Show();
                        break;
                    }
                case "Zone pretplatne":
                    {
                        Form nova = new SaveZone_pretplatne();
                        nova.Show();
                        break;
                    }
            }
        }

        private void CHANGE_Click(object sender, EventArgs e)
        {
            String item = izborEntitetaBox.Text;
            switch (item)
            {
                case "Klijent":
                    {
                        Form nova = new ChangeKlijent();
                        nova.Show();
                        break;
                    }
                case "Pravno lice":
                    {
                        Form nova = new ChangePravno_lice();
                        nova.Show();
                        break;
                    }
                case "Fizičko lice":
                    {
                        Form nova = new ChangeFizicko_lice();
                        nova.Show();
                        break;
                    }
                case "Pretplatna":
                    {
                        Form nova = new ChangePretplatna();
                        nova.Show();
                        break;
                    }
                case "Jednokratna":
                    {
                        Form nova = new ChangeJednokratna();
                        nova.Show();
                        break;
                    }
                case "Parking mesto":
                    {
                        Form nova = new ChangeParking_mesto();
                        nova.Show();
                        break;
                    }
                case "Garažno mesto":
                    {
                        Form nova = new ChangeGarazno_mesto();
                        nova.Show();
                        break;
                    }
                case "Ulično mesto":
                    {
                        Form nova = new ChangeUlicno_mesto();
                        nova.Show();
                        break;
                    }
                case "Parking":
                    {
                        Form nova = new ChangeParking();
                        nova.Show();
                        break;
                    }
                case "Javna garaža":
                    {
                        Form nova = new ChangeJavna_garaza();
                        nova.Show();
                        break;
                    }
                case "Vozilo":
                    {
                        Form nova = new ChangeVozilo();
                        nova.Show();
                        break;
                    }
                case "Telefon":
                    {
                        Form nova = new ChangeTelefon();
                        nova.Show();
                        break;
                    }
                case "Odnosi se na P":
                    {
                        Form nova = new ChangeOdnosi_se_na_P();
                        nova.Show();
                        break;
                    }
                case "Zona":
                    {
                        Form nova = new ChangeZona();
                        nova.Show();
                        break;
                    }
                case "Zone pretplatne":
                    {
                        Form nova = new ChangeZone_pretplatne();
                        nova.Show();
                        break;
                    }
            }
        }

        private void DELETE_Click(object sender, EventArgs e)
        {
            String item = izborEntitetaBox.Text;
            switch (item)
            {
                case "Klijent":
                    {
                        Form nova = new DeleteKlijent();
                        nova.Show();
                        break;
                    }
                case "Pravno lice":
                    {
                        Form nova = new DeletePravno_lice();
                        nova.Show();
                        break;
                    }
                case "Fizičko lice":
                    {
                        Form nova = new DeleteFizicko_lice();
                        nova.Show();
                        break;
                    }
                case "Pretplatna":
                    {
                        Form nova = new DeletePretplatna();
                        nova.Show();
                        break;
                    }
                case "Jednokratna":
                    {
                        Form nova = new DeleteJednokratna();
                        nova.Show();
                        break;
                    }
                case "Parking mesto":
                    {
                        Form nova = new DeleteParking_mesto();
                        nova.Show();
                        break;
                    }
                case "Garažno mesto":
                    {
                        Form nova = new DeleteGarazno_mesto();
                        nova.Show();
                        break;
                    }
                case "Ulično mesto":
                    {
                        Form nova = new DeleteUlicno_mesto();
                        nova.Show();
                        break;
                    }
                case "Parking":
                    {
                        Form nova = new DeleteParking();
                        nova.Show();
                        break;
                    }
                case "Javna garaža":
                    {
                        Form nova = new DeleteJavna_garaza();
                        nova.Show();
                        break;
                    }
                case "Vozilo":
                    {
                        Form nova = new DeleteVozilo();
                        nova.Show();
                        break;
                    }
                case "Telefon":
                    {
                        Form nova = new DeleteTelefon();
                        nova.Show();
                        break;
                    }
                case "Odnosi se na P":
                    {
                        Form nova = new DeleteOdnosi_se_na_P();
                        nova.Show();
                        break;
                    }
                case "Zona":
                    {
                        Form nova = new DeleteZona();
                        nova.Show();
                        break;
                    }
                case "Zone pretplatne":
                    {
                        Form nova = new DeleteZone_pretplatne();
                        nova.Show();
                        break;
                    }
            }
        }
    }
}

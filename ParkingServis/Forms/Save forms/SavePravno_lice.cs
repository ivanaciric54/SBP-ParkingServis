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

namespace ParkingServis.Forms.Save_forms
{
    public partial class SavePravno_lice : Form
    {
        public SavePravno_lice()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                ISession s = DataLayer.GetSession();
                Entiteti.Pravno_lice pl = new Entiteti.Pravno_lice();
         
                pl.PIB = (long)Convert.ToDouble(txtPIB.Text);
                pl.Naziv = txtNaziv.Text;
                pl.Adresa = txtAdresa.Text;
                pl.Ovlasceno_lice = txtOvlascenoLice.Text;

                s.SaveOrUpdate(pl);
                s.Flush();

                Telefon t = new Telefon();
                t.id_klijenta = s.Load<Klijent>(pl.ID);
                t.broj = txtTelefon.Text;
                pl.telefoni.Add(t);

                s.SaveOrUpdate(t);


                s.Flush();
                s.Close();

            }
            catch (Exception ec)
            {
                MessageBox.Show(ec.Message);
            }
        }

        private void SavePravno_lice_Load(object sender, EventArgs e)
        {

        }
    }
}

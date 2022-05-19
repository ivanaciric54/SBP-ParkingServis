using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ParkingServis.Entiteti;
using ParkingServis.Mapiranja;
using NHibernate;

namespace ParkingServis.Forms.Save_forms
{
    public partial class SaveFizicko_lice : Form
    {
        public SaveFizicko_lice()
        {
            InitializeComponent();
        }

        private void SaveFizicko_lice_Load(object sender, EventArgs e)
        {

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                ISession s = DataLayer.GetSession();
                Entiteti.Fizicko_lice fl = new Entiteti.Fizicko_lice();
                fl.JMBG = (long)Convert.ToDouble(txtJMBG.Text);
                fl.LK = (long)Convert.ToDouble(txtLK.Text);
                fl.mesto_izdavanja_lk = txtMestoLK.Text;
                fl.licno_ime = txtIme.Text;
                fl.ime_roditelja = txtImeRoditelja.Text;
                fl.prezime = txtPrezime.Text;
                fl.adresa = txtAdresa.Text;
                fl.prebivaliste = txtPrebivaliste.Text;
                fl.broj_vozacke = (long)Convert.ToDouble(txtVD.Text);

                s.SaveOrUpdate(fl);

                s.Flush();
                s.Close();
            }
            catch (Exception ec)
            {
                MessageBox.Show(ec.Message);
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e) //JMBG
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(txtJMBG.Text, "[^0-9]"))
            {
                MessageBox.Show("Samo brojevi.");
                txtJMBG.Text = txtJMBG.Text.Remove(txtJMBG.Text.Length - 1);
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e) // LK
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(txtJMBG.Text, "[^0-9]"))
            {
                MessageBox.Show("Samo brojevi.");
                txtJMBG.Text = txtJMBG.Text.Remove(txtJMBG.Text.Length - 1);
            }
        }

        private void textBox8_TextChanged(object sender, EventArgs e) // vozacka
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(txtJMBG.Text, "[^0-9]"))
            {
                MessageBox.Show("Samo brojevi.");
                txtJMBG.Text = txtJMBG.Text.Remove(txtJMBG.Text.Length - 1);
            }
        }

        private void txtPrezime_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

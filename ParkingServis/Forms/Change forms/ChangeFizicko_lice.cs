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

namespace ParkingServis.Forms.Change_forms
{
    public partial class ChangeFizicko_lice : Form
    {
        public ChangeFizicko_lice()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
       {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnChange_Click(object sender, EventArgs e)
        {
            try
            {
                ISession s = DataLayer.GetSession();
                int id = Int32.Parse(textBox1.Text);
                Fizicko_lice f = s.Load<Entiteti.Fizicko_lice>(id);
                //s.Close();

                f.JMBG = (long)Convert.ToDouble(txtJMBG.Text);
                f.LK = (long)Convert.ToDouble(txtLK.Text);
                f.mesto_izdavanja_lk = txtMestoLK.Text;
                f.licno_ime = txtIme.Text;
                f.ime_roditelja = txtImeRoditelja.Text;
                f.prezime = txtPrezime.Text;
                f.adresa = txtAdresa.Text;
                f.prebivaliste = txtPrebivaliste.Text;
                f.broj_vozacke = (long)Convert.ToDouble(txtVD.Text);

                //ISession s1 = DataLayer.GetSession();
                s.Update(f);

                s.Flush();
                s.Close();
            }
            catch (Exception ec)
            {
                MessageBox.Show(ec.Message);
            }
        }

        private void txtJMBG_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(txtJMBG.Text, "[^0-9]"))
            {
                MessageBox.Show("Samo brojevi.");
                txtJMBG.Text = txtJMBG.Text.Remove(txtJMBG.Text.Length - 1);
            }
        }

        private void txtLK_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(txtLK.Text, "[^0-9]"))
            {
                MessageBox.Show("Samo brojevi.");
                txtLK.Text = txtLK.Text.Remove(txtLK.Text.Length - 1);
            }
        }

        private void txtVD_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(txtVD.Text, "[^0-9]"))
            {
                MessageBox.Show("Samo brojevi.");
                txtVD.Text = txtVD.Text.Remove(txtVD.Text.Length - 1);
            }
        }
    }
}

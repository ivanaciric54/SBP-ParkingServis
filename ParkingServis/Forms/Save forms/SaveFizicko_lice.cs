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
            Fizicko_lice fl = new Fizicko_lice();
            fl.JMBG = Int32.Parse(txtJMBG.Text);
            fl.LK = Int32.Parse(txtLK.Text);
            fl.mesto_izdavanja_lk = txtMestoLK.Text;
            fl.licno_ime = txtIme.Text;
            fl.ime_roditelja = txtImeRoditelja.Text;
            fl.prezime = txtPrezime.Text;
            fl.adresa = txtAdresa.Text;
            fl.prebivaliste = txtPrebivaliste.Text;
            fl.broj_vozacke = Int32.Parse(txtVD.Text);
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
    }
}

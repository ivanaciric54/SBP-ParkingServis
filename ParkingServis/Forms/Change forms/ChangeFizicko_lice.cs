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

namespace ParkingServis.Forms.Change_forms
{
    public partial class ChangeFizicko_lice : Form
    {
        private int id;

        public ChangeFizicko_lice()
        {
            InitializeComponent();
        }

        public ChangeFizicko_lice(int id)
        {
            this.id = id;
            InitializeComponent();
        }

        private void btnChange_Click(object sender, EventArgs e)
        {
            Fizicko_lice fl = new Fizicko_lice();
            fl.JMBG = Int32.Parse(txtJMBG.Text);
            fl.LK = Int32.Parse(txtLK.Text);
            fl.mesto_izdavanja_lk = txtMestoLK.Text;
            fl.licno_ime = txtIme.Text;
            fl.ime_roditelja = txtImeRoditelja.Text;
            fl.prezime = txtPrezime.Text;
            fl.broj_vozacke = (long)Convert.ToDouble(txtVD.Text);
            fl.adresa = txtAdresa.Text;
            fl.prebivaliste = txtPrebivaliste.Text;

            int idd = this.id;

            DTOManager.izmeniFizickoLice(idd, fl);
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
    }
}

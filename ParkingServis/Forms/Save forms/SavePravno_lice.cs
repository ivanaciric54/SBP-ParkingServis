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
            Entiteti.Pravno_lice pl = new Entiteti.Pravno_lice();
            pl.PIB = (long)Convert.ToDouble(txtPIB.Text);
            pl.Naziv = txtNaziv.Text;
            pl.Adresa = txtAdresa.Text;
            pl.Ovlasceno_lice = txtOvlascenoLice.Text;

            String telefon = txtTelefon.Text;

            DTOManager.dodajPravnoLice(pl, telefon);
        }

        private void SavePravno_lice_Load(object sender, EventArgs e)
        {

        }

        private void txtPIB_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(txtPIB.Text, "[^0-9]"))
            {
                MessageBox.Show("Samo brojevi.");
                txtPIB.Text = txtPIB.Text.Remove(txtPIB.Text.Length - 1);
            }
        }
    }
}

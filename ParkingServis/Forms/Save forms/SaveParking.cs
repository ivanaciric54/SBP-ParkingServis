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
    public partial class SaveParking : Form
    {
        public SaveParking()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
                Entiteti.Parking p = new Entiteti.Parking();
                p.br_mesta = Int32.Parse(txtBRMesta.Text);
                p.naziv = txtNAZIV.Text;
                p.adresa = txtADRESA.Text;
                p.radno_vreme_od = new DateTime(2022, 5, 5);
                p.radno_vreme_do = new DateTime(2022, 5, 5);

            DTOManager.dodajParking(p, Int32.Parse(txtZONA.Text));

        }

        private void txtZONA_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(txtZONA.Text, "[^0-9]"))
            {
                MessageBox.Show("Samo brojevi.");
                txtZONA.Text = txtZONA.Text.Remove(txtZONA.Text.Length - 1);
            }
        }

        private void txtBRMesta_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(txtBRMesta.Text, "[^0-9]"))
            {
                MessageBox.Show("Samo brojevi.");
                txtBRMesta.Text = txtBRMesta.Text.Remove(txtBRMesta.Text.Length - 1);
            }
        }
    }
}

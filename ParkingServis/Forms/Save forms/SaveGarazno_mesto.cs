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
    public partial class SaveGarazno_mesto : Form
    {
        public SaveGarazno_mesto()
        {
            InitializeComponent();
        }

        private void txtNivo_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(txtNivo.Text, "[^0-9]"))
            {
                MessageBox.Show("Samo brojevi.");
                txtNivo.Text = txtNivo.Text.Remove(txtNivo.Text.Length - 1);
            }
        }

        private void txtRedniBroj_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(txtRedniBroj.Text, "[^0-9]"))
            {
                MessageBox.Show("Samo brojevi.");
                txtRedniBroj.Text = txtRedniBroj.Text.Remove(txtRedniBroj.Text.Length - 1);
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {

            Entiteti.Garazno_mesto gm= new Entiteti.Garazno_mesto();
            String zausetost = txtZauzetost.Text;
            gm.nivo = Int32.Parse(txtNivo.Text);
            gm.redni_br = Int32.Parse(txtRedniBroj.Text);
                
            int p= Int32.Parse(txtParking.Text);

            DTOManager.dodajGaraznoMesto(gm, p, zausetost);
        }

        private void txtZauzetost_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtParking_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(txtRedniBroj.Text, "[^0-9]"))
            {
                MessageBox.Show("Samo brojevi.");
                txtRedniBroj.Text = txtRedniBroj.Text.Remove(txtRedniBroj.Text.Length - 1);
            }
        }
    }
}
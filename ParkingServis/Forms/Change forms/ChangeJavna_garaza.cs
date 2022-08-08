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
    public partial class ChangeJavna_garaza : Form
    {
        private int id;

        public ChangeJavna_garaza()
        {
            InitializeComponent();
        }

        public ChangeJavna_garaza(int id)
        {
            this.id = id;
            InitializeComponent();
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

        private void txtBrN_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(txtBrN.Text, "[^0-9]"))
            {
                MessageBox.Show("Samo brojevi.");
                txtBrN.Text = txtBrN.Text.Remove(txtBrN.Text.Length - 1);
            }
        }

        private void btnChange_Click(object sender, EventArgs e)
        {
            Javna_garaza jg = new Javna_garaza();

            jg.naziv = txtNAZIV.Text;
            jg.adresa = txtADRESA.Text;
            jg.br_mesta = Int32.Parse(txtBRMesta.Text);
            jg.radno_vreme_od = DateTime.Parse(txtOD.Text);
            jg.radno_vreme_do = DateTime.Parse(txtDO.Text);

            jg.br_nivoa = Int32.Parse(txtBrN.Text);
            jg.montazni_objekat = txtMO.Text;
            jg.tip = txtTip.Text;

            int zona = Int32.Parse(txtZONA.Text);
            int idd = this.id;

            DTOManager.izmeniJavnuGarazu(idd, jg, zona);
        }
    }
}

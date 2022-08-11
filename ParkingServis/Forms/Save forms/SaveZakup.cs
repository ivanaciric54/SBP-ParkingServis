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
    public partial class SaveZakup : Form
    {
        public SaveZakup()
        {
            InitializeComponent();
        }

        private void txtK_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(txtK.Text, "[^0-9]"))
            {
                MessageBox.Show("Samo brojevi.");
                txtK.Text = txtK.Text.Remove(txtK.Text.Length - 1);
            }
        }

        private void txtPM_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(txtPM.Text, "[^0-9]"))
            {
                MessageBox.Show("Samo brojevi.");
                txtPM.Text = txtPM.Text.Remove(txtPM.Text.Length - 1);
            }
        }

        private void txtV_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(txtV.Text, "[^0-9]"))
            {
                MessageBox.Show("Samo brojevi.");
                txtV.Text = txtV.Text.Remove(txtV.Text.Length - 1);
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            Zakup z = new Zakup();
            z.zakup_od = DateTime.Parse(txtOD.Text);
            z.zakup_do = DateTime.Parse(txtDO.Text);
            z.datum_ugovora = DateTime.Parse(txtDatum.Text);

            int k = Int32.Parse(txtK.Text);
            int v = Int32.Parse(txtV.Text);
            int pm = Int32.Parse(txtPM.Text);

            DTOManager.dodajZakup(z, k, v, pm);
        }
    }
}

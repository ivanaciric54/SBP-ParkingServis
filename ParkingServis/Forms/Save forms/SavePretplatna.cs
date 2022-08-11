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
    public partial class SavePretplatna : Form
    {
        public SavePretplatna()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            DTOManager.dodajPretplatnu(DateTime.Parse(txtOD.Text), DateTime.Parse(txtDO.Text), DateTime.Parse(txtDatum.Text), Int32.Parse(txtK.Text), Int32.Parse(txtV.Text), Int32.Parse(txtZona.Text));
        }

        private void txtK_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(txtK.Text, "[^0-9]"))
            {
                MessageBox.Show("Samo brojevi.");
                txtK.Text = txtK.Text.Remove(txtK.Text.Length - 1);
            }
        }
    }
}

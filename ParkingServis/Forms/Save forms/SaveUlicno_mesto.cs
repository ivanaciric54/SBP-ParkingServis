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
    public partial class SaveUlicno_mesto : Form
    {
        public SaveUlicno_mesto()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                ISession s = DataLayer.GetSession();
                Entiteti.Ulicno_mesto um = new Entiteti.Ulicno_mesto(txtZauzetost.Text);
                Zona z = s.Load<Zona>(Int32.Parse(txtZ.Text));
                um.zona = z;
                um.naziv_ulice = txtUlica.Text;

                s.SaveOrUpdate(um);
                s.Flush();

                s.Close();
            }
            catch (Exception ec)
            {
                MessageBox.Show(ec.Message);
            }
        }

        private void txtZ_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(txtZ.Text, "[^0-9]"))
            {
                MessageBox.Show("Samo brojevi.");
                txtZ.Text = txtZ.Text.Remove(txtZ.Text.Length - 1);
            }
        }
    }
}

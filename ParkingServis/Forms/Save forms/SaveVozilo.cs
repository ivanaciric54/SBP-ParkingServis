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
    public partial class SaveVozilo : Form
    {
        public SaveVozilo()
        {
            InitializeComponent();
        }

        private void txtSaobracajne_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(txtSaobracajne.Text, "[^0-9]"))
            {
                MessageBox.Show("Samo brojevi.");
                txtSaobracajne.Text = txtSaobracajne.Text.Remove(txtSaobracajne.Text.Length - 1);
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                ISession s = DataLayer.GetSession();
                Entiteti.Vozilo v = new Entiteti.Vozilo();
                v.registracija = txtRegistracija.Text;
                v.proizvodjac = txtProizvodjac.Text;
                v.model = txtModelVozila.Text;
                v.br_saobracajne = (long)Convert.ToDouble(txtSaobracajne.Text);

                s.SaveOrUpdate(v);

                s.Flush();
                s.Close();
            }
            catch(Exception ec)
            {
                MessageBox.Show(ec.Message);
            }
            
        }
    }
}

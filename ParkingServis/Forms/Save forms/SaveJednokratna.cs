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
    public partial class SaveJednokratna : Form
    {
        public SaveJednokratna()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try 
            {
                ISession s = DataLayer.GetSession();
                Entiteti.Jednokratna j = new Entiteti.Jednokratna();
                j.period_parkiranja_od = new DateTime(2022, 1, 1);
                j.period_parkiranja_do = new DateTime(2022, 1, 1);
                j.vreme_kontrole = new DateTime(2022, 1, 1);
                Klijent k = s.Load<Klijent>(Int32.Parse(txtK.Text));
                Vozilo v = s.Load<Vozilo>(Int32.Parse(txtV.Text));
                j.id_klijenta = k;
                j.vozilo = v;
                k.jednokratne.Add(j);
                v.jednokratne.Add(j);
                s.SaveOrUpdate(j);
                s.Flush();

                s.SaveOrUpdate(k);
                s.SaveOrUpdate(j);

                s.Flush();
                s.Close();
            }
            catch (Exception ec)
            {
                MessageBox.Show(ec.Message);
            }
        }

        private void txtK_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(txtK.Text, "[^0-9]"))
            {
                MessageBox.Show("Samo brojevi.");
                txtK.Text = txtK.Text.Remove(txtK.Text.Length - 1);
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
    }
}

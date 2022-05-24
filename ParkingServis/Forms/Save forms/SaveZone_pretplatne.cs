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
using ParkingServis.Mapiranja;
using NHibernate;

namespace ParkingServis.Forms.Save_forms
{
    public partial class SaveZone_pretplatne : Form
    {
        public SaveZone_pretplatne()
        {
            InitializeComponent();
        }

        private void txtZ_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(txtZ.Text, "[^0-9]"))
            {
                MessageBox.Show("Samo brojevi.");
                txtZ.Text = txtZ.Text.Remove(txtZ.Text.Length - 1);
            }
        }

        private void txtP_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(txtP.Text, "[^0-9]"))
            {
                MessageBox.Show("Samo brojevi.");
                txtP.Text = txtP.Text.Remove(txtP.Text.Length - 1);
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                ISession s = DataLayer.GetSession();
                Entiteti.Zone_pretplatne zp = new Entiteti.Zone_pretplatne();
                Zona z = s.Load<Zona>(Int32.Parse(txtZ.Text));
                Pretplatna p = s.Load<Pretplatna>(Int32.Parse(txtP.Text));
                zp.zona = z;
                zp.pretplatna_karta = p;
                s.SaveOrUpdate(zp);
                s.Flush();

                z.zone_pretplatne.Add(zp);
                p.zone_pretplatne.Add(zp);

                
                s.SaveOrUpdate(z);
                s.SaveOrUpdate(p);

                s.Flush();
                s.Close();
            }
            catch (Exception ec)
            {
                MessageBox.Show(ec.Message);
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}

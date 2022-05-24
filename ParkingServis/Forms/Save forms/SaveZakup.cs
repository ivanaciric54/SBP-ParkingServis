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
            try // 11 10 27
            {
                ISession s = DataLayer.GetSession();
                Entiteti.Zakup z = new Entiteti.Zakup();
                z.datum_ugovora = new DateTime(2022, 2, 2);//Convert.ToDateTime(txtDatum.Text);
                z.zakup_od = new DateTime(2022, 2, 2);//Convert.ToDateTime(txtOD.Text);
                z.zakup_do = new DateTime(2022, 2, 2);//Convert.ToDateTime(txtDO.Text);

                Vozilo v = s.Load<Vozilo>(Int32.Parse(txtV.Text));
                z.vozilo = v;
                Klijent k = s.Load<Klijent>(Int32.Parse(txtK.Text));
                z.klijent = k;
                Parking_mesto pm= s.Load<Parking_mesto>(Int32.Parse(txtPM.Text));
                z.parking_mesto = pm;

                v.zakupi.Add(z);
                k.zakupi.Add(z);
                pm.zakupi.Add(z);

                s.SaveOrUpdate(z);

                s.Flush();
                s.Close();
            }
            catch (Exception ec)
            {
                MessageBox.Show(ec.Message);
            }
        }
    }
}

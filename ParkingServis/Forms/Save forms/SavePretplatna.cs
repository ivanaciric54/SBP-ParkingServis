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
            try
            {
                ISession s = DataLayer.GetSession();
                Entiteti.Pretplatna p = new Entiteti.Pretplatna();
                p.period_vazenja_od = new DateTime(2022, 1, 1);
                p.period_vazenja_do = new DateTime(2022, 5, 5);
                p.datum = new DateTime(2022, 1, 1);
                Klijent k = s.Load<Klijent>(Int32.Parse(txtK.Text));
                p.id_klijenta = k;
                k.pretplatne.Add(p);

                s.SaveOrUpdate(k);
                s.SaveOrUpdate(p);

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
    }
}

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
    public partial class SaveOdnosi_se_na_P : Form
    {
        public SaveOdnosi_se_na_P()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                ISession s = DataLayer.GetSession();
                Entiteti.Odnosi_se_na_P o = new Entiteti.Odnosi_se_na_P();
                Pretplatna p = s.Load<Pretplatna>(Int32.Parse(txtP.Text));
                Vozilo v = s.Load<Vozilo>(Int32.Parse(txtV.Text));
                o.id_pretplatne = p;
                o.id_vozila = v;

                s.SaveOrUpdate(o);
                s.Flush();

                p.odnosi_se_na_p.Add(o);
                v.odnosi_se_na_p.Add(o);
                s.SaveOrUpdate(p);
                s.SaveOrUpdate(v);
                s.Flush();
                s.Close();
            }
            catch (Exception ec)
            {
                MessageBox.Show(ec.Message);
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
    }
}

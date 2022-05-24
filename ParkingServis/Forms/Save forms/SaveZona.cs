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
    public partial class SaveZona : Form
    {
        public SaveZona()
        {
            InitializeComponent();
        }

        private void txtZona_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(txtZona.Text, "[^0-9]"))
            {
                MessageBox.Show("Samo brojevi.");
                txtZona.Text = txtZona.Text.Remove(txtZona.Text.Length - 1);
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                ISession s = DataLayer.GetSession();
                Entiteti.Zona z = new Entiteti.Zona();
                z.ID = Int32.Parse(txtZona.Text);

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

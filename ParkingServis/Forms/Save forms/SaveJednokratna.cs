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
            DateTime o = DateTime.Parse(txtOD.Text);
            DateTime d = DateTime.Parse(txtDO.Text);
            DateTime vk = DateTime.Parse(txtVK.Text);
            int k = Int32.Parse(txtK.Text);
            int v = Int32.Parse(txtV.Text);

            DTOManager.dodajJednokratnu(o, d, vk, k, v);
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

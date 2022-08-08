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
using ParkingServis.Forms;

namespace ParkingServis.Forms.Change_forms
{
    public partial class ChangeParking : Form
    {
        private int id;

        public ChangeParking()
        {
            InitializeComponent();
        }

        public ChangeParking(int id)
        {
            this.id = id;
            InitializeComponent();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(txtZona.Text, "[^0-9]"))
            {
                MessageBox.Show("Samo brojevi.");
                txtZona.Text = txtZona.Text.Remove(txtZona.Text.Length - 1);
            }
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(txtBrM.Text, "[^0-9]"))
            {
                MessageBox.Show("Samo brojevi.");
                txtBrM.Text = txtBrM.Text.Remove(txtBrM.Text.Length - 1);
            }
        }

        private void btnChange_Click(object sender, EventArgs e)
        {
            Parking p = new Parking();
            p.naziv = txtNaziv.Text;
            p.adresa = txtAdresa.Text;
            p.br_mesta = Int32.Parse(txtBrM.Text);
            p.radno_vreme_do = DateTime.Parse(txtVremeOD.Text);
            p.radno_vreme_do = DateTime.Parse(txtVremeDO.Text);

            int z = Int32.Parse(txtZona.Text);
            int idd = this.id;

            DTOManager.izmeniParking(id, p, z);
        }
    }
}

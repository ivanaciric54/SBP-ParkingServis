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

namespace ParkingServis.Forms.Change_forms
{
    public partial class ChangePravno_lice : Form
    {
        private int id;

        public ChangePravno_lice()
        {
            InitializeComponent();
        }

        public ChangePravno_lice(int id)
        {
            this.id = id;
            InitializeComponent();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(txtPIB.Text, "[^0-9]"))
            {
                MessageBox.Show("Samo brojevi.");
                txtPIB.Text = txtPIB.Text.Remove(txtPIB.Text.Length - 1);
            }
        }

        private void btnChange_Click(object sender, EventArgs e)
        {
            Pravno_lice pl = new Pravno_lice();
            pl.PIB = (long)Convert.ToDouble(txtPIB.Text);
            pl.Naziv = txtNaziv.Text;
            pl.Adresa = txtAdresa.Text;
            pl.Ovlasceno_lice = txtOL.Text;

            int idd = this.id;

            DTOManager.izmeniPravnoLice(idd, pl);
        }
    }
}

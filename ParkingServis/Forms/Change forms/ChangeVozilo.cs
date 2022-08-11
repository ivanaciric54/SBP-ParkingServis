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

namespace ParkingServis.Forms.Change_forms
{
    public partial class ChangeVozilo : Form
    {
        private int id;

        public ChangeVozilo()
        {
            InitializeComponent();
        }

        public ChangeVozilo(int id)
        {
            this.id = id;
            InitializeComponent();
        }

        private void txtBrojSaobracajne_TextChanged(object sender, EventArgs e)
        {
            /*if (System.Text.RegularExpressions.Regex.IsMatch(txtBrojSaobracajne.Text, "[^0-9]"))
            {
                MessageBox.Show("Samo brojevi.");
                txtBrojSaobracajne.Text = txtBrojSaobracajne.Text.Remove(textBox1.Text.Length - 1);
            }*/
        }

        private void ChangeVozilo_Load(object sender, EventArgs e)
        {
            //txtBrojSaobracajne.ReadOnly = true;
        }



        private void btnChange_Click(object sender, EventArgs e)
        {
            Vozilo v = new Vozilo();

            v.registracija = txtRegistracija.Text;
            v.proizvodjac = txtProizvodjac.Text;
            v.model = txtModel.Text;
            v.br_saobracajne = (long)Convert.ToDouble(txtBrojSaobracajne.Text);

            int idd = this.id;

            DTOManager.izmeniVozilo(idd, v);

        }
    }
}

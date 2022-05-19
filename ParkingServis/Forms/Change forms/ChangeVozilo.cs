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
        public ChangeVozilo()
        {
            InitializeComponent();
        }

        private void txtBrojSaobracajne_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(txtBrojSaobracajne.Text, "[^0-9]"))
            {
                MessageBox.Show("Samo brojevi.");
                txtBrojSaobracajne.Text = txtBrojSaobracajne.Text.Remove(textBox1.Text.Length - 1);
            }
        }

        private void ChangeVozilo_Load(object sender, EventArgs e)
        {
            //txtBrojSaobracajne.ReadOnly = true;
        }

        private void chkRegistacija_CheckedChanged(object sender, EventArgs e)
        {
            if (chkRegistracija.Checked==true)
            {
                txtRegistracija.ReadOnly = false;
            }
            else 
            {
                txtRegistracija.ReadOnly = true;
            }
        }

        private void chkBrojSaobracajne_CheckedChanged(object sender, EventArgs e)
        {
            if (chkRegistracija.Checked == true)
            {
                txtBrojSaobracajne.ReadOnly = false;
            }
            else
            {
                txtBrojSaobracajne.ReadOnly = true;
            }
        }

        private void chkProizvodjac_CheckedChanged(object sender, EventArgs e)
        {
            if (chkRegistracija.Checked == true)
            {
                txtProizvodjac.ReadOnly = false;
            }
            else
            {
                txtProizvodjac.ReadOnly = true;
            }
        }

        private void chkModel_CheckedChanged(object sender, EventArgs e)
        {
            if (chkRegistracija.Checked == true)
            {
                txtModel.ReadOnly = false;
            }
            else
            {
                txtModel.ReadOnly = true;
            }
        }

        private void btnChange_Click(object sender, EventArgs e)
        {
            try 
            {
                ISession s = DataLayer.GetSession();
                int id = Int32.Parse(textBox1.Text);
                Vozilo v = s.Load<Vozilo>(id);
                if (txtRegistracija.Text.Length != 0)
                {
                    v.registracija = txtRegistracija.Text;
                }
                if (txtProizvodjac.Text.Length != 0)
                {
                    v.proizvodjac = txtProizvodjac.Text;
                }
                if (txtModel.Text.Length != 0)
                {
                    v.model = txtModel.Text;
                }
                if (txtBrojSaobracajne.Text.Length != 0)
                {
                    v.br_saobracajne = (long)Convert.ToDouble(txtBrojSaobracajne.Text);
                }

                s.SaveOrUpdate(v);
                s.Flush();
                s.Close();
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message);
            }
        }
    }
}

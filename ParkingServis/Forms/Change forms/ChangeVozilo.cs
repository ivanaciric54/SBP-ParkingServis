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

namespace ParkingServis.Forms.Change_forms
{
    public partial class ChangeVozilo : Form
    {
        public ChangeVozilo()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnChange_Click(object sender, EventArgs e)
        {
            try //10
            {
                ISession s = DataLayer.GetSession();
                int id = Int32.Parse(textBox1.Text);
                Vozilo v = s.Load<Vozilo>(id);

                v.registracija = textBox2.Text;
                v.br_saobracajne = (long)Convert.ToDouble(textBox3.Text);
                v.proizvodjac = textBox4.Text;
                v.model = textBox5.Text;

                s.Update(v);

                s.Flush();
                s.Close();
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message);
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(textBox3.Text, "[^0-9]"))
            {
                MessageBox.Show("Samo brojevi.");
                textBox3.Text = textBox3.Text.Remove(textBox3.Text.Length - 1);
            }
        }
    }
}

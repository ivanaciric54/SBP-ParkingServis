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
    public partial class ChangeJavna_garaza : Form
    {
        public ChangeJavna_garaza()
        {
            InitializeComponent();
        }

        private void btnChange_Click(object sender, EventArgs e)
        {
            try  //12
            {
                ISession s = DataLayer.GetSession();
                int id = Int32.Parse(textBox1.Text);
                Javna_garaza k = s.Load<Entiteti.Javna_garaza>(id);

                k.br_nivoa = Int32.Parse(textBox2.Text);
                k.montazni_objekat = textBox3.Text;
                k.tip = textBox4.Text;

                s.Update(k);

                s.Flush();
                s.Close();
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message);
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(textBox2.Text, "[^0-9]"))
            {
                MessageBox.Show("Samo brojevi.");
                textBox2.Text = textBox2.Text.Remove(textBox2.Text.Length - 1);
            }
        }
    }
}

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

namespace ParkingServis.Forms.Load_forms
{
    public partial class LoadZone_pretplatne : Form
    {
        public LoadZone_pretplatne()
        {
            InitializeComponent();
        }

        private void btnLoadZonePretplatne_Click(object sender, EventArgs e)
        {
            try //9
            {
                ISession s = DataLayer.GetSession();
                int id = Int32.Parse(textBox1.Text);
                Zone_pretplatne k = s.Load<Zone_pretplatne>(id);
                MessageBox.Show(k.pretplatna_karta.ToString());
                s.Close();
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message);
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(textBox1.Text, "[^0-9]"))
            {
                MessageBox.Show("Samo brojevi.");
                textBox1.Text = textBox1.Text.Remove(textBox1.Text.Length - 1);
            }
        }
    }
}

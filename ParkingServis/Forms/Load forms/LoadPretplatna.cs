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
    public partial class LoadPretplatna : Form
    {
        public LoadPretplatna()
        {
            InitializeComponent();
        }

        private void btnLoadPretplatna_Click(object sender, EventArgs e)
        {
            try //14
            {
                ISession s = DataLayer.GetSession();
                int id = Int32.Parse(textBox1.Text);
                Pretplatna p = s.Load<Pretplatna>(id);
                MessageBox.Show(p.period_vazenja_od.ToString() + " - " + p.period_vazenja_do.ToString());
                Klijent k = p.id_klijenta;
                MessageBox.Show(k.ID.ToString());
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

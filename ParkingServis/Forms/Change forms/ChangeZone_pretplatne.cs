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
    public partial class ChangeZone_pretplatne : Form
    {
        public ChangeZone_pretplatne()
        {
            InitializeComponent();
        }

        private void btnChange_Click(object sender, EventArgs e)
        {
            try //9
            {
                ISession s = DataLayer.GetSession();
                int id = Int32.Parse(textBox1.Text);
                Zone_pretplatne k = s.Load<Zone_pretplatne>(id);

                k.zona = Int32.Parse(textBox2.Text);
                k.pretplatna_karta = Int32.Parse(textBox3.Text);

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

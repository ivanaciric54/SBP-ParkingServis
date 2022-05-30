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
    public partial class ChangeJednokratna : Form
    {
        public ChangeJednokratna()
        {
            InitializeComponent();
        }

        private void btnChange_Click(object sender, EventArgs e)
        {
            try //15
            {
                ISession s = DataLayer.GetSession();
                int id = Int32.Parse(textBox1.Text);
                Jednokratna k = s.Load<Jednokratna>(id);

                k.id_klijenta = Int32.Parse(textBox2.Text);
                k.id_vozila = Int32.Parse(textBox3.Text);
                k.period_parkiranja_od = System.DateTime.Parse(textBox4.Text);
                k.period_parkiranja_do = System.DateTime.Parse(textBox5.Text);
                k.vreme_kontrole = System.DateTime.Parse(textBox6.Text);

                s.Update(k);

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

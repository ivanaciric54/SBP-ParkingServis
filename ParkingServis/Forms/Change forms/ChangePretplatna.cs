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
    public partial class ChangePretplatna : Form
    {
        public ChangePretplatna()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnChange_Click(object sender, EventArgs e)
        {
            try //14
            {
                ISession s = DataLayer.GetSession();
                int id = Int32.Parse(textBox1.Text);
                Pretplatna k = s.Load<Pretplatna>(id);

                k.datum = System.DateTime.Parse(textBox2.Text);
                k.period_vazenja_od = System.DateTime.Parse(textBox3.Text);
                k.period_vazenja_do = System.DateTime.Parse(textBox4.Text);
                k.id_klijenta = Int32.Parse(textBox5.Text);

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

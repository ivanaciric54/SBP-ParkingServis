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
    public partial class ChangeParking : Form
    {
        public ChangeParking()
        {
            InitializeComponent();
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void btnChange_Click(object sender, EventArgs e)
        {
            try //13
            {
                ISession s = DataLayer.GetSession();
                int id = Int32.Parse(textBox1.Text);
                Parking k = s.Load<Parking>(id);

                k.zona = Int32.Parse(textBox2.Text);
                k.br_mesta = Int32.Parse(textBox3.Text);
                k.adresa = textBox4.Text;
                k.naziv = textBox5.Text;
                k.radno_vreme_od = System.DateTime.Parse(textBox6.Text);
                k.radno_vreme_do = System.DateTime.Parse(textBox8.Text);


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

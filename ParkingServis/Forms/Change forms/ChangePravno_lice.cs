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
    public partial class ChangePravno_lice : Form
    {
        public ChangePravno_lice()
        {
            InitializeComponent();
        }

        private void btnChange_Click(object sender, EventArgs e)
        {
            try //36
            {
                ISession s = DataLayer.GetSession();
                int id = Int32.Parse(textBox1.Text);
                Pravno_lice p = s.Load<Pravno_lice>(id);

                p.PIB = Int32.Parse(textBox2.Text);
                p.Naziv = textBox3.Text;
                p.Adresa = textBox4.Text;
                p.Ovlasceno_lice = textBox5.Text;

                s.Update(p);

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

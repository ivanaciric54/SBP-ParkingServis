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
    public partial class ChangeTelefon : Form
    {
        public ChangeTelefon()
        {
            InitializeComponent();
        }

        private void btnChange_Click(object sender, EventArgs e)
        {
            try //8
            {
                ISession s = DataLayer.GetSession();
                int id = Int32.Parse(textBox1.Text);
                Telefon k = s.Load<Telefon>(id);

                k.broj = textBox2.Text;
                k.id_klijenta = Int32.Parse(textBox3.Text);

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

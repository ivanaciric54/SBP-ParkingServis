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

namespace ParkingServis.Forms.Save_forms
{
    public partial class SaveTelefon : Form
    {
        public SaveTelefon()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count == 0)
            {
                MessageBox.Show("Izaberite klijenta!");
                return;
            }
            int id = Int32.Parse(listView1.SelectedItems[0].SubItems[0].Text);

            String broj = txtBroj.Text;

            DTOManager.dodajTelefon(id, broj);
        }

        private void SaveTelefon_Load(object sender, EventArgs e)
        {
            popuniPodacima();
        }

        private void popuniPodacima()
        {
            listView1.Items.Clear();
            List<KlijentPregled> podaci = DTOManager.vratiSveKlijente();

            foreach (KlijentPregled m in podaci)
            {
                ListViewItem item = new ListViewItem(new string[] { m.ID.ToString(), m.Ime});
                listView1.Items.Add(item);
            }
            listView1.Refresh();
        }
    }
}

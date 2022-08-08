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
using ParkingServis.Forms;
using ParkingServis.Forms.Save_forms;
using ParkingServis.Forms.Load_forms;
using ParkingServis.Forms.Entity_forms;
using ParkingServis.Forms.Change_forms;
using ParkingServis.Forms.Delete_forms;
using ParkingServis.Mapiranja;

namespace ParkingServis.Forms.Entity_forms
{
    public partial class FizickoLiceForm : Form
    {
        public FizickoLiceForm()
        {
            InitializeComponent();
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void FizickoLiceForm_Load(object sender, EventArgs e)
        {
            popuniPodacima();
        }

        private void popuniPodacima()
        {
            listView1.Items.Clear();
            List<FizickoLicePregled> podaci = DTOManager.vratiSvaFizickaLica();

            foreach (FizickoLicePregled m in podaci)
            {
                ListViewItem item = new ListViewItem(new string[] { m.ID.ToString(), m.Ime, m.Prezime, m.Adresa, m.Prebivaliste, m.Telefon });
                listView1.Items.Add(item);
            }
            listView1.Refresh();
        }

        private void LOAD_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count == 0)
            {
                MessageBox.Show("Izaberite fizičko lice!");
                return;
            }

            int id = Int32.Parse(listView1.SelectedItems[0].SubItems[0].Text);
            DTOManager.vratiFizickoLice(id);
        }

        private void listView1_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }

        private void SAVE_Click(object sender, EventArgs e)
        {
            SaveFizicko_lice savefl = new SaveFizicko_lice();
            savefl.Show();
        }

        private void CHANGE_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count == 0)
            {
                MessageBox.Show("Izaberite fizičko lice!");
                return;
            }
            int id = Int32.Parse(listView1.SelectedItems[0].SubItems[0].Text);

            ChangeFizicko_lice changefl = new ChangeFizicko_lice(id);
            changefl.Show();
        }

        private void DELETE_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count == 0)
            {
                MessageBox.Show("Izaberite fizičko lice!");
                return;
            }

            int id = Int32.Parse(listView1.SelectedItems[0].SubItems[0].Text);
            DTOManager.izbrisiFizickoLice(id);

        }
    }
}

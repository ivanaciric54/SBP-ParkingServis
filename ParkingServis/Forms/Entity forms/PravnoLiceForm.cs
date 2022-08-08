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
    public partial class PravnoLiceForm : Form
    {
        public PravnoLiceForm()
        {
            InitializeComponent();
        }

        private void PravnoLiceForm_Load(object sender, EventArgs e)
        {
            popuniPodacima();
        }

        private void popuniPodacima()
        {
            listView1.Items.Clear();
            List<PravnoLicePregled> podaci = DTOManager.vratiSvaPravnaLica();

            foreach (PravnoLicePregled m in podaci)
            {
                ListViewItem item = new ListViewItem(new string[] { m.ID.ToString(), m.Naziv, m.Adresa});
                listView1.Items.Add(item);
            }
            listView1.Refresh();
        }

        private void LOAD_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count == 0)
            {
                MessageBox.Show("Izaberite pravno lice!");
                return;
            }

            int id = Int32.Parse(listView1.SelectedItems[0].SubItems[0].Text);
            DTOManager.vratiPravnoLice(id);
        }

        private void SAVE_Click(object sender, EventArgs e)
        {
            SavePravno_lice savepl = new SavePravno_lice();
            savepl.Show();
        }

        private void CHANGE_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count == 0)
            {
                MessageBox.Show("Izaberite pravno lice!");
                return;
            }

            int id = Int32.Parse(listView1.SelectedItems[0].SubItems[0].Text);

            ChangePravno_lice changepl = new ChangePravno_lice(id);
            changepl.Show();
        }

        private void DELETE_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count == 0)
            {
                MessageBox.Show("Izaberite pravno lice!");
                return;
            }

            int id = Int32.Parse(listView1.SelectedItems[0].SubItems[0].Text);

            DTOManager.izbrisiPravnoLice(id);
        }
    }
}

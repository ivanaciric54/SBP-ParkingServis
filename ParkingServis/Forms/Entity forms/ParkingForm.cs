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
using ParkingServis.Forms.Change_forms;
using ParkingServis.Forms.Save_forms;

namespace ParkingServis.Forms.Entity_forms
{
    public partial class ParkingForm : Form
    {
        public ParkingForm()
        {
            InitializeComponent();
        }

        private void ParkingForm_Load(object sender, EventArgs e)
        {
            popuniPodacima();
        }

        private void popuniPodacima()
        {
            listView1.Items.Clear();
            List<ParkingPregled> podaci = DTOManager.vratiSveParkinge();

            foreach (ParkingPregled m in podaci)
            {
                ListViewItem item = new ListViewItem(new string[] { m.ID.ToString(), m.zona.ToString(), m.naziv, m.adresa, m.br_mesta.ToString(), m.vremeOtvaranja, m.vremeZatvaranja});
                listView1.Items.Add(item);
            }
            listView1.Refresh();
        }

        private void LOAD_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count == 0)
            {
                MessageBox.Show("Izaberite parking!");
                return;
            }

            int id = Int32.Parse(listView1.SelectedItems[0].SubItems[0].Text);
            DTOManager.vratiParking(id);
        }

        private void SAVE_Click(object sender, EventArgs e)
        {
            SaveParking savep = new SaveParking();
            savep.Show();
        }

        private void CHANGE_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count == 0)
            {
                MessageBox.Show("Izaberite parking!");
                return;
            }

            int id = Int32.Parse(listView1.SelectedItems[0].SubItems[0].Text);
            ChangeParking changep = new ChangeParking(id);
            changep.Show();
        }

        private void DELETE_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count == 0)
            {
                MessageBox.Show("Izaberite parking!");
                return;
            }

            int id = Int32.Parse(listView1.SelectedItems[0].SubItems[0].Text);
            DTOManager.izbrisiParking(id);
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}

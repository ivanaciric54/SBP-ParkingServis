using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ParkingServis.Forms.Change_forms;
using ParkingServis.Forms.Save_forms;

namespace ParkingServis.Forms.Entity_forms
{
    public partial class VoziloForm : Form
    {
        public VoziloForm()
        {
            InitializeComponent();
        }

        private void VoziloForm_Load(object sender, EventArgs e)
        {
            popuniPodacima();
        }

        private void popuniPodacima()
        {
            listView1.Items.Clear();
            List<VoziloPregled> podaci = DTOManager.vratiSvaVozila();

            foreach (VoziloPregled m in podaci)
            {
                ListViewItem item = new ListViewItem(new string[] { m.ID.ToString(), m.registracija, m.odgovornolice, m.parkingmesta.ToString() });
                listView1.Items.Add(item);
            }
            listView1.Refresh();
        }

        private void LOAD_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count == 0)
            {
                MessageBox.Show("Izaberite vozilo!");
                return;
            }

            int id = Int32.Parse(listView1.SelectedItems[0].SubItems[0].Text);
            DTOManager.vratiVozilo(id);
        }

        private void SAVE_Click(object sender, EventArgs e)
        {
            SaveVozilo sv = new SaveVozilo();
            sv.Show();
        }

        private void CHANGE_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count == 0)
            {
                MessageBox.Show("Izaberite vozilo!");
                return;
            }

            int id = Int32.Parse(listView1.SelectedItems[0].SubItems[0].Text);
            ChangeVozilo cv = new ChangeVozilo(id);
            cv.Show();
        }

        private void DELETE_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count == 0)
            {
                MessageBox.Show("Izaberite vozilo!");
                return;
            }

            int id = Int32.Parse(listView1.SelectedItems[0].SubItems[0].Text);
            DTOManager.izbrisiVozilo(id);
        }
    }
}

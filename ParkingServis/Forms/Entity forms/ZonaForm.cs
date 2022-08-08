using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ParkingServis.Forms.Save_forms;
using ParkingServis.Forms.Change_forms;

namespace ParkingServis.Forms.Entity_forms
{
    public partial class ZonaForm : Form
    {
        public ZonaForm()
        {
            InitializeComponent();
        }

        private void ZonaForm_Load(object sender, EventArgs e)
        {
            CHANGE.Enabled = false;
            popuniPodacima();
        }

        private void popuniPodacima()
        {
            listView1.Items.Clear();
            List<ZonaPregled> podaci = DTOManager.vratiSveZone();

            foreach (ZonaPregled m in podaci)
            {
                ListViewItem item = new ListViewItem(new string[] { m.ID.ToString(), m.br_parkinga.ToString()});
                listView1.Items.Add(item);
            }
            listView1.Refresh();
        }

        private void LOAD_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count == 0)
            {
                MessageBox.Show("Izaberite zonu!");
                return;
            }

            int id = Int32.Parse(listView1.SelectedItems[0].SubItems[0].Text);
            DTOManager.vratiZonu(id);
        }

        private void SAVE_Click(object sender, EventArgs e)
        {
            SaveZona savez = new SaveZona();
            savez.Show();
        }

        private void CHANGE_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count == 0)
            {
                MessageBox.Show("Izaberite zonu!");
                return;
            }

            int id = Int32.Parse(listView1.SelectedItems[0].SubItems[0].Text);
            ChangeZona changez = new ChangeZona(id);
            changez.Show();
        }

        private void DELETE_Click(object sender, EventArgs e)
        {
            int id = Int32.Parse(listView1.SelectedItems[0].SubItems[0].Text);
            DTOManager.izbrisiZonu(id);
        }
    }
}

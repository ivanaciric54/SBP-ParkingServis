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
    public partial class GaraznoMestoForm : Form
    {
        public GaraznoMestoForm()
        {
            InitializeComponent();
        }

        private void GaraznoMestoForm_Load(object sender, EventArgs e)
        {
            popuniPodacima();
        }

        private void popuniPodacima()
        {
            listView1.Items.Clear();
            List<GaraznoMestoPregled> podaci = DTOManager.vratiSvaGaraznaMesta();

            foreach (GaraznoMestoPregled m in podaci)
            {
                ListViewItem item = new ListViewItem(new string[] { m.ID.ToString(), m.zauzetost, m.nivo.ToString(), m.r_br.ToString(), m.parking, m.adresa });
                listView1.Items.Add(item);
            }
            listView1.Refresh();
        }

        private void LOAD_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count == 0)
            {
                MessageBox.Show("Izaberite garažno mesto!");
                return;
            }

            int id = Int32.Parse(listView1.SelectedItems[0].SubItems[0].Text);
            DTOManager.vratiGaraznoMesto(id);
        }

        private void SAVE_Click(object sender, EventArgs e)
        {
            SaveGarazno_mesto savegm = new SaveGarazno_mesto();
            savegm.Show();
        }

        private void CHANGE_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count == 0)
            {
                MessageBox.Show("Izaberite garažno mesto!");
                return;
            }

            int id = Int32.Parse(listView1.SelectedItems[0].SubItems[0].Text);
            ChangeGarazno_mesto changegm = new ChangeGarazno_mesto(id);
            changegm.Show();
        }

        private void DELETE_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count == 0)
            {
                MessageBox.Show("Izaberite garažno mesto!");
                return;
            }

            int id = Int32.Parse(listView1.SelectedItems[0].SubItems[0].Text);
            DTOManager.izbrisiGaraznoMesto(id);
        }
    }
}

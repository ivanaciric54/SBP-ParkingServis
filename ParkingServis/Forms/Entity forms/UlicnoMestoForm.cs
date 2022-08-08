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
    public partial class UlicnoMestoForm : Form
    {
        public UlicnoMestoForm()
        {
            InitializeComponent();
        }

        private void LOAD_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count == 0)
            {
                MessageBox.Show("Izaberite ulično mesto!");
                return;
            }

            int id = Int32.Parse(listView1.SelectedItems[0].SubItems[0].Text);
            DTOManager.vratiUlicnoMesto(id);
        }

        private void SAVE_Click(object sender, EventArgs e)
        {
            SaveUlicno_mesto saveum = new SaveUlicno_mesto();
            saveum.Show();
        }

        private void CHANGE_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count == 0)
            {
                MessageBox.Show("Izaberite ulično mesto!");
                return;
            }

            int id = Int32.Parse(listView1.SelectedItems[0].SubItems[0].Text);
            ChangeUlicno_mesto changeul = new ChangeUlicno_mesto(id);
            changeul.Show();
        }

        private void DELETE_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count == 0)
            {
                MessageBox.Show("Izaberite ulično mesto!");
                return;
            }

            int id = Int32.Parse(listView1.SelectedItems[0].SubItems[0].Text);
            DTOManager.izbrisiUlicnoMesto(id);
        }

        private void UlicnoMestoForm_Load(object sender, EventArgs e)
        {
            popuniPodacima();
        }

        private void popuniPodacima()
        {
            listView1.Items.Clear();
            List<UlicnoMestoPregled> podaci = DTOManager.vratiSvaUlicnaMesta();

            foreach (UlicnoMestoPregled m in podaci)
            {
                ListViewItem item = new ListViewItem(new string[] { m.ID.ToString(), m.zauzetost, m.zona.ToString(), m.ulica });
                listView1.Items.Add(item);
            }
            listView1.Refresh();
        }
    }
}

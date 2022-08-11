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
    public partial class JednokratnaForm : Form
    {
        public JednokratnaForm()
        {
            InitializeComponent();
        }

        private void JednokratnaForm_Load(object sender, EventArgs e)
        {
            popuniPodacima();
        }

        private void popuniPodacima()
        {
            listView1.Items.Clear();
            List<JednokratnaPregled> podaci = DTOManager.vratiSveJednokratne();

            foreach (JednokratnaPregled m in podaci)
            {
                ListViewItem item = new ListViewItem(new string[] { m.ID.ToString(), m.voziloRegistracija, m.ovlascenolice });
                listView1.Items.Add(item);
            }
            listView1.Refresh();
        }

        private void LOAD_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count == 0)
            {
                MessageBox.Show("Izaberite kartu!");
                return;
            }

            int id = Int32.Parse(listView1.SelectedItems[0].SubItems[0].Text);
            String ol = listView1.SelectedItems[0].SubItems[2].Text;
            DTOManager.vratiJednokratnu(id, ol);
        }

        private void SAVE_Click(object sender, EventArgs e)
        {
            SaveJednokratna sj = new SaveJednokratna();
            sj.Show();
        }

        private void CHANGE_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count == 0)
            {
                MessageBox.Show("Izaberite kartu!");
                return;
            }

            int id = Int32.Parse(listView1.SelectedItems[0].SubItems[0].Text);
            ChangeJednokratna cj = new ChangeJednokratna(id);
            cj.Show();
        }

        private void DELETE_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count == 0)
            {
                MessageBox.Show("Izaberite kartu!");
                return;
            }

            int id = Int32.Parse(listView1.SelectedItems[0].SubItems[0].Text);
            DTOManager.izbrisiJenokratnu(id);
        }
    }
}

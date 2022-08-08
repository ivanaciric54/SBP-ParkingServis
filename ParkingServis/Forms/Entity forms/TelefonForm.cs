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
using ParkingServis.Forms;
using ParkingServis.Forms.Entity_forms;
using ParkingServis.Forms.Load_forms;
using ParkingServis.Forms.Save_forms;
using ParkingServis.Forms.Change_forms;

namespace ParkingServis.Forms.Entity_forms
{
    public partial class TelefonForm : Form
    {
        public TelefonForm()
        {
            InitializeComponent();
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void TelefonForm_Load(object sender, EventArgs e)
        {
            popuniPodacima();
        }

        private void popuniPodacima()
        {
            listView1.Items.Clear();
            List<TelefonPregled> podaci = DTOManager.vratiSveTelefone();

            foreach (TelefonPregled m in podaci)
            {
                ListViewItem item = new ListViewItem(new string[] { m.ID.ToString(), m.ImeKlijenta, m.broj });
                listView1.Items.Add(item);
            }
            listView1.Refresh();
        }

        private void CHANGE_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count == 0)
            {
                MessageBox.Show("Izaberite telefon!");
                return;
            }
            int id = Int32.Parse(listView1.SelectedItems[0].SubItems[0].Text);

            Forms.Change_forms.ChangeTelefon changet = new Forms.Change_forms.ChangeTelefon(id);
            changet.Show();
        }

        private void SAVE_Click(object sender, EventArgs e)
        {
            SaveTelefon savet = new SaveTelefon();
            savet.Show();
        }

        private void LOAD_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count == 0)
            {
                MessageBox.Show("Izaberite telefon!");
                return;
            }
            int id = Int32.Parse(listView1.SelectedItems[0].SubItems[0].Text);

            DTOManager.vratiTelefon(id, listView1.SelectedItems[0].SubItems[1].Text);
        }

        private void DELETE_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count == 0)
            {
                MessageBox.Show("Izaberite telefon!");
                return;
            }
            int id = Int32.Parse(listView1.SelectedItems[0].SubItems[0].Text);

            DTOManager.izbrisiTelefon(id);
        }
    }
}

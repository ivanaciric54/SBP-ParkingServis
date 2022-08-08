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
    public partial class JavnaGarazaForm : Form
    {
        public JavnaGarazaForm()
        {
            InitializeComponent();
        }

        private void LOAD_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count == 0)
            {
                MessageBox.Show("Izaberite parking!");
                return;
            }

            int id = Int32.Parse(listView1.SelectedItems[0].SubItems[0].Text);
            DTOManager.vratiJavnuGarazu(id);
        }

        private void SAVE_Click(object sender, EventArgs e)
        {
            SaveJavna_garaza savejg = new SaveJavna_garaza();
            savejg.Show();
        }

        private void CHANGE_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count == 0)
            {
                MessageBox.Show("Izaberite parking!");
                return;
            }

            int id = Int32.Parse(listView1.SelectedItems[0].SubItems[0].Text);
            ChangeJavna_garaza changejg = new ChangeJavna_garaza(id);
            changejg.Show();
        }

        private void DELETE_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count == 0)
            {
                MessageBox.Show("Izaberite parking!");
                return;
            }

            int id = Int32.Parse(listView1.SelectedItems[0].SubItems[0].Text);
            DTOManager.izbrisiJavnuGarazu(id);
        }

        private void JavnaGarazaForm_Load(object sender, EventArgs e)
        {
            popuniPodacima();
        }

        private void popuniPodacima()
        {
            listView1.Items.Clear();
            List<JavnaGarazaPregled> podaci = DTOManager.vratiSveJavneGaraze();

            foreach (JavnaGarazaPregled m in podaci)
            {
                ListViewItem item = new ListViewItem(new string[] { m.ID.ToString(), m.zona.ToString(), m.naziv, m.adresa, m.br_mesta.ToString(), m.vremeOtvaranja, m.vremeZatvaranja, m.br_nivoa.ToString(), m.podnad });
                listView1.Items.Add(item);
            }
            listView1.Refresh();
        }
    }
}

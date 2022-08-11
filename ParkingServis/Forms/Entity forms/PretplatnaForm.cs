﻿using System;
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
    public partial class PretplatnaForm : Form
    {
        public PretplatnaForm()
        {
            InitializeComponent();
        }

        private void PretplatnaForm_Load(object sender, EventArgs e)
        {
            popuniPodacima();
        }

        private void popuniPodacima()
        {
            listView1.Items.Clear();
            List<PretplatnaPregled> podaci = DTOManager.vratiSvePretplatne();

            foreach (PretplatnaPregled m in podaci)
            {
                ListViewItem item = new ListViewItem(new string[] { m.ID.ToString(), m.vaziOD, m.vaziOD, m.zona.ToString(), m.registracijaVozila, m.ol });
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
            String ol = listView1.SelectedItems[0].SubItems[5].Text;
            DTOManager.vratiPretplatnu(id, ol);
        }

        private void SAVE_Click(object sender, EventArgs e)
        {
            SavePretplatna sp = new SavePretplatna();
            sp.Show();
        }

        private void CHANGE_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count == 0)
            {
                MessageBox.Show("Izaberite kartu!");
                return;
            }

            int id = Int32.Parse(listView1.SelectedItems[0].SubItems[0].Text);
            ChangePretplatna cp = new ChangePretplatna(id);
            cp.Show();
        }

        private void DELETE_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count == 0)
            {
                MessageBox.Show("Izaberite kartu!");
                return;
            }

            int id = Int32.Parse(listView1.SelectedItems[0].SubItems[0].Text);
            DTOManager.izbrisiPretplatnu(id);
        }
    }
}

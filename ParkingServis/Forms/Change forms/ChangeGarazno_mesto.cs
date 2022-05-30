﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using NHibernate;
using ParkingServis.Entiteti;

namespace ParkingServis.Forms.Change_forms
{
    public partial class ChangeGarazno_mesto : Form
    {
        public ChangeGarazno_mesto()
        {
            InitializeComponent();
        }

        private void btnChange_Click(object sender, EventArgs e)
        {
            try
            {
                ISession s = DataLayer.GetSession();
                int id = Int32.Parse(textBox1.Text);
                Entiteti.Garazno_mesto gm = s.Load<Entiteti.Garazno_mesto>(id);

             //   gm.ID = Int32.Parse(textBox1.Text);
                gm.nivo = Int32.Parse(txtNivo.Text);
                gm.redni_br = Int32.Parse(txtRedniBroj.Text);
                gm.id_parkinga = Int32.Parse(txtParking.Text);


                s.SaveOrUpdate(gm);

                s.Flush();
                s.Close();
            }
            catch (Exception ec)
            {
                MessageBox.Show(ec.Message);
            }
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

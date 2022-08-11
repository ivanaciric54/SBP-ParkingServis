﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ParkingServis.Forms.Change_forms
{
    public partial class ChangeJednokratna : Form
    {
        private int id;

        public ChangeJednokratna()
        {
            InitializeComponent();
        }

        public ChangeJednokratna(int id)
        {
            this.id = id;
            InitializeComponent();
        }

        private void btnChange_Click(object sender, EventArgs e)
        {
            int idd = this.id;
            DateTime p_od = DateTime.Parse(txtOD.Text);
            DateTime p_do = DateTime.Parse(txtDO.Text);
            DateTime kontrola = DateTime.Parse(txtVK.Text);

            DTOManager.izmeniJednokratnu(id, p_od, p_do, kontrola);
        }
    }
}

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

namespace ParkingServis.Forms.Change_forms
{
    public partial class ChangeGarazno_mesto : Form
    {
        private int id;

        public ChangeGarazno_mesto()
        {
            InitializeComponent();
        }

        public ChangeGarazno_mesto(int id)
        {
            this.id = id;
            InitializeComponent();
        }

        private void btnChange_Click(object sender, EventArgs e)
        {
            String zauzetost = txtZauzetost.Text;
            int park = Int32.Parse(txtParking.Text);
            int idd = this.id;

            Garazno_mesto gm = new Garazno_mesto();
            gm.nivo= Int32.Parse(txtNivo.Text);
            gm.redni_br= Int32.Parse(txtRedniBroj.Text);

            DTOManager.izmeniGaraznoMesto(idd, zauzetost, park, gm);
        }
    }
}

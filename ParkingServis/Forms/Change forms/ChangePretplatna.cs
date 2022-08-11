using System;
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
    public partial class ChangePretplatna : Form
    {
        private int id;

        public ChangePretplatna()
        {
            InitializeComponent();
        }

        public ChangePretplatna(int id)
        {
            this.id = id;
            InitializeComponent();
        }

        private void btnChange_Click(object sender, EventArgs e)
        {
            DateTime o = DateTime.Parse(txtOD.Text);
            DateTime d = DateTime.Parse(txtDO.Text);
            int idd = this.id;

            DTOManager.izmeniPretplatnu(idd, o, d);
        }
    }
}

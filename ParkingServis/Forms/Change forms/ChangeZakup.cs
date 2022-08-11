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
    public partial class ChangeZakup : Form
    {
        private int id;

        public ChangeZakup()
        {
            InitializeComponent();
        }

        public ChangeZakup(int id)
        {
            this.id = id;
            InitializeComponent();
        }

        private void licno_ime_Click(object sender, EventArgs e)
        {

        }

        private void btnChange_Click(object sender, EventArgs e)
        {
            DateTime o = DateTime.Parse(txtOD.Text);
            DateTime d = DateTime.Parse(txtDO.Text);
            int idd = this.id;

            DTOManager.izmeniZakup(idd, o, d);
        }
    }
}

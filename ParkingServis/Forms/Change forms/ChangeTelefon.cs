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

namespace ParkingServis.Forms.Change_forms
{
    public partial class ChangeTelefon : Form
    {
        private int id;

        public ChangeTelefon()
        {
            InitializeComponent();
        }

        public ChangeTelefon(int id)
        {
            this.id = id;
            InitializeComponent();
        }

        private void btnChange_Click(object sender, EventArgs e)
        {
            String broj = textBox1.Text;
            int idd = this.id;

            DTOManager.izmeniTelefon(idd, broj);
        }
    }
}

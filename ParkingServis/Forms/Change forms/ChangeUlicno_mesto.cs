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
    public partial class ChangeUlicno_mesto : Form
    {
        private int id;

        public ChangeUlicno_mesto()
        {
            InitializeComponent();
        }

        public ChangeUlicno_mesto(int id)
        {
            this.id = id;
            InitializeComponent();
        }

        private void btnChange_Click(object sender, EventArgs e)
        {
            int zona = Int32.Parse(txtZ.Text);
            String zauzetost = txtZauzetost.Text;
            String ulica = txtUlica.Text;
            int idd = this.id;

            DTOManager.izmeniUlicnoMesto(id, zona, zauzetost, ulica);
        }

        private void txtZ_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(txtZ.Text, "[^0-9]"))
            {
                MessageBox.Show("Samo brojevi.");
                txtZ.Text = txtZ.Text.Remove(txtZ.Text.Length - 1);
            }
        }
    }
}

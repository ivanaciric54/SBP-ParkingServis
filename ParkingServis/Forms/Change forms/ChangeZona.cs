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
    public partial class ChangeZona : Form
    {
        private int id;

        public ChangeZona()
        {
            InitializeComponent();
        }

        public ChangeZona(int id)
        {
            this.id = id;
            InitializeComponent();
        }

        private void ChangeZona_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(textBox1.Text, "[^0-9]"))
            {
                MessageBox.Show("Samo brojevi.");
                textBox1.Text = textBox1.Text.Remove(textBox1.Text.Length - 1);
            }
        }

        private void btnChange_Click(object sender, EventArgs e)
        {
            int idd = this.id;
            int broj = Int32.Parse(textBox1.Text);
            DTOManager.izmeniZonu(idd, broj);
        }
    }
}

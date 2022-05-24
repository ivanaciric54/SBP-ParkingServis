using NHibernate.Linq;
using ParkingServis.Entiteti;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ParkingServis.Forms.Delete_forms
{
    public partial class DeleteFizicko_lice : Form
    {
        public DeleteFizicko_lice()
        {
            InitializeComponent();

            try
            {
                var s = DataLayer.GetSession();
                IList<Fizicko_lice> flica = (from v in s.Query<Fizicko_lice>() select v).ToList<Fizicko_lice>();

                var FLica = new DataTable("FLica");
                FLica.Columns.Add(new DataColumn("ID", typeof(int)));
                FLica.Columns.Add(new DataColumn("Opis", typeof(string)));

                foreach (var fl in flica)
                {
                    string opis = $"{fl.ID}: {fl.licno_ime}, {fl.ime_roditelja} {fl.prezime}, JMBG: {fl.JMBG}";
                    FLica.Rows.Add(fl.ID, opis);
                }
                ds.Tables.Add(FLica);

                cbVozilaList.DataSource = ds.Tables["FLica"].DefaultView;
                cbVozilaList.DisplayMember = "Opis";
                cbVozilaList.BindingContext = this.BindingContext;

                s.Close();
            }
            catch (Exception ec)
            {
                MessageBox.Show(ec.Message);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                var s = DataLayer.GetSession();
                int index = cbVozilaList.SelectedIndex;
                int id = ds.Tables["Flica"].Rows[index].Field <int>("ID");
                var fl = s.Load<Fizicko_lice>(id);
                s.Delete(fl);
                s.Flush();
                s.Close();
            }
            catch (Exception ec)
            {
                MessageBox.Show(ec.Message);
            }

            this.Close();
        }
    }
}

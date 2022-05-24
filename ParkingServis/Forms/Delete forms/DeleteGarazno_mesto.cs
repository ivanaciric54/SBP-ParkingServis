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
    public partial class DeleteGarazno_mesto : Form
    {
        public DeleteGarazno_mesto()
        {
            InitializeComponent();

            try
            {
                var s = DataLayer.GetSession();
                IList<Garazno_mesto> lista = (from v in s.Query<Garazno_mesto>() select v).ToList<Garazno_mesto>();

                var table = new DataTable("Table");
                table.Columns.Add(new DataColumn("ID", typeof(int)));
                table.Columns.Add(new DataColumn("Opis", typeof(string)));

                foreach (var p in lista)
                {
                    var parking = s.Load<Parking>(p.id_parkinga);
                    string opis = $"{p.ID}: Parking: {parking.naziv}/{parking.adresa} , nivo: {p.nivo}, br: {p.redni_br}";
                    table.Rows.Add(p.ID, opis);
                }
                ds.Tables.Add(table);

                cbGMList.DataSource = ds.Tables["Table"].DefaultView;
                cbGMList.DisplayMember = "Opis";
                cbGMList.BindingContext = this.BindingContext;

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
                int index = cbGMList.SelectedIndex;
                int id = ds.Tables["Table"].Rows[index].Field<int>("ID");
                var p = s.Load<Garazno_mesto>(id);
                s.Delete(p);
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

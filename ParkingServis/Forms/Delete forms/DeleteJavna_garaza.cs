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
    public partial class DeleteJavna_garaza : Form
    {
        public DeleteJavna_garaza()
        {
            InitializeComponent();

            try
            {
                var s = DataLayer.GetSession();
                IList<Javna_garaza> lista = (from v in s.Query<Javna_garaza>() select v).ToList<Javna_garaza>();

                var table = new DataTable("Table");
                table.Columns.Add(new DataColumn("ID", typeof(int)));
                table.Columns.Add(new DataColumn("Opis", typeof(string)));

                foreach (var p in lista)
                {
                    var parking = s.Load<Parking>(p.ID);
                    string opis = $"{p.ID}: {p.naziv}/ {p.adresa}, tip: {p.tip}";
                    table.Rows.Add(p.ID, opis);
                }
                dataSet1.Tables.Add(table);

                comboBox1.DataSource = dataSet1.Tables["Table"].DefaultView;
                comboBox1.DisplayMember = "Opis";
                comboBox1.BindingContext = this.BindingContext;

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
                int index = comboBox1.SelectedIndex;
                int id = dataSet1.Tables["Table"].Rows[index].Field<int>("ID");
                var p = s.Load<Javna_garaza>(id);
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

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MotornaVozila.Entiteti;
using NHibernate;
using NHibernate.Linq;

namespace MotornaVozila
{
    public partial class frmZaposleni : Form
    {
        private DataTable _zaposleni = new DataTable();
        private bool noviZaposleni = false;

        public frmZaposleni()
        {
            InitializeComponent();
        }

        private void frmZaposleni_Load(object sender, EventArgs e)
        {
            dgvZaposleni.AllowUserToAddRows = false;
            dgvZaposleni.AllowUserToDeleteRows = false;
            dgvZaposleni.AllowUserToOrderColumns = false;
            dgvZaposleni.AllowUserToResizeRows = false;
            dgvZaposleni.AllowUserToResizeColumns = false;
            dgvZaposleni.ReadOnly = true;
            dgvZaposleni.MultiSelect = false;
            dgvZaposleni.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvZaposleni.DataBindingComplete += delegate
            {
                foreach (DataGridViewColumn c in dgvZaposleni.Columns)
                {
                    c.SortMode = DataGridViewColumnSortMode.NotSortable;
                }

                dgvZaposleni.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
                dgvZaposleni.RowHeadersVisible = false;
            };

            GetData();
        }

        private void GetData()
        {
            _zaposleni = new DataTable();

            _zaposleni.Columns.Add("Id");
            _zaposleni.Columns.Add("MaticniBroj");
            _zaposleni.Columns.Add("Ime");
            _zaposleni.Columns.Add("Prezime");
            _zaposleni.Columns.Add("GodRadnogStaza");
            _zaposleni.Columns.Add("DatumZaposlenja");
            _zaposleni.Columns.Add("DatumRodjenja");
            _zaposleni.Columns.Add("StepenStrSpreme");
            _zaposleni.Columns.Add("Plata");
            _zaposleni.Columns.Add("TipZaposlenog");
            _zaposleni.Columns.Add("TipUgovora");
            _zaposleni.Columns.Add("DatumIstekaUgovora");

            ISession session = DataLayer.GetSession();

            var zaposleni = (from z in session.Query<Zaposleni>()
                         select z).ToList();

            foreach (var z in zaposleni)
            {
                var newRow = _zaposleni.NewRow();

                newRow[0] = z.id;
                newRow[1] = z.maticniBroj;
                newRow[2] = z.ime;
                newRow[3] = z.prezime;
                newRow[4] = z.godineRadnogStaza;
                newRow[5] = z.datumZaposlenja.ToShortDateString();
                newRow[6] = z.datumRodjenja.ToShortDateString();
                newRow[7] = z.stepenStrucneSpreme;

                if (z.plata == null)
                    newRow[8] = string.Empty;
                else
                    newRow[8] = z.plata;

                newRow[9] = z.tipZaposlenog;
                newRow[10] = z.tipUgovora;

                if (z.datumIstekaUgovora == null)
                    newRow[11] = string.Empty;
                else
                    newRow[11] = z.datumIstekaUgovora.Value.ToShortDateString();

                _zaposleni.Rows.Add(newRow);
            }

            dgvZaposleni.DataSource = _zaposleni;

            //dgvKupac.Columns["IdKupac"].Width = 60;
            //dgvKupac.Columns["Ime"].Width = 60;
            //dgvKupac.Columns["Prezime"].Width = 70;
            //dgvKupac.Columns["Telefon"].Width = 80;
            //dgvKupac.Columns["TipLica"].Width = 60;
            //dgvKupac.Columns["PIB"].Width = 60;

            session.Close();
        }
    }
}

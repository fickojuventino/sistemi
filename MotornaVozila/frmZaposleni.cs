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

            dgvZaposleni.Columns["Id"].Width = 40;
            dgvZaposleni.Columns["Ime"].Width = 60;
            dgvZaposleni.Columns["Prezime"].Width = 70;
            dgvZaposleni.Columns["Plata"].Width = 60;
            dgvZaposleni.Columns["DatumIstekaUgovora"].Width = 115;
            dgvZaposleni.Columns["TipZaposlenog"].Width = 85;
            dgvZaposleni.Columns["TipUgovora"].Width = 80;

            session.Close();
        }

        private void dgvZaposleni_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvZaposleni.SelectedRows.Count <= 0 || dgvZaposleni.DataSource == null)
                return;
            else
            {
                txt_maticni_broj.Text = dgvZaposleni.SelectedRows[0].Cells[1].Value.ToString();
                txt_ime.Text = dgvZaposleni.SelectedRows[0].Cells[2].Value.ToString();
                txt_prezime.Text = dgvZaposleni.SelectedRows[0].Cells[3].Value.ToString();
                txt_god_rad_staza.Text = dgvZaposleni.SelectedRows[0].Cells[4].Value.ToString();
                dtp_datum_zaposlenja.Value = DateTime.Parse(dgvZaposleni.SelectedRows[0].Cells[5].Value.ToString());
                dtp_datum_rodjenja.Value = DateTime.Parse(dgvZaposleni.SelectedRows[0].Cells[6].Value.ToString());
                txt_stepen_str_spreme.Text = dgvZaposleni.SelectedRows[0].Cells[7].Value.ToString();
                txt_plata.Text = dgvZaposleni.SelectedRows[0].Cells[8].Value.ToString();
                cb_tip_zaposlenog.Text = dgvZaposleni.SelectedRows[0].Cells[9].Value.ToString();
                cb_tip_ugovora.Text = dgvZaposleni.SelectedRows[0].Cells[10].Value.ToString();

                if (!string.IsNullOrEmpty(dgvZaposleni.SelectedRows[0].Cells[11].Value.ToString()))
                    dtp_datum_isteka_ugovora.Value = DateTime.Parse(dgvZaposleni.SelectedRows[0].Cells[11].Value.ToString());
                else dtp_datum_isteka_ugovora.Value = DateTime.Now;
            }
        }

        private void btn_novi_Click(object sender, EventArgs e)
        {
            noviZaposleni = true;

            txt_god_rad_staza.Text = string.Empty;
            txt_ime.Text = string.Empty;
            txt_maticni_broj.Text = string.Empty;
            txt_plata.Text = string.Empty;
            txt_prezime.Text = string.Empty;
            txt_stepen_str_spreme.Text = string.Empty;
            dtp_datum_isteka_ugovora.Value = DateTime.Now;
            dtp_datum_rodjenja.Value = DateTime.Now;
            dtp_datum_zaposlenja.Value = DateTime.Now;
            cb_tip_ugovora.Text = cb_tip_ugovora.Items[0].ToString();
            cb_tip_zaposlenog.Text = cb_tip_zaposlenog.Items[0].ToString();
        }

        private void btn_obustavi_Click(object sender, EventArgs e)
        {
            noviZaposleni = false;
            dgvZaposleni_SelectionChanged( sender, e);
        }

        private void btn_sacuvaj_Click(object sender, EventArgs e)
        {
            try
            {
                if (noviZaposleni)
                {
                    ISession session = DataLayer.GetSession();

                    Zaposleni zaposleni = new Zaposleni();

                    zaposleni.maticniBroj = long.Parse(txt_maticni_broj.Text);
                    zaposleni.ime = txt_ime.Text;
                    zaposleni.prezime = txt_prezime.Text;
                    zaposleni.godineRadnogStaza = int.Parse(txt_god_rad_staza.Text);

                    if (cb_tip_ugovora.Text == "za stalno") zaposleni.datumIstekaUgovora = null;
                    else zaposleni.datumIstekaUgovora = dtp_datum_isteka_ugovora.Value;

                    zaposleni.datumRodjenja = dtp_datum_rodjenja.Value;
                    zaposleni.datumZaposlenja = dtp_datum_zaposlenja.Value;
                    zaposleni.tipUgovora = cb_tip_ugovora.Text;
                    zaposleni.tipZaposlenog = cb_tip_zaposlenog.Text;
                    zaposleni.plata = double.Parse(txt_plata.Text);
                    zaposleni.stepenStrucneSpreme = int.Parse(txt_stepen_str_spreme.Text);

                    session.Save(zaposleni);
                    session.Flush();
                    session.Close();

                    GetData();
                    noviZaposleni = false;
                }
                //azurira postojeceg kupca
                else
                {
                    ISession session = DataLayer.GetSession();
                    int id = int.Parse(dgvZaposleni.SelectedRows[0].Cells[0].Value.ToString());
                    Zaposleni zaposleni = session.Load<Zaposleni>(id);

                    zaposleni.maticniBroj = long.Parse(txt_maticni_broj.Text);
                    zaposleni.ime = txt_ime.Text;
                    zaposleni.prezime = txt_prezime.Text;
                    zaposleni.godineRadnogStaza = int.Parse(txt_god_rad_staza.Text);

                    if (cb_tip_ugovora.Text == "za stalno") zaposleni.datumIstekaUgovora = null;
                    else zaposleni.datumIstekaUgovora = dtp_datum_isteka_ugovora.Value;

                    zaposleni.datumRodjenja = dtp_datum_rodjenja.Value;
                    zaposleni.datumZaposlenja = dtp_datum_zaposlenja.Value;
                    zaposleni.tipUgovora = cb_tip_ugovora.Text;
                    zaposleni.tipZaposlenog = cb_tip_zaposlenog.Text;
                    zaposleni.plata = double.Parse(txt_plata.Text);
                    zaposleni.stepenStrucneSpreme = int.Parse(txt_stepen_str_spreme.Text);

                    session.SaveOrUpdate(zaposleni);

                    session.Flush();
                    session.Close();
                    GetData();
                }
            }
            catch (Exception catchException)
            {
                MessageBox.Show(catchException.Message + catchException.InnerException, "Exception", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_obrisi_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvZaposleni.Rows.Count <= 0 || dgvZaposleni.SelectedRows.Count <= 0)
                    return;

                var dr = MessageBox.Show("Da li ste sigurno da zelite da izbrisete kupca?", "Kupac",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dr == DialogResult.No)
                    return;

                ISession session = DataLayer.GetSession();

                int id = int.Parse(dgvZaposleni.SelectedRows[0].Cells[0].Value.ToString());

                var zaposleni = (from zap in session.Query<Zaposleni>()
                             where zap.id == id
                             select zap).SingleOrDefault();

                for (int i = zaposleni.servisiTehnicar.Count; i > 0; i--)
                {
                    zaposleni.servisiTehnicar[i - 1].odgovorniTehnicar = null;
                    session.Update(zaposleni.servisiTehnicar[i - 1]);
                    zaposleni.servisiTehnicar.RemoveAt(i - 1);
                }
                for (int i = zaposleni.servisiSef.Count; i > 0; i--)
                {
                    zaposleni.servisiSef[i - 1].sef = null;
                    session.Update(zaposleni.servisiSef[i - 1]);
                    zaposleni.servisiSef.RemoveAt(i - 1);
                }
                for (int i = zaposleni.saloniSef.Count; i > 0; i--)
                {
                    zaposleni.saloniSef[i - 1].sef = null;
                    session.Update(zaposleni.saloniSef[i - 1]);
                    zaposleni.saloniSef.RemoveAt(i - 1);
                }
                for (int i = zaposleni.saloniSef.Count; i > 0; i--)
                {
                    zaposleni.saloniSef[i - 1].sef = null;
                    session.Update(zaposleni.saloniSef[i - 1]);
                    zaposleni.saloniSef.RemoveAt(i - 1);
                }

                session.Delete(zaposleni);
                session.Flush();
                session.Close();

                GetData();
            }
            catch (Exception catchException)
            {
                MessageBox.Show(catchException.Message, "Exception", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}

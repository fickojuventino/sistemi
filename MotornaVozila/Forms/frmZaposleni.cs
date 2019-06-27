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

            cb_prikaz.SelectedIndex = 0;
            GetData("za stalno");
            dtp_datum_isteka_ugovora.Enabled = false;
        }

        private void GetData(string tipUgovora)
        {

            ISession session = DataLayer.GetSession();

            if (tipUgovora == "za stalno")
            {
                List<ZaStalno> zaposleni = (from z in session.Query<ZaStalno>()
                                      select z).ToList();

                
                _zaposleni = new DataTable();

                _zaposleni.Columns.Add("Id");
                _zaposleni.Columns.Add("MaticniBroj");
                _zaposleni.Columns.Add("Ime");
                _zaposleni.Columns.Add("Prezime");
                _zaposleni.Columns.Add("GodineRadnogStaza");
                _zaposleni.Columns.Add("DatumZaposlenja");
                _zaposleni.Columns.Add("DatumRodjenja");
                _zaposleni.Columns.Add("Stepen strucne spreme");
                _zaposleni.Columns.Add("TipZaposlenog");
                _zaposleni.Columns.Add("TipUgovora");
                _zaposleni.Columns.Add("Plata");

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
                    newRow[8] = z.tipZaposlenog;
                    newRow[9] = z.tipUgovora;
                    newRow[10] = z.plata;

                    _zaposleni.Rows.Add(newRow);
                }

                dgvZaposleni.DataSource = _zaposleni;
            }
            else
            {
                List<NaOdredjeno> zaposleni = (from z in session.Query<NaOdredjeno>()
                                            select z).ToList();

                _zaposleni = new DataTable();

                _zaposleni.Columns.Add("Id");
                _zaposleni.Columns.Add("MaticniBroj");
                _zaposleni.Columns.Add("Ime");
                _zaposleni.Columns.Add("Prezime");
                _zaposleni.Columns.Add("GodineRadnogStaza");
                _zaposleni.Columns.Add("DatumZaposlenja");
                _zaposleni.Columns.Add("DatumRodjenja");
                _zaposleni.Columns.Add("StepenStrucneSpreme");
                _zaposleni.Columns.Add("TipZaposlenog");
                _zaposleni.Columns.Add("TipUgovora");
                _zaposleni.Columns.Add("DatumIstekaUgovora");

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
                    newRow[8] = z.tipZaposlenog;
                    newRow[9] = z.tipUgovora;
                    newRow[10] = z.datumIstekaUgovora.ToShortDateString();

                    _zaposleni.Rows.Add(newRow);
                }

                dgvZaposleni.DataSource = _zaposleni;
            }

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
                cb_tip_zaposlenog.Text = dgvZaposleni.SelectedRows[0].Cells[8].Value.ToString();
                cb_tip_ugovora.Text = dgvZaposleni.SelectedRows[0].Cells[9].Value.ToString();

                if (cb_prikaz.Text == "za stalno")
                    txt_plata.Text = dgvZaposleni.SelectedRows[0].Cells[10].Value.ToString();
                else if (!string.IsNullOrEmpty(dgvZaposleni.SelectedRows[0].Cells[10].Value.ToString()))
                    dtp_datum_isteka_ugovora.Value = DateTime.Parse(dgvZaposleni.SelectedRows[0].Cells[10].Value.ToString());
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

                    switch(cb_tip_ugovora.Text)
                    {
                        case "za stalno":
                            {
                                ZaStalno zaposleni = new ZaStalno();

                                zaposleni.maticniBroj = long.Parse(txt_maticni_broj.Text);
                                zaposleni.ime = txt_ime.Text;
                                zaposleni.prezime = txt_prezime.Text;
                                zaposleni.godineRadnogStaza = int.Parse(txt_god_rad_staza.Text);
                                zaposleni.datumZaposlenja = dtp_datum_zaposlenja.Value;
                                zaposleni.datumRodjenja = dtp_datum_rodjenja.Value;
                                zaposleni.stepenStrucneSpreme = int.Parse(txt_stepen_str_spreme.Text);
                                zaposleni.tipZaposlenog = cb_tip_zaposlenog.Text;
                                zaposleni.tipUgovora = cb_tip_ugovora.Text;
                                zaposleni.plata = double.Parse(txt_plata.Text);

                                session.Save(zaposleni);
                                session.Flush();
                                session.Close();

                                GetData("za stalno");
                                noviZaposleni = false;

                                break;
                            }
                        case "na odredjeno":
                            {
                                NaOdredjeno zaposleni = new NaOdredjeno();

                                zaposleni.maticniBroj = long.Parse(txt_maticni_broj.Text);
                                zaposleni.ime = txt_ime.Text;
                                zaposleni.prezime = txt_prezime.Text;
                                zaposleni.godineRadnogStaza = int.Parse(txt_god_rad_staza.Text);
                                zaposleni.datumZaposlenja = dtp_datum_zaposlenja.Value;
                                zaposleni.datumRodjenja = dtp_datum_rodjenja.Value;
                                zaposleni.stepenStrucneSpreme = int.Parse(txt_stepen_str_spreme.Text);
                                zaposleni.tipZaposlenog = cb_tip_zaposlenog.Text;
                                zaposleni.tipUgovora = cb_tip_ugovora.Text;
                                zaposleni.datumIstekaUgovora = dtp_datum_isteka_ugovora.Value;

                                session.Save(zaposleni);
                                session.Flush();
                                session.Close();

                                GetData("na odredjeno");
                                noviZaposleni = false;
                                break;
                            }
                    }
                }
                //azurira postojeceg kupca
                else
                {
                    ISession session = DataLayer.GetSession();
                    int id = int.Parse(dgvZaposleni.SelectedRows[0].Cells[0].Value.ToString());

                    switch (cb_tip_ugovora.Text)
                    {
                        case "za stalno":
                            {
                                var zaposleni = session.Load<ZaStalno>(id);

                                zaposleni.maticniBroj = long.Parse(txt_maticni_broj.Text);
                                zaposleni.ime = txt_ime.Text;
                                zaposleni.prezime = txt_prezime.Text;
                                zaposleni.godineRadnogStaza = int.Parse(txt_god_rad_staza.Text);
                                zaposleni.datumZaposlenja = dtp_datum_zaposlenja.Value;
                                zaposleni.datumRodjenja = dtp_datum_rodjenja.Value;
                                zaposleni.stepenStrucneSpreme = int.Parse(txt_stepen_str_spreme.Text);
                                zaposleni.tipZaposlenog = cb_tip_zaposlenog.Text;
                                zaposleni.tipUgovora = cb_tip_ugovora.Text;
                                zaposleni.plata = double.Parse(txt_plata.Text);

                                session.SaveOrUpdate(zaposleni);
                                session.Flush();
                                session.Close();

                                GetData("za stalno");
                                noviZaposleni = false;

                                break;
                            }
                        case "na odredjeno":
                            {
                                var zaposleni = session.Load<NaOdredjeno>(id);

                                zaposleni.maticniBroj = long.Parse(txt_maticni_broj.Text);
                                zaposleni.ime = txt_ime.Text;
                                zaposleni.prezime = txt_prezime.Text;
                                zaposleni.godineRadnogStaza = int.Parse(txt_god_rad_staza.Text);
                                zaposleni.datumZaposlenja = dtp_datum_zaposlenja.Value;
                                zaposleni.datumRodjenja = dtp_datum_rodjenja.Value;
                                zaposleni.stepenStrucneSpreme = int.Parse(txt_stepen_str_spreme.Text);
                                zaposleni.tipZaposlenog = cb_tip_zaposlenog.Text;
                                zaposleni.tipUgovora = cb_tip_ugovora.Text;
                                zaposleni.datumIstekaUgovora = dtp_datum_isteka_ugovora.Value;

                                session.SaveOrUpdate(zaposleni);
                                session.Flush();
                                session.Close();

                                GetData("na odredjeno");
                                noviZaposleni = false;
                                break;
                            }
                    }
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

                var dr = MessageBox.Show("Da li ste sigurno da zelite da izbrisete zaposlenog?", "Zaposleni",
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

                GetData(cb_prikaz.Text);
            }
            catch (Exception catchException)
            {
                MessageBox.Show(catchException.Message, "Exception", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cb_prikaz_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cb_prikaz.Text == "za stalno")
            {
                GetData("za stalno");
                dtp_datum_isteka_ugovora.Enabled = false;
                dtp_datum_isteka_ugovora.Value = DateTime.Now;
                txt_plata.Enabled = true;
            }
            else
            {
                GetData("na odredjeno");
                txt_plata.Enabled = false;
                txt_plata.Text = string.Empty;
                dtp_datum_isteka_ugovora.Enabled = true;
            }
        }
    }
}

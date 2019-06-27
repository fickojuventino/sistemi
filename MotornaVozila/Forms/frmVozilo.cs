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
    public partial class frmVozilo : Form
    {
        private DataTable _vozila = new DataTable();
        private bool novoVozilo = false;

        public frmVozilo()
        {
            InitializeComponent();
        }

        private void frmVozilo_Load(object sender, EventArgs e)
        {
            dgvVozilo.AllowUserToAddRows = false;
            dgvVozilo.AllowUserToDeleteRows = false;
            dgvVozilo.AllowUserToOrderColumns = false;
            dgvVozilo.AllowUserToResizeRows = false;
            dgvVozilo.AllowUserToResizeColumns = false;
            dgvVozilo.ReadOnly = true;
            dgvVozilo.MultiSelect = false;
            dgvVozilo.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvVozilo.DataBindingComplete += delegate
            {
                foreach (DataGridViewColumn c in dgvVozilo.Columns)
                {
                    c.SortMode = DataGridViewColumnSortMode.NotSortable;
                }

                dgvVozilo.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
                dgvVozilo.RowHeadersVisible = false;
            };

            cb_prikaz.SelectedIndex = 0;
            GetData("putnicko");
            txt_nosivost.Enabled = false;
            txt_tip_prostora.Enabled = false;
        }

        private void GetData(string tipVozila)
        {
            if (tipVozila == "putnicko")
            {
                _vozila = new DataTable();

                _vozila.Columns.Add("IdVozilo");
                _vozila.Columns.Add("BrSasije");
                _vozila.Columns.Add("Boja");
                _vozila.Columns.Add("IdSalon");
                _vozila.Columns.Add("BrMotora");
                _vozila.Columns.Add("Gorivo");
                _vozila.Columns.Add("IdKupac");
                _vozila.Columns.Add("ModelVozila");
                _vozila.Columns.Add("IdServis");
                _vozila.Columns.Add("Kubikaza");
                _vozila.Columns.Add("DatumUvoza");                
                _vozila.Columns.Add("DatumKupovine");
                _vozila.Columns.Add("Poznato");
                _vozila.Columns.Add("OpisProblema");
                _vozila.Columns.Add("Ime");
                _vozila.Columns.Add("Prezime");
                _vozila.Columns.Add("Telefon");
                _vozila.Columns.Add("TipVozila");
                _vozila.Columns.Add("RegBr");
                _vozila.Columns.Add("GodProizvodnje");
                _vozila.Columns.Add("BrPutnika");

                ISession session = DataLayer.GetSession();

                var vozila = (from v in session.Query<Putnicko>()
                              select v).ToList();
                session.Close();

                foreach (var v in vozila)
                {
                    var newRow = _vozila.NewRow();

                    newRow[0] = v.id;
                    newRow[1] = v.brojSasije;
                    newRow[2] = v.boja;

                    if (v.salon == null)
                        newRow[3] = string.Empty;
                    else
                        newRow[3] = v.salon.idSalon;

                    newRow[4] = v.brojMotora;
                    newRow[5] = v.gorivo;

                    if (v.kupac == null)
                        newRow[6] = string.Empty;
                    else
                        newRow[6] = v.kupac.id;

                    newRow[7] = v.modelVozila;

                    if (v.servis == null)
                        newRow[8] = string.Empty;
                    else
                        newRow[8] = v.servis.id;

                    newRow[9] = v.kubikaza;

                    if (v.datumUvoza == null)
                        newRow[10] = string.Empty;
                    else
                        newRow[10] = v.datumUvoza.Value.ToShortDateString();                   

                    if (v.datumKupovine == null)
                        newRow[11] = string.Empty;
                    else
                        newRow[11] = v.datumKupovine.Value.ToShortDateString();

                    newRow[12] = v.poznato;
                    newRow[13] = v.opisProblema;
                    newRow[14] = v.ime;
                    newRow[15] = v.prezime;
                    newRow[16] = v.telefon;
                    newRow[17] = v.tipVozila;
                    newRow[18] = v.registarskiBroj;
                    newRow[19] = v.godinaProizvodnje;
                    newRow[20] = v.brojPutnika;

                    _vozila.Rows.Add(newRow);
                }

                dgvVozilo.DataSource = _vozila;               
            }
            else
            {
                _vozila = new DataTable();

                _vozila.Columns.Add("IdVozilo");
                _vozila.Columns.Add("BrSasije");
                _vozila.Columns.Add("Boja");
                _vozila.Columns.Add("IdSalon");
                _vozila.Columns.Add("BrMotora");
                _vozila.Columns.Add("Gorivo");
                _vozila.Columns.Add("IdKupac");
                _vozila.Columns.Add("ModelVozila");
                _vozila.Columns.Add("IdServis");
                _vozila.Columns.Add("Kubikaza");
                _vozila.Columns.Add("DatumUvoza");                
                _vozila.Columns.Add("DatumKupovine");
                _vozila.Columns.Add("Poznato");
                _vozila.Columns.Add("OpisProblema");
                _vozila.Columns.Add("Ime");
                _vozila.Columns.Add("Prezime");
                _vozila.Columns.Add("Telefon");
                _vozila.Columns.Add("TipVozila");
                _vozila.Columns.Add("RegBr");
                _vozila.Columns.Add("GodProizvodnje");
                _vozila.Columns.Add("Nosivost");
                _vozila.Columns.Add("TipProstora");

                ISession session = DataLayer.GetSession();

                var vozila = (from v in session.Query<Teretno>()
                              select v).ToList();
                session.Close();

                foreach (var v in vozila)
                {
                    var newRow = _vozila.NewRow();

                    newRow[0] = v.id;
                    newRow[1] = v.brojSasije;
                    newRow[2] = v.boja;

                    if (v.salon == null)
                        newRow[3] = string.Empty;
                    else
                        newRow[3] = v.salon.idSalon;

                    newRow[4] = v.brojMotora;
                    newRow[5] = v.gorivo;

                    if (v.kupac == null)
                        newRow[6] = string.Empty;
                    else
                        newRow[6] = v.kupac.id;

                    newRow[7] = v.modelVozila;

                    if (v.servis == null)
                        newRow[8] = string.Empty;
                    else
                        newRow[8] = v.servis.id;

                    newRow[9] = v.kubikaza;

                    if (v.datumUvoza == null)
                        newRow[10] = string.Empty;
                    else
                        newRow[10] = v.datumUvoza.Value.ToShortDateString();                    

                    if (v.datumKupovine == null)
                        newRow[11] = string.Empty;
                    else
                        newRow[11] = v.datumKupovine.Value.ToShortDateString();

                    newRow[12] = v.poznato;
                    newRow[13] = v.opisProblema;
                    newRow[14] = v.ime;
                    newRow[15] = v.prezime;
                    newRow[16] = v.telefon;
                    newRow[17] = v.tipVozila;
                    newRow[18] = v.registarskiBroj;
                    newRow[19] = v.godinaProizvodnje;
                    newRow[20] = v.nosivost;
                    newRow[21] = v.tipVozila;

                    _vozila.Rows.Add(newRow);
                }

                dgvVozilo.DataSource = _vozila;
            }
        }

        private void dgvVozilo_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvVozilo.SelectedRows.Count <= 0 || dgvVozilo.DataSource == null)
                return;
            else
            {
                txt_br_sasije.Text = dgvVozilo.SelectedRows[0].Cells[1].Value.ToString();
                txt_boja.Text = dgvVozilo.SelectedRows[0].Cells[2].Value.ToString();
                txt_id_salon.Text = dgvVozilo.SelectedRows[0].Cells[3].Value.ToString();
                txt_br_motora.Text = dgvVozilo.SelectedRows[0].Cells[4].Value.ToString();
                txt_gorivo.Text = dgvVozilo.SelectedRows[0].Cells[5].Value.ToString();
                txt_id_kupac.Text = dgvVozilo.SelectedRows[0].Cells[6].Value.ToString();
                txt_model_vozila.Text = dgvVozilo.SelectedRows[0].Cells[7].Value.ToString();
                txt_id_servis.Text = dgvVozilo.SelectedRows[0].Cells[8].Value.ToString();
                txt_kubikaza.Text = dgvVozilo.SelectedRows[0].Cells[9].Value.ToString();

                if (string.IsNullOrEmpty(dgvVozilo.SelectedRows[0].Cells[10].Value.ToString()))
                    dtp_datum_uvoza.Value = DateTime.Now;
                else
                    dtp_datum_uvoza.Value = DateTime.Parse(dgvVozilo.SelectedRows[0].Cells[10].Value.ToString());                

                if (string.IsNullOrEmpty(dgvVozilo.SelectedRows[0].Cells[11].Value.ToString()))
                    dtp_datum_kupovine.Value = DateTime.Now;
                else
                    dtp_datum_kupovine.Value = DateTime.Parse(dgvVozilo.SelectedRows[0].Cells[11].Value.ToString());  
                
                txt_poznato.Text = dgvVozilo.SelectedRows[0].Cells[12].Value.ToString();
                txt_opis_problema.Text = dgvVozilo.SelectedRows[0].Cells[13].Value.ToString();
                txt_ime.Text = dgvVozilo.SelectedRows[0].Cells[14].Value.ToString();
                txt_prezime.Text = dgvVozilo.SelectedRows[0].Cells[15].Value.ToString();
                txt_telefon.Text = dgvVozilo.SelectedRows[0].Cells[16].Value.ToString();
                txt_tip_vozila.Text = dgvVozilo.SelectedRows[0].Cells[17].Value.ToString();
                txt_registarski_broj.Text = dgvVozilo.SelectedRows[0].Cells[18].Value.ToString();
                txt_godina_proizvodnje.Text = dgvVozilo.SelectedRows[0].Cells[19].Value.ToString();

                if (cb_prikaz.Text == "putnicko")
                    txt_br_putnika.Text = dgvVozilo.SelectedRows[0].Cells[20].Value.ToString();
                else
                {
                    txt_tip_prostora.Text = dgvVozilo.SelectedRows[0].Cells[20].Value.ToString();
                    txt_nosivost.Text = dgvVozilo.SelectedRows[0].Cells[21].Value.ToString();
                }
            }
        }

        private void btn_obustavi_Click(object sender, EventArgs e)
        {
            novoVozilo = false;
            dgvVozilo_SelectionChanged(sender, e);
        }

        private void btn_novi_Click(object sender, EventArgs e)
        {
            novoVozilo = true;

            txt_br_sasije.Text = string.Empty;
            txt_boja.Text = string.Empty;
            txt_id_salon.Text = string.Empty;
            txt_br_motora.Text = string.Empty;
            txt_gorivo.Text = string.Empty;
            txt_id_kupac.Text = string.Empty;
            txt_model_vozila.Text = string.Empty;
            txt_id_servis.Text = string.Empty;
            txt_kubikaza.Text = string.Empty;
            dtp_datum_uvoza.Value = DateTime.Now;
            txt_br_putnika.Text = string.Empty;
            txt_tip_prostora.Text = string.Empty;
            txt_nosivost.Text = string.Empty;
            dtp_datum_kupovine.Value = DateTime.Now;
            txt_poznato.Text = string.Empty;
            txt_opis_problema.Text = string.Empty;
            txt_ime.Text = string.Empty;
            txt_prezime.Text = string.Empty;
            txt_telefon.Text = string.Empty;
            txt_tip_vozila.Text = string.Empty;
            txt_registarski_broj.Text = string.Empty;
            txt_godina_proizvodnje.Text = string.Empty;
        }

        private void btn_sacuvaj_Click(object sender, EventArgs e)
        {
            try
            {
                //kreira novog kupca
                if (novoVozilo)
                {
                    if(string.IsNullOrEmpty(txt_tip_vozila.Text))
                    {
                        MessageBox.Show("Polje Tip Vozila ne sme biti prazno!", "Upozorenje",
                                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }

                    ISession session = DataLayer.GetSession();

                    switch(cb_prikaz.Text)
                    {
                        case "putnicko":
                            {
                                Putnicko vozilo = new Putnicko();

                                vozilo.boja = txt_boja.Text;

                                if (string.IsNullOrEmpty(txt_br_motora.Text))
                                    vozilo.brojMotora = null;
                                else
                                    vozilo.brojMotora = Double.Parse(txt_br_motora.Text);
                                
                                    vozilo.brojPutnika = int.Parse(txt_br_putnika.Text);

                                if (string.IsNullOrEmpty(txt_br_sasije.Text))
                                    vozilo.brojSasije = null;
                                else
                                    vozilo.brojSasije = Double.Parse(txt_br_sasije.Text);

                                vozilo.datumKupovine = DateTime.Parse(dtp_datum_kupovine.Value.ToString());
                                vozilo.datumUvoza = DateTime.Parse(dtp_datum_uvoza.Value.ToString());

                                if (string.IsNullOrEmpty(txt_godina_proizvodnje.Text))
                                    vozilo.godinaProizvodnje = null;
                                else
                                    vozilo.godinaProizvodnje = int.Parse(txt_godina_proizvodnje.Text);

                                vozilo.gorivo = txt_gorivo.Text;
                                vozilo.ime = txt_ime.Text;
                                vozilo.prezime = txt_prezime.Text;

                                if (string.IsNullOrEmpty(txt_telefon.Text))
                                    vozilo.telefon = null;
                                else
                                    vozilo.telefon = long.Parse(txt_telefon.Text);

                                if (string.IsNullOrEmpty(txt_kubikaza.Text))
                                    vozilo.kubikaza = null;
                                else
                                    vozilo.kubikaza = float.Parse(txt_kubikaza.Text);

                                if (!string.IsNullOrEmpty(txt_id_kupac.Text))
                                {
                                    var kupac = (from kpc in session.Query<Kupac>()
                                                 where kpc.id == int.Parse(txt_id_kupac.Text)
                                                 select kpc).SingleOrDefault();
                                    vozilo.kupac = kupac;
                                }
                                else
                                    vozilo.kupac = null;

                                vozilo.modelVozila = txt_model_vozila.Text;
                                
                                vozilo.opisProblema = txt_opis_problema.Text;
                                vozilo.poznato = txt_poznato.Text;

                                if (string.IsNullOrEmpty(txt_registarski_broj.Text))
                                    vozilo.registarskiBroj = null;
                                else
                                    vozilo.registarskiBroj = long.Parse(txt_registarski_broj.Text);

                                if (!string.IsNullOrEmpty(txt_id_salon.Text))
                                {
                                    var salon = (from sln in session.Query<Salon>()
                                                 where sln.idSalon == int.Parse(txt_id_salon.Text)
                                                 select sln).SingleOrDefault();
                                    vozilo.salon = salon;
                                }
                                else
                                    vozilo.salon = null;

                                if (!string.IsNullOrEmpty(txt_id_servis.Text))
                                {
                                    var servis = (from srv in session.Query<Servis>()
                                                  where srv.id == int.Parse(txt_id_servis.Text)
                                                  select srv).SingleOrDefault();
                                    vozilo.servis = servis;
                                }
                                else
                                    vozilo.servis = null;

                                vozilo.tipVozila = txt_tip_vozila.Text;

                                session.Save(vozilo);
                                session.Flush();
                                session.Close();

                                GetData("putnicko");
                                novoVozilo = false;

                                break;
                            }
                        case "teretno":
                            {
                                Teretno vozilo = new Teretno();

                                vozilo.boja = txt_boja.Text;

                                if (string.IsNullOrEmpty(txt_br_motora.Text))
                                    vozilo.brojMotora = null;
                                else
                                    vozilo.brojMotora = Double.Parse(txt_br_motora.Text);
                                
                                if (string.IsNullOrEmpty(txt_br_sasije.Text))
                                    vozilo.brojSasije = null;
                                else
                                    vozilo.brojSasije = Double.Parse(txt_br_sasije.Text);

                                vozilo.datumKupovine = DateTime.Parse(dtp_datum_kupovine.Value.ToString());
                                vozilo.datumUvoza = DateTime.Parse(dtp_datum_uvoza.Value.ToString());

                                if (string.IsNullOrEmpty(txt_godina_proizvodnje.Text))
                                    vozilo.godinaProizvodnje = null;
                                else
                                    vozilo.godinaProizvodnje = int.Parse(txt_godina_proizvodnje.Text);

                                vozilo.gorivo = txt_gorivo.Text;
                                vozilo.ime = txt_ime.Text;
                                vozilo.prezime = txt_prezime.Text;

                                if (string.IsNullOrEmpty(txt_telefon.Text))
                                    vozilo.telefon = null;
                                else
                                    vozilo.telefon = long.Parse(txt_telefon.Text);

                                if (string.IsNullOrEmpty(txt_kubikaza.Text))
                                    vozilo.kubikaza = null;
                                else
                                    vozilo.kubikaza = float.Parse(txt_kubikaza.Text);

                                if (!string.IsNullOrEmpty(txt_id_kupac.Text))
                                {
                                    var kupac = (from kpc in session.Query<Kupac>()
                                                 where kpc.id == int.Parse(txt_id_kupac.Text)
                                                 select kpc).SingleOrDefault();
                                    vozilo.kupac = kupac;
                                }
                                else
                                    vozilo.kupac = null;

                                vozilo.modelVozila = txt_model_vozila.Text;
                                
                                vozilo.nosivost = Double.Parse(txt_nosivost.Text);

                                vozilo.opisProblema = txt_opis_problema.Text;
                                vozilo.poznato = txt_poznato.Text;

                                if (string.IsNullOrEmpty(txt_registarski_broj.Text))
                                    vozilo.registarskiBroj = null;
                                else
                                    vozilo.registarskiBroj = long.Parse(txt_registarski_broj.Text);

                                if (!string.IsNullOrEmpty(txt_id_salon.Text))
                                {
                                    var salon = (from sln in session.Query<Salon>()
                                                 where sln.idSalon == int.Parse(txt_id_salon.Text)
                                                 select sln).SingleOrDefault();
                                    vozilo.salon = salon;
                                }
                                else
                                    vozilo.salon = null;

                                if (!string.IsNullOrEmpty(txt_id_servis.Text))
                                {
                                    var servis = (from srv in session.Query<Servis>()
                                                  where srv.id == int.Parse(txt_id_servis.Text)
                                                  select srv).SingleOrDefault();
                                    vozilo.servis = servis;
                                }
                                else
                                    vozilo.servis = null;

                                vozilo.tipProstora = txt_tip_prostora.Text;
                                vozilo.tipVozila = txt_tip_vozila.Text;

                                session.Save(vozilo);
                                session.Flush();
                                session.Close();

                                GetData("teretno");
                                novoVozilo = false;
                                break;
                            }
                    }                    
                }
                //azurira postojeceg kupca
                else
                {                   

                    ISession session = DataLayer.GetSession();
                    int id = int.Parse(dgvVozilo.SelectedRows[0].Cells[0].Value.ToString());

                    switch(cb_prikaz.Text)
                    {
                        case "putnicko":
                            {
                                Putnicko vozilo = session.Load<Putnicko>(id);

                                vozilo.boja = txt_boja.Text;

                                if (string.IsNullOrEmpty(txt_br_motora.Text))
                                    vozilo.brojMotora = null;
                                else
                                    vozilo.brojMotora = Double.Parse(txt_br_motora.Text);

                                vozilo.brojPutnika = int.Parse(txt_br_putnika.Text);

                                if (string.IsNullOrEmpty(txt_br_sasije.Text))
                                    vozilo.brojSasije = null;
                                else
                                    vozilo.brojSasije = Double.Parse(txt_br_sasije.Text);

                                vozilo.datumKupovine = DateTime.Parse(dtp_datum_kupovine.Value.ToString());
                                vozilo.datumUvoza = DateTime.Parse(dtp_datum_uvoza.Value.ToString());

                                if (string.IsNullOrEmpty(txt_godina_proizvodnje.Text))
                                    vozilo.godinaProizvodnje = null;
                                else
                                    vozilo.godinaProizvodnje = int.Parse(txt_godina_proizvodnje.Text);

                                vozilo.gorivo = txt_gorivo.Text;
                                vozilo.ime = txt_ime.Text;
                                vozilo.prezime = txt_prezime.Text;

                                if (string.IsNullOrEmpty(txt_telefon.Text))
                                    vozilo.telefon = null;
                                else
                                    vozilo.telefon = long.Parse(txt_telefon.Text);

                                if (string.IsNullOrEmpty(txt_kubikaza.Text))
                                    vozilo.kubikaza = null;
                                else
                                    vozilo.kubikaza = float.Parse(txt_kubikaza.Text);

                                if (!string.IsNullOrEmpty(txt_id_kupac.Text))
                                {
                                    var kupac = (from kpc in session.Query<Kupac>()
                                                 where kpc.id == int.Parse(txt_id_kupac.Text)
                                                 select kpc).SingleOrDefault();
                                    vozilo.kupac = kupac;
                                }
                                else
                                    vozilo.kupac = null;

                                vozilo.modelVozila = txt_model_vozila.Text;

                                vozilo.opisProblema = txt_opis_problema.Text;
                                vozilo.poznato = txt_poznato.Text;

                                if (string.IsNullOrEmpty(txt_registarski_broj.Text))
                                    vozilo.registarskiBroj = null;
                                else
                                    vozilo.registarskiBroj = long.Parse(txt_registarski_broj.Text);

                                if (!string.IsNullOrEmpty(txt_id_salon.Text))
                                {
                                    var salon = (from sln in session.Query<Salon>()
                                                 where sln.idSalon == int.Parse(txt_id_salon.Text)
                                                 select sln).SingleOrDefault();
                                    vozilo.salon = salon;
                                }
                                else
                                    vozilo.salon = null;

                                if (!string.IsNullOrEmpty(txt_id_servis.Text))
                                {
                                    var servis = (from srv in session.Query<Servis>()
                                                  where srv.id == int.Parse(txt_id_servis.Text)
                                                  select srv).SingleOrDefault();
                                    vozilo.servis = servis;
                                }
                                else
                                    vozilo.servis = null;

                                vozilo.tipVozila = txt_tip_vozila.Text;

                                session.SaveOrUpdate(vozilo);
                                session.Flush();
                                session.Close();

                                GetData("putnicko");
                                novoVozilo = false;

                                break;
                            }
                        case "teretno":
                            {
                                Teretno vozilo = session.Load<Teretno>(id);

                                vozilo.boja = txt_boja.Text;

                                if (string.IsNullOrEmpty(txt_br_motora.Text))
                                    vozilo.brojMotora = null;
                                else
                                    vozilo.brojMotora = Double.Parse(txt_br_motora.Text);

                                if (string.IsNullOrEmpty(txt_br_sasije.Text))
                                    vozilo.brojSasije = null;
                                else
                                    vozilo.brojSasije = Double.Parse(txt_br_sasije.Text);

                                vozilo.datumKupovine = DateTime.Parse(dtp_datum_kupovine.Value.ToString());
                                vozilo.datumUvoza = DateTime.Parse(dtp_datum_uvoza.Value.ToString());

                                if (string.IsNullOrEmpty(txt_godina_proizvodnje.Text))
                                    vozilo.godinaProizvodnje = null;
                                else
                                    vozilo.godinaProizvodnje = int.Parse(txt_godina_proizvodnje.Text);

                                vozilo.gorivo = txt_gorivo.Text;
                                vozilo.ime = txt_ime.Text;
                                vozilo.prezime = txt_prezime.Text;

                                if (string.IsNullOrEmpty(txt_telefon.Text))
                                    vozilo.telefon = null;
                                else
                                    vozilo.telefon = long.Parse(txt_telefon.Text);

                                if (string.IsNullOrEmpty(txt_kubikaza.Text))
                                    vozilo.kubikaza = null;
                                else
                                    vozilo.kubikaza = float.Parse(txt_kubikaza.Text);

                                if (!string.IsNullOrEmpty(txt_id_kupac.Text))
                                {
                                    var kupac = (from kpc in session.Query<Kupac>()
                                                 where kpc.id == int.Parse(txt_id_kupac.Text)
                                                 select kpc).SingleOrDefault();
                                    vozilo.kupac = kupac;
                                }
                                else
                                    vozilo.kupac = null;

                                vozilo.modelVozila = txt_model_vozila.Text;

                                vozilo.nosivost = Double.Parse(txt_nosivost.Text);

                                vozilo.opisProblema = txt_opis_problema.Text;
                                vozilo.poznato = txt_poznato.Text;

                                if (string.IsNullOrEmpty(txt_registarski_broj.Text))
                                    vozilo.registarskiBroj = null;
                                else
                                    vozilo.registarskiBroj = long.Parse(txt_registarski_broj.Text);

                                if (!string.IsNullOrEmpty(txt_id_salon.Text))
                                {
                                    var salon = (from sln in session.Query<Salon>()
                                                 where sln.idSalon == int.Parse(txt_id_salon.Text)
                                                 select sln).SingleOrDefault();
                                    vozilo.salon = salon;
                                }
                                else
                                    vozilo.salon = null;

                                if (!string.IsNullOrEmpty(txt_id_servis.Text))
                                {
                                    var servis = (from srv in session.Query<Servis>()
                                                  where srv.id == int.Parse(txt_id_servis.Text)
                                                  select srv).SingleOrDefault();
                                    vozilo.servis = servis;
                                }
                                else
                                    vozilo.servis = null;

                                vozilo.tipProstora = txt_tip_prostora.Text;
                                vozilo.tipVozila = txt_tip_vozila.Text;

                                session.SaveOrUpdate(vozilo);
                                session.Flush();
                                session.Close();

                                GetData("teretno");
                                novoVozilo = false;
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
                if (dgvVozilo.Rows.Count <= 0 || dgvVozilo.SelectedRows.Count <= 0)
                    return;

                var dr = MessageBox.Show("Da li ste sigurno da zelite da izbrisete vozilo?", "Vozilo",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dr == DialogResult.No)
                    return;

                ISession session = DataLayer.GetSession();

                int id = int.Parse(dgvVozilo.SelectedRows[0].Cells[0].Value.ToString());

                var vozilo = (from v in session.Query<Vozilo>()
                             where v.id == id
                             select v).SingleOrDefault();

                session.Delete(vozilo);
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
            if (cb_prikaz.Text == "putnicko")
            {
                GetData("putnicko");
                txt_nosivost.Enabled = false;
                txt_tip_prostora.Enabled = false;
                txt_nosivost.Text = string.Empty;
                txt_tip_prostora.Text = string.Empty;
                txt_br_putnika.Enabled = true;
            }
            else
            {
                GetData("teretno");
                txt_br_putnika.Enabled = false;
                txt_br_putnika.Text = string.Empty;
                txt_nosivost.Enabled = true;
                txt_tip_prostora.Enabled = true;
            }
        }
    }
}

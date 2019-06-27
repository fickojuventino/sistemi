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
    public partial class frmServisi : Form
    {
        private DataTable _servisi = new DataTable();
        private bool noviServis = false;

        public frmServisi()
        {
            InitializeComponent();
        }

        private void frmServisi_Load(object sender, EventArgs e)
        {
            dgvServisi.AllowUserToAddRows = false;
            dgvServisi.AllowUserToDeleteRows = false;
            dgvServisi.AllowUserToOrderColumns = false;
            dgvServisi.AllowUserToResizeRows = false;
            dgvServisi.AllowUserToResizeColumns = false;
            dgvServisi.ReadOnly = true;
            dgvServisi.MultiSelect = false;
            dgvServisi.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvServisi.DataBindingComplete += delegate
            {
                foreach (DataGridViewColumn c in dgvServisi.Columns)
                {
                    c.SortMode = DataGridViewColumnSortMode.NotSortable;
                }

                dgvServisi.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
                dgvServisi.RowHeadersVisible = false;
            };

                GetData();
        }

        private void GetData()
        {
            _servisi = new DataTable();

            _servisi.Columns.Add("IdServis");
            _servisi.Columns.Add("DatumPrijema");
            _servisi.Columns.Add("IdSef");
            _servisi.Columns.Add("IdSalon");
            _servisi.Columns.Add("DatumZavrsetka");
            _servisi.Columns.Add("TipUsluge");
            _servisi.Columns.Add("IdTehnicar");

            ISession session = DataLayer.GetSession();

            var servisi = (from srvs in session.Query<Servis>()
                           select srvs).ToList();

            foreach (var srvs in servisi)
            {
                var newRow = _servisi.NewRow();
    
                newRow[0] = srvs.id;
                newRow[1] = srvs.datumPrijema;
                newRow[2] = srvs.sef.id;
                newRow[3] = srvs.salon.idSalon;
                newRow[4] = srvs.datumZavrsetka;
                newRow[5] = srvs.GetType().ToString().Split('.')[2].ToLower();
                newRow[6] = srvs.odgovorniTehnicar.id;

                _servisi.Rows.Add(newRow);
            }

            dgvServisi.DataSource = _servisi;
            dgvServisi.Columns["IdServis"].Width = 50;
            dgvServisi.Columns["IdSef"].Width = 40;
            dgvServisi.Columns["IdTehnicar"].Width = 60;
            dgvServisi.Columns["IdSalon"].Width = 50;
            dgvServisi.Columns["DatumZavrsetka"].Width = 130;
            dgvServisi.Columns["DatumPrijema"].Width = 130;

            txt_tip_usluge.Enabled = false;

            session.Close();
        }

        private void dgvServisi_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvServisi.SelectedRows.Count <= 0 || dgvServisi.DataSource == null)
                return;
            else
            {
                txt_tip_usluge.Enabled = false;
                dtp_datum_prijema.Value = DateTime.Parse(dgvServisi.SelectedRows[0].Cells[1].Value.ToString());
                dtp_datum_zavrsetka.Value = DateTime.Parse(dgvServisi.SelectedRows[0].Cells[4].Value.ToString());
                txt_id_sef.Text = dgvServisi.SelectedRows[0].Cells[2].Value.ToString();
                txt_id_salon.Text = dgvServisi.SelectedRows[0].Cells[3].Value.ToString();
                txt_id_tehnicar.Text = dgvServisi.SelectedRows[0].Cells[6].Value.ToString();
                txt_tip_usluge.Text = dgvServisi.SelectedRows[0].Cells[5].Value.ToString();
            }
        }

        private void btn_novi_Click(object sender, EventArgs e)
        {
            noviServis = true;
            txt_tip_usluge.Enabled = true;
            dtp_datum_prijema.Value = DateTime.Now;
            dtp_datum_zavrsetka.Value = DateTime.Now;
            txt_id_sef.Text = string.Empty;
            txt_id_salon.Text = string.Empty;
            txt_id_tehnicar.Text = string.Empty;
            txt_tip_usluge.Text = string.Empty;
            txt_id_sef.Focus();
        }

        private void btn_obustavi_Click(object sender, EventArgs e)
        {
            noviServis = false;
            dgvServisi_SelectionChanged(sender, e);
        }

        private void btn_sacuvaj_Click(object sender, EventArgs e)
        {
            try
            {
                //doda novi servis
                if (noviServis)
                {
                    if(string.IsNullOrEmpty(txt_id_sef.Text) || string.IsNullOrEmpty(txt_tip_usluge.Text) ||
                        string.IsNullOrEmpty(txt_id_tehnicar.Text))
                    {
                        MessageBox.Show("Polja Id Sefa, Tip Usluge i Id Tehnicara ne smeju biti parzna!", "Upozorenje",
                             MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }

                    ISession session = DataLayer.GetSession();

                    //Servis servis = new Servis();

                    DateTime datum_prijema = DateTime.Parse(dtp_datum_prijema.Text);
                    DateTime datum_zavrsetka = DateTime.Parse(dtp_datum_zavrsetka.Text);

                    switch (txt_tip_usluge.Text.ToLower())
                    {
                        case "mehanicarska":
                            Mehanicarska meh = new Mehanicarska();
                            meh.datumPrijema = datum_prijema;

                            if (DateTime.Compare(datum_prijema, datum_zavrsetka) <= 0)
                                meh.datumZavrsetka = datum_zavrsetka;
                            else
                            {
                                MessageBox.Show("Datum prijema ne moze biti veci od dana zavrsetka", "Upozorenje", MessageBoxButtons.OK,
                                     MessageBoxIcon.Warning);
                                return;
                            }

                            var srvs_tehnicar = (from teh in session.Query<Zaposleni>()
                                                 where teh.id == int.Parse(txt_id_tehnicar.Text)
                                                 select teh).SingleOrDefault();
                            meh.odgovorniTehnicar = srvs_tehnicar;

                            var srvs_sef = (from sef in session.Query<Zaposleni>()
                                            where sef.id == int.Parse(txt_id_sef.Text)
                                            select sef).SingleOrDefault();
                            meh.sef = srvs_sef;

                            var srvs_salon = (from sln in session.Query<Salon>()
                                              where sln.idSalon == int.Parse(txt_id_salon.Text)
                                              select sln).SingleOrDefault();
                            meh.salon = srvs_salon;
                            session.SaveOrUpdate(meh);
                            break;
                        case "farbarska":
                            Farbarska far = new Farbarska();
                            far.datumPrijema = datum_prijema;

                            if (DateTime.Compare(datum_prijema, datum_zavrsetka) <= 0)
                                far.datumZavrsetka = datum_zavrsetka;
                            else
                            {
                                MessageBox.Show("Datum prijema ne moze biti veci od dana zavrsetka", "Upozorenje", MessageBoxButtons.OK,
                                     MessageBoxIcon.Warning);
                                return;
                            }

                            var srv_tehnicar = (from teh in session.Query<Zaposleni>()
                                                 where teh.id == int.Parse(txt_id_tehnicar.Text)
                                                 select teh).SingleOrDefault();
                            far.odgovorniTehnicar = srv_tehnicar;

                            var srv_sef = (from sef in session.Query<Zaposleni>()
                                            where sef.id == int.Parse(txt_id_sef.Text)
                                            select sef).SingleOrDefault();
                            far.sef = srv_sef;

                            var srv_salon = (from sln in session.Query<Salon>()
                                              where sln.idSalon == int.Parse(txt_id_salon.Text)
                                              select sln).SingleOrDefault();
                            far.salon = srv_salon;
                            session.SaveOrUpdate(far);
                            break;
                        case "vulkanizerska":
                            Vulkanizerska vul = new Vulkanizerska();
                            vul.datumPrijema = datum_prijema;

                            if (DateTime.Compare(datum_prijema, datum_zavrsetka) <= 0)
                                vul.datumZavrsetka = datum_zavrsetka;
                            else
                            {
                                MessageBox.Show("Datum prijema ne moze biti veci od dana zavrsetka", "Upozorenje", MessageBoxButtons.OK,
                                     MessageBoxIcon.Warning);
                                return;
                            }

                            var svs_tehnicar = (from teh in session.Query<Zaposleni>()
                                                 where teh.id == int.Parse(txt_id_tehnicar.Text)
                                                 select teh).SingleOrDefault();
                            vul.odgovorniTehnicar = svs_tehnicar;

                            var svs_sef = (from sef in session.Query<Zaposleni>()
                                            where sef.id == int.Parse(txt_id_sef.Text)
                                            select sef).SingleOrDefault();
                            vul.sef = svs_sef;

                            var svs_salon = (from sln in session.Query<Salon>()
                                              where sln.idSalon == int.Parse(txt_id_salon.Text)
                                              select sln).SingleOrDefault();
                            vul.salon = svs_salon;
                            session.SaveOrUpdate(vul);
                            break;
                        default:
                            break;
                    }

                    session.Flush();
                    session.Close();
                    GetData();
                    noviServis = false;
                }
                //azurira postojeci servis
                else
                {
                    if (string.IsNullOrEmpty(txt_id_sef.Text) || string.IsNullOrEmpty(txt_tip_usluge.Text) ||
                        string.IsNullOrEmpty(txt_id_tehnicar.Text))
                    {
                        MessageBox.Show("Polja Id Sefa, Tip Usluge i Id Tehnicara ne smeju biti parzna!", "Upozorenje",
                             MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }

                    ISession session = DataLayer.GetSession();
                    var servis = session.Load<Servis>(int.Parse(dgvServisi.SelectedRows[0].Cells[0].Value.ToString()));

                    DateTime datum_prijema = DateTime.Parse(dtp_datum_prijema.Text);
                    DateTime datum_zavrsetka = DateTime.Parse(dtp_datum_zavrsetka.Text);

                    servis.datumPrijema = datum_prijema;

                    if (DateTime.Compare(datum_prijema, datum_zavrsetka) <= 0)
                        servis.datumZavrsetka = datum_zavrsetka;
                    else
                    {
                        MessageBox.Show("Datum prijema ne moze biti veci od dana zavrsetka", "Upozorenje", MessageBoxButtons.OK,
                             MessageBoxIcon.Warning);
                        return;
                    }

                    // servis.tipuUsluge = txt_tip_usluge.Text;

                    var srvs_tehnicar = (from teh in session.Query<Zaposleni>()
                                         where teh.id == int.Parse(txt_id_tehnicar.Text)
                                         select teh).SingleOrDefault();
                    servis.odgovorniTehnicar = srvs_tehnicar;

                    var srvs_sef = (from sef in session.Query<Zaposleni>()
                                    where sef.id == int.Parse(txt_id_sef.Text)
                                    select sef).SingleOrDefault();
                    servis.sef = srvs_sef;

                    var srvs_salon = (from sln in session.Query<Salon>()
                                      where sln.idSalon == int.Parse(txt_id_salon.Text)
                                      select sln).SingleOrDefault();
                    servis.salon = srvs_salon;                   

                    session.SaveOrUpdate(servis);

                    session.Flush();
                    session.Close();
                    GetData();
                }
            }
            catch(Exception catchException)
            {
                MessageBox.Show(catchException.Message, "Exception", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_obrisi_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvServisi.Rows.Count <= 0 || dgvServisi.SelectedRows.Count <= 0)
                    return;

                var dr = MessageBox.Show("Da li ste sigurno da zelite da izbrisete servis?", "Servis",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dr == DialogResult.No)
                    return;

                ISession session = DataLayer.GetSession();
                var servis = (from srvs in session.Query<Servis>()
                              where srvs.id == int.Parse(dgvServisi.SelectedRows[0].Cells[0].Value.ToString())
                              select srvs).SingleOrDefault();

                for (int i = servis.servisiranaVozila.Count; i > 0; i--)
                {
                    servis.servisiranaVozila[i - 1].servis = null;
                    session.Update(servis.servisiranaVozila[i - 1]);
                    servis.servisiranaVozila.RemoveAt(i - 1);
                }

                session.Delete(servis);
                session.Flush();
                session.Close();
                GetData();
            }
            catch(Exception catchException)
            {
                MessageBox.Show(catchException.Message, "Exception", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}

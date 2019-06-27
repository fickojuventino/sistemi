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
    public partial class frmNezavisniEkonomista : Form
    {
        private DataTable _nezavisni_ekonomista = new DataTable();
        private bool noviEkonomista = false;

        public frmNezavisniEkonomista()
        {
            InitializeComponent();
        }

        private void frmNezavisniEkonomista_Load(object sender, EventArgs e)
        {
            dgvNezavisniEkonomista.AllowUserToAddRows = false;
            dgvNezavisniEkonomista.AllowUserToDeleteRows = false;
            dgvNezavisniEkonomista.AllowUserToOrderColumns = false;
            dgvNezavisniEkonomista.AllowUserToResizeRows = false;
            dgvNezavisniEkonomista.AllowUserToResizeColumns = false;
            dgvNezavisniEkonomista.ReadOnly = true;
            dgvNezavisniEkonomista.MultiSelect = false;
            dgvNezavisniEkonomista.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvNezavisniEkonomista.DataBindingComplete += delegate
            {
                foreach (DataGridViewColumn c in dgvNezavisniEkonomista.Columns)
                {
                    c.SortMode = DataGridViewColumnSortMode.NotSortable;
                }

                dgvNezavisniEkonomista.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
                dgvNezavisniEkonomista.RowHeadersVisible = false;
            };

            GetData();
        }

        private void GetData()
        {
            _nezavisni_ekonomista = new DataTable();

            _nezavisni_ekonomista.Columns.Add("Id");
            _nezavisni_ekonomista.Columns.Add("Ime");
            _nezavisni_ekonomista.Columns.Add("Prezime");
            _nezavisni_ekonomista.Columns.Add("MatBr");
            _nezavisni_ekonomista.Columns.Add("Telefon");
            _nezavisni_ekonomista.Columns.Add("Grad");
            _nezavisni_ekonomista.Columns.Add("Adresa");

            ISession session = DataLayer.GetSession();

            var ekonomisti = (from eko in session.Query<NezavisniEkonomista>()
                         select eko).ToList();

            foreach (var eko in ekonomisti)
            {
                var newRow = _nezavisni_ekonomista.NewRow();

                newRow[0] = eko.id;
                newRow[1] = eko.ime;
                newRow[2] = eko.prezime;
                newRow[3] = eko.maticniBroj;
                newRow[4] = eko.telefon;
                newRow[5] = eko.grad;
                newRow[6] = eko.adresa;

                _nezavisni_ekonomista.Rows.Add(newRow);
            }

            dgvNezavisniEkonomista.DataSource = _nezavisni_ekonomista;

            dgvNezavisniEkonomista.Columns["Id"].Width = 40;
            dgvNezavisniEkonomista.Columns["Ime"].Width = 60;
            dgvNezavisniEkonomista.Columns["Prezime"].Width = 70;
            dgvNezavisniEkonomista.Columns["Telefon"].Width = 80;
            dgvNezavisniEkonomista.Columns["Grad"].Width = 70;
            dgvNezavisniEkonomista.Columns["Adresa"].Width = 120;

            session.Close();
        }

        private void dgvNezavisniEkonomista_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvNezavisniEkonomista.SelectedRows.Count <= 0 || dgvNezavisniEkonomista.DataSource == null)
                return;
            else
            {
                txt_ime.Text = dgvNezavisniEkonomista.SelectedRows[0].Cells[1].Value.ToString();
                txt_prezime.Text = dgvNezavisniEkonomista.SelectedRows[0].Cells[2].Value.ToString();
                txt_maticni_broj.Text = dgvNezavisniEkonomista.SelectedRows[0].Cells[3].Value.ToString();
                txt_telefon.Text = dgvNezavisniEkonomista.SelectedRows[0].Cells[4].Value.ToString();
                txt_grad.Text = dgvNezavisniEkonomista.SelectedRows[0].Cells[5].Value.ToString();
                txt_adresa.Text = dgvNezavisniEkonomista.SelectedRows[0].Cells[6].Value.ToString();
            }
        }

        private void btn_novi_Click(object sender, EventArgs e)
        {
            noviEkonomista = true;

            txt_ime.Text = string.Empty;
            txt_prezime.Text = string.Empty;
            txt_maticni_broj.Text = string.Empty;
            txt_telefon.Text = string.Empty;            
            txt_grad.Text = string.Empty;
            txt_adresa.Text = string.Empty;
            txt_ime.Focus();
        }

        private void btn_obustavi_Click(object sender, EventArgs e)
        {
            noviEkonomista = false;
            dgvNezavisniEkonomista_SelectionChanged(sender, e);
        }

        private void btn_sacuvaj_Click(object sender, EventArgs e)
        {
            try
            {
                //kreira novog kupca
                if (noviEkonomista)
                {
                    if (string.IsNullOrEmpty(txt_ime.Text) || string.IsNullOrEmpty(txt_prezime.Text) ||
                        string.IsNullOrEmpty(txt_grad.Text) || string.IsNullOrEmpty(txt_adresa.Text))
                    {
                        MessageBox.Show("Polja Ime, Prezime, Grad i Adresa ne smeju biti prazna!", "Upozorenje",
                             MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }

                    ISession session = DataLayer.GetSession();

                    NezavisniEkonomista ekonomista = new NezavisniEkonomista();

                    ekonomista.ime = txt_ime.Text;
                    ekonomista.prezime = txt_prezime.Text;

                    if (string.IsNullOrEmpty(txt_maticni_broj.Text))
                        ekonomista.maticniBroj = null;
                    else
                        ekonomista.maticniBroj = long.Parse(txt_maticni_broj.Text);

                    if (string.IsNullOrEmpty(txt_telefon.Text))
                        ekonomista.telefon = null;
                    else
                        ekonomista.telefon = long.Parse(txt_telefon.Text);

                    ekonomista.grad = txt_grad.Text;
                    ekonomista.adresa = txt_adresa.Text;

                    session.Save(ekonomista);
                    session.Flush();
                    session.Close();

                    GetData();
                    noviEkonomista = false;
                }
                //azurira postojeceg kupca
                else
                {
                    if (string.IsNullOrEmpty(txt_ime.Text) || string.IsNullOrEmpty(txt_prezime.Text) ||
                        string.IsNullOrEmpty(txt_grad.Text) || string.IsNullOrEmpty(txt_adresa.Text))
                    {
                        MessageBox.Show("Polja Ime, Prezime, Grad i Adresa ne smeju biti prazna!", "Upozorenje",
                             MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }

                    ISession session = DataLayer.GetSession();

                    int id = int.Parse(dgvNezavisniEkonomista.SelectedRows[0].Cells[0].Value.ToString());

                    NezavisniEkonomista ekonomista = session.Load<NezavisniEkonomista>(id);

                    ekonomista.ime = txt_ime.Text;
                    ekonomista.prezime = txt_prezime.Text;

                    if (string.IsNullOrEmpty(txt_maticni_broj.Text))
                        ekonomista.maticniBroj = null;
                    else
                        ekonomista.maticniBroj = long.Parse(txt_maticni_broj.Text);

                    if (string.IsNullOrEmpty(txt_telefon.Text))
                        ekonomista.telefon = null;
                    else
                    ekonomista.telefon = long.Parse(txt_telefon.Text);

                    ekonomista.grad = txt_grad.Text;
                    ekonomista.adresa = txt_adresa.Text;

                    session.SaveOrUpdate(ekonomista);

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
                if (dgvNezavisniEkonomista.Rows.Count <= 0 || dgvNezavisniEkonomista.SelectedRows.Count <= 0)
                    return;

                var dr = MessageBox.Show("Da li ste sigurno da zelite da izbrisete nezavisnog ekonomistu?", "Ekonomista",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dr == DialogResult.No)
                    return;

                ISession session = DataLayer.GetSession();

                int id = int.Parse(dgvNezavisniEkonomista.SelectedRows[0].Cells[0].Value.ToString());

                var ekonomista = (from eko in session.Query<NezavisniEkonomista>()
                                  where eko.id == id
                                  select eko).SingleOrDefault();
                
                session.Delete(ekonomista);
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

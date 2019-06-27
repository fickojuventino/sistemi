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
    public partial class frmSalon : Form
    {
        private DataTable _saloni = new DataTable();
        private bool noviSalon = false;

        public frmSalon()
        {
            InitializeComponent();
        }

        private void frmSalon_Load(object sender, EventArgs e)
        {
            dgvSalon.AllowUserToAddRows = false;
            dgvSalon.AllowUserToDeleteRows = false;
            dgvSalon.AllowUserToOrderColumns = false;
            dgvSalon.AllowUserToResizeRows = false;
            dgvSalon.AllowUserToResizeColumns = false;
            dgvSalon.ReadOnly = true;
            dgvSalon.MultiSelect = false;
            dgvSalon.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvSalon.DataBindingComplete += delegate
            {
                foreach (DataGridViewColumn c in dgvSalon.Columns)
                {
                    c.SortMode = DataGridViewColumnSortMode.NotSortable;
                }

                dgvSalon.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
                dgvSalon.RowHeadersVisible = false;
            };

            GetData();
        }

        private void GetData()
        {
            _saloni = new DataTable();

            _saloni.Columns.Add("IdSalon");
            _saloni.Columns.Add("Grad");
            _saloni.Columns.Add("Adresa");
            _saloni.Columns.Add("IdZaposleni");
            _saloni.Columns.Add("StpnOpremljenosti");

            ISession session = DataLayer.GetSession();

            var saloni = (from sln in session.Query<Salon>()
                           select sln).ToList();

            foreach (var sln in saloni)
            {
                var newRow = _saloni.NewRow();

                newRow[0] = sln.idSalon;
                newRow[1] = sln.grad;
                newRow[2] = sln.adresa;
                if (sln.sef != null)
                    newRow[3] = sln.sef.id;
                else
                    newRow[3] = string.Empty;
                newRow[4] = sln.stepenOpremljenosti;

                _saloni.Rows.Add(newRow);
            }

            dgvSalon.DataSource = _saloni;

            dgvSalon.Columns["IdSalon"].Width = 50;
            dgvSalon.Columns["Grad"].Width = 80;
            dgvSalon.Columns["IdZaposleni"].Width = 70;
            dgvSalon.Columns["Adresa"].Width = 140;
            dgvSalon.Columns["StpnOpremljenosti"].Width = 100;
            //dgvServisi.Columns["DatumPrijema"].Width = 130;

            session.Close();
        }

        private void dgvSalon_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvSalon.SelectedRows.Count <= 0 || dgvSalon.DataSource == null)
                return;
            else
            {
                txt_grad.Text = dgvSalon.SelectedRows[0].Cells[1].Value.ToString();
                txt_adresa.Text = dgvSalon.SelectedRows[0].Cells[2].Value.ToString();
                txt_id_zaposleni.Text = dgvSalon.SelectedRows[0].Cells[3].Value.ToString();
                txt_stepen_opremljenosti.Text = dgvSalon.SelectedRows[0].Cells[4].Value.ToString();
            }
        }

        private void btn_novi_Click(object sender, EventArgs e)
        {
            noviSalon = true;

            txt_grad.Text = string.Empty;
            txt_adresa.Text = string.Empty;
            txt_id_zaposleni.Text = string.Empty;
            txt_stepen_opremljenosti.Text = string.Empty;
            txt_grad.Focus();
        }

        private void btn_otkazi_Click(object sender, EventArgs e)
        {
            noviSalon = false;
            dgvSalon_SelectionChanged(sender, e);
        }

        private void btn_sacuvaj_Click(object sender, EventArgs e)
        {
            try
            {
                //doda novi salon
                if (noviSalon)
                {
                    if (string.IsNullOrEmpty(txt_grad.Text) || string.IsNullOrEmpty(txt_adresa.Text) ||
                        string.IsNullOrEmpty(txt_stepen_opremljenosti.Text))
                    {
                        MessageBox.Show("Polja ne smeju biti parzna!", "Upozorenje",
                             MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }

                    ISession session = DataLayer.GetSession();

                    Zaposleni sef_salona;
                    if (!string.IsNullOrEmpty(txt_id_zaposleni.Text))
                        sef_salona = (from ss in session.Query<Zaposleni>()
                                      where ss.id == int.Parse(txt_id_zaposleni.Text)
                                      select ss).SingleOrDefault();
                    else
                        sef_salona = null;

                    Salon salon = new Salon()
                    {
                        grad = txt_grad.Text,
                        adresa = txt_adresa.Text,
                        sef = sef_salona,
                        stepenOpremljenosti = float.Parse(txt_stepen_opremljenosti.Text)
                    };

                    sef_salona.saloniSef.Add(salon);
                    
                    session.Save(salon);

                    session.Flush();
                    session.Close();

                    GetData();
                    noviSalon = false;
                }
                //azurira postojeci
                else
                {
                    if (string.IsNullOrEmpty(txt_grad.Text) || string.IsNullOrEmpty(txt_adresa.Text) ||
                        string.IsNullOrEmpty(txt_stepen_opremljenosti.Text))
                    {
                        MessageBox.Show("Polja ne smeju biti parzna!", "Upozorenje",
                             MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }

                    int id = int.Parse(dgvSalon.SelectedRows[0].Cells[0].Value.ToString());

                    ISession session = DataLayer.GetSession();

                    Zaposleni sef_salona;
                    if (!string.IsNullOrEmpty(txt_id_zaposleni.Text))
                        sef_salona = (from ss in session.Query<Zaposleni>()
                                      where ss.id == int.Parse(txt_id_zaposleni.Text)
                                      select ss).SingleOrDefault();
                    else
                        sef_salona = null;

                    var salon = session.Load<Salon>(id);

                    salon.grad = txt_grad.Text;
                    salon.adresa = txt_adresa.Text;
                    salon.sef = sef_salona;
                    salon.stepenOpremljenosti = float.Parse(txt_stepen_opremljenosti.Text);

                    session.SaveOrUpdate(salon);

                    session.Flush();
                    session.Close();

                    GetData();
                }
            }
            catch (Exception catchException)
            {
                MessageBox.Show(catchException.Message, "Exception", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_obrisi_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvSalon.Rows.Count <= 0 || dgvSalon.SelectedRows.Count <= 0)
                    return;

                var dr = MessageBox.Show("Da li ste sigurno da zelite da izbrisete salon?", "Salon",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dr == DialogResult.No)
                    return;

                ISession session = DataLayer.GetSession();

                var salon = (from sln in session.Query<Salon>()
                              where sln.idSalon == int.Parse(dgvSalon.SelectedRows[0].Cells[0].Value.ToString())
                              select sln).SingleOrDefault();

                for (int i = salon.servisi.Count; i > 0; i--)
                {
                    salon.servisi[i - 1].salon = null;
                    session.Update(salon.servisi[i - 1]);
                    salon.servisi.RemoveAt(i - 1);
                }

                session.Delete(salon);
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

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
    public partial class frmSpecijalnost : Form
    {
        private DataTable _specijalnosti = new DataTable();
        private bool novaSpecijalnost = false;

        public frmSpecijalnost()
        {
            InitializeComponent();
        }

        private void frmSpecijalnost_Load(object sender, EventArgs e)
        {
            dgvSpecijalnost.AllowUserToAddRows = false;
            dgvSpecijalnost.AllowUserToDeleteRows = false;
            dgvSpecijalnost.AllowUserToOrderColumns = false;
            dgvSpecijalnost.AllowUserToResizeRows = false;
            dgvSpecijalnost.AllowUserToResizeColumns = false;
            dgvSpecijalnost.ReadOnly = true;
            dgvSpecijalnost.MultiSelect = false;
            dgvSpecijalnost.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvSpecijalnost.DataBindingComplete += delegate
            {
                foreach (DataGridViewColumn c in dgvSpecijalnost.Columns)
                {
                    c.SortMode = DataGridViewColumnSortMode.NotSortable;
                }

                dgvSpecijalnost.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
                dgvSpecijalnost.RowHeadersVisible = false;
            };

            GetData();
        }

        private void GetData()
        {
            _specijalnosti = new DataTable();

            _specijalnosti.Columns.Add("Id");
            _specijalnosti.Columns.Add("IdTehnicar");
            _specijalnosti.Columns.Add("Specijalnost");

            ISession session = DataLayer.GetSession();

            var specijalnosti = (from spc in session.Query<Specijalnost>()
                           select spc).ToList();

            var zaposleni = from zpsln in session.Query<Zaposleni>()
                            select zpsln;

            foreach (var spc in specijalnosti)
            {
                var newRow = _specijalnosti.NewRow();

                //trazimo id zaposlenog koji ima ovu specijalnost (spc)
                var odgovorni_tehnicar_id = 0;
                foreach (var zpsln in zaposleni)
                {
                    var zaposleni_specijalnost = (from zs in zpsln.specijalnosti
                                                 where zs.id == spc.id
                                                 select zs).SingleOrDefault();

                    if (zaposleni_specijalnost != null)                    
                        odgovorni_tehnicar_id = zpsln.id;                    
                }     

                newRow[0] = spc.id;
                newRow[1] = odgovorni_tehnicar_id;
                newRow[2] = spc.specijalnost;

                _specijalnosti.Rows.Add(newRow);
            }

            dgvSpecijalnost.DataSource = _specijalnosti;

            dgvSpecijalnost.Columns["Id"].Width = 40;
            dgvSpecijalnost.Columns["IdTehnicar"].Width = 70;
            dgvSpecijalnost.Columns["Specijalnost"].Width = 80;            

            session.Close();
        }

        private void btn_nova_Click(object sender, EventArgs e)
        {
            novaSpecijalnost = true;
            
            txt_id_tehnicar.Text = string.Empty;
            txt_specijalnost.Text = string.Empty;
            txt_id_tehnicar.Focus();
        }

        private void btn_obustavi_Click(object sender, EventArgs e)
        {
            novaSpecijalnost = false;
            dgvSpecijalnost_SelectionChanged(sender, e);
        }

        private void dgvSpecijalnost_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvSpecijalnost.SelectedRows.Count <= 0 || dgvSpecijalnost.DataSource == null)
                return;
            else
            {               
                txt_id_tehnicar.Text = dgvSpecijalnost.SelectedRows[0].Cells[1].Value.ToString();
                txt_specijalnost.Text = dgvSpecijalnost.SelectedRows[0].Cells[2].Value.ToString();
            }
        }

        private void btn_sacuvaj_Click(object sender, EventArgs e)
        {
            try
            {
                //doda novu specijalnost
                if (novaSpecijalnost)
                {
                    if (string.IsNullOrEmpty(txt_id_tehnicar.Text) || string.IsNullOrEmpty(txt_specijalnost.Text))
                    {
                        MessageBox.Show("Polja Id Tehnicara i Specijalnost ne smeju biti parzna!", "Upozorenje",
                             MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }

                    ISession session = DataLayer.GetSession();

                    Specijalnost specijalnost_zaposlenog = new Specijalnost();

                    specijalnost_zaposlenog.specijalnost = txt_specijalnost.Text;

                    //nadjemo zaposlenog koji ima ovaj id tehnicara (txt_id_tehnicar)
                    var zaposleni_tehnicar = (from zpsln in session.Query<Zaposleni>()
                                              where zpsln.id == int.Parse(txt_id_tehnicar.Text)
                                              select zpsln).SingleOrDefault();

                    //dodamo tehnicara kao referencu u ovu specijalnost
                    specijalnost_zaposlenog.zaposleni.Add(zaposleni_tehnicar);                    
                    //dodamo specijalnost kao referencu u zaposlenog
                    zaposleni_tehnicar.specijalnosti.Add(specijalnost_zaposlenog);

                    //session.SaveOrUpdate(specijalnost_zaposlenog);
                    session.SaveOrUpdate(zaposleni_tehnicar);                    
                    session.Flush();
                    session.Close();

                    GetData();
                    novaSpecijalnost = false;
                }
                //azurira postojecu specijalnost
                else
                {
                    if (string.IsNullOrEmpty(txt_id_tehnicar.Text) || string.IsNullOrEmpty(txt_specijalnost.Text))
                    {
                        MessageBox.Show("Polja Id Tehnicara i Specijalnost ne smeju biti parzna!", "Upozorenje",
                             MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }

                    ISession session = DataLayer.GetSession();
                    var specijalnost_zaposlenog = session.Load<Specijalnost>(
                        int.Parse(dgvSpecijalnost.SelectedRows[0].Cells[0].Value.ToString()));

                    specijalnost_zaposlenog.specijalnost = txt_specijalnost.Text;

                    //obrisemo prethodnu specijalnost
                    var stara_specijalnost = (from ss in session.Query<Zaposleni>()
                                              where ss.id == int.Parse(dgvSpecijalnost.SelectedRows[0].Cells[1].Value.ToString())
                                              select ss).SingleOrDefault();
                    stara_specijalnost.specijalnosti.Remove(specijalnost_zaposlenog);

                    //nadjemo zaposlenog koji ima ovaj id tehnicara (txt_id_tehnicar)
                    var zaposleni_tehnicar = (from zpsln in session.Query<Zaposleni>()
                                              where zpsln.id == int.Parse(txt_id_tehnicar.Text)
                                              select zpsln).SingleOrDefault();
                    //dodamo tehnicara kao referencu u ovu specijalnost
                    specijalnost_zaposlenog.zaposleni.Add(zaposleni_tehnicar);
                    //dodamo specijalnost kao referencu u zaposlenog
                    zaposleni_tehnicar.specijalnosti.Add(specijalnost_zaposlenog);

                    session.SaveOrUpdate(specijalnost_zaposlenog);

                    session.Flush();
                    session.Close();
                    GetData();

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

        }
    }
}

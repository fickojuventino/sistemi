using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using MotornaVozila.Entiteti;
using System.Windows.Forms;
using NHibernate;

namespace MotornaVozila.Employee
{
    public partial class DodajZaposleni : Form
    {
        public DodajZaposleni()
        {
            InitializeComponent();
        }


        #region Attributes
        int _id;
        #endregion

        #region Properties
        public int Id
        {
            set { _id = value; }
        }
        #endregion


        private void DodajZaposleni_Load(object sender, EventArgs e)
        {
            cmbTipUgovora.Items.Add("za stalno");
            cmbTipUgovora.Items.Add("na odredjeno");
            cmbTipZaposlenog.Items.Add("tehnicar");
            cmbTipZaposlenog.Items.Add("ekonomista");
            cmbTipZaposlenog.SelectedIndex = 0;
            cmbTipUgovora.SelectedIndex = 0;
        }

        private void btnDodaj_Click(object sender, EventArgs e)
        {
            try
            {
                ISession session = DataLayer.GetSession();

                Zaposleni zaposleni = new Zaposleni();

                zaposleni.ime = tbIme.Text.ToString();
                zaposleni.prezime = tbPrezime.Text.ToString();
                zaposleni.maticniBroj = long.Parse(tbMatBr.Text.ToString());
                zaposleni.datumRodjenja = Convert.ToDateTime(dtpDatumRodjenja.Text.ToString());
                zaposleni.datumZaposlenja = Convert.ToDateTime(dtpDatumZaposlenja.Text.ToString());
                zaposleni.datumIstekaUgovora = Convert.ToDateTime(dtpDatumIsteka.Text.ToString());
                zaposleni.stepenStrucneSpreme = int.Parse(tbStepenStSpreme.Text.ToString());
                zaposleni.godineRadnogStaza = int.Parse(tbGodRadStaza.Text.ToString());
                zaposleni.plata = double.Parse(tbPlata.Text.ToString());
                zaposleni.tipUgovora = cmbTipUgovora.SelectedItem.ToString();
                zaposleni.tipZaposlenog = cmbTipZaposlenog.SelectedItem.ToString();

                if (tbSefSalona.Text.ToString() != "ID" && !String.IsNullOrEmpty(tbSefSalona.Text))
                {
                    int idSefSalona = int.Parse(tbSefSalona.Text.ToString());

                    Salon salon = new Salon();
                    salon = session.Load<Salon>(idSefSalona);

                    // uklanja vezu izmedju prethodnog sefa salona i salona
                    Zaposleni zap2 = new Zaposleni();
                    zap2 = session.Load<Zaposleni>(salon.sef.id);
                    zap2.saloniSef.Remove(salon);

                    // postavlja novog sefa
                    salon.sef = zaposleni;
                    zaposleni.saloniSef.Add(salon);
                }

                if (tbSefServisa.Text.ToString() != "ID" && !String.IsNullOrEmpty(tbSefServisa.Text))
                {
                    // dovrsiti fju
                    int idSefServisa = int.Parse(tbSefServisa.Text.ToString());
                }
                if (tbOdgovorniTehnicar.Text.ToString() != "ID" && !String.IsNullOrEmpty(tbOdgovorniTehnicar.Text))
                {
                    // dovrsiti fju
                    int idOdgovorniTehnicar = int.Parse(tbOdgovorniTehnicar.Text.ToString());
                }


                session.SaveOrUpdate(zaposleni);

                session.Flush();
                session.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnAzuriraj_Click(object sender, EventArgs e)
        {
            ISession session = DataLayer.GetSession();

            Zaposleni zaposleni = new Zaposleni();
            zaposleni = session.Load<Zaposleni>(_id);

            // ne dja mi se ovako
            if(!String.IsNullOrEmpty(tbIme.Text))
                zaposleni.ime = tbIme.Text.ToString();
            if(!String.IsNullOrEmpty(tbPrezime.Text))
                zaposleni.prezime = tbPrezime.Text.ToString();
            if(!String.IsNullOrEmpty(tbMatBr.Text))
                zaposleni.maticniBroj = long.Parse(tbMatBr.Text.ToString());

            zaposleni.datumRodjenja = Convert.ToDateTime(dtpDatumRodjenja.Text.ToString());
            zaposleni.datumZaposlenja = Convert.ToDateTime(dtpDatumZaposlenja.Text.ToString());
            zaposleni.datumIstekaUgovora = Convert.ToDateTime(dtpDatumIsteka.Text.ToString());
            if (!String.IsNullOrEmpty(tbStepenStSpreme.Text))
                zaposleni.stepenStrucneSpreme = int.Parse(tbStepenStSpreme.Text.ToString());
            if (!String.IsNullOrEmpty(tbGodRadStaza.Text))
                zaposleni.godineRadnogStaza = int.Parse(tbGodRadStaza.Text.ToString());
            if (!String.IsNullOrEmpty(tbPlata.Text))
                zaposleni.plata = double.Parse(tbPlata.Text.ToString());
            zaposleni.tipUgovora = cmbTipUgovora.SelectedItem.ToString();
            zaposleni.tipZaposlenog = cmbTipZaposlenog.SelectedItem.ToString();

            if (tbSefSalona.Text.ToString() != "ID" && !String.IsNullOrEmpty(tbSefSalona.Text))
            {
                int idSefSalona = int.Parse(tbSefSalona.Text.ToString());

                Salon salon = new Salon();
                salon = session.Load<Salon>(idSefSalona);

                // uklanja vezu izmedju prethodnog sefa salona i salona
                Zaposleni zap2 = new Zaposleni();
                zap2 = session.Load<Zaposleni>(salon.sef.id);
                zap2.saloniSef.Remove(salon);

                // postavlja novog sefa
                salon.sef = zaposleni;
                zaposleni.saloniSef.Add(salon);
            }

            if (tbSefServisa.Text.ToString() != "ID" && !String.IsNullOrEmpty(tbSefServisa.Text))
            {
                // dovrsiti fju
                int idSefServisa = int.Parse(tbSefServisa.Text.ToString());
            }
            if (tbOdgovorniTehnicar.Text.ToString() != "ID" && !String.IsNullOrEmpty(tbOdgovorniTehnicar.Text))
            {
                // dovrsiti fju
                int idOdgovorniTehnicar = int.Parse(tbOdgovorniTehnicar.Text.ToString());
            }


            session.SaveOrUpdate(zaposleni);

            session.Flush();

            session.Close();
        }
    }
}

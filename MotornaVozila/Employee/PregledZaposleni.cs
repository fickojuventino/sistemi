using NHibernate;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MotornaVozila.Entiteti;

namespace MotornaVozila.Employee
{
    public partial class PregledZaposleni : Form
    {
        public PregledZaposleni()
        {
            InitializeComponent();
        }

        private void btnPotvrdi_Click(object sender, EventArgs e)
        {
        //    try
        //    {
        //        if (tbID.Text.ToString() != "Unesite ID Zaposlenog")
        //        {
        //            ISession session = DataLayer.GetSession();
        //            Zaposleni zaposleni = session.Load<Zaposleni>(int.Parse(tbID.Text.ToString()));

        //            lbIme.Text = "Ime: " + zaposleni.ime;
        //            lbPrezime.Text = "Prezime: " + zaposleni.prezime;
        //            lbPlata.Text = "Plata: " + zaposleni.plata;
        //            lbStepenStSpreme.Text = "Stepen Strucne Spreme: " + zaposleni.stepenStrucneSpreme;
        //            lbGodRadnogStaza.Text = "Godine Radnog Staza: " + zaposleni.godineRadnogStaza;
        //            lbDatumIstekaUgovora.Text = "Datum Isteka Ugovora: " + zaposleni.datumIstekaUgovora;
        //            lbDatumZaposlenja.Text = "Datum Zaposlenja: " + zaposleni.datumZaposlenja;
        //            lbDatumRodjenja.Text = "Datum Rodjenja: " + zaposleni.datumRodjenja;
        //            lbTipUgovora.Text = "Tip Ugovora: " + zaposleni.tipUgovora;
        //            lbTipZaposlenog.Text = "Tip Zaposlenog: " + zaposleni.tipZaposlenog;

        //            session.Close();
        //        }
        //        else
        //        {
        //            MessageBox.Show("Unesite ID zaposlenog!");
        //        }
        //    }
        //    catch(Exception ex)
        //    {
        //        MessageBox.Show(ex.Message);
        //    }
        }
    }
}

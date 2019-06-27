using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace MotornaVozila
{
    public partial class Dodaj_nEkonomistu : Form
    {
        public Dodaj_nEkonomistu()
        {
            InitializeComponent();
        }

        #region Attributes
        //private string _ime;
        //private string _prezime;
        //private int _matbr;
        //private int _telefon;
        //private int _grad;
        //private int _adresa;
        #endregion

        #region Properties
        public string Ime
        {
            get { return ime.Text.ToString(); }
        }
        public string Prezime
        {
            get { return prezime.Text.ToString(); }
        }
        public long MatBr
        {
            get { return long.Parse(matBr.Text.ToString()); }
        }
        public long Telefon
        {
            get { return long.Parse(telefon.Text.ToString()); }
        }
        public string Grad
        {
            get { return grad.Text.ToString(); }
        }
        public string Adresa
        {
            get { return adresa.Text.ToString(); }
        }
        #endregion

        private void btnSubmit_Click(object sender, EventArgs e)
        {

        }
    }
}

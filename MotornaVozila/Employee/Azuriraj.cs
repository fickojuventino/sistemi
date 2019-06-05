using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace MotornaVozila.Employee
{
    public partial class Azuriraj : Form
    {
        public Azuriraj()
        {
            InitializeComponent();
        }

        #region Properties
        private bool _type; // odredjuje svrhu forme
        #endregion

        #region Property
        public int Id
        {
            get
            {
                try
                {
                    return int.Parse(tbID.Text.ToString());
                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    return -1; // edituj ovo 
                }
            }
        }
        public bool Type
        {
            set { _type = value; }
        }
        #endregion

        private void btnOK_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(tbID.Text))
            {
                MessageBox.Show("Unesite ID!");
            }
            else
            {
                if (_type)
                {
                    DodajZaposleni dz = new DodajZaposleni();
                    dz.Id = int.Parse(tbID.Text.ToString());
                    dz.Show();
                }
                Close();
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using NHibernate;
using MotornaVozila.Entiteti;
using MotornaVozila.Employee;
using MotornaVozila.Mapiranja;

namespace MotornaVozila
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void cmdRead_Click(object sender, EventArgs e)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                // Ucitavaju se podaci o zaposlenom sa specificiranim id-em
                Zaposleni zaposleni = s.Load<Zaposleni>(35);
                Servis servis = s.Load<Servis>(1);
                Kupac kupac = s.Load<Kupac>(3);
                Vozilo vozilo = s.Load<Vozilo>(3);
                Salon salon = s.Load<Salon>(1);
                NezavisniEkonomista nEkonomista = s.Load<NezavisniEkonomista>(1);
                Specijalnost specijalnost = s.Load<Specijalnost>(1);

                MessageBox.Show(specijalnost.specijalnost);
                MessageBox.Show(nEkonomista.ime);
                MessageBox.Show(salon.grad);
                MessageBox.Show(kupac.ime);
                MessageBox.Show(vozilo.modelVozila);
                MessageBox.Show(servis.salon.grad);
                //MessageBox.Show((zaposleni.plata).ToString());

                s.Close();
            }
            catch (Exception ec)
            {
                MessageBox.Show(ec.Message);
            }
        }

        private void cmdCreate_Click(object sender, EventArgs e)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                Zaposleni zaposleni = new Zaposleni();

                //zaposleni = s.Load<Zaposleni>(36);
                zaposleni.maticniBroj = 1234512345123;
                zaposleni.ime = "Ficko";
                zaposleni.prezime = "Fickic";
                zaposleni.godineRadnogStaza = 10;
                zaposleni.datumZaposlenja = Convert.ToDateTime("01/01/2015");
                zaposleni.datumRodjenja = Convert.ToDateTime("01/01/1995");
                zaposleni.stepenStrucneSpreme = 7;
                //zaposleni.plata = 540000;
                zaposleni.tipZaposlenog = "tehnicar";
                zaposleni.tipUgovora = "za stalno";
                //zaposleni.datumIstekaUgovora = Convert.ToDateTime(null); // proveriti kako insertovati u bazi null 
                

                s.SaveOrUpdate(zaposleni);
                s.Flush();
                s.Close();

            //    Entiteti.Prodavnica p = new Entiteti.Prodavnica();

            //    //p = s.Load<Entiteti.Prodavnica>(81);
           
            //    p.Naziv = "Emmi Shop II";
            //    p.RadniDan = "08-20";
            //    p.Subota = "08-14";
            //    p.Nedelja = "Ne radi";


            //    //s.Save(p);
            //    s.SaveOrUpdate(p);

            //    s.Flush();
            //    s.Close();
            }
            catch (Exception ec)
            {
                MessageBox.Show(ec.Message);
            }
        }

        private void cmdManytoOne_Click(object sender, EventArgs e)
        {
            //try
            //{
            //    ISession s = DataLayer.GetSession();

            //    //Ucitavaju se podaci o prodavnici za zadatim brojem
            //    Odeljenje o = s.Load<Odeljenje>(5);

            //    MessageBox.Show(o.Tip);
            //    MessageBox.Show(o.PripadaProdavnici.Naziv);

            //    s.Close();
            //}
            //catch (Exception ec)
            //{
            //    MessageBox.Show(ec.Message);
            //}
        }

        private void cmdOneToMany_Click(object sender, EventArgs e)
        {
            //try
            //{
            //    ISession s = DataLayer.GetSession();

            //    //Ucitavaju se podaci o prodavnici za zadatim brojem
            //    MotornaVozila.Entiteti.Prodavnica p = s.Load<MotornaVozila.Entiteti.Prodavnica>(61);

            //    foreach (Odeljenje o in p.Odeljenja)
            //    {
            //        MessageBox.Show(o.Tip + " " + o.Lokacija);
            //    }

            //    s.Close();
            //}
            //catch (Exception ec)
            //{
            //    MessageBox.Show(ec.Message);
            //}
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                Dodaj_nEkonomistu dne = new Dodaj_nEkonomistu();
                ISession s = DataLayer.GetSession();

                NezavisniEkonomista nezEkonomista = new NezavisniEkonomista();
                Salon salon = new Salon();

                salon = s.Load<Salon>(1);

                if (dne.ShowDialog() == DialogResult.OK)
                {
                    nezEkonomista.ime = dne.Ime;
                    nezEkonomista.prezime = dne.Prezime;
                    nezEkonomista.maticniBroj = dne.MatBr;
                    nezEkonomista.telefon = dne.Telefon;
                    nezEkonomista.grad = dne.Grad;
                    nezEkonomista.adresa = dne.Adresa;

                    salon.nEkonomiste.Add(nezEkonomista); // no row with the given identifier exists
                    nezEkonomista.saloni.Add(salon);
                }

                s.Save(nezEkonomista);
                s.Flush();
                s.Close();

                //    //ako je kod prodavnice kolekcija postavljena na Inverse
                //    //obavezno ukoliko za Foreign Key BROJ postavimo da je NOT NULL
                //    //o.PripadaProdavnici = p;

            }
            catch (Exception ec)
            {
                MessageBox.Show(ec.Message);
            }
        }

        private void btnPregledZaposleni_Click(object sender, EventArgs e)
        {
            PregledZaposleni pz = new PregledZaposleni();
            pz.Show();
        }

        private void btnDodajZaposlenog_Click(object sender, EventArgs e)
        {
            DodajZaposleni dz = new DodajZaposleni();
            dz.Show();
        }

        private void btnAzurirajZaposlenog_Click(object sender, EventArgs e)
        {
            Azuriraj a = new Azuriraj();
            a.Type = true;
            a.Show();
        }

        private void btnUkloniZaposlenog_Click(object sender, EventArgs e)
        {
            try
            {
                Azuriraj a = new Azuriraj();
                a.Type = false;
                if (a.ShowDialog() == DialogResult.OK)
                {
                    ISession session = DataLayer.GetSession();
                    Zaposleni zaposleni = new Zaposleni();
                    zaposleni = session.Load<Zaposleni>(a.Id);

                    for(int i = zaposleni.saloniSef.Count; i > 0 ; i--)
                    {
                        zaposleni.saloniSef[i-1].sef = null;
                        session.Update(zaposleni.saloniSef[i - 1]);
                        zaposleni.saloniSef.RemoveAt(i-1);
                    }

                    for (int i = zaposleni.servisiSef.Count; i > 0; i--)
                    {
                        zaposleni.servisiSef[i-1].sef = null;
                        session.Update(zaposleni.servisiSef[i - 1]);
                        zaposleni.servisiSef.RemoveAt(i-1);
                    }

                    for (int i = zaposleni.servisiTehnicar.Count; i > 0; i--)
                    {
                        zaposleni.servisiTehnicar[i-1].odgovorniTehnicar = null;
                        session.Update(zaposleni.servisiTehnicar[i - 1]);
                        zaposleni.servisiTehnicar.RemoveAt(i-1);
                    }

                    session.Delete(zaposleni);
                    session.Flush();
                    session.Close();
                    MessageBox.Show("Uspesno uklonjen zaposleni iz baze!");
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnServis_Click(object sender, EventArgs e)
        {
            frmServisi fs = new frmServisi();
            fs.ShowDialog();
            fs.Dispose();
        }

        private void btn_kupac_Click(object sender, EventArgs e)
        {
            frmKupac fk = new frmKupac();
            fk.ShowDialog();
            fk.Dispose();
        }

        private void btn_specijalnost_Click(object sender, EventArgs e)
        {
            frmSpecijalnost fs = new frmSpecijalnost();
            fs.ShowDialog();
            fs.Dispose();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            frmNezavisniEkonomista fne = new frmNezavisniEkonomista();
            fne.ShowDialog();
            fne.Dispose();
        }

        private void btnSalon_Click(object sender, EventArgs e)
        {
            frmSalon fs = new frmSalon();
            fs.ShowDialog();
            fs.Dispose();
        }

        private void btn_vozilo_Click(object sender, EventArgs e)
        {
            frmVozilo fv = new frmVozilo();
            fv.ShowDialog();
            fv.Dispose();
        }

        private void btn_zaposleni_Click(object sender, EventArgs e)
        {
            frmZaposleni fz = new frmZaposleni();
            fz.ShowDialog();
            fz.Dispose();
        }
    }
}

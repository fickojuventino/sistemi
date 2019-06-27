using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MotornaVozila.Entiteti;

namespace MotornaVozila.DTOs
{
    public class PutnickoView
    {
        public virtual int id { get; set; }
        public virtual Double? brojSasije { get; set; }
        public virtual string boja { get; set; }
        public virtual Double? brojMotora { get; set; }
        public virtual string gorivo { get; set; }
        public virtual string modelVozila { get; set; }
        public virtual float? kubikaza { get; set; }
        public virtual DateTime? datumUvoza { get; set; }
        public virtual DateTime? datumKupovine { get; set; }
        public virtual string poznato { get; set; }
        public virtual string opisProblema { get; set; }
        public virtual string ime { get; set; }
        public virtual string prezime { get; set; }
        public virtual long? telefon { get; set; }
        public virtual string tipVozila { get; set; }
        public virtual long? registarskiBroj { get; set; }
        public virtual int? godinaProizvodnje { get; set; }
        public virtual int brojPutnika { get; set; }

        public PutnickoView(Putnicko p)
        {
            id = p.id;
            brojSasije = p.brojSasije;
            boja = p.boja;
            brojMotora = p.brojMotora;
            gorivo = p.gorivo;
            modelVozila = p.modelVozila;
            kubikaza = p.kubikaza;
            datumUvoza = p.datumUvoza;
            datumKupovine = p.datumKupovine;
            poznato = p.poznato;
            opisProblema = p.opisProblema;
            ime = p.ime;
            prezime = p.prezime;
            telefon = p.telefon;
            tipVozila = p.tipVozila;
            registarskiBroj = p.registarskiBroj;
            godinaProizvodnje = p.godinaProizvodnje;
            brojPutnika = p.brojPutnika;
        }

        public PutnickoView()
        {

        }
    }
}

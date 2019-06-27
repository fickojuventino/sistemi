using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MotornaVozila.Entiteti;

namespace MotornaVozila.DTOs
{
    public class NaOdredjenoView
    {
        public virtual int id { get; set; }
        public virtual long maticniBroj { get; set; }
        public virtual string ime { get; set; }
        public virtual string prezime { get; set; }
        public virtual int godineRadnogStaza { get; set; }
        public virtual DateTime datumZaposlenja { get; set; }
        public virtual DateTime datumRodjenja { get; set; }
        public virtual int stepenStrucneSpreme { get; set; }
        public virtual DateTime datumIstekaUgovora { get; set; }
        public virtual string tipZaposlenog { get; set; }
        public virtual string tipUgovora { get; set; }

        public NaOdredjenoView(NaOdredjeno z)
        {
            id = z.id;
            maticniBroj = z.maticniBroj;
            ime = z.ime;
            prezime = z.prezime;
            godineRadnogStaza = z.godineRadnogStaza;
            datumZaposlenja = z.datumZaposlenja;
            datumRodjenja = z.datumRodjenja;
            stepenStrucneSpreme = z.stepenStrucneSpreme;
            datumIstekaUgovora = z.datumIstekaUgovora;
            tipZaposlenog = z.tipZaposlenog;
            tipUgovora = z.tipUgovora;
        }

        public NaOdredjenoView()
        {

        }
    }
}

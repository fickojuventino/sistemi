using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MotornaVozila.Entiteti;

namespace MotornaVozila.DTOs
{
    public class FizickoView
    {
        public virtual int id { get; set; }
        public virtual string ime { get; set; }
        public virtual string prezime { get; set; }
        public virtual long? telefon { get; set; }
        public virtual string tipLica { get; set; }
        public virtual long maticniBroj { get; set; }

        public FizickoView(Fizicko k)
        {
            id = k.id;
            ime = k.ime;
            prezime = k.prezime;
            telefon = k.telefon;
            tipLica = k.tipLica;
            maticniBroj = k.maticniBroj;
        }

        public FizickoView() { }
    }
}

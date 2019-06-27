using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MotornaVozila.Entiteti;

namespace MotornaVozila.DTOs
{
    public class NezavisniEkonomistaView
    {
        public virtual int id { get; set; }
        public virtual string ime { get; set; }
        public virtual string prezime { get; set; }
        public virtual long? maticniBroj { get; set; }
        public virtual long? telefon { get; set; }
        public virtual string grad { get; set; }
        public virtual string adresa { get; set; }

        public NezavisniEkonomistaView(NezavisniEkonomista n)
        {
            id = n.id;
            ime = n.ime;
            prezime = n.prezime;
            maticniBroj = n.maticniBroj;
            telefon = n.telefon;
            grad = n.grad;
            adresa = n.adresa;
        }

        public NezavisniEkonomistaView() { }
    }
}

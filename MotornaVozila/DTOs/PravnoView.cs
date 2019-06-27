using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MotornaVozila.Entiteti;

namespace MotornaVozila.DTOs
{
    public class PravnoView
    {
        public virtual int id { get; set; }
        public virtual string ime { get; set; }
        public virtual string prezime { get; set; }
        public virtual long? telefon { get; set; }
        public virtual string tipLica { get; set; }
        public virtual long pib { get; set; }

        public PravnoView(Pravno k)
        {
            id = k.id;
            ime = k.ime;
            prezime = k.prezime;
            telefon = k.telefon;
            tipLica = k.tipLica;
            pib = k.pib;
        }

        public PravnoView() { }
    }
}

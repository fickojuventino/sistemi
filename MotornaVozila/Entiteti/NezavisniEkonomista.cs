using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MotornaVozila.Entiteti
{
    public class NezavisniEkonomista
    {
        public virtual int id { get; protected set; }
        public virtual string ime { get; set; }
        public virtual string prezime { get; set; }
        public virtual long? maticniBroj { get; set; }
        public virtual long? telefon { get; set; }
        public virtual string grad { get; set; }
        public virtual string adresa { get; set; }

        public virtual IList<Salon> saloni { get; set; }

        public NezavisniEkonomista()
        {
            saloni = new List<Salon>();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Numerics;


namespace MotornaVozila.Entiteti
{
    public abstract class Kupac
    {
        public virtual int id { get; protected set; }
        public virtual string ime { get; set; }
        public virtual string prezime { get; set; }
        public virtual Double? telefon { get; set; }
        public virtual string tipLica { get; set; }
        public virtual Double? pib { get; set; }
        public virtual Double? maticniBroj { get; set; }

        public virtual IList<Vozilo> vozila { get; set; }
        
        public Kupac()
        {
            vozila = new List<Vozilo>();
        }

    }

    public class Fizicko : Kupac
    {
        public override Double? maticniBroj { get; set; }
    }

    public class Pravno : Kupac
    {
        public override Double? pib { get; set; }
    }
}

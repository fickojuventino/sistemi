using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MotornaVozila.Entiteti
{
    public class Specijalnost
    {
        public virtual int id { get; protected set; }
        public virtual string specijalnost { get; set; }

        public virtual IList<Zaposleni> zaposleni { get; set; }

        // task - resi kompozitni kljuc idtehnicar + specijalnost

        public Specijalnost()
        {
            zaposleni = new List<Zaposleni>();
        }
    }
}

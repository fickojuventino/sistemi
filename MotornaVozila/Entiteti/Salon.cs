using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MotornaVozila.Entiteti
{
    public class Salon
    {
        public virtual int idSalon { get; protected set; }
        public virtual string grad { get; set; }
        public virtual string adresa { get; set; }
        public virtual float stepenOpremljenosti { get; set; }

        public virtual Zaposleni sef { get; set; }
        public virtual IList<Servis> servisi { get; set; }
        public virtual IList<NezavisniEkonomista> nEkonomiste { get; set; }

        public Salon()
        {
            servisi = new List<Servis>();
            nEkonomiste = new List<NezavisniEkonomista>();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MotornaVozila.Entiteti
{
    public class Servis
    {
        public virtual int id { get; protected set; }
        public virtual DateTime? datumPrijema { get; set; }
        //public virtual int idSef { get; protected set; }
        //public virtual int idSalon { get; protected set; }
        public virtual DateTime? datumZavrsetka { get; set; }
        public virtual string tipuUsluge { get; set; }
        //public virtual int idtehnicar { get; protected set; }

        public virtual Zaposleni odgovorniTehnicar { get; set; }
        public virtual Zaposleni sef { get; set; }
        public virtual Salon salon { get; set; }
        public virtual IList<Vozilo> servisiranaVozila { get; set; }

        public Servis()
        {
            servisiranaVozila = new List<Vozilo>();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MotornaVozila.Entiteti;

namespace MotornaVozila.DTOs
{
    public class ServisView
    {
        public virtual int id { get; set; }
        public virtual DateTime? datumPrijema { get; set; }
        public virtual DateTime? datumZavrsetka { get; set; }
        public virtual string tipuUsluge { get; set; }

        public ServisView(Servis s)
        {
            id = s.id;
            datumPrijema = s.datumPrijema;
            datumZavrsetka = s.datumZavrsetka;
            tipuUsluge = s.tipuUsluge;
        }

        public ServisView() { }
    }
}

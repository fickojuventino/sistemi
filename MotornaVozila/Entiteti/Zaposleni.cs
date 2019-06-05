using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MotornaVozila.Entiteti
{
    public class Zaposleni
    {
        public virtual int id { get; protected set; }
        public virtual long maticniBroj { get; set; }
        public virtual string ime { get; set; }
        public virtual string prezime { get; set; }
        public virtual int godineRadnogStaza { get; set; }
        public virtual DateTime datumZaposlenja { get; set; }
        public virtual DateTime datumRodjenja { get; set; }
        public virtual int stepenStrucneSpreme { get; set; }
        public virtual double? plata { get; set; }
        public virtual string tipZaposlenog { get; set; }
        public virtual string tipUgovora { get; set; }
        public virtual DateTime? datumIstekaUgovora { get; set; }

        // odgovorni tehnicar u servisima
        public virtual IList<Servis> servisiTehnicar { get; set; }
        public virtual IList<Servis> servisiSef { get; set; }
        public virtual IList<Salon> saloniSef { get; set; }
        public virtual IList<Specijalnost> specijalnosti { get; set; }

        public Zaposleni()
        {
            servisiTehnicar = new List<Servis>();
            servisiSef = new List<Servis>();
            saloniSef = new List<Salon>();
            specijalnosti = new List<Specijalnost>();
        }
    }
}

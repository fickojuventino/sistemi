using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MotornaVozila.Entiteti
{
    // klasa mora da bude deklarisana kao public u okviru svog namespace-a
    // sva svojstva klase koja ce biti mapirana na kolone u tabeli relacione baze podataka moraju biti deklarisana kao public virtual
    // nHibernate predefinise sva svojstva kako bi obezbedio proxy za lazy load ucitavanje podataka
    public class Vozilo
    {
        public virtual int id { get; protected set; }
        public virtual Double? brojSasije { get; set; }
        public virtual string boja { get; set; }
        //public virtual int idSalona { get; protected set; }
        public virtual Double? brojMotora { get; set; }
        public virtual string gorivo { get; set; }
        //public virtual int idKupac { get; protected set; }
        public virtual string modelVozila { get; set; }
        //public virtual int idServis { get; protected set; }
        public virtual float? kubikaza { get; set; }
        public virtual DateTime? datumUvoza { get; set; }
        //public virtual int? brojPutnika { get; set; }
        //public virtual string tipProstora { get; set; }
        //public virtual Double? nosivost { get; set; }
        public virtual DateTime? datumKupovine { get; set; }
        public virtual string poznato { get; set; } // da li pretvoriti u bool?
        public virtual string opisProblema { get; set; }
        public virtual string ime { get; set; }
        public virtual string prezime { get; set; }
        public virtual long? telefon { get; set; }
        public virtual string tipVozila { get; set; }
        public virtual long? registarskiBroj { get; set; }
        public virtual int? godinaProizvodnje { get; set; }

        public virtual Kupac kupac { get; set; }
        public virtual Servis servis { get; set; }
        public virtual Salon salon { get; set; }
    }

    public class Putnicko : Vozilo
    {
        public virtual int brojPutnika { get; set; }
    }

    public class Teretno : Vozilo
    {
        public virtual string tipProstora { get; set; }
        public virtual Double nosivost { get; set; }
    }
}

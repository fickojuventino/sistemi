using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MotornaVozila.Entiteti;

namespace MotornaVozila.DTOs
{
    public class SalonView
    {
        public virtual int idSalon { get; set; }
        public virtual string grad { get; set; }
        public virtual string adresa { get; set; }
        public virtual float stepenOpremljenosti { get; set; }

        public SalonView(Salon s)
        {
            idSalon = s.idSalon;
            grad = s.grad;
            adresa = s.adresa;
            stepenOpremljenosti = s.stepenOpremljenosti;
        }

        public SalonView() { }
    }
}

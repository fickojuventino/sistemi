using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MotornaVozila.DTOs;
using MotornaVozila.Entiteti;
using NHibernate;
using NHibernate.Linq;

namespace MotornaVozila.DataProviders
{
    public class SalonProvider
    {
        public IEnumerable<Salon> VratiSalone()
        {
            ISession s = DataLayer.GetSession();

            IEnumerable<Salon> saloni = s.Query<Salon>().Select(p => p);
            return saloni;
        }

        public Salon VratiSalon(int id)
        {
            ISession s = DataLayer.GetSession();

            return s.Query<Salon>()
                .Where(v => v.idSalon == id).Select(p => p).FirstOrDefault();
        }

        public SalonView VratiSalonView(int id)
        {
            ISession s = DataLayer.GetSession();

            Salon salon = s.Query<Salon>()
                .Where(v => v.idSalon == id).Select(p => p).FirstOrDefault();

            if (salon == null) return new SalonView();

            return new SalonView(salon);
        }

        public int DodajSalon(Salon v)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                s.Save(v);

                s.Flush();
                s.Close();

                return 1;
            }
            catch (Exception ec)
            {
                return -1;
            }
        }

        public int ObrisiSalon(int id)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                Salon v = s.Load<Salon>(id);

                s.Delete(v);

                s.Flush();
                s.Close();

                return 1;
            }
            catch (Exception exc)
            {
                return -1;
            }

        }
    }
}

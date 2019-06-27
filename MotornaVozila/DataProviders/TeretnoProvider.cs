using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MotornaVozila.DTOs;
using MotornaVozila.Entiteti;
using NHibernate;
using NHibernate.Linq;

namespace MotornaVozila.DataProviders
{
    public class TeretnoProvider
    {
        public IEnumerable<Teretno> VratiTeretnaVozila()
        {
            ISession s = DataLayer.GetSession();

            IEnumerable<Teretno> vozila = s.Query<Teretno>().Select(p => p);
            return vozila;
        }

        public Teretno VratiTeretnoVozilo(int id)
        {
            ISession s = DataLayer.GetSession();

            return s.Query<Teretno>()
                .Where(v => v.id == id).Select(p => p).FirstOrDefault();
        }

        public TeretnoView VratiTeretnoView(int id)
        {
            ISession s = DataLayer.GetSession();

            Teretno vozilo = s.Query<Teretno>()
                .Where(v => v.id == id).Select(p => p).FirstOrDefault();

            if (vozilo == null) return new TeretnoView();

            return new TeretnoView(vozilo);
        }

        public int DodajTeretnoVozilo(Teretno v)
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

        public int ObrisiTeretnoVozilo(int id)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                Teretno v = s.Load<Teretno>(id);

                s.Delete(v);

                s.Flush();
                s.Close();

                return 1;
            }
            catch (Exception ec)
            {
                return -1;
            }

        }
    }
}

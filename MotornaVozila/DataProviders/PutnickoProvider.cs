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
    public class PutnickoProvider
    {
        public IEnumerable<Putnicko> VratiPutnickaVozila()
        {
            ISession s = DataLayer.GetSession();

            IEnumerable<Putnicko> vozila = s.Query<Putnicko>().Select(p => p);
            return vozila;
        }

        public Putnicko VratiPutnickoVozilo(int id)
        {
            ISession s = DataLayer.GetSession();

            return s.Query<Putnicko>()
                .Where(v => v.id == id).Select(p => p).FirstOrDefault();
        }

        public PutnickoView VratiPutnickoView(int id)
        {
            ISession s = DataLayer.GetSession();

            Putnicko vozilo = s.Query<Putnicko>()
                .Where(v => v.id == id).Select(p => p).FirstOrDefault();

            if (vozilo == null) return new PutnickoView();

            return new PutnickoView(vozilo);
        }

        public int DodajPutnickoVozilo(Putnicko v)
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

        public int ObirisPutnickoVozilo(int id)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                Putnicko v = s.Load<Putnicko>(id);

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

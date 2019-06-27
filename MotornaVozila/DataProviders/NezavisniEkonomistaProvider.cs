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
    public class NezavisniEkonomistaProvider
    {
        public IEnumerable<NezavisniEkonomista> VratiNezEkonomiste()
        {
            ISession s = DataLayer.GetSession();

            IEnumerable<NezavisniEkonomista> ekonomiste = s.Query<NezavisniEkonomista>().Select(p => p);
            return ekonomiste;
        }

        public NezavisniEkonomista VratiNezEkonomistu(int id)
        {
            ISession s = DataLayer.GetSession();

            return s.Query<NezavisniEkonomista>()
                .Where(v => v.id == id).Select(p => p).FirstOrDefault();
        }

        public NezavisniEkonomistaView VratiNezEkonomistuView(int id)
        {
            ISession s = DataLayer.GetSession();

            NezavisniEkonomista ekonomista = s.Query<NezavisniEkonomista>()
                .Where(v => v.id == id).Select(p => p).FirstOrDefault();

            if (ekonomista == null) return new NezavisniEkonomistaView();

            return new NezavisniEkonomistaView(ekonomista);
        }

        public int DodajnezEkonomistu(NezavisniEkonomista v)
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

        public int ObrisiNezEkonomistu(int id)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                NezavisniEkonomista v = s.Load<NezavisniEkonomista>(id);

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

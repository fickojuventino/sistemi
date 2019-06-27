using MotornaVozila.DTOs;
using MotornaVozila.Entiteti;
using NHibernate;
using NHibernate.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MotornaVozila.DataProviders
{
    public class ZaposleniProvider
    {
        public ZaStalnoView GetZaStalno()
        {
            ISession s = DataLayer.GetSession();
            List<ZaStalno> radnici = (from radnik in s.Query<ZaStalno>()
                                                       select radnik).ToList();
            if (radnici[0] == null) return new ZaStalnoView();
            return new ZaStalnoView(radnici[0]);
        }
    }
}

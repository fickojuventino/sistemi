using MotornaVozila.DataProviders;
using MotornaVozila.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;

namespace WebApplication1.Controllers.Zaposleni
{
    public class ZaStalnoController : ApiController
    {
        public ZaStalnoView GetZaStalno()
        {
            ZaposleniProvider provider = new ZaposleniProvider();
            return provider.GetZaStalno();
        }
    }
}
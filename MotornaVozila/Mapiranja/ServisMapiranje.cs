using FluentNHibernate.Mapping;
using MotornaVozila.Entiteti;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MotornaVozila.Mapiranja
{
    class ServisMapiranje : ClassMap<Servis>
    {
        public ServisMapiranje()
        {
            Table("SERVIS");

            Id(x => x.id, "IDSERVIS").GeneratedBy.TriggerIdentity();

            Map(x => x.datumPrijema, "DATUMPRIJEMA");
            Map(x => x.datumZavrsetka, "DATUMZAVRSETKA");
            Map(x => x.tipuUsluge, "TIPUSLUGE");

            // reference dodati
            References(x => x.odgovorniTehnicar).Column("IDTEHNICAR").LazyLoad();
            References(x => x.sef).Column("IDSEF").LazyLoad();
            References(x => x.salon).Column("IDSALON").LazyLoad();
            HasMany(x => x.servisiranaVozila).KeyColumn("IDSERVIS");
        }
    }
}

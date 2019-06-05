using FluentNHibernate.Mapping;
using MotornaVozila.Entiteti;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MotornaVozila.Mapiranja
{
    class SalonMapiranje : ClassMap<Salon>
    {
        public SalonMapiranje()
        {
            Table("SALON");

            Id(x => x.idSalon, "IDSALON").GeneratedBy.TriggerIdentity();

            Map(x => x.grad, "GRAD");
            Map(x => x.adresa, "ADRESA");
            Map(x => x.stepenOpremljenosti, "STEPENOPREMLJENOSTI");

            References(x => x.sef).Column("IDZAPOSLENI").LazyLoad();
            HasMany(x => x.servisi).KeyColumn("IDSALON");

            HasManyToMany(x => x.nEkonomiste).Table("ANGAZUJE")
                .ParentKeyColumn("IDSALON").ChildKeyColumn("IDNEZEKONOMISTA");
        }
    }
}

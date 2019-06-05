using FluentNHibernate.Mapping;
using MotornaVozila.Entiteti;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MotornaVozila.Mapiranja
{
    class SpecijalnostMapiranje : ClassMap<Specijalnost>
    {
        public SpecijalnostMapiranje()
        {
            Table("SPECIJALNOST");

            Id(x => x.id, "ID").GeneratedBy.TriggerIdentity();

            Map(x => x.specijalnost, "SPECIJALNOST");

            HasManyToMany(x => x.zaposleni).Table("SPECIJALNOST").ParentKeyColumn("ID").ChildKeyColumn("IDTEHNICAR").Cascade.All();
        }
    }
}

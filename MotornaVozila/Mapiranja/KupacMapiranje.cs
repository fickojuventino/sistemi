﻿using FluentNHibernate.Mapping;
using MotornaVozila.Entiteti;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MotornaVozila.Mapiranja
{
    class KupacMapiranje : ClassMap<Kupac>
    {
        public KupacMapiranje()
        {
            Table("KUPAC");

            Id(x => x.id, "IDKUPAC").GeneratedBy.TriggerIdentity();

            // mapiranje podklasa
            DiscriminateSubClassesOnColumn("TIPLICA");

            Map(x => x.ime, "IME");
            Map(x => x.prezime, "PREZIME");
            Map(x => x.telefon, "TELEFON");
            //Map(x => x.tipLica, "TIPLICA");
            //Map(x => x.pib, "PIB");
            //Map(x => x.maticniBroj, "MATBR");

            HasMany(x => x.vozila).KeyColumn("IDKUPAC");
        }
    }

    class FizickoMapiranje : SubclassMap<Fizicko>
    {
        public FizickoMapiranje()
        {
            DiscriminatorValue("fizicko");
            Map(x => x.maticniBroj, "MATBR");
            Map(x => x.tipLica, "TIPLICA");
        }
    }

    class PravnoMapiranje : SubclassMap<Pravno>
    {
        public PravnoMapiranje()
        {
            DiscriminatorValue("pravno");
            Map(x => x.pib, "PIB");
            Map(x => x.tipLica, "TIPLICA");
        }
    }
}

using FluentNHibernate.Mapping;
using MotornaVozila.Entiteti;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MotornaVozila.Mapiranja
{
    class ZaposleniMapiranje : ClassMap<Zaposleni>
    {
        public ZaposleniMapiranje()
        {
            // Mapiranje tabele 
            Table("ZAPOSLENI");

            // Mapiranje primarnog kljuca
            Id(x => x.id, "ID").GeneratedBy.TriggerIdentity();

            // Mapiranje svojstava
            Map(x => x.maticniBroj, "MATBR");
            Map(x => x.ime, "IME");
            Map(x => x.prezime, "PREZIME");
            Map(x => x.godineRadnogStaza, "GODRADNOGSTAZA");
            Map(x => x.datumZaposlenja, "DATUMZAPOSLENJA");
            Map(x => x.datumRodjenja, "DATUMRODJENJA");
            Map(x => x.stepenStrucneSpreme, "STEPENSTSPREME");
            Map(x => x.plata, "PLATA");
            Map(x => x.tipZaposlenog, "TIPZAPOSLENOG");
            Map(x => x.tipUgovora, "TIPUGOVORA");
            Map(x => x.datumIstekaUgovora, "DATUMISTEKAUGOVORA");

            // mapiranje veze odgovorniTehnicar 1:N
            // lazyload svojstvo je podrazumevano, iskljucuje se sa .not.lazyload();
            HasMany(x => x.servisiTehnicar).KeyColumn("IDTEHNICAR");
            HasMany(x => x.servisiSef).KeyColumn("IDSEF");
            HasMany(x => x.saloniSef).KeyColumn("IDZAPOSLENI");
            HasManyToMany(x => x.specijalnosti).Table("SPECIJALNOST")
                .ParentKeyColumn("IDTEHNICAR").ChildKeyColumn("ID").Inverse().Cascade.All();
        }
    }
}

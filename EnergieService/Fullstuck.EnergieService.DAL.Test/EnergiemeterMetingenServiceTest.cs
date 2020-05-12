using Fullstuck.EnergieService.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using System.Linq;

namespace Fullstuck.EnergieService.DAL.Test
{
    [TestClass]
    public class EnergiemeterMetingenServiceTest
    {
        public List<EnergieMeting> GetEnergieMetingen2019()
        {
            var meter = new Energiemeter();

            return new List<EnergieMeting>() {
                new EnergieMeting(GebruiksType.Opbrengst)
                {
                    DatumTijd = new System.DateTime(day: 1, month: 1, year: 2019),
                    Energie = new Energie()
                    {
                        Kilowattuur = 13,
                        Prijs = 5
                    },
                    Energiemeter = new Energiemeter(){ Locatie = new Locatie() }
                },
                new EnergieMeting(GebruiksType.Opbrengst)
                {
                    DatumTijd = new System.DateTime(day: 1, month: 1, year: 2019),
                    Energie = new Energie()
                    {
                        Kilowattuur = 13,
                        Prijs = 5
                    },
                    Energiemeter = new Energiemeter(){ Locatie = new Locatie() }
                },
                new EnergieMeting(GebruiksType.Opbrengst)
                {
                    DatumTijd = new System.DateTime(day: 1, month: 1, year: 2019),
                    Energie = new Energie()
                    {
                        Kilowattuur = 13,
                        Prijs = 5
                    },
                    Energiemeter = meter
                },
                new EnergieMeting(GebruiksType.Opbrengst)
                {
                    DatumTijd = new System.DateTime(day: 1, month: 1, year: 2019),
                    Energie = new Energie()
                    {
                        Kilowattuur = 13,
                        Prijs = 5
                    },
                    Energiemeter = meter
                },
                new EnergieMeting(GebruiksType.Opbrengst)
                {
                    DatumTijd = new System.DateTime(day: 1, month: 1, year: 2019),
                    Energie = new Energie()
                    {
                        Kilowattuur = 13,
                        Prijs = 5
                    },
                    Energiemeter = meter
                },
                new EnergieMeting(GebruiksType.Opbrengst)
                {
                    DatumTijd = new System.DateTime(day: 1, month: 1, year: 2019),
                    Energie = new Energie()
                    {
                        Kilowattuur = 13,
                        Prijs = 5
                    },
                    Energiemeter = meter
                },
                new EnergieMeting(GebruiksType.Opbrengst)
                {
                    DatumTijd = new System.DateTime(day: 1, month: 1, year: 2019),
                    Energie = new Energie()
                    {
                        Kilowattuur = 13,
                        Prijs = 5
                    },
                    Energiemeter = meter
                },
                new EnergieMeting(GebruiksType.Opbrengst)
                {
                    DatumTijd = new System.DateTime(day: 1, month: 1, year: 2019),
                    Energie = new Energie()
                    {
                        Kilowattuur = 13,
                        Prijs = 5
                    },
                    Energiemeter = meter
                },
                new EnergieMeting(GebruiksType.Opbrengst)
                {
                    DatumTijd = new System.DateTime(day: 1, month: 1, year: 2019),
                    Energie = new Energie()
                    {
                        Kilowattuur = 13,
                        Prijs = 5
                    },
                    Energiemeter = meter
                }
            };
        }

        public List<EnergieMeting> GetOpbrengstMetingenJanuari2019()
        {
            var meter1 = new Energiemeter();
            var meter2 = new Energiemeter();

            return new List<EnergieMeting>()
                    {
                        new EnergieMeting(GebruiksType.Opbrengst)
                        {
                            DatumTijd = new System.DateTime(2019, 1, 1),
                            Energie = new Energie(){ Kilowattuur = 5, Prijs = 9 },
                            Energiemeter = meter1
                        },
                        new EnergieMeting(GebruiksType.Opbrengst)
                        {
                            DatumTijd = new System.DateTime(2019, 1, 1),
                            Energie = new Energie(){ Kilowattuur = 10, Prijs = 9 },
                            Energiemeter = meter1

                        },
                        new EnergieMeting(GebruiksType.Opbrengst)
                        {
                            DatumTijd = new System.DateTime(2019, 1, 2),
                            Energie = new Energie(){ Kilowattuur = 15, Prijs = 9 },
                            Energiemeter = meter1
                        },
                        new EnergieMeting(GebruiksType.Opbrengst)
                        {
                            DatumTijd = new System.DateTime(2019, 1, 2),
                            Energie = new Energie(){ Kilowattuur = 9, Prijs = 9 },
                            Energiemeter = meter1
                        },
                        new EnergieMeting(GebruiksType.Opbrengst)
                        {
                            DatumTijd = new System.DateTime(2019, 1, 3),
                            Energie = new Energie(){ Kilowattuur = 10, Prijs = 9 },
                            Energiemeter = meter1
                        },
                        new EnergieMeting(GebruiksType.Opbrengst)
                        {
                            DatumTijd = new System.DateTime(2019, 1, 3),
                            Energie = new Energie(){ Kilowattuur = 11, Prijs = 9 },
                            Energiemeter = meter1
                        },
                        new EnergieMeting(GebruiksType.Opbrengst)
                        {
                            DatumTijd = new System.DateTime(2019, 1, 4),
                            Energie = new Energie(){ Kilowattuur = 10, Prijs = 9 },
                            Energiemeter = meter1
                        },
                        new EnergieMeting(GebruiksType.Opbrengst)
                        {
                            DatumTijd = new System.DateTime(2019, 1, 4),
                            Energie = new Energie(){ Kilowattuur = 34, Prijs = 9 },
                            Energiemeter = meter1
                        },
                        new EnergieMeting(GebruiksType.Opbrengst)
                        {
                            DatumTijd = new System.DateTime(2019, 1, 5),
                            Energie = new Energie(){ Kilowattuur = 10, Prijs = 9 },
                            Energiemeter = meter1
                        },
                        new EnergieMeting(GebruiksType.Opbrengst)
                        {
                            DatumTijd = new System.DateTime(2019, 1, 5),
                            Energie = new Energie(){ Kilowattuur = 22, Prijs = 9 },
                            Energiemeter = meter1
                        },
                        new EnergieMeting(GebruiksType.Opbrengst)
                        {
                            DatumTijd = new System.DateTime(2019, 1, 6),
                            Energie = new Energie(){ Kilowattuur = 10, Prijs = 9 },
                            Energiemeter = meter1
                        },
                        new EnergieMeting(GebruiksType.Opbrengst)
                        {
                            DatumTijd = new System.DateTime(2019, 1, 6),
                            Energie = new Energie(){ Kilowattuur = 9, Prijs = 9 },
                            Energiemeter = meter1
                        },
                        new EnergieMeting(GebruiksType.Opbrengst)
                        {
                            DatumTijd = new System.DateTime(2019, 1, 7),
                            Energie = new Energie(){ Kilowattuur = 5, Prijs = 9 },
                            Energiemeter = meter2
                        },
                        new EnergieMeting(GebruiksType.Opbrengst)
                        {
                            DatumTijd = new System.DateTime(2019, 1, 7),
                            Energie = new Energie(){ Kilowattuur = 10, Prijs = 9 },
                            Energiemeter = meter2
                        },
                        new EnergieMeting(GebruiksType.Opbrengst)
                        {
                            DatumTijd = new System.DateTime(2019, 1, 8),
                            Energie = new Energie(){ Kilowattuur = 10, Prijs = 9 },
                            Energiemeter = meter2
                        },
                        new EnergieMeting(GebruiksType.Opbrengst)
                        {
                            DatumTijd = new System.DateTime(2019, 1, 8),
                            Energie = new Energie(){ Kilowattuur = 34, Prijs = 9 },
                            Energiemeter = meter2
                        },
                        new EnergieMeting(GebruiksType.Opbrengst)
                        {
                            DatumTijd = new System.DateTime(2019, 1, 9),
                            Energie = new Energie(){ Kilowattuur = 10, Prijs = 9 },
                            Energiemeter = meter2
                        },
                        new EnergieMeting(GebruiksType.Opbrengst)
                        {
                            DatumTijd = new System.DateTime(2019, 1, 9),
                            Energie = new Energie(){ Kilowattuur = 27, Prijs = 9 },
                            Energiemeter = meter2
                        },
                        new EnergieMeting(GebruiksType.Opbrengst)
                        {
                            DatumTijd = new System.DateTime(2019, 1, 10),
                            Energie = new Energie(){ Kilowattuur = 3, Prijs = 9 },
                            Energiemeter = meter2
                        },
                        new EnergieMeting(GebruiksType.Opbrengst)
                        {
                            DatumTijd = new System.DateTime(2019, 1, 10),
                            Energie = new Energie(){ Kilowattuur = 19, Prijs = 9 },
                            Energiemeter = meter2
                        },
                        new EnergieMeting(GebruiksType.Opbrengst)
                        {
                            DatumTijd = new System.DateTime(2019, 1, 11),
                            Energie = new Energie(){ Kilowattuur = 10, Prijs = 9 },
                            Energiemeter = meter2
                        },
                        new EnergieMeting(GebruiksType.Opbrengst)
                        {
                            DatumTijd = new System.DateTime(2019, 1, 11),
                            Energie = new Energie(){ Kilowattuur = 50, Prijs = 9 },
                            Energiemeter = meter2
                        },
                        new EnergieMeting(GebruiksType.Opbrengst)
                        {
                            DatumTijd = new System.DateTime(2019, 1, 12),
                            Energie = new Energie(){ Kilowattuur = 3, Prijs = 9 },
                            Energiemeter = meter2
                        },
                        new EnergieMeting(GebruiksType.Opbrengst)
                        {
                            DatumTijd = new System.DateTime(2019, 1, 13),
                            Energie = new Energie(){ Kilowattuur = 8, Prijs = 9 },
                            Energiemeter = meter2
                        },
                        new EnergieMeting(GebruiksType.Opbrengst)
                        {
                            DatumTijd = new System.DateTime(2019, 1, 14),
                            Energie = new Energie(){ Kilowattuur = 7, Prijs = 9 },
                            Energiemeter = meter2
                        },
                        new EnergieMeting(GebruiksType.Opbrengst)
                        {
                            DatumTijd = new System.DateTime(2019, 1, 15),
                            Energie = new Energie(){ Kilowattuur = 7, Prijs = 9 },
                            Energiemeter = meter2
                        },
                        new EnergieMeting(GebruiksType.Opbrengst)
                        {
                            DatumTijd = new System.DateTime(2019, 1, 16),
                            Energie = new Energie(){ Kilowattuur = 7, Prijs = 9 },
                            Energiemeter = meter2
                        },
                        new EnergieMeting(GebruiksType.Opbrengst)
                        {
                            DatumTijd = new System.DateTime(2019, 1, 16),
                            Energie = new Energie(){ Kilowattuur = 7, Prijs = 9 },
                            Energiemeter = meter2
                        },
                        new EnergieMeting(GebruiksType.Opbrengst)
                        {
                            DatumTijd = new System.DateTime(2019, 1, 16),
                            Energie = new Energie(){ Kilowattuur = 7, Prijs = 9 },
                            Energiemeter = meter2
                        },
                        new EnergieMeting(GebruiksType.Opbrengst)
                        {
                            DatumTijd = new System.DateTime(2019, 1, 17),
                            Energie = new Energie(){ Kilowattuur = 7, Prijs = 9 },
                            Energiemeter = meter2
                        },
                        new EnergieMeting(GebruiksType.Opbrengst)
                        {
                            DatumTijd = new System.DateTime(2019, 1, 17),
                            Energie = new Energie(){ Kilowattuur = 7, Prijs = 9 },
                            Energiemeter = meter2
                        },
                        new EnergieMeting(GebruiksType.Opbrengst)
                        {
                            DatumTijd = new System.DateTime(2019, 1, 18),
                            Energie = new Energie(){ Kilowattuur = 7, Prijs = 9 },
                            Energiemeter = meter2
                        },
                        new EnergieMeting(GebruiksType.Opbrengst)
                        {
                            DatumTijd = new System.DateTime(2019, 1, 19),
                            Energie = new Energie(){ Kilowattuur = 7, Prijs = 9 },
                            Energiemeter = meter2
                        },
                        new EnergieMeting(GebruiksType.Opbrengst)
                        {
                            DatumTijd = new System.DateTime(2019, 1, 20),
                            Energie = new Energie(){ Kilowattuur = 7, Prijs = 9 },
                            Energiemeter = meter2
                        },
                        new EnergieMeting(GebruiksType.Opbrengst)
                        {
                            DatumTijd = new System.DateTime(2019, 1, 21),
                            Energie = new Energie(){ Kilowattuur = 7, Prijs = 9 },
                            Energiemeter = meter1
                        },
                        new EnergieMeting(GebruiksType.Opbrengst)
                        {
                            DatumTijd = new System.DateTime(2019, 1, 22),
                            Energie = new Energie(){ Kilowattuur = 7, Prijs = 9 },
                            Energiemeter = meter1
                        },
                        new EnergieMeting(GebruiksType.Opbrengst)
                        {
                            DatumTijd = new System.DateTime(2019, 1, 23),
                            Energie = new Energie(){ Kilowattuur = 7, Prijs = 9 },
                            Energiemeter = meter1
                        },
                        new EnergieMeting(GebruiksType.Opbrengst)
                        {
                            DatumTijd = new System.DateTime(2019, 1, 24),
                            Energie = new Energie(){ Kilowattuur = 7, Prijs = 9 },
                            Energiemeter = meter1
                        },
                        new EnergieMeting(GebruiksType.Opbrengst)
                        {
                            DatumTijd = new System.DateTime(2019, 1, 25),
                            Energie = new Energie(){ Kilowattuur = 7, Prijs = 9 },
                            Energiemeter = meter1
                        },
                        new EnergieMeting(GebruiksType.Opbrengst)
                        {
                            DatumTijd = new System.DateTime(2019, 1, 26),
                            Energie = new Energie(){ Kilowattuur = 7, Prijs = 9 },
                            Energiemeter = meter1
                        },
                        new EnergieMeting(GebruiksType.Opbrengst)
                        {
                            DatumTijd = new System.DateTime(2019, 1, 27),
                            Energie = new Energie(){ Kilowattuur = 7, Prijs = 9 },
                            Energiemeter = meter1
                        },
                        new EnergieMeting(GebruiksType.Opbrengst)
                        {
                            DatumTijd = new System.DateTime(2019, 1, 28),
                            Energie = new Energie(){ Kilowattuur = 7, Prijs = 9 },
                            Energiemeter = meter1
                        },
                        new EnergieMeting(GebruiksType.Opbrengst)
                        {
                            DatumTijd = new System.DateTime(2019, 1, 29),
                            Energie = new Energie(){ Kilowattuur = 7, Prijs = 9 },
                            Energiemeter = meter1
                        },
                        new EnergieMeting(GebruiksType.Opbrengst)
                        {
                            DatumTijd = new System.DateTime(2019, 1, 30),
                            Energie = new Energie(){ Kilowattuur = 7, Prijs = 9 },
                            Energiemeter = meter1
                        },
                        new EnergieMeting(GebruiksType.Opbrengst)
                        {
                            DatumTijd = new System.DateTime(2019, 1, 31),
                            Energie = new Energie(){ Kilowattuur = 7, Prijs = 9 },
                            Energiemeter = meter1
                        }
                    };
        }

        [TestMethod]
        public void ReadMetingenPerJaar_Returns2OpbrengstMetingen_OnMeterId3()
        {
            //Arrange
            var options = new DbContextOptionsBuilder<EnergystuckContext>()
                .UseInMemoryDatabase(databaseName: "Read_metingen_perjaar_meter3_database")
                .Options;

            var target = new EnergiemeterMetingenService(new EnergystuckContext(options));

            using var context = new EnergystuckContext(options);

            context.AddRange(GetEnergieMetingen2019());
            context.SaveChanges();

            //Act
            var result = target.ReadMetingenPerJaar(GebruiksType.Opbrengst, 3, 2019);

            //Assert
            Assert.AreEqual(3, result[0].Id);
            Assert.AreEqual(7, result.Count);
        }

        [TestMethod]
        public void ReadMetingenPerJaar_Returns0Verbruiksmetingen_OnMeterId3()
        {
            //Arrange
            var options = new DbContextOptionsBuilder<EnergystuckContext>()
                .UseInMemoryDatabase(databaseName: "Read_metingen_perjaar_meter3_database")
                .Options;

            using var context = new EnergystuckContext(options);

            context.AddRange(GetEnergieMetingen2019());
            context.SaveChanges();

            var target = new EnergiemeterMetingenService(new EnergystuckContext(options));

            //Act
            var result = target.ReadMetingenPerJaar(GebruiksType.Verbruik, 3, 2019);

            //Assert
            Assert.AreEqual(0, result.Count);
        }

        [TestMethod]
        public void ReadMetingenPerMaand_Returns0Opbrengstmetingen_OnMeterId2()
        {
            //Arrange
            var options = new DbContextOptionsBuilder<EnergystuckContext>()
                .UseInMemoryDatabase(databaseName: "Read_metingen_permaand_meter2_database")
                .Options;

            using var context = new EnergystuckContext(options);

            context.AddRange(GetOpbrengstMetingenJanuari2019());
            context.SaveChanges();

            var target = new EnergiemeterMetingenService(new EnergystuckContext(options));

            //Act
            var result = target.ReadMetingenPerMaand(GebruiksType.Opbrengst, 2, 2019, 1);

            //Assert
            Assert.AreEqual(22, result.Count);
            Assert.AreEqual(GebruiksType.Opbrengst, result[0].GebruiksType);
        }

        [TestMethod]
        public void ReadMetingenPerMaand_Returns0Opbrengstmetingen_OnMeterId1()
        {
            //Arrange
            var options = new DbContextOptionsBuilder<EnergystuckContext>()
                .UseInMemoryDatabase(databaseName: "Read_metingen_permaand_meter1_database")
                .Options;

            using var context = new EnergystuckContext(options);

            context.AddRange(GetOpbrengstMetingenJanuari2019());
            context.SaveChanges();

            var target = new EnergiemeterMetingenService(new EnergystuckContext(options));

            //Act
            var result = target.ReadMetingenPerMaand(GebruiksType.Opbrengst, 1, 2019, 1);

            //Assert
            Assert.AreEqual(23, result.Count);
            Assert.AreEqual(GebruiksType.Opbrengst, result[5].GebruiksType);
        }
    }
}

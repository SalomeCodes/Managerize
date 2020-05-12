using Fullstuck.EnergieService.DAL;
using Fullstuck.EnergieService.Models;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using System.Collections.Generic;

namespace Fullstuck.EnergieService.BLL.Test
{
    [TestClass]
    public class EnergieLogicTest
    {
        public List<EnergieMeting> GetOpbrengstMetingenJaar2019()
        {
            return new List<EnergieMeting>()
                    {
                        new EnergieMeting(GebruiksType.Opbrengst)
                        {
                            Id = 1,
                            DatumTijd = new System.DateTime(2019, 1, 1),
                            Energie = new Energie(){ Id = 1, Kilowattuur = 5, Prijs = 9 }
                        },
                        new EnergieMeting(GebruiksType.Opbrengst)
                        {
                            Id = 2,
                            DatumTijd = new System.DateTime(2019, 1, 1),
                            Energie = new Energie(){ Id = 1, Kilowattuur = 10, Prijs = 9 }
                        },
                        new EnergieMeting(GebruiksType.Opbrengst)
                        {
                            Id = 3,
                            DatumTijd = new System.DateTime(2019, 2, 1),
                            Energie = new Energie(){ Id = 1, Kilowattuur = 15, Prijs = 9 }
                        },
                        new EnergieMeting(GebruiksType.Opbrengst)
                        {
                            Id = 4,
                            DatumTijd = new System.DateTime(2019, 2, 1),
                            Energie = new Energie(){ Id = 1, Kilowattuur = 9, Prijs = 9 }
                        },
                        new EnergieMeting(GebruiksType.Opbrengst)
                        {
                            Id = 5,
                            DatumTijd = new System.DateTime(2019, 3, 1),
                            Energie = new Energie(){ Id = 1, Kilowattuur = 10, Prijs = 9 }
                        },
                        new EnergieMeting(GebruiksType.Opbrengst)
                        {
                            Id = 6,
                            DatumTijd = new System.DateTime(2019, 3, 1),
                            Energie = new Energie(){ Id = 1, Kilowattuur = 11, Prijs = 9 }
                        },
                        new EnergieMeting(GebruiksType.Opbrengst)
                        {
                            Id = 7,
                            DatumTijd = new System.DateTime(2019, 4, 1),
                            Energie = new Energie(){ Id = 1, Kilowattuur = 10, Prijs = 9 }
                        },
                        new EnergieMeting(GebruiksType.Opbrengst)
                        {
                            Id = 8,
                            DatumTijd = new System.DateTime(2019, 4, 1),
                            Energie = new Energie(){ Id = 1, Kilowattuur = 34, Prijs = 9 }
                        },
                        new EnergieMeting(GebruiksType.Opbrengst)
                        {
                            Id = 9,
                            DatumTijd = new System.DateTime(2019, 5, 1),
                            Energie = new Energie(){ Id = 1, Kilowattuur = 10, Prijs = 9 }
                        },
                        new EnergieMeting(GebruiksType.Opbrengst)
                        {
                            Id = 10,
                            DatumTijd = new System.DateTime(2019, 5, 1),
                            Energie = new Energie(){ Id = 1, Kilowattuur = 22, Prijs = 9 }
                        },
                        new EnergieMeting(GebruiksType.Opbrengst)
                        {
                            Id = 11,
                            DatumTijd = new System.DateTime(2019, 6, 1),
                            Energie = new Energie(){ Id = 1, Kilowattuur = 10, Prijs = 9 }
                        },
                        new EnergieMeting(GebruiksType.Opbrengst)
                        {
                            Id = 12,
                            DatumTijd = new System.DateTime(2019, 6, 1),
                            Energie = new Energie(){ Id = 1, Kilowattuur = 9, Prijs = 9 }
                        },
                        new EnergieMeting(GebruiksType.Opbrengst)
                        {
                            Id = 13,
                            DatumTijd = new System.DateTime(2019, 7, 1),
                            Energie = new Energie(){ Id = 1, Kilowattuur = 5, Prijs = 9 }
                        },
                        new EnergieMeting(GebruiksType.Opbrengst)
                        {
                            Id = 14,
                            DatumTijd = new System.DateTime(2019, 7, 1),
                            Energie = new Energie(){ Id = 1, Kilowattuur = 10, Prijs = 9 }
                        },
                        new EnergieMeting(GebruiksType.Opbrengst)
                        {
                            Id = 15,
                            DatumTijd = new System.DateTime(2019, 8, 1),
                            Energie = new Energie(){ Id = 1, Kilowattuur = 10, Prijs = 9 }
                        },
                        new EnergieMeting(GebruiksType.Opbrengst)
                        {
                            Id = 16,
                            DatumTijd = new System.DateTime(2019, 8, 1),
                            Energie = new Energie(){ Id = 1, Kilowattuur = 34, Prijs = 9 }
                        },
                        new EnergieMeting(GebruiksType.Opbrengst)
                        {
                            Id = 17,
                            DatumTijd = new System.DateTime(2019, 9, 1),
                            Energie = new Energie(){ Id = 1, Kilowattuur = 10, Prijs = 9 }
                        },
                        new EnergieMeting(GebruiksType.Opbrengst)
                        {
                            Id = 18,
                            DatumTijd = new System.DateTime(2019, 9, 1),
                            Energie = new Energie(){ Id = 1, Kilowattuur = 27, Prijs = 9 }
                        },
                        new EnergieMeting(GebruiksType.Opbrengst)
                        {
                            Id = 19,
                            DatumTijd = new System.DateTime(2019, 9, 1),
                            Energie = new Energie(){ Id = 1, Kilowattuur = 3, Prijs = 9 }
                        },
                        new EnergieMeting(GebruiksType.Opbrengst)
                        {
                            Id = 20,
                            DatumTijd = new System.DateTime(2019, 10, 1),
                            Energie = new Energie(){ Id = 1, Kilowattuur = 19, Prijs = 9 }
                        },
                        new EnergieMeting(GebruiksType.Opbrengst)
                        {
                            Id = 21,
                            DatumTijd = new System.DateTime(2019, 10, 1),
                            Energie = new Energie(){ Id = 1, Kilowattuur = 10, Prijs = 9 }
                        },
                        new EnergieMeting(GebruiksType.Opbrengst)
                        {
                            Id = 22,
                            DatumTijd = new System.DateTime(2019, 11, 1),
                            Energie = new Energie(){ Id = 1, Kilowattuur = 50, Prijs = 9 }
                        },
                        new EnergieMeting(GebruiksType.Opbrengst)
                        {
                            Id = 23,
                            DatumTijd = new System.DateTime(2019, 11, 1),
                            Energie = new Energie(){ Id = 1, Kilowattuur = 3, Prijs = 9 }
                        },
                        new EnergieMeting(GebruiksType.Opbrengst)
                        {
                            Id = 24,
                            DatumTijd = new System.DateTime(2019, 12, 1),
                            Energie = new Energie(){ Id = 1, Kilowattuur = 8, Prijs = 9 }
                        },
                        new EnergieMeting(GebruiksType.Opbrengst)
                        {
                            Id = 25,
                            DatumTijd = new System.DateTime(2019, 12, 1),
                            Energie = new Energie(){ Id = 1, Kilowattuur = 7, Prijs = 9 }
                        }
                    };
        }
        public List<EnergieMeting> GetVerbruikMetingenJaar2019()
        {
            return new List<EnergieMeting>()
                    {
                        new EnergieMeting(GebruiksType.Verbruik)
                        {
                            Id = 1,
                            DatumTijd = new System.DateTime(2019, 1, 1),
                            Energie = new Energie(){ Id = 1, Kilowattuur = 5, Prijs = 9 }
                        },
                        new EnergieMeting(GebruiksType.Verbruik)
                        {
                            Id = 2,
                            DatumTijd = new System.DateTime(2019, 2, 1),
                            Energie = new Energie(){ Id = 1, Kilowattuur = 10, Prijs = 9 }
                        },
                        new EnergieMeting(GebruiksType.Verbruik)
                        {
                            Id = 3,
                            DatumTijd = new System.DateTime(2019, 3, 1),
                            Energie = new Energie(){ Id = 1, Kilowattuur = 5, Prijs = 9 }
                        },
                        new EnergieMeting(GebruiksType.Verbruik)
                        {
                            Id = 4,
                            DatumTijd = new System.DateTime(2019, 4, 1),
                            Energie = new Energie(){ Id = 1, Kilowattuur = 10, Prijs = 9 }
                        },
                        new EnergieMeting(GebruiksType.Verbruik)
                        {
                            Id = 5,
                            DatumTijd = new System.DateTime(2019, 5, 1),
                            Energie = new Energie(){ Id = 1, Kilowattuur = 5, Prijs = 9 }
                        },
                        new EnergieMeting(GebruiksType.Verbruik)
                        {
                            Id = 6,
                            DatumTijd = new System.DateTime(2019, 6, 1),
                            Energie = new Energie(){ Id = 1, Kilowattuur = 10, Prijs = 9 }
                        },
                        new EnergieMeting(GebruiksType.Verbruik)
                        {
                            Id = 7,
                            DatumTijd = new System.DateTime(2019, 7, 1),
                            Energie = new Energie(){ Id = 1, Kilowattuur = 5, Prijs = 9 }
                        },
                        new EnergieMeting(GebruiksType.Verbruik)
                        {
                            Id = 8,
                            DatumTijd = new System.DateTime(2019, 8, 1),
                            Energie = new Energie(){ Id = 1, Kilowattuur = 10, Prijs = 9 }
                        },
                        new EnergieMeting(GebruiksType.Verbruik)
                        {
                            Id = 9,
                            DatumTijd = new System.DateTime(2019, 9, 1),
                            Energie = new Energie(){ Id = 1, Kilowattuur = 5, Prijs = 9 }
                        },
                        new EnergieMeting(GebruiksType.Verbruik)
                        {
                            Id = 10,
                            DatumTijd = new System.DateTime(2019, 10, 1),
                            Energie = new Energie(){ Id = 1, Kilowattuur = 10, Prijs = 9 }
                        },
                        new EnergieMeting(GebruiksType.Verbruik)
                        {
                            Id = 11,
                            DatumTijd = new System.DateTime(2019, 11, 1),
                            Energie = new Energie(){ Id = 1, Kilowattuur = 5, Prijs = 9 }
                        },
                        new EnergieMeting(GebruiksType.Verbruik)
                        {
                            Id = 12,
                            DatumTijd = new System.DateTime(2019, 12, 1),
                            Energie = new Energie(){ Id = 1, Kilowattuur = 10, Prijs = 9 }
                        },
                        new EnergieMeting(GebruiksType.Verbruik)
                        {
                            Id = 13,
                            DatumTijd = new System.DateTime(2019, 12, 1),
                            Energie = new Energie(){ Id = 1, Kilowattuur = 10, Prijs = 9 }
                        }
                    };
        }
        public List<EnergieMeting> GetOpbrengstMetingenJanuari2019()
        {
            return new List<EnergieMeting>()
                    {
                        new EnergieMeting(GebruiksType.Opbrengst)
                        {
                            Id = 1,
                            DatumTijd = new System.DateTime(2019, 1, 1),
                            Energie = new Energie(){ Id = 1, Kilowattuur = 5, Prijs = 9 }
                        },
                        new EnergieMeting(GebruiksType.Opbrengst)
                        {
                            Id = 2,
                            DatumTijd = new System.DateTime(2019, 1, 1),
                            Energie = new Energie(){ Id = 1, Kilowattuur = 10, Prijs = 9 }
                        },
                        new EnergieMeting(GebruiksType.Opbrengst)
                        {
                            Id = 3,
                            DatumTijd = new System.DateTime(2019, 1, 2),
                            Energie = new Energie(){ Id = 1, Kilowattuur = 15, Prijs = 9 }
                        },
                        new EnergieMeting(GebruiksType.Opbrengst)
                        {
                            Id = 4,
                            DatumTijd = new System.DateTime(2019, 1, 2),
                            Energie = new Energie(){ Id = 1, Kilowattuur = 9, Prijs = 9 }
                        },
                        new EnergieMeting(GebruiksType.Opbrengst)
                        {
                            Id = 5,
                            DatumTijd = new System.DateTime(2019, 1, 3),
                            Energie = new Energie(){ Id = 1, Kilowattuur = 10, Prijs = 9 }
                        },
                        new EnergieMeting(GebruiksType.Opbrengst)
                        {
                            Id = 6,
                            DatumTijd = new System.DateTime(2019, 1, 3),
                            Energie = new Energie(){ Id = 1, Kilowattuur = 11, Prijs = 9 }
                        },
                        new EnergieMeting(GebruiksType.Opbrengst)
                        {
                            Id = 7,
                            DatumTijd = new System.DateTime(2019, 1, 4),
                            Energie = new Energie(){ Id = 1, Kilowattuur = 10, Prijs = 9 }
                        },
                        new EnergieMeting(GebruiksType.Opbrengst)
                        {
                            Id = 8,
                            DatumTijd = new System.DateTime(2019, 1, 4),
                            Energie = new Energie(){ Id = 1, Kilowattuur = 34, Prijs = 9 }
                        },
                        new EnergieMeting(GebruiksType.Opbrengst)
                        {
                            Id = 9,
                            DatumTijd = new System.DateTime(2019, 1, 5),
                            Energie = new Energie(){ Id = 1, Kilowattuur = 10, Prijs = 9 }
                        },
                        new EnergieMeting(GebruiksType.Opbrengst)
                        {
                            Id = 10,
                            DatumTijd = new System.DateTime(2019, 1, 5),
                            Energie = new Energie(){ Id = 1, Kilowattuur = 22, Prijs = 9 }
                        },
                        new EnergieMeting(GebruiksType.Opbrengst)
                        {
                            Id = 11,
                            DatumTijd = new System.DateTime(2019, 1, 6),
                            Energie = new Energie(){ Id = 1, Kilowattuur = 10, Prijs = 9 }
                        },
                        new EnergieMeting(GebruiksType.Opbrengst)
                        {
                            Id = 12,
                            DatumTijd = new System.DateTime(2019, 1, 6),
                            Energie = new Energie(){ Id = 1, Kilowattuur = 9, Prijs = 9 }
                        },
                        new EnergieMeting(GebruiksType.Opbrengst)
                        {
                            Id = 13,
                            DatumTijd = new System.DateTime(2019, 1, 7),
                            Energie = new Energie(){ Id = 1, Kilowattuur = 5, Prijs = 9 }
                        },
                        new EnergieMeting(GebruiksType.Opbrengst)
                        {
                            Id = 14,
                            DatumTijd = new System.DateTime(2019, 1, 7),
                            Energie = new Energie(){ Id = 1, Kilowattuur = 10, Prijs = 9 }
                        },
                        new EnergieMeting(GebruiksType.Opbrengst)
                        {
                            Id = 15,
                            DatumTijd = new System.DateTime(2019, 1, 8),
                            Energie = new Energie(){ Id = 1, Kilowattuur = 10, Prijs = 9 }
                        },
                        new EnergieMeting(GebruiksType.Opbrengst)
                        {
                            Id = 16,
                            DatumTijd = new System.DateTime(2019, 1, 8),
                            Energie = new Energie(){ Id = 1, Kilowattuur = 34, Prijs = 9 }
                        },
                        new EnergieMeting(GebruiksType.Opbrengst)
                        {
                            Id = 17,
                            DatumTijd = new System.DateTime(2019, 1, 9),
                            Energie = new Energie(){ Id = 1, Kilowattuur = 10, Prijs = 9 }
                        },
                        new EnergieMeting(GebruiksType.Opbrengst)
                        {
                            Id = 18,
                            DatumTijd = new System.DateTime(2019, 1, 9),
                            Energie = new Energie(){ Id = 1, Kilowattuur = 27, Prijs = 9 }
                        },
                        new EnergieMeting(GebruiksType.Opbrengst)
                        {
                            Id = 19,
                            DatumTijd = new System.DateTime(2019, 1, 10),
                            Energie = new Energie(){ Id = 1, Kilowattuur = 3, Prijs = 9 }
                        },
                        new EnergieMeting(GebruiksType.Opbrengst)
                        {
                            Id = 20,
                            DatumTijd = new System.DateTime(2019, 1, 10),
                            Energie = new Energie(){ Id = 1, Kilowattuur = 19, Prijs = 9 }
                        },
                        new EnergieMeting(GebruiksType.Opbrengst)
                        {
                            Id = 21,
                            DatumTijd = new System.DateTime(2019, 1, 11),
                            Energie = new Energie(){ Id = 1, Kilowattuur = 10, Prijs = 9 }
                        },
                        new EnergieMeting(GebruiksType.Opbrengst)
                        {
                            Id = 22,
                            DatumTijd = new System.DateTime(2019, 1, 11),
                            Energie = new Energie(){ Id = 1, Kilowattuur = 50, Prijs = 9 }
                        },
                        new EnergieMeting(GebruiksType.Opbrengst)
                        {
                            Id = 23,
                            DatumTijd = new System.DateTime(2019, 1, 12),
                            Energie = new Energie(){ Id = 1, Kilowattuur = 3, Prijs = 9 }
                        },
                        new EnergieMeting(GebruiksType.Opbrengst)
                        {
                            Id = 24,
                            DatumTijd = new System.DateTime(2019, 1, 13),
                            Energie = new Energie(){ Id = 1, Kilowattuur = 8, Prijs = 9 }
                        },
                        new EnergieMeting(GebruiksType.Opbrengst)
                        {
                            Id = 25,
                            DatumTijd = new System.DateTime(2019, 1, 14),
                            Energie = new Energie(){ Id = 1, Kilowattuur = 7, Prijs = 9 }
                        },
                        new EnergieMeting(GebruiksType.Opbrengst)
                        {
                            Id = 26,
                            DatumTijd = new System.DateTime(2019, 1, 15),
                            Energie = new Energie(){ Id = 1, Kilowattuur = 7, Prijs = 9 }
                        },
                        new EnergieMeting(GebruiksType.Opbrengst)
                        {
                            Id = 27,
                            DatumTijd = new System.DateTime(2019, 1, 16),
                            Energie = new Energie(){ Id = 1, Kilowattuur = 7, Prijs = 9 }
                        },
                        new EnergieMeting(GebruiksType.Opbrengst)
                        {
                            Id = 28,
                            DatumTijd = new System.DateTime(2019, 1, 16),
                            Energie = new Energie(){ Id = 1, Kilowattuur = 7, Prijs = 9 }
                        },
                        new EnergieMeting(GebruiksType.Opbrengst)
                        {
                            Id = 29,
                            DatumTijd = new System.DateTime(2019, 1, 16),
                            Energie = new Energie(){ Id = 1, Kilowattuur = 7, Prijs = 9 }
                        },
                        new EnergieMeting(GebruiksType.Opbrengst)
                        {
                            Id = 30,
                            DatumTijd = new System.DateTime(2019, 1, 17),
                            Energie = new Energie(){ Id = 1, Kilowattuur = 7, Prijs = 9 }
                        },
                        new EnergieMeting(GebruiksType.Opbrengst)
                        {
                            Id = 31,
                            DatumTijd = new System.DateTime(2019, 1, 17),
                            Energie = new Energie(){ Id = 1, Kilowattuur = 7, Prijs = 9 }
                        },
                        new EnergieMeting(GebruiksType.Opbrengst)
                        {
                            Id = 31,
                            DatumTijd = new System.DateTime(2019, 1, 18),
                            Energie = new Energie(){ Id = 1, Kilowattuur = 7, Prijs = 9 }
                        },
                        new EnergieMeting(GebruiksType.Opbrengst)
                        {
                            Id = 31,
                            DatumTijd = new System.DateTime(2019, 1, 19),
                            Energie = new Energie(){ Id = 1, Kilowattuur = 7, Prijs = 9 }
                        },
                        new EnergieMeting(GebruiksType.Opbrengst)
                        {
                            Id = 31,
                            DatumTijd = new System.DateTime(2019, 1, 20),
                            Energie = new Energie(){ Id = 1, Kilowattuur = 7, Prijs = 9 }
                        },
                        new EnergieMeting(GebruiksType.Opbrengst)
                        {
                            Id = 31,
                            DatumTijd = new System.DateTime(2019, 1, 21),
                            Energie = new Energie(){ Id = 1, Kilowattuur = 7, Prijs = 9 }
                        },
                        new EnergieMeting(GebruiksType.Opbrengst)
                        {
                            Id = 31,
                            DatumTijd = new System.DateTime(2019, 1, 22),
                            Energie = new Energie(){ Id = 1, Kilowattuur = 7, Prijs = 9 }
                        },
                        new EnergieMeting(GebruiksType.Opbrengst)
                        {
                            Id = 31,
                            DatumTijd = new System.DateTime(2019, 1, 23),
                            Energie = new Energie(){ Id = 1, Kilowattuur = 7, Prijs = 9 }
                        },
                        new EnergieMeting(GebruiksType.Opbrengst)
                        {
                            Id = 31,
                            DatumTijd = new System.DateTime(2019, 1, 24),
                            Energie = new Energie(){ Id = 1, Kilowattuur = 7, Prijs = 9 }
                        },
                        new EnergieMeting(GebruiksType.Opbrengst)
                        {
                            Id = 31,
                            DatumTijd = new System.DateTime(2019, 1, 25),
                            Energie = new Energie(){ Id = 1, Kilowattuur = 7, Prijs = 9 }
                        },
                        new EnergieMeting(GebruiksType.Opbrengst)
                        {
                            Id = 31,
                            DatumTijd = new System.DateTime(2019, 1, 26),
                            Energie = new Energie(){ Id = 1, Kilowattuur = 7, Prijs = 9 }
                        },
                        new EnergieMeting(GebruiksType.Opbrengst)
                        {
                            Id = 31,
                            DatumTijd = new System.DateTime(2019, 1, 27),
                            Energie = new Energie(){ Id = 1, Kilowattuur = 7, Prijs = 9 }
                        },
                        new EnergieMeting(GebruiksType.Opbrengst)
                        {
                            Id = 31,
                            DatumTijd = new System.DateTime(2019, 1, 28),
                            Energie = new Energie(){ Id = 1, Kilowattuur = 7, Prijs = 9 }
                        },
                        new EnergieMeting(GebruiksType.Opbrengst)
                        {
                            Id = 31,
                            DatumTijd = new System.DateTime(2019, 1, 29),
                            Energie = new Energie(){ Id = 1, Kilowattuur = 7, Prijs = 9 }
                        },
                        new EnergieMeting(GebruiksType.Opbrengst)
                        {
                            Id = 31,
                            DatumTijd = new System.DateTime(2019, 1, 30),
                            Energie = new Energie(){ Id = 1, Kilowattuur = 7, Prijs = 9 }
                        },
                        new EnergieMeting(GebruiksType.Opbrengst)
                        {
                            Id = 31,
                            DatumTijd = new System.DateTime(2019, 1, 31),
                            Energie = new Energie(){ Id = 1, Kilowattuur = 7, Prijs = 9 }
                        }
                    };
        }

        [TestMethod]
        public void GetBalans_Retuns2Metingen_1Verbruik1Opbrengst()
        {
            //Arrange
            var energieMock = new Mock<IMetingenService>();
            energieMock.Setup(m => m.ReadMetingenPerJaar(GebruiksType.Verbruik, 2019)).Returns(GetVerbruikMetingenJaar2019);
            energieMock.Setup(m => m.ReadMetingenPerJaar(GebruiksType.Opbrengst, 2019)).Returns(GetOpbrengstMetingenJaar2019);
            var energieMetingService = energieMock.Object;

            var target = new EnergieLogic(energieMetingService);

            //Act
            var result = target.GetBalans(2019);

            //Assert
            Assert.AreEqual(2, result.Count);
            Assert.AreEqual(GebruiksType.Verbruik, result[0].GebruiksType);
            Assert.AreEqual(GebruiksType.Opbrengst, result[1].GebruiksType);
        }

        [TestMethod]
        public void GetBalans_Retuns2Metingen_Verbruik90KilowattuurAndOpbrengst250()
        {
            //Arrange
            var energieMock = new Mock<IMetingenService>();
            energieMock.Setup(m => m.ReadMetingenPerJaar(GebruiksType.Verbruik, 2019)).Returns(GetVerbruikMetingenJaar2019);
            energieMock.Setup(m => m.ReadMetingenPerJaar(GebruiksType.Opbrengst, 2019)).Returns(GetOpbrengstMetingenJaar2019);
            var energieMetingService = energieMock.Object;

            var target = new EnergieLogic(energieMetingService);

            //Act
            var result = target.GetBalans(2019);

            //Assert
            Assert.AreEqual(2, result.Count);
            Assert.AreEqual(100, result[0].Energie.Kilowattuur);
            Assert.AreEqual(351, result[1].Energie.Kilowattuur);
        }

        [TestMethod]
        public void GetMetingPerJaar_Returns12Metingen()
        {
            //Arrange
            var energieMock = new Mock<IMetingenService>();
            energieMock.Setup(m => m.ReadMetingenPerJaar(GebruiksType.Opbrengst, 2019)).Returns(GetOpbrengstMetingenJaar2019);
            var energieMetingService = energieMock.Object;

            var target = new EnergieLogic(energieMetingService);

            //Act
            var result = target.GetMetingPerJaar(GebruiksType.Opbrengst, 2019);

            //Assert
            Assert.AreEqual(12, result.Count);
        }

        [TestMethod]
        public void GetMetingPerJaar_ReturnsAllMaand()
        {
            //Arrange
            var energieMock = new Mock<IMetingenService>();
            energieMock.Setup(m => m.ReadMetingenPerJaar(GebruiksType.Opbrengst, 2019)).Returns(GetOpbrengstMetingenJaar2019);
            var energieMetingService = energieMock.Object;

            var target = new EnergieLogic(energieMetingService);

            //Act
            var result = target.GetMetingPerJaar(GebruiksType.Opbrengst, 2019);

            //Assert
            Assert.AreEqual(12, result.Count);
            Assert.AreEqual(1, result[0].DatumTijd.Month);
            Assert.AreEqual(2, result[1].DatumTijd.Month);
            Assert.AreEqual(3, result[2].DatumTijd.Month);
            Assert.AreEqual(4, result[3].DatumTijd.Month);
            Assert.AreEqual(5, result[4].DatumTijd.Month);
            Assert.AreEqual(6, result[5].DatumTijd.Month);
            Assert.AreEqual(7, result[6].DatumTijd.Month);
            Assert.AreEqual(8, result[7].DatumTijd.Month);
            Assert.AreEqual(9, result[8].DatumTijd.Month);
            Assert.AreEqual(10, result[9].DatumTijd.Month);
            Assert.AreEqual(11, result[10].DatumTijd.Month);
            Assert.AreEqual(12, result[11].DatumTijd.Month);
        }

        [TestMethod]
        public void GetMetingPerJaar_ReturnsRightValuePerMaand()
        {
            //Arrange
            var energieMock = new Mock<IMetingenService>();
            energieMock.Setup(m => m.ReadMetingenPerJaar(GebruiksType.Opbrengst, 2019)).Returns(GetOpbrengstMetingenJaar2019);
            var energieMetingService = energieMock.Object;

            var target = new EnergieLogic(energieMetingService);

            //Act
            var result = target.GetMetingPerJaar(GebruiksType.Opbrengst, 2019);

            //Assert
            Assert.AreEqual(15, result[0].Energie.Kilowattuur);
            Assert.AreEqual(24, result[1].Energie.Kilowattuur);
            Assert.AreEqual(21, result[2].Energie.Kilowattuur);
            Assert.AreEqual(44, result[3].Energie.Kilowattuur);
            Assert.AreEqual(32, result[4].Energie.Kilowattuur);
            Assert.AreEqual(19, result[5].Energie.Kilowattuur);
            Assert.AreEqual(15, result[6].Energie.Kilowattuur);
            Assert.AreEqual(44, result[7].Energie.Kilowattuur);
            Assert.AreEqual(40, result[8].Energie.Kilowattuur);
            Assert.AreEqual(29, result[9].Energie.Kilowattuur);
            Assert.AreEqual(53, result[10].Energie.Kilowattuur);
            Assert.AreEqual(15, result[11].Energie.Kilowattuur);
        }

        [TestMethod]
        public void GetMetingPerMaand_Returns31MetingenJanuari2019()
        {
            //Arrange
            var energieMock = new Mock<IMetingenService>();
            energieMock.Setup(m => m.ReadMetingenPerMaand(GebruiksType.Opbrengst, 2019, 1)).Returns(GetOpbrengstMetingenJanuari2019);
            var energieMetingService = energieMock.Object;

            var target = new EnergieLogic(energieMetingService);

            //Act
            var result = target.GetMetingPerMaand(GebruiksType.Opbrengst, 2019, 1);

            //Assert
            Assert.AreEqual(31, result.Count);
        }

        [TestMethod]
        public void GetMetingPerMaand_ReturnsRightDagen_OnJanuari2019()
        {
            //Arrange
            var energieMock = new Mock<IMetingenService>();
            energieMock.Setup(m => m.ReadMetingenPerMaand(GebruiksType.Opbrengst, 2019, 1)).Returns(GetOpbrengstMetingenJanuari2019);
            var energieMetingService = energieMock.Object;

            var target = new EnergieLogic(energieMetingService);

            //Act
            var result = target.GetMetingPerMaand(GebruiksType.Opbrengst, 2019, 1);

            //Assert
            Assert.AreEqual(1, result[0].DatumTijd.Day);
            Assert.AreEqual(2, result[1].DatumTijd.Day);
            Assert.AreEqual(3, result[2].DatumTijd.Day);
            Assert.AreEqual(4, result[3].DatumTijd.Day);
            Assert.AreEqual(5, result[4].DatumTijd.Day);
            Assert.AreEqual(6, result[5].DatumTijd.Day);
            Assert.AreEqual(7, result[6].DatumTijd.Day);
            Assert.AreEqual(8, result[7].DatumTijd.Day);
            Assert.AreEqual(9, result[8].DatumTijd.Day);
            Assert.AreEqual(10, result[9].DatumTijd.Day);
            Assert.AreEqual(11, result[10].DatumTijd.Day);
            Assert.AreEqual(12, result[11].DatumTijd.Day);
            Assert.AreEqual(13, result[12].DatumTijd.Day);
            Assert.AreEqual(14, result[13].DatumTijd.Day);
            Assert.AreEqual(15, result[14].DatumTijd.Day);
            Assert.AreEqual(16, result[15].DatumTijd.Day);
            Assert.AreEqual(17, result[16].DatumTijd.Day);
            Assert.AreEqual(18, result[17].DatumTijd.Day);
            Assert.AreEqual(19, result[18].DatumTijd.Day);
            Assert.AreEqual(20, result[19].DatumTijd.Day);
            Assert.AreEqual(21, result[20].DatumTijd.Day);
            Assert.AreEqual(22, result[21].DatumTijd.Day);
            Assert.AreEqual(23, result[22].DatumTijd.Day);
            Assert.AreEqual(24, result[23].DatumTijd.Day);
            Assert.AreEqual(25, result[24].DatumTijd.Day);
            Assert.AreEqual(26, result[25].DatumTijd.Day);
            Assert.AreEqual(27, result[26].DatumTijd.Day);
            Assert.AreEqual(28, result[27].DatumTijd.Day);
            Assert.AreEqual(29, result[28].DatumTijd.Day);
            Assert.AreEqual(30, result[29].DatumTijd.Day);
            Assert.AreEqual(31, result[30].DatumTijd.Day);
        }

        [TestMethod]
        public void GetMetingPerMaand_ReturnsRightValuePerDay_OnJanuari2019()
        {
            //Arrange
            var energieMock = new Mock<IMetingenService>();
            energieMock.Setup(m => m.ReadMetingenPerMaand(GebruiksType.Opbrengst, 2019, 1)).Returns(GetOpbrengstMetingenJanuari2019);
            var energieMetingService = energieMock.Object;

            var target = new EnergieLogic(energieMetingService);

            //Act
            var result = target.GetMetingPerMaand(GebruiksType.Opbrengst, 2019, 1);

            //Assert
            Assert.AreEqual(15, result[0].Energie.Kilowattuur);
            Assert.AreEqual(24, result[1].Energie.Kilowattuur);
            Assert.AreEqual(21, result[2].Energie.Kilowattuur);
            Assert.AreEqual(44, result[3].Energie.Kilowattuur);
            Assert.AreEqual(32, result[4].Energie.Kilowattuur);
            Assert.AreEqual(19, result[5].Energie.Kilowattuur);
            Assert.AreEqual(15, result[6].Energie.Kilowattuur);
            Assert.AreEqual(44, result[7].Energie.Kilowattuur);
            Assert.AreEqual(37, result[8].Energie.Kilowattuur);
            Assert.AreEqual(22, result[9].Energie.Kilowattuur);
            Assert.AreEqual(60, result[10].Energie.Kilowattuur);
            Assert.AreEqual(3, result[11].Energie.Kilowattuur);
            Assert.AreEqual(8, result[12].Energie.Kilowattuur);
            Assert.AreEqual(7, result[13].Energie.Kilowattuur);
            Assert.AreEqual(7, result[14].Energie.Kilowattuur);
            Assert.AreEqual(21, result[15].Energie.Kilowattuur);
            Assert.AreEqual(14, result[16].Energie.Kilowattuur);
            Assert.AreEqual(7, result[17].Energie.Kilowattuur);
            Assert.AreEqual(7, result[18].Energie.Kilowattuur);
            Assert.AreEqual(7, result[19].Energie.Kilowattuur);
            Assert.AreEqual(7, result[20].Energie.Kilowattuur);
            Assert.AreEqual(7, result[21].Energie.Kilowattuur);
            Assert.AreEqual(7, result[22].Energie.Kilowattuur);
            Assert.AreEqual(7, result[23].Energie.Kilowattuur);
            Assert.AreEqual(7, result[24].Energie.Kilowattuur);
            Assert.AreEqual(7, result[25].Energie.Kilowattuur);
            Assert.AreEqual(7, result[26].Energie.Kilowattuur);
            Assert.AreEqual(7, result[27].Energie.Kilowattuur);
            Assert.AreEqual(7, result[28].Energie.Kilowattuur);
            Assert.AreEqual(7, result[29].Energie.Kilowattuur);
            Assert.AreEqual(7, result[30].Energie.Kilowattuur);
        }

        [TestMethod]
        public void GetMetingPerDag()
        {

        }
    }
}

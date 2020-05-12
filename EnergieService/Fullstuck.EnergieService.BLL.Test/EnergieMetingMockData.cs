using Fullstuck.EnergieService.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Fullstuck.EnergieService.BLL.Test
{
    static class EnergieMetingMockData
    {
        public static List<EnergieMeting> GetEnergieMetingenOpbrengstForJanuary2019()
        {
            return new List<EnergieMeting>() {
                new EnergieMeting(GebruiksType.Opbrengst)
                {
                    Id = 1,
                    DatumTijd = new System.DateTime(day: 1, month: 1, year: 2019),
                    Energie = new Energie()
                    {
                        Id = 1,
                        Kilowattuur = 13,
                        Prijs = 5
                    }
                },
                new EnergieMeting(GebruiksType.Opbrengst)
                {
                    Id = 2,
                    DatumTijd = new System.DateTime(day: 2, month: 1, year: 2019),
                    Energie = new Energie()
                    {
                        Id = 2,
                        Kilowattuur = 20,
                        Prijs = 5
                    }
                },
                new EnergieMeting(GebruiksType.Opbrengst)
                {
                    Id = 3,
                    DatumTijd = new System.DateTime(day: 3, month: 1, year: 2019),
                    Energie = new Energie()
                    {
                        Id = 3,
                        Kilowattuur = 24,
                        Prijs = 5
                    }
                },
                new EnergieMeting(GebruiksType.Opbrengst)
                {
                    Id = 4,
                    DatumTijd = new System.DateTime(day: 4, month: 1, year: 2019),
                    Energie = new Energie()
                    {
                        Id = 4,
                        Kilowattuur = 37,
                        Prijs = 5
                    }
                },
                new EnergieMeting(GebruiksType.Opbrengst)
                {
                    Id = 5,
                    DatumTijd = new System.DateTime(day: 5, month: 1, year: 2019),
                    Energie = new Energie()
                    {
                        Id = 5,
                        Kilowattuur = 35,
                        Prijs = 19
                    }
                },
                new EnergieMeting(GebruiksType.Opbrengst)
                {
                    Id = 6,
                    DatumTijd = new System.DateTime(day: 6, month: 1, year: 2019),
                    Energie = new Energie()
                    {
                        Id = 1,
                        Kilowattuur = 35,
                        Prijs = 19
                    }
                },
                new EnergieMeting(GebruiksType.Opbrengst)
                {
                    Id = 7,
                    DatumTijd = new System.DateTime(day: 7, month: 1, year: 2019),
                    Energie = new Energie()
                    {
                        Id = 1,
                        Kilowattuur = 35,
                        Prijs = 19
                    }
                },
                new EnergieMeting(GebruiksType.Opbrengst)
                {
                    Id = 8,
                    DatumTijd = new System.DateTime(day: 8, month: 1, year: 2019),
                    Energie = new Energie()
                    {
                        Id = 1,
                        Kilowattuur = 35,
                        Prijs = 19
                    }
                },
                new EnergieMeting(GebruiksType.Opbrengst)
                {
                    Id = 9,
                    DatumTijd = new System.DateTime(day: 9, month: 1, year: 2019),
                    Energie = new Energie()
                    {
                        Id = 1,
                        Kilowattuur = 35,
                        Prijs = 19
                    }
                },
                new EnergieMeting(GebruiksType.Opbrengst)
                {
                    Id = 10,
                    DatumTijd = new System.DateTime(day: 10, month: 1, year: 2019),
                    Energie = new Energie()
                    {
                        Id = 1,
                        Kilowattuur = 35,
                        Prijs = 19
                    }
                },
                new EnergieMeting(GebruiksType.Opbrengst)
                {
                    Id = 11,
                    DatumTijd = new System.DateTime(day: 11, month: 1, year: 2019),
                    Energie = new Energie()
                    {
                        Id = 1,
                        Kilowattuur = 35,
                        Prijs = 19
                    }
                },
                new EnergieMeting(GebruiksType.Opbrengst)
                {
                    Id = 12,
                    DatumTijd = new System.DateTime(day: 12, month: 1, year: 2019),
                    Energie = new Energie()
                    {
                        Id = 1,
                        Kilowattuur = 35,
                        Prijs = 19
                    }
                },
                new EnergieMeting(GebruiksType.Opbrengst)
                {
                    Id = 13,
                    DatumTijd = new System.DateTime(day: 13, month: 1, year: 2019),
                    Energie = new Energie()
                    {
                        Id = 1,
                        Kilowattuur = 35,
                        Prijs = 19
                    }
                },
                new EnergieMeting(GebruiksType.Opbrengst)
                {
                    Id = 14,
                    DatumTijd = new System.DateTime(day: 14, month: 1, year: 2019),
                    Energie = new Energie()
                    {
                        Id = 1,
                        Kilowattuur = 35,
                        Prijs = 19
                    }
                },
                new EnergieMeting(GebruiksType.Opbrengst)
                {
                    Id = 15,
                    DatumTijd = new System.DateTime(day: 15, month: 1, year: 2019),
                    Energie = new Energie()
                    {
                        Id = 1,
                        Kilowattuur = 35,
                        Prijs = 19
                    }
                },
                new EnergieMeting(GebruiksType.Opbrengst)
                {
                    Id = 16,
                    DatumTijd = new System.DateTime(day: 16, month: 1, year: 2019),
                    Energie = new Energie()
                    {
                        Id = 1,
                        Kilowattuur = 35,
                        Prijs = 19
                    }
                },
                new EnergieMeting(GebruiksType.Opbrengst)
                {
                    Id = 17,
                    DatumTijd = new System.DateTime(day: 17, month: 1, year: 2019),
                    Energie = new Energie()
                    {
                        Id = 1,
                        Kilowattuur = 35,
                        Prijs = 19
                    }
                },
                new EnergieMeting(GebruiksType.Opbrengst)
                {
                    Id = 18,
                    DatumTijd = new System.DateTime(day: 18, month: 1, year: 2019),
                    Energie = new Energie()
                    {
                        Id = 1,
                        Kilowattuur = 35,
                        Prijs = 19
                    }
                },
                new EnergieMeting(GebruiksType.Opbrengst)
                {
                    Id = 19,
                    DatumTijd = new System.DateTime(day: 19, month: 1, year: 2019),
                    Energie = new Energie()
                    {
                        Id = 1,
                        Kilowattuur = 35,
                        Prijs = 19
                    }
                },
                new EnergieMeting(GebruiksType.Opbrengst)
                {
                    Id = 20,
                    DatumTijd = new System.DateTime(day: 20, month: 1, year: 2019),
                    Energie = new Energie()
                    {
                        Id = 1,
                        Kilowattuur = 35,
                        Prijs = 19
                    }
                },
                new EnergieMeting(GebruiksType.Opbrengst)
                {
                    Id = 21,
                    DatumTijd = new System.DateTime(day: 21, month: 1, year: 2019),
                    Energie = new Energie()
                    {
                        Id = 1,
                        Kilowattuur = 35,
                        Prijs = 19
                    }
                },
                new EnergieMeting(GebruiksType.Opbrengst)
                {
                    Id = 22,
                    DatumTijd = new System.DateTime(day: 22, month: 1, year: 2019),
                    Energie = new Energie()
                    {
                        Id = 22,
                        Kilowattuur = 5,
                        Prijs = 10
                    }
                },
                new EnergieMeting(GebruiksType.Opbrengst)
                {
                    Id = 23,
                    DatumTijd = new System.DateTime(day: 23, month: 1, year: 2019),
                    Energie = new Energie()
                    {
                        Id = 23,
                        Kilowattuur = 5,
                        Prijs = 10
                    }
                },
                new EnergieMeting(GebruiksType.Opbrengst)
                {
                    Id = 24,
                    DatumTijd = new System.DateTime(day: 24, month: 1, year: 2019),
                    Energie = new Energie()
                    {
                        Id = 24,
                        Kilowattuur = 5,
                        Prijs = 10
                    }
                },
                new EnergieMeting(GebruiksType.Opbrengst)
                {
                    Id = 25,
                    DatumTijd = new System.DateTime(day: 25, month: 1, year: 2019),
                    Energie = new Energie()
                    {
                        Id = 25,
                        Kilowattuur = 5,
                        Prijs = 10
                    }
                },
                new EnergieMeting(GebruiksType.Opbrengst)
                {
                    Id = 26,
                    DatumTijd = new System.DateTime(day: 26, month: 1, year: 2019),
                    Energie = new Energie()
                    {
                        Id = 26,
                        Kilowattuur = 5,
                        Prijs = 10
                    }
                },
                new EnergieMeting(GebruiksType.Opbrengst)
                {
                    Id = 27,
                    DatumTijd = new System.DateTime(day: 27, month: 1, year: 2019),
                    Energie = new Energie()
                    {
                        Id = 27,
                        Kilowattuur = 5,
                        Prijs = 10
                    }
                },
                new EnergieMeting(GebruiksType.Opbrengst)
                {
                    Id = 28,
                    DatumTijd = new System.DateTime(day: 28, month: 1, year: 2019),
                    Energie = new Energie()
                    {
                        Id = 28,
                        Kilowattuur = 5,
                        Prijs = 10
                    }
                },
                new EnergieMeting(GebruiksType.Opbrengst)
                {
                    Id = 29,
                    DatumTijd = new System.DateTime(day: 29, month: 1, year: 2019),
                    Energie = new Energie()
                    {
                        Id = 29,
                        Kilowattuur = 23,
                        Prijs = 10
                    }
                },
                new EnergieMeting(GebruiksType.Opbrengst)
                {
                    Id = 30,
                    DatumTijd = new System.DateTime(day: 30, month: 1, year: 2019),
                    Energie = new Energie()
                    {
                        Id = 30,
                        Kilowattuur = 21,
                        Prijs = 9
                    }
                },
                new EnergieMeting(GebruiksType.Opbrengst)
                {
                    Id = 31,
                    DatumTijd = new System.DateTime(day: 31, month: 1, year: 2019),
                    Energie = new Energie()
                    {
                        Id = 31,
                        Kilowattuur = 43,
                        Prijs = 6
                    }
                }
            };
        }
        public static List<EnergieMeting> GetEnergieMetingenFor2019()
        {
            return new List<EnergieMeting>() {
                new EnergieMeting(GebruiksType.Opbrengst)
                {
                    Id = 1,
                    DatumTijd = new System.DateTime(day: 1, month: 1, year: 2019),
                    Energie = new Energie()
                    {
                        Id = 1,
                        Kilowattuur = 13,
                        Prijs = 5
                    }
                },
                new EnergieMeting(GebruiksType.Verbruik)
                {
                    Id = 2,
                    DatumTijd = new System.DateTime(day: 1, month: 1, year: 2019),
                    Energie = new Energie()
                    {
                        Id = 2,
                        Kilowattuur = 20,
                        Prijs = 5
                    }
                },
                new EnergieMeting(GebruiksType.Opbrengst)
                {
                    Id = 3,
                    DatumTijd = new System.DateTime(day: 22, month: 2, year: 2019),
                    Energie = new Energie()
                    {
                        Id = 3,
                        Kilowattuur = 24,
                        Prijs = 5
                    }
                },
                new EnergieMeting(GebruiksType.Opbrengst)
                {
                    Id = 31,
                    DatumTijd = new System.DateTime(day: 22, month: 2, year: 2019),
                    Energie = new Energie()
                    {
                        Id = 3,
                        Kilowattuur = 24,
                        Prijs = 5
                    }
                },
                new EnergieMeting(GebruiksType.Verbruik)
                {
                    Id = 4,
                    DatumTijd = new System.DateTime(day: 22, month: 2, year: 2019),
                    Energie = new Energie()
                    {
                        Id = 4,
                        Kilowattuur = 37,
                        Prijs = 5
                    }
                },
                new EnergieMeting(GebruiksType.Opbrengst)
                {
                    Id = 5,
                    DatumTijd = new System.DateTime(day: 5, month: 3, year: 2019),
                    Energie = new Energie()
                    {
                        Id = 5,
                        Kilowattuur = 35,
                        Prijs = 19
                    }
                },
                new EnergieMeting(GebruiksType.Verbruik)
                {
                    Id = 6,
                    DatumTijd = new System.DateTime(day: 5, month: 3, year: 2019),
                    Energie = new Energie()
                    {
                        Id = 1,
                        Kilowattuur = 35,
                        Prijs = 19
                    }
                },
                new EnergieMeting(GebruiksType.Opbrengst)
                {
                    Id = 7,
                    DatumTijd = new System.DateTime(day: 7, month: 4, year: 2019),
                    Energie = new Energie()
                    {
                        Id = 1,
                        Kilowattuur = 35,
                        Prijs = 19
                    }
                },
                new EnergieMeting(GebruiksType.Verbruik)
                {
                    Id = 8,
                    DatumTijd = new System.DateTime(day: 7, month: 4, year: 2019),
                    Energie = new Energie()
                    {
                        Id = 1,
                        Kilowattuur = 35,
                        Prijs = 19
                    }
                },
                new EnergieMeting(GebruiksType.Opbrengst)
                {
                    Id = 9,
                    DatumTijd = new System.DateTime(day: 19, month: 5, year: 2019),
                    Energie = new Energie()
                    {
                        Id = 1,
                        Kilowattuur = 35,
                        Prijs = 19
                    }
                },
                new EnergieMeting(GebruiksType.Verbruik)
                {
                    Id = 10,
                    DatumTijd = new System.DateTime(day: 19, month: 5, year: 2019),
                    Energie = new Energie()
                    {
                        Id = 1,
                        Kilowattuur = 35,
                        Prijs = 19
                    }
                },
                new EnergieMeting(GebruiksType.Opbrengst)
                {
                    Id = 11,
                    DatumTijd = new System.DateTime(day: 11, month: 6, year: 2019),
                    Energie = new Energie()
                    {
                        Id = 1,
                        Kilowattuur = 35,
                        Prijs = 19
                    }
                },
                new EnergieMeting(GebruiksType.Verbruik)
                {
                    Id = 12,
                    DatumTijd = new System.DateTime(day: 11, month: 6, year: 2019),
                    Energie = new Energie()
                    {
                        Id = 1,
                        Kilowattuur = 35,
                        Prijs = 19
                    }
                },
                new EnergieMeting(GebruiksType.Opbrengst)
                {
                    Id = 13,
                    DatumTijd = new System.DateTime(day: 23, month: 7, year: 2019),
                    Energie = new Energie()
                    {
                        Id = 1,
                        Kilowattuur = 35,
                        Prijs = 19
                    }
                },
                new EnergieMeting(GebruiksType.Verbruik)
                {
                    Id = 14,
                    DatumTijd = new System.DateTime(day: 23, month: 7, year: 2019),
                    Energie = new Energie()
                    {
                        Id = 1,
                        Kilowattuur = 35,
                        Prijs = 19
                    }
                },
                new EnergieMeting(GebruiksType.Opbrengst)
                {
                    Id = 15,
                    DatumTijd = new System.DateTime(day: 15, month: 8, year: 2019),
                    Energie = new Energie()
                    {
                        Id = 1,
                        Kilowattuur = 35,
                        Prijs = 19
                    }
                },
                new EnergieMeting(GebruiksType.Verbruik)
                {
                    Id = 16,
                    DatumTijd = new System.DateTime(day: 15, month: 8, year: 2019),
                    Energie = new Energie()
                    {
                        Id = 1,
                        Kilowattuur = 35,
                        Prijs = 19
                    }
                },
                new EnergieMeting(GebruiksType.Opbrengst)
                {
                    Id = 17,
                    DatumTijd = new System.DateTime(day: 17, month: 9, year: 2019),
                    Energie = new Energie()
                    {
                        Id = 1,
                        Kilowattuur = 35,
                        Prijs = 19
                    }
                },
                new EnergieMeting(GebruiksType.Verbruik)
                {
                    Id = 18,
                    DatumTijd = new System.DateTime(day: 17, month: 9, year: 2019),
                    Energie = new Energie()
                    {
                        Id = 1,
                        Kilowattuur = 35,
                        Prijs = 19
                    }
                },
                new EnergieMeting(GebruiksType.Opbrengst)
                {
                    Id = 19,
                    DatumTijd = new System.DateTime(day: 19, month: 10, year: 2019),
                    Energie = new Energie()
                    {
                        Id = 1,
                        Kilowattuur = 35,
                        Prijs = 19
                    }
                },
                new EnergieMeting(GebruiksType.Verbruik)
                {
                    Id = 20,
                    DatumTijd = new System.DateTime(day: 20, month: 10, year: 2019),
                    Energie = new Energie()
                    {
                        Id = 1,
                        Kilowattuur = 35,
                        Prijs = 19
                    }
                },
                new EnergieMeting(GebruiksType.Opbrengst)
                {
                    Id = 21,
                    DatumTijd = new System.DateTime(day: 21, month: 11, year: 2019),
                    Energie = new Energie()
                    {
                        Id = 1,
                        Kilowattuur = 35,
                        Prijs = 19
                    }
                },
                new EnergieMeting(GebruiksType.Verbruik)
                {
                    Id = 22,
                    DatumTijd = new System.DateTime(day: 22, month: 11, year: 2019),
                    Energie = new Energie()
                    {
                        Id = 22,
                        Kilowattuur = 5,
                        Prijs = 10
                    }
                },
                new EnergieMeting(GebruiksType.Opbrengst)
                {
                    Id = 23,
                    DatumTijd = new System.DateTime(day: 30, month: 12, year: 2019),
                    Energie = new Energie()
                    {
                        Id = 23,
                        Kilowattuur = 5,
                        Prijs = 10
                    }
                },
                new EnergieMeting(GebruiksType.Verbruik)
                {
                    Id = 24,
                    DatumTijd = new System.DateTime(day: 30, month: 12, year: 2019),
                    Energie = new Energie()
                    {
                        Id = 24,
                        Kilowattuur = 5,
                        Prijs = 10
                    }
                }
            };
        }
    }
}

using Fullstuck.EnergieService.Models;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace Fullstuck.EnergieService.BLL.Test
{
    [TestClass]
    public class EnergieCalculationLogicTest
    {
        [TestMethod]
        public void CalculateTotal_ShouldReturn20_OnlyOpbrengstMetingen()
        {
            //Arrange
            var target = new EnergieCalculationLogic();
            var energieMetingenToCalculate = new List<EnergieMeting>()
            {
                new EnergieMeting(GebruiksType.Opbrengst)
                {
                    Id = 1,
                    DatumTijd = new System.DateTime(2019, 2, 28),
                    Energie = new Energie(){ Id = 1, Kilowattuur = 10, Prijs = 9 }
                },
                new EnergieMeting(GebruiksType.Opbrengst)
                {
                    Id = 2,
                    DatumTijd = new System.DateTime(2019, 2, 28),
                    Energie = new Energie(){ Id = 2, Kilowattuur = 5, Prijs = 9 }
                },
                new EnergieMeting(GebruiksType.Opbrengst)
                {
                    Id = 3,
                    DatumTijd = new System.DateTime(2019, 2, 28),
                    Energie = new Energie(){ Id = 3, Kilowattuur = 5, Prijs = 9 }
                }
            };

            //Act
            var result = target.CalculateTotalKilowattuur(energieMetingenToCalculate);

            //Assert
            Assert.AreEqual(20, result.Energie.Kilowattuur);
        }

        [TestMethod]
        public void CalculateTotal_ShouldReturn20_OnlyVerbruikMetingen()
        {
            //Arrange
            var target = new EnergieCalculationLogic();
            var energieMetingenToCalculate = new List<EnergieMeting>()
            {
                new EnergieMeting(GebruiksType.Verbruik)
                {
                    Id = 1,
                    DatumTijd = new System.DateTime(2019, 2, 28),
                    Energie = new Energie(){ Id = 1, Kilowattuur = 10, Prijs = 9 }
                },
                new EnergieMeting(GebruiksType.Verbruik)
                {
                    Id = 2,
                    DatumTijd = new System.DateTime(2019, 2, 28),
                    Energie = new Energie(){ Id = 2, Kilowattuur = 5, Prijs = 9 }
                },
                new EnergieMeting(GebruiksType.Verbruik)
                {
                    Id = 3,
                    DatumTijd = new System.DateTime(2019, 2, 28),
                    Energie = new Energie(){ Id = 3, Kilowattuur = 5, Prijs = 9 }
                }
            };

            //Act
            var result = target.CalculateTotalKilowattuur(energieMetingenToCalculate);

            //Assert
            Assert.AreEqual(20, result.Energie.Kilowattuur);
        }

        [TestMethod]
        public void CalculateTotal_ShouldReturn20_BothGebruiksTypes()
        {
            //Arrange
            var target = new EnergieCalculationLogic();
            var energieMetingenToCalculate = new List<EnergieMeting>()
            {
                new EnergieMeting(GebruiksType.Verbruik)
                {
                    Id = 1,
                    DatumTijd = new System.DateTime(2019, 2, 28),
                    Energie = new Energie(){ Id = 1, Kilowattuur = 10, Prijs = 9 }
                },
                new EnergieMeting(GebruiksType.Opbrengst)
                {
                    Id = 2,
                    DatumTijd = new System.DateTime(2019, 2, 28),
                    Energie = new Energie(){ Id = 2, Kilowattuur = 5, Prijs = 9 }
                },
                new EnergieMeting(GebruiksType.Verbruik)
                {
                    Id = 3,
                    DatumTijd = new System.DateTime(2019, 2, 28),
                    Energie = new Energie(){ Id = 3, Kilowattuur = 5, Prijs = 9 }
                }
            };

            //Act
            var result = target.CalculateTotalKilowattuur(energieMetingenToCalculate);

            //Assert
            Assert.AreEqual(20, result.Energie.Kilowattuur);
        }

        [TestMethod]
        public void AreThereTwoGebruiksTypes_ShouldReturnTrue_2VerbruikMetingen()
        {
            //Arrange
            var target = new EnergieCalculationLogic();
            var energieMetingenToCheck = new List<EnergieMeting>()
            {
                new EnergieMeting(GebruiksType.Verbruik)
                {
                    Id = 1,
                    DatumTijd = new System.DateTime(2019, 2, 28),
                    Energie = new Energie(){ Id = 1, Kilowattuur = 10, Prijs = 9 }
                },
                new EnergieMeting(GebruiksType.Verbruik)
                {
                    Id = 3,
                    DatumTijd = new System.DateTime(2019, 2, 28),
                    Energie = new Energie(){ Id = 3, Kilowattuur = 5, Prijs = 9 }
                }
            };

            //Act
            var result = target.AreThereTwoGebruiksTypes(energieMetingenToCheck);

            //Assert
            Assert.IsFalse(result);
        }
        
        [TestMethod]
        public void AreThereTwoGebruiksTypes_ShouldReturnTrue_2OpbrengstMetingen()
        {
            //Arrange
            var target = new EnergieCalculationLogic();
            var energieMetingenToCheck = new List<EnergieMeting>()
            {
                new EnergieMeting(GebruiksType.Opbrengst)
                {
                    Id = 1,
                    DatumTijd = new System.DateTime(2019, 2, 28),
                    Energie = new Energie(){ Id = 1, Kilowattuur = 10, Prijs = 9 }
                },
                new EnergieMeting(GebruiksType.Opbrengst)
                {
                    Id = 3,
                    DatumTijd = new System.DateTime(2019, 2, 28),
                    Energie = new Energie(){ Id = 3, Kilowattuur = 5, Prijs = 9 }
                }
            };

            //Act
            var result = target.AreThereTwoGebruiksTypes(energieMetingenToCheck);

            //Assert
            Assert.IsFalse(result);
        }

        [TestMethod]
        public void AreThereTwoGebruiksTypes_ShouldReturnFalse_1OpbrengstMeting_1VerbruikMeting()
        {
            //Arrange
            var target = new EnergieCalculationLogic();
            var energieMetingenToCheck = new List<EnergieMeting>()
            {
                new EnergieMeting(GebruiksType.Opbrengst)
                {
                    Id = 1,
                    DatumTijd = new System.DateTime(2019, 2, 28),
                    Energie = new Energie(){ Id = 1, Kilowattuur = 10, Prijs = 9 }
                },
                new EnergieMeting(GebruiksType.Verbruik)
                {
                    Id = 3,
                    DatumTijd = new System.DateTime(2019, 2, 28),
                    Energie = new Energie(){ Id = 3, Kilowattuur = 5, Prijs = 9 }
                }
            };

            //Act
            var result = target.AreThereTwoGebruiksTypes(energieMetingenToCheck);

            //Assert
            Assert.IsTrue(result);
        }

        [TestMethod]
        public void GetEnergieMetingenPerMaand_ShouldReturn2Februari_2MetingenFebruari()
        {
            //Arrange
            var target = new EnergieCalculationLogic();
            var energieMetingenToGroup = new List<EnergieMeting>()
            {
                new EnergieMeting(GebruiksType.Opbrengst)
                {
                    Id = 1,
                    DatumTijd = new System.DateTime(2019, 2, 28),
                    Energie = new Energie(){ Id = 1, Kilowattuur = 10, Prijs = 9 }
                },
                new EnergieMeting(GebruiksType.Opbrengst)
                {
                    Id = 3,
                    DatumTijd = new System.DateTime(2019, 2, 28),
                    Energie = new Energie(){ Id = 3, Kilowattuur = 5, Prijs = 9 }
                }
            };

            //Act
            var result = target.GetEnergieMetingenPerMaand(energieMetingenToGroup, 2);

            //Assert
            Assert.AreEqual(2, result.Count);
            Assert.AreEqual(2, result[1].DatumTijd.Month);
        }

        [TestMethod]
        public void GetEnergieMetingenPerMaand_ShouldReturn2Februari_1MetingJanuariAnd2MetingenFebruari()
        {
            //Arrange
            var target = new EnergieCalculationLogic();
            var energieMetingenToGroup = new List<EnergieMeting>()
            {
                new EnergieMeting(GebruiksType.Opbrengst)
                {
                    Id = 1,
                    DatumTijd = new System.DateTime(2019, 1, 30),
                    Energie = new Energie(){ Id = 1, Kilowattuur = 10, Prijs = 9 }
                },
                new EnergieMeting(GebruiksType.Opbrengst)
                {
                    Id = 2,
                    DatumTijd = new System.DateTime(2019, 2, 28),
                    Energie = new Energie(){ Id = 3, Kilowattuur = 5, Prijs = 9 }
                },
                new EnergieMeting(GebruiksType.Opbrengst)
                {
                    Id = 3,
                    DatumTijd = new System.DateTime(2019, 2, 28),
                    Energie = new Energie(){ Id = 3, Kilowattuur = 5, Prijs = 9 }
                }
            };

            //Act
            var result = target.GetEnergieMetingenPerMaand(energieMetingenToGroup, 2);

            //Assert
            Assert.AreEqual(2, result.Count);
            Assert.AreEqual(2, result[1].DatumTijd.Month);
        }

        [TestMethod]
        public void GetEnergieMetingenPerDag_ShouldReturn2EenFebruari_2MetingenEenFebruari()
        {
            //Arrange
            var target = new EnergieCalculationLogic();
            var energieMetingenToGroup = new List<EnergieMeting>()
            {
                new EnergieMeting(GebruiksType.Opbrengst)
                {
                    Id = 1,
                    DatumTijd = new System.DateTime(2019, 2, 1),
                    Energie = new Energie(){ Id = 1, Kilowattuur = 10, Prijs = 9 }
                },
                new EnergieMeting(GebruiksType.Opbrengst)
                {
                    Id = 3,
                    DatumTijd = new System.DateTime(2019, 2, 1),
                    Energie = new Energie(){ Id = 3, Kilowattuur = 5, Prijs = 9 }
                }
            };

            //Act
            var result = target.GetEnergieMetingenPerDag(energieMetingenToGroup, 1);

            //Assert
            Assert.AreEqual(2, result.Count);
            Assert.AreEqual(2, result[1].DatumTijd.Month);
        }

        [TestMethod]
        public void GetEnergieMetingenPerDag_ShouldReturn2EenFebruari_2MetingenEenFebruari1MetingTweeFebruari()
        {
            //Arrange
            var target = new EnergieCalculationLogic();
            var energieMetingenToGroup = new List<EnergieMeting>()
            {
                new EnergieMeting(GebruiksType.Opbrengst)
                {
                    Id = 1,
                    DatumTijd = new System.DateTime(2019, 2, 2),
                    Energie = new Energie(){ Id = 1, Kilowattuur = 10, Prijs = 9 }
                },
                new EnergieMeting(GebruiksType.Opbrengst)
                {
                    Id = 2,
                    DatumTijd = new System.DateTime(2019, 2, 1),
                    Energie = new Energie(){ Id = 2, Kilowattuur = 5, Prijs = 9 }
                },
                new EnergieMeting(GebruiksType.Opbrengst)
                {
                    Id = 3,
                    DatumTijd = new System.DateTime(2019, 2, 1),
                    Energie = new Energie(){ Id = 3, Kilowattuur = 5, Prijs = 9 }
                }
            };

            //Act
            var result = target.GetEnergieMetingenPerDag(energieMetingenToGroup, 1);

            //Assert
            Assert.AreEqual(2, result.Count);
            Assert.AreEqual(2, result[1].DatumTijd.Month);
        }

        [TestMethod]
        public void GetCalculationOfEnergieMetingen_Returns12_OnJaarRequest_With1InputMeting()
        {
            //Arrange
            var target = new EnergieCalculationLogic();
            var energieMetingenToGroup = new List<EnergieMeting>()
            {
                new EnergieMeting(GebruiksType.Opbrengst)
                {
                    Id = 1,
                    DatumTijd = new System.DateTime(2019, 1, 1),
                    Energie = new Energie(){ Id = 1, Kilowattuur = 10, Prijs = 9 }
                }
            };

            //Act
            var result = target.GetCalculationOfEnergieMetingen(energieMetingenToGroup, RequestType.Jaar);

            //Assert
            Assert.AreEqual(12, result.Count);
        }

        [TestMethod]
        public void GetCalculationOfEnergieMetingen_Returns28_OnMaandRequestFebruari2019_With1InputMeting()
        {
            //Arrange
            var target = new EnergieCalculationLogic();
            var energieMetingenToGroup = new List<EnergieMeting>()
            {
                new EnergieMeting(GebruiksType.Opbrengst)
                {
                    Id = 1,
                    DatumTijd = new System.DateTime(2019, 2, 1),
                    Energie = new Energie(){ Id = 1, Kilowattuur = 10, Prijs = 9 }
                }
            };

            //Act
            var result = target.GetCalculationOfEnergieMetingen(energieMetingenToGroup, RequestType.Maand);

            //Assert
            Assert.AreEqual(28, result.Count);
        }

        [TestMethod]
        public void GetCalculationOfEnergieMetingen_Returns24_OnDayRequest_With1InputMeting()
        {
            //Arrange
            var target = new EnergieCalculationLogic();
            var energieMetingenToGroup = new List<EnergieMeting>()
            {
                new EnergieMeting(GebruiksType.Opbrengst)
                {
                    Id = 1,
                    DatumTijd = new System.DateTime(2019, 2, 1),
                    Energie = new Energie(){ Id = 1, Kilowattuur = 10, Prijs = 9 }
                }
            };

            //Act
            var result = target.GetCalculationOfEnergieMetingen(energieMetingenToGroup, RequestType.Dag);

            //Assert
            Assert.AreEqual(24, result.Count);
        }

        [TestMethod]
        public void GetCalculationOfEnergieMeting_Returns15Kilowattuur_OnJaarRequest_With2InputMetingen_1And2Januari2019()
        {
            //Arrange
            var target = new EnergieCalculationLogic();
            var energieMetingenToGroup = new List<EnergieMeting>()
            {
                new EnergieMeting(GebruiksType.Opbrengst)
                {
                    Id = 1,
                    DatumTijd = new System.DateTime(2019, 1, 1),
                    Energie = new Energie(){ Id = 1, Kilowattuur = 10, Prijs = 9 }
                },
                new EnergieMeting(GebruiksType.Opbrengst)
                {
                    Id = 1,
                    DatumTijd = new System.DateTime(2019, 1, 1),
                    Energie = new Energie(){ Id = 1, Kilowattuur = 5, Prijs = 9 }
                },
                new EnergieMeting(GebruiksType.Opbrengst)
                {
                    Id = 2,
                    DatumTijd = new System.DateTime(2019, 2, 2),
                    Energie = new Energie(){ Id = 1, Kilowattuur = 5, Prijs = 9 }
                },
                new EnergieMeting(GebruiksType.Opbrengst)
                {
                    Id = 3,
                    DatumTijd = new System.DateTime(2019, 3, 2),
                    Energie = new Energie(){ Id = 1, Kilowattuur = 5, Prijs = 9 }
                },
                new EnergieMeting(GebruiksType.Opbrengst)
                {
                    Id = 4,
                    DatumTijd = new System.DateTime(2019, 4, 2),
                    Energie = new Energie(){ Id = 1, Kilowattuur = 5, Prijs = 9 }
                },
                new EnergieMeting(GebruiksType.Opbrengst)
                {
                    Id = 5,
                    DatumTijd = new System.DateTime(2019, 5, 2),
                    Energie = new Energie(){ Id = 1, Kilowattuur = 5, Prijs = 9 }
                },
                new EnergieMeting(GebruiksType.Opbrengst)
                {
                    Id = 6,
                    DatumTijd = new System.DateTime(2019, 6, 2),
                    Energie = new Energie(){ Id = 1, Kilowattuur = 5, Prijs = 9 }
                },
                new EnergieMeting(GebruiksType.Opbrengst)
                {
                    Id = 7,
                    DatumTijd = new System.DateTime(2019, 7, 2),
                    Energie = new Energie(){ Id = 1, Kilowattuur = 5, Prijs = 9 }
                },
                new EnergieMeting(GebruiksType.Opbrengst)
                {
                    Id = 8,
                    DatumTijd = new System.DateTime(2019, 8, 2),
                    Energie = new Energie(){ Id = 1, Kilowattuur = 5, Prijs = 9 }
                },
                new EnergieMeting(GebruiksType.Opbrengst)
                {
                    Id = 9,
                    DatumTijd = new System.DateTime(2019, 9, 2),
                    Energie = new Energie(){ Id = 1, Kilowattuur = 5, Prijs = 9 }
                },
                new EnergieMeting(GebruiksType.Opbrengst)
                {
                    Id = 10,
                    DatumTijd = new System.DateTime(2019, 10, 2),
                    Energie = new Energie(){ Id = 1, Kilowattuur = 5, Prijs = 9 }
                },
                new EnergieMeting(GebruiksType.Opbrengst)
                {
                    Id = 11,
                    DatumTijd = new System.DateTime(2019, 11, 2),
                    Energie = new Energie(){ Id = 1, Kilowattuur = 5, Prijs = 9 }
                },
                new EnergieMeting(GebruiksType.Opbrengst)
                {
                    Id = 12,
                    DatumTijd = new System.DateTime(2019, 12, 2),
                    Energie = new Energie(){ Id = 1, Kilowattuur = 5, Prijs = 9 }
                }
            };

            //Act
            var result = target.GetCalculationOfEnergieMetingen(energieMetingenToGroup, RequestType.Jaar);

            //Assert
            Assert.AreEqual(15, result[0].Energie.Kilowattuur);
        }

        [TestMethod]
        public void GetCalculationOfEnergieMeting_Returns15Kilowattuur_OnMaandRequest_With2InputMetingen_1And2Januari2019()
        {
            //Arrange
            var target = new EnergieCalculationLogic();
            var energieMetingenToGroup = new List<EnergieMeting>()
            {
                new EnergieMeting(GebruiksType.Opbrengst)
                {
                    Id = 1,
                    DatumTijd = new System.DateTime(2019, 1, 1),
                    Energie = new Energie(){ Id = 1, Kilowattuur = 10, Prijs = 9 }
                },
                new EnergieMeting(GebruiksType.Opbrengst)
                {
                    Id = 1,
                    DatumTijd = new System.DateTime(2019, 1, 2),
                    Energie = new Energie(){ Id = 1, Kilowattuur = 5, Prijs = 9 }
                }
            };

            //Act
            var result = target.GetCalculationOfEnergieMetingen(energieMetingenToGroup, RequestType.Maand);

            //Assert
            Assert.AreEqual(31, result.Count);
            Assert.AreEqual(10, result[0].Energie.Kilowattuur);
            Assert.AreEqual(5, result[1].Energie.Kilowattuur);
        }

        [TestMethod]
        public void GetCalculationOfEnergieMeting_Returns15Kilowattuur_OnDagRequest_With2InputMetingen_1And2Januari2019()
        {
            //Arrange
            var target = new EnergieCalculationLogic();
            var energieMetingenToGroup = new List<EnergieMeting>()
            {
                new EnergieMeting(GebruiksType.Opbrengst)
                {
                    Id = 1,
                    DatumTijd = new System.DateTime(2019, 1, 1, 1, 0, 0),
                    Energie = new Energie(){ Id = 1, Kilowattuur = 10, Prijs = 9 }
                },
                new EnergieMeting(GebruiksType.Opbrengst)
                {
                    Id = 1,
                    DatumTijd = new System.DateTime(2019, 1, 1, 1, 0, 0),
                    Energie = new Energie(){ Id = 1, Kilowattuur = 5, Prijs = 9 }
                },
                new EnergieMeting(GebruiksType.Opbrengst)
                {
                    Id = 1,
                    DatumTijd = new System.DateTime(2019, 1, 1, 3, 0, 0),
                    Energie = new Energie(){ Id = 1, Kilowattuur = 5, Prijs = 9 }
                },
                new EnergieMeting(GebruiksType.Opbrengst)
                {
                    Id = 1,
                    DatumTijd = new System.DateTime(2019, 1, 1, 4, 0, 0),
                    Energie = new Energie(){ Id = 1, Kilowattuur = 5, Prijs = 9 }
                }
            };

            //Act
            var result = target.GetCalculationOfEnergieMetingen(energieMetingenToGroup, RequestType.Dag);

            //Assert
            Assert.AreEqual(15, result[0].Energie.Kilowattuur);
        }

        [TestMethod]
        public void GetProperDate_ReturnsCorrectDate_OnJaarRequest()
        {
            //Arrange
            var target = new EnergieCalculationLogic();

            //Act
            var result = target.GetProperDate(RequestType.Jaar, 2019, 11, 0, 9);

            //Assert
            Assert.AreEqual(2019, result.Year);
            Assert.AreEqual(9, result.Month);
            Assert.AreEqual(1, result.Day);
        }

        [TestMethod]
        public void GetProperDate_ReturnsCorrectDate_OnMaandRequest()
        {
            //Arrange
            var target = new EnergieCalculationLogic();

            //Act
            var result = target.GetProperDate(RequestType.Maand, 2019, 11, 0, 9);

            //Assert
            Assert.AreEqual(2019, result.Year);
            Assert.AreEqual(11, result.Month);
            Assert.AreEqual(9, result.Day);
        }
    }
}

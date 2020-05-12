using Fullstuck.EnergieService.DAL;
using Fullstuck.EnergieService.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Fullstuck.EnergieService.BLL
{
    public class EnergieLogic : IEnergieLogic
    {
        private readonly IEnergieCalculationLogic _calculationLogic;
        private readonly IMetingenService _energiecentraleService;

        public EnergieLogic(IMetingenService energiecentraleService)
        {
            _energiecentraleService = energiecentraleService;
            _calculationLogic = new EnergieCalculationLogic();
        }
        public List<EnergieMeting> GetBalans(int jaar)
        {
            var allVerbruikMetingenOfJaar = _energiecentraleService.ReadMetingenPerJaar(GebruiksType.Verbruik, jaar);
            var allOpbrengstMetingenOfJaar = _energiecentraleService.ReadMetingenPerJaar(GebruiksType.Opbrengst, jaar);
            var totalVerbruik = _calculationLogic.CalculateTotalKilowattuur(allVerbruikMetingenOfJaar);
            var totalOpbrengst= _calculationLogic.CalculateTotalKilowattuur(allOpbrengstMetingenOfJaar);

            return new List<EnergieMeting>()
            {
                totalVerbruik,
                totalOpbrengst
            };
        }

        public List<EnergieMeting> GetMetingPerJaar(GebruiksType type, int jaar)
        {
            var allMetingenOfJaar = _energiecentraleService.ReadMetingenPerJaar(type, jaar);
            return _calculationLogic.GetCalculationOfEnergieMetingen(allMetingenOfJaar, RequestType.Jaar);
        }

        public List<EnergieMeting> GetMetingPerMaand(GebruiksType type, int jaar, int maand)
        {
            var allMetingenOfMaand = _energiecentraleService.ReadMetingenPerMaand(type, jaar, maand);
            return _calculationLogic.GetCalculationOfEnergieMetingen(allMetingenOfMaand, RequestType.Maand);
        }

        public List<EnergieMeting> GetMetingPerDag(GebruiksType type, int jaar, int maand, int dag)
        {
            var allMetingenOfDag = _energiecentraleService.ReadMetingenPerDag(type, jaar, maand, dag);
            return _calculationLogic.GetCalculationOfEnergieMetingen(allMetingenOfDag, RequestType.Dag);
        }
    }
}

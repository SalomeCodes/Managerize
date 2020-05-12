using Fullstuck.EnergieService.Models;
using Fullstuck.EnergieService.DAL;
using System.Collections.Generic;

namespace Fullstuck.EnergieService.BLL
{
    public class EnergiemeterLogic : IEnergiemeterLogic
    {
        private readonly IEnergieCalculationLogic _calculationLogic;
        private readonly IEnergiemeterMetingenService _energiemeterService;

        public EnergiemeterLogic(IEnergiemeterMetingenService energiemeterService)
        {
            _energiemeterService = energiemeterService;
            _calculationLogic = new EnergieCalculationLogic();
        }

        public List<EnergieMeting> GetBalans(int meterId, int jaar)
        {
            var allVerbruikMetingenOfJaar = _energiemeterService.ReadMetingenPerJaar(GebruiksType.Verbruik, meterId, jaar);
            var allOpbrengstMetingenOfJaar = _energiemeterService.ReadMetingenPerJaar(GebruiksType.Opbrengst, meterId, jaar);
            var totalVerbruik = _calculationLogic.CalculateTotalKilowattuur(allVerbruikMetingenOfJaar);
            var totalOpbrengst = _calculationLogic.CalculateTotalKilowattuur(allOpbrengstMetingenOfJaar);

            return new List<EnergieMeting>()
            {
                totalVerbruik,
                totalOpbrengst
            };
        }

        public List<EnergieMeting> GetMetingPerDag(GebruiksType type, int meterId, int jaar, int maand, int dag)
        {
            var allMetingenOfDag = _energiemeterService.ReadMetingenPerDag(type, meterId, jaar, maand, dag);
            return _calculationLogic.GetCalculationOfEnergieMetingen(allMetingenOfDag, RequestType.Dag);
        }

        public List<EnergieMeting> GetMetingPerJaar(GebruiksType type, int meterId, int jaar)
        {
            var allMetingenOfJaar = _energiemeterService.ReadMetingenPerJaar(type, meterId, jaar);
            return _calculationLogic.GetCalculationOfEnergieMetingen(allMetingenOfJaar, RequestType.Jaar);
        }

        public List<EnergieMeting> GetMetingPerMaand(GebruiksType type, int meterId, int jaar, int maand)
        {
            var allMetingenOfMaand = _energiemeterService.ReadMetingenPerMaand(type, meterId, jaar, maand);
            return _calculationLogic.GetCalculationOfEnergieMetingen(allMetingenOfMaand, RequestType.Maand);
        }
    }
}

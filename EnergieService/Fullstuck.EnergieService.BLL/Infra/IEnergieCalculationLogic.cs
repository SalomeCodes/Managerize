using Fullstuck.EnergieService.Models;
using System.Collections.Generic;

namespace Fullstuck.EnergieService.BLL
{
    public interface IEnergieCalculationLogic
    {
        public List<EnergieMeting> GetCalculationOfEnergieMetingen(List<EnergieMeting> energieMetingen, RequestType type);
        public EnergieMeting CalculateTotalKilowattuur(List<EnergieMeting> energieMetingen);
    }
}

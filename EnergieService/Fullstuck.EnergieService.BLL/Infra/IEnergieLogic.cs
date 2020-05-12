using Fullstuck.EnergieService.Models;
using System.Collections.Generic;

namespace Fullstuck.EnergieService.BLL
{
    public interface IEnergieLogic
    {
        public List<EnergieMeting> GetBalans(int jaar);
        public List<EnergieMeting> GetMetingPerJaar(GebruiksType type, int jaar);
        public List<EnergieMeting> GetMetingPerMaand(GebruiksType type, int jaar, int maand);
        public List<EnergieMeting> GetMetingPerDag(GebruiksType type, int jaar, int maand, int dag);
    }
}

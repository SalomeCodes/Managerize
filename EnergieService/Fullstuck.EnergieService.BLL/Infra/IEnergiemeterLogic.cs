using Fullstuck.EnergieService.Models;
using System.Collections.Generic;

namespace Fullstuck.EnergieService.BLL
{
    public interface IEnergiemeterLogic
    {
        public List<EnergieMeting> GetBalans(int meterId, int jaar);
        public List<EnergieMeting> GetMetingPerJaar(GebruiksType type, int meterId, int jaar);
        public List<EnergieMeting> GetMetingPerMaand(GebruiksType type, int meterId, int jaar, int maand);
        public List<EnergieMeting> GetMetingPerDag(GebruiksType type, int meterId, int jaar, int maand, int dag);
    }
}

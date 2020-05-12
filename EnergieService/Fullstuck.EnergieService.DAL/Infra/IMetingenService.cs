using Fullstuck.EnergieService.Models;
using System.Collections.Generic;

namespace Fullstuck.EnergieService.DAL
{
    public interface IMetingenService
    {
        public List<EnergieMeting> ReadMetingenPerJaar(GebruiksType type, int jaar);
        public List<EnergieMeting> ReadMetingenPerMaand(GebruiksType type, int jaar, int maand);
        public List<EnergieMeting> ReadMetingenPerDag(GebruiksType type, int jaar, int maand, int dag);
    }
}

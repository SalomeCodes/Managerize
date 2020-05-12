using Fullstuck.EnergieService.Models;
using System.Collections.Generic;

namespace Fullstuck.EnergieService.DAL
{
    public interface IEnergiemeterMetingenService
    {
        public List<EnergieMeting> ReadMetingenPerJaar(GebruiksType type, int meterId, int jaar);
        public List<EnergieMeting> ReadMetingenPerMaand(GebruiksType type, int meterId, int jaar, int maand);
        public List<EnergieMeting> ReadMetingenPerDag(GebruiksType type, int meterId, int jaar, int maand, int dag);
    }
}

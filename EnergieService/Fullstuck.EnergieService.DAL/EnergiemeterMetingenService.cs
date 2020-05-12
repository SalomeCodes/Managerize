using Fullstuck.EnergieService.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Fullstuck.EnergieService.DAL
{
    public class EnergiemeterMetingenService : IEnergiemeterMetingenService
    {
        private readonly EnergystuckContext _energystuckContext;
        public EnergiemeterMetingenService(EnergystuckContext context)
        {
            _energystuckContext = context;
        }

        public List<EnergieMeting> ReadMetingenPerDag(GebruiksType type, int meterId, int jaar, int maand, int dag)
        {
            return _energystuckContext.EnergieMeting
                .Include(m => m.Energie)
                .Where(m => m.GebruiksType == type && m.DatumTijd.Year == jaar && m.DatumTijd.Month == maand && m.DatumTijd.Day == dag)
                .ToList();
        }

        public List<EnergieMeting> ReadMetingenPerJaar(GebruiksType type, int meterId, int jaar)
        {
            return _energystuckContext.EnergieMeting
                .Include(m => m.Energie)
                .Where(m => m.GebruiksType == type && m.Energiemeter.Id == meterId && m.DatumTijd.Year == jaar)
                .ToList();
        }

        public List<EnergieMeting> ReadMetingenPerMaand(GebruiksType type, int meterId, int jaar, int maand)
        {
            return _energystuckContext.EnergieMeting
                .Include(m => m.Energie)
                .Where(m => m.GebruiksType == type && m.Energiemeter.Id == meterId && m.DatumTijd.Year == jaar && m.DatumTijd.Month == maand)
                .ToList();
        }
    }
}

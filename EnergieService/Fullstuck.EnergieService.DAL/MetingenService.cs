using Fullstuck.EnergieService.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Fullstuck.EnergieService.DAL
{
    public class MetingenService : IMetingenService
    {
        private readonly EnergystuckContext _energystuckContext;

        public MetingenService(EnergystuckContext context) => _energystuckContext = context;

        public List<EnergieMeting> ReadMetingenPerJaar(GebruiksType type, int jaar)
        {
            return _energystuckContext.EnergieMeting
                .Include(m => m.Energie)
                .Where(m => m.GebruiksType == type && m.DatumTijd.Year == jaar)
                .ToList();
        }

        public List<EnergieMeting> ReadMetingenPerMaand(GebruiksType type, int jaar, int maand)
        {
            return _energystuckContext.EnergieMeting
                .Include(m => m.Energie)
                .Where(m => m.GebruiksType == type && m.DatumTijd.Year == jaar && m.DatumTijd.Month == maand)
                .ToList();
        }

        public List<EnergieMeting> ReadMetingenPerDag(GebruiksType type, int jaar, int maand, int dag)
        {
            return _energystuckContext.EnergieMeting
                .Include(m => m.Energie)
                .Where(m => m.GebruiksType == type && m.DatumTijd.Year == jaar && m.DatumTijd.Month == maand && m.DatumTijd.Day == dag)
                .ToList();
        }
    }
}

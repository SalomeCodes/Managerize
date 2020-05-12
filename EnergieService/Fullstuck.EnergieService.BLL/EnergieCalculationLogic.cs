using Fullstuck.EnergieService.DAL;
using Fullstuck.EnergieService.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Fullstuck.EnergieService.BLL
{
    public class EnergieCalculationLogic : IEnergieCalculationLogic
    {
        private readonly IMetingenService _energiecentraleService;

        public EnergieCalculationLogic() { }
        public EnergieCalculationLogic(IMetingenService energiecentraleService) => _energiecentraleService = energiecentraleService;

        public List<EnergieMeting> GetCalculationOfEnergieMetingen(List<EnergieMeting> energieMetingen, RequestType type)
        {
            var groupedMetingen = new List<EnergieMeting>();
            var jaar = energieMetingen[0].DatumTijd.Year;
            var maand = energieMetingen[0].DatumTijd.Month;
            var dag = energieMetingen[0].DatumTijd.Day;

            int amountOfListRecords = type == RequestType.Maand ? DateTime.DaysInMonth(jaar, maand) : (int)type;

            for (int entityDateIndexer = 1; entityDateIndexer <= amountOfListRecords; entityDateIndexer++)
            {
                var groupedMetingenPerDate = GroupMetingenOnDate(energieMetingen, type, entityDateIndexer);
                if (groupedMetingenPerDate.Count > 0)
                {
                    var calculatedMaandMeting = CalculateTotalKilowattuur(groupedMetingenPerDate);
                    calculatedMaandMeting.Id = entityDateIndexer;
                    calculatedMaandMeting.DatumTijd = GetProperDate(type, jaar, maand, dag, entityDateIndexer);

                    groupedMetingen.Add(calculatedMaandMeting);
                }
                else
                {
                    // Add default 0 value for kilowattuur
                    EnergieMeting energieMeting = new EnergieMeting();
                    energieMeting.Id = entityDateIndexer;
                    energieMeting.DatumTijd = GetProperDate(type, jaar, maand, dag, entityDateIndexer);

                    energieMeting.Energie = new Energie();
                    energieMeting.Energie.Id = 1;
                    energieMeting.Energie.Kilowattuur = 0;
                    
                    groupedMetingen.Add(energieMeting);
                }
            };

            return groupedMetingen;
        }
        public DateTime GetProperDate(RequestType type, int jaar, int maand, int dag, int index)
        {
            switch (type)
            {
                case RequestType.Jaar:
                    return new DateTime(jaar, index, 1);
                case RequestType.Maand:
                    return new DateTime(jaar, maand, index);
                case RequestType.Dag:
                    return new DateTime(jaar, maand, dag, index - 1, 0, 0);
                default:
                    return new DateTime(jaar, maand, index);
            }
        }
        public List<EnergieMeting> GroupMetingenOnDate(List<EnergieMeting> energieMetingen, RequestType type, int entityDateIndexer)
        {
            var groupedMetingen = new List<EnergieMeting>();

            switch (type)
            {
                case RequestType.Jaar:
                    groupedMetingen = GetEnergieMetingenPerMaand(energieMetingen, entityDateIndexer);
                    break;
                case RequestType.Maand:
                    groupedMetingen = GetEnergieMetingenPerDag(energieMetingen, entityDateIndexer);
                    break;
                case RequestType.Dag:
                    groupedMetingen = GetEnergieMetingenPerUur(energieMetingen, entityDateIndexer);
                    break;
            }
            return groupedMetingen;
        }
        public EnergieMeting CalculateTotalKilowattuur(List<EnergieMeting> energieMetingen)
        {
            if (energieMetingen.Count == 0)
            {
                // Add default 0 value for kilowattuur
                EnergieMeting energieMeting = new EnergieMeting();
                energieMeting.Energie = new Energie();
                energieMeting.Energie.Id = 1;
                energieMeting.Energie.Kilowattuur = 0;

                energieMetingen.Add(energieMeting);
            }

            var calculatedMeting = new EnergieMeting(energieMetingen[0].GebruiksType);

            foreach (var energieMeting in energieMetingen)
            {
                calculatedMeting.Energie.Kilowattuur += energieMeting.Energie.Kilowattuur;
            }

            return calculatedMeting;
        }
        public bool AreThereTwoGebruiksTypes(List<EnergieMeting> energieMetingen)
        {
            return energieMetingen.Any(m => m.GebruiksType != energieMetingen[0].GebruiksType);
        }
        public List<EnergieMeting> GetEnergieMetingenPerMaand(List<EnergieMeting> energieMetingen, int maandNummer)
        {
            return energieMetingen.Where(meting => meting.DatumTijd.Month == maandNummer).ToList();
        }
        public List<EnergieMeting> GetEnergieMetingenPerDag(List<EnergieMeting> energieMetingen, int dagNummer)
        {
            return energieMetingen.Where(meting => meting.DatumTijd.Day == dagNummer).ToList();
        }
        public List<EnergieMeting> GetEnergieMetingenPerUur(List<EnergieMeting> energieMetingen, int uur)
        {
            return energieMetingen.Where(meting => meting.DatumTijd.Hour == uur).ToList();
        }
    }
}

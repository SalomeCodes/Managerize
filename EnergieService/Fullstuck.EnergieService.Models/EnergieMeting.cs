using System;

namespace Fullstuck.EnergieService.Models
{
    public class EnergieMeting : IEquatable<EnergieMeting>
    {
        public int Id { get; set; }
        public Energie Energie { get; set; }
        public GebruiksType GebruiksType { get; private set; }
        public DateTime DatumTijd { get; set; }
        public Energiemeter Energiemeter { get; set; }
        public EnergieMeting() { }
        public EnergieMeting(GebruiksType gebruiksType)
        {
            GebruiksType = gebruiksType;
            Energie = new Energie();
        }

        public bool Equals(EnergieMeting other)
        {
            return GebruiksType == other.GebruiksType;
        }
    }
}

namespace Fullstuck.EnergieService.Models
{
    public class Locatie
    {
        public int Id { get; set; }
        public string Straat { get; set; }
        public string Huisnummer { get; set; }
        public string Postcode { get; set; }
        public string Gemeente { get; set; }
        public string Wijk { get; set; }
        public string Plaats { get; set; }
        public string Provincie { get; set; }
    }
}

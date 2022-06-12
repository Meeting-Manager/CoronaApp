namespace CoronaApp.Services.Models
{
    public class Location
    {
        public string City { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public string TheLocation { get; set; }
        public Patient PatientId { get; set; }
    }
}
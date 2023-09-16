namespace Booking_App_WebApi.Model
{
    public class Product
    {
        public int BoatId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int Capacity { get; set; }
        public decimal PricePerHour { get; set; }
        public string Location { get; set; }
        public List<string> Amenities { get; set; }
        //public List<DateTime> AvailableDates { get; set; }
        public string ManagerName { get; set; }
        public string ManagerContact { get; set; }
        public string ImageUrl { get; set; }
        public string EngineType { get; set; }
        public double Length { get; set; }
        public string Manufacturer { get; set; }
        public int YearOfManufacture { get; set; }
        public string RegistrationNumber { get; set; }
        public string InsuranceProvider { get; set; }
        public DateTime InsuranceExpiry { get; set; }
        public List<string> SafetyEquipment { get; set; }
        public List<Booking> Bookings { get; set; }

    }
}

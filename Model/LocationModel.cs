namespace Model
{
    public class LocationModel
    {
        public long? Id { get; set; }
        public string Name { get; set; }
        public string State { get; set; }
        public string City { get; set; }
        public string ZipCode { get; set; }
        public string Phone { get; set; }
        public string Fax { get; set; }
        public string Address { get; set; }
        public string Notes { get; set; }
        public bool EeoEnabled { get; set; }
        public long CountryId { get; set; }
        public long TimeZoneId { get; set; }
    }
}

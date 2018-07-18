using System;

namespace MongoCrud.Domain.Breweries
{
    public class Location
    {
        public Guid Id { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string Zip { get; set; }
        public string StreetAddress { get; set; }
        public string PhoneNumber { get; set; }
        public bool IsMain { get; set; }
    }
}
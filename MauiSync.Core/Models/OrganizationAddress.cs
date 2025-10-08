namespace MauiSync.Core.Models
{
    public class OrganizationAddress
    {
        public int Id { get; set; }
        public string? ZipCode { get; set; }
        public string Country { get; set; } = "Россия";
        public string? Region { get; set; }
        public string City { get; set; } = string.Empty;
        public string Street { get; set; } = string.Empty;
        public string Building { get; set; } = string.Empty;
        public string? Block { get; set; }
        public string? Entrance { get; set; }
        public string? ApartmentOffice { get; set; }
    }
}
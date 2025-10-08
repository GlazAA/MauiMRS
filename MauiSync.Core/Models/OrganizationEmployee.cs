namespace MauiSync.Core.Models
{
    public class OrganizationEmployee
    {
        public int Id { get; set; }
        public int OrganizationId { get; set; }
        public string FirstName { get; set; } = string.Empty;
        public string LastName { get; set; } = string.Empty;
        public string? MiddleName { get; set; }
        public string? Email { get; set; }

        public string? Position { get; set; }
        public string? WorkPhone { get; set; }

        public string? WorkPhoneSecondary { get; set; }
        public string? WorkEmail { get; set; }
        public bool IsActive { get; set; } = true;

        public Organization? Organization { get; set; }
    }
}
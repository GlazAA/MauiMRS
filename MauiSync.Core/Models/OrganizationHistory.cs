namespace MauiSync.Core.Models
{
    public class OrganizationHistory
    {
        public int Id { get; set; }
        public int OrganizationId { get; set; }
        public string FullName { get; set; } = string.Empty;
        public DateTime ChangeDate { get; set; }
        public string? ChangeReason { get; set; }

        public Organization? Organization { get; set; }
    }
}
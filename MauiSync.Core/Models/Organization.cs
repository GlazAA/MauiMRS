namespace MauiSync.Core.Models
{
    public class Organization
    {
        public int Id { get; set; }
        public string FullName { get; set; } = string.Empty;
        public string? ShortName { get; set; }
        public bool IsActive { get; set; } = true;

        // Навигационные свойства
        public List<OrganizationEmployee>? Employees { get; set; }
        public OrganizationData? Data { get; set; }
        public List<OrganizationHistory>? History { get; set; }
    }
}
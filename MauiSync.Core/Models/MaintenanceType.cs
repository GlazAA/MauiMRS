namespace MauiSync.Core.Models
{
    public class MaintenanceType
    {
        public int Id { get; set; }
        public string TypeName { get; set; } = string.Empty;
        public string? Description { get; set; }
        public int? RecommendedIntervalDays { get; set; }

        public List<ChecklistTemplate>? ChecklistTemplates { get; set; }
        public List<Checklist>? Checklists { get; set; }
        public List<MaintenanceHistory>? MaintenanceHistory { get; set; }
    }
}
namespace MauiSync.Core.Models
{
    public class Checklist
    {
        public int Id { get; set; }
        public int InstallationId { get; set; }
        public int MaintenanceTypeId { get; set; }
        public int? ChecklistTemplateId { get; set; }
        public int EngineerId { get; set; }
        public int? ResponsibleEmployeeId { get; set; }
        public DateTime? StartDate { get; set; }
        public DateTime? EndDate { get; set; }
        public string Status { get; set; } = "draft";
        public bool IsActive { get; set; } = true;

        public Installation? Installation { get; set; }
        public MaintenanceType? MaintenanceType { get; set; }
        public ChecklistTemplate? ChecklistTemplate { get; set; }
        public User? Engineer { get; set; }
        public OrganizationEmployee? ResponsibleEmployee { get; set; }
        public List<ChecklistResponse>? Responses { get; set; }
        public List<MediaFile>? MediaFiles { get; set; }
        public ChecklistDocumentation? Documentation { get; set; }
    }
}
namespace MauiSync.Core.Models
{
    public class MaintenanceHistory
    {
        public int Id { get; set; }
        public int InstallationId { get; set; }
        public int? ChecklistId { get; set; }
        public int MaintenanceTypeId { get; set; }
        public DateTime MaintenanceDate { get; set; }
        public DateTime? NextMaintenanceDate { get; set; }
        public int? EngineerId { get; set; }
        public string? Comments { get; set; }
        public bool IsActive { get; set; } = true;

        public Installation? Installation { get; set; }
        public Checklist? Checklist { get; set; }
        public MaintenanceType? MaintenanceType { get; set; }
        public User? Engineer { get; set; }
    }
}
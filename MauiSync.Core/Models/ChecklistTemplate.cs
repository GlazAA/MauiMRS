namespace MauiSync.Core.Models
{
    public class ChecklistTemplate
    {
        public int Id { get; set; }
        public int EquipmentTypeId { get; set; }
        public int MaintenanceTypeId { get; set; }
        public string TemplateName { get; set; } = string.Empty;
        public int Version { get; set; } = 1;
        public bool IsActive { get; set; } = true;

        public EquipmentType? EquipmentType { get; set; }
        public MaintenanceType? MaintenanceType { get; set; }
        public List<ChecklistTemplateItem>? Items { get; set; }
    }
}
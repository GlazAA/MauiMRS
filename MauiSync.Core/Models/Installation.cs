namespace MauiSync.Core.Models
{
    public class Installation
    {
        public int Id { get; set; }
        public int SystemId { get; set; }
        public int EquipmentTypeId { get; set; }
        public int? EquipmentModelId { get; set; }
        public string? CustomName { get; set; }
        public string? StandardModelName { get; set; }
        public string? StandardSerialNumber { get; set; }
        public string? CustomModelName { get; set; }
        public string? CustomSerialNumber { get; set; }
        public bool IsDataModified { get; set; }
        public bool IsActive { get; set; } = true;

        public System? System { get; set; }
        public EquipmentType? EquipmentType { get; set; }
        public EquipmentModel? EquipmentModel { get; set; }
        public List<Checklist>? Checklists { get; set; }
        public List<MaintenanceHistory>? MaintenanceHistory { get; set; }
    }
}
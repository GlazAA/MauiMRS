namespace MauiSync.Core.Models
{
    public class FacilitySystem
    {
        public int Id { get; set; }
        public int FacilityId { get; set; }
        public string Name { get; set; } = string.Empty;
        public string? Description { get; set; }
        public bool IsActive { get; set; } = true;

        public Facility? Facility { get; set; }
        public List<Installation>? Installations { get; set; }
        public List<SystemEquipmentType>? EquipmentTypes { get; set; }
    }
}
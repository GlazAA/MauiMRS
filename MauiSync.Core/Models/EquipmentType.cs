namespace MauiSync.Core.Models
{
    public class EquipmentType
    {
        public int Id { get; set; }
        public string TypeName { get; set; } = string.Empty;

        public List<SystemEquipmentType>? SystemEquipmentTypes { get; set; }
        public List<Installation>? Installations { get; set; }
    }
}
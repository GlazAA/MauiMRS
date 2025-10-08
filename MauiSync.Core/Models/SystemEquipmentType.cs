namespace MauiSync.Core.Models
{
    public class SystemEquipmentType
    {
        public int SystemId { get; set; }
        public int EquipmentTypeId { get; set; }

        public System? System { get; set; }
        public EquipmentType? EquipmentType { get; set; }
    }
}
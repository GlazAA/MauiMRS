namespace MauiSync.Core.Models
{
    public class SystemEquipmentType
    {
        public int FacilityId { get; set; }
        public int EquipmentTypeId { get; set; }

        public FacilitySystem? System { get; set; }
        public EquipmentType? EquipmentType { get; set; }
    }
}
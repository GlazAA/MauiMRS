namespace MauiSync.Core.Models
{
    public class EquipmentModel
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public string? Manufacturer { get; set; }
        public string? Specifications { get; set; }

        public List<Installation>? Installations { get; set; }
    }
}
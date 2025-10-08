namespace MauiSync.Core.Models
{
    public class FieldType
    {
        public int Id { get; set; }
        public string TypeName { get; set; } = string.Empty;

        public List<ChecklistTemplateItem>? ChecklistTemplateItems { get; set; }
    }
}
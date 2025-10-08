namespace MauiSync.Core.Models
{
    public class ChecklistTemplateItem
    {
        public int Id { get; set; }
        public int ChecklistTemplateId { get; set; }
        public int SortOrder { get; set; }
        public string QuestionText { get; set; } = string.Empty;
        public int FieldTypeId { get; set; }
        public bool IsRequired { get; set; }

        public ChecklistTemplate? ChecklistTemplate { get; set; }
        public FieldType? FieldType { get; set; }
        public List<ChecklistResponse>? Responses { get; set; }
    }
}
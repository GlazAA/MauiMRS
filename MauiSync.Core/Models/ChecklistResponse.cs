namespace MauiSync.Core.Models
{
    public class ChecklistResponse
    {
        public int Id { get; set; }
        public int ChecklistId { get; set; }
        public int ChecklistTemplateItemId { get; set; }
        public bool? BooleanResponse { get; set; }
        public string? TextResponse { get; set; }
        public double? NumericResponse { get; set; }

        public Checklist? Checklist { get; set; }
        public ChecklistTemplateItem? ChecklistTemplateItem { get; set; }
    }
}
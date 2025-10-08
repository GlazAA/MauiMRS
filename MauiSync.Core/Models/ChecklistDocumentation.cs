namespace MauiSync.Core.Models
{
    public class ChecklistDocumentation
    {
        public int Id { get; set; }
        public int ChecklistId { get; set; }
        public string? Comments { get; set; }
        public string? Recommendations { get; set; }

        public Checklist? Checklist { get; set; }
    }
}
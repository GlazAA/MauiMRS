namespace MauiSync.Core.Models
{
    public class MediaFile
    {
        public int Id { get; set; }
        public int ChecklistId { get; set; }
        public string FilePath { get; set; } = string.Empty;
        public string? FileName { get; set; }
        public string? MimeType { get; set; }
        public string? Description { get; set; }

        public Checklist? Checklist { get; set; }
    }
}
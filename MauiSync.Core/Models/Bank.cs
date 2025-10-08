namespace MauiSync.Core.Models
{
    public class Bank
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public string? Bic { get; set; }
        public string? CorrespondentAccount { get; set; }
    }
}
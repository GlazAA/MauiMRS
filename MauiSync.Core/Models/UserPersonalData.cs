namespace MauiSync.Core.Models
{
    public class UserPersonalData
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public string? PassportSeries { get; set; }
        public string? PassportNumber { get; set; }
        public string? PassportIssuedBy { get; set; }
        public string? PassportIssueDate { get; set; }
        public string? PassportDepartmentCode { get; set; }
    }
}
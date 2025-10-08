namespace MauiSync.Core.Models
{
    public class User
    {
        public int Id { get; set; }
        public int UserRoleId { get; set; }
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public string? MiddleName { get; set; }

        public string Login { get; set; } = string.Empty;
        public string PasswordHash { get; set; } = string.Empty;
        public string? Email { get; set; }
        public string? PhoneNumber { get; set; }
        public string? PhoneNumberSecondary { get; set; }
        public bool IsActive { get; set; } = true;

        

        // Навигационные свойства
        public UserRole? UserRole { get; set; }
        public UserPersonalData? PersonalData { get; set; }
    }
}
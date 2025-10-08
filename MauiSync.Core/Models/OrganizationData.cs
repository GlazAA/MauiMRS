namespace MauiSync.Core.Models
{
    public class OrganizationData
    {
        public int Id { get; set; }
        public int OrganizationId { get; set; }
        public int LegalAddressId { get; set; }
        public int OwnershipFormId { get; set; }
        public string Inn { get; set; } = string.Empty;
        public string? Kpp { get; set; }
        public string Ogrn { get; set; } = string.Empty;
        public int? BankId { get; set; }
        public string? PaymentAccount { get; set; }
        public string? CeoFullName { get; set; }
        public bool IsActive { get; set; } = true;

        // Навигационные свойства
        public Organization? Organization { get; set; }
        public OrganizationAddress? LegalAddress { get; set; }
        public OwnershipForm? OwnershipForm { get; set; }
        public Bank? Bank { get; set; }
    }
}
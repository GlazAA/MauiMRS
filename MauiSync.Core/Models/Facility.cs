namespace MauiSync.Core.Models
{
	public class Facility
	{
		public int Id { get; set; }
		public int OrganizationId { get; set; }
		public int? ResponsibleEmployeeId { get; set; }
		public int? SecondaryContactId { get; set; }
		public string Name { get; set; } = string.Empty;
		public int AddressId { get; set; }
		public bool IsActive { get; set; } = true;

		public Organization? Organization { get; set; }
		public OrganizationAddress? Address { get; set; }
		public OrganizationEmployee? ResponsibleEmployee { get; set; }
		public OrganizationEmployee? SecondaryContact { get; set; }
		public List<System>? Systems { get; set; }
	}
}
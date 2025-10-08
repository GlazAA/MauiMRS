using MauiSync.Core.Models;

namespace MauiSync.Core.Services
{
    public interface IDataService
    {
        Task<List<Organization>> GetOrganizationsAsync();
        Task<List<Facility>> GetFacilitiesAsync(int organizationId);
        Task<List<FacilitySystem>> GetSystemsAsync(int facilityId); // ������ ���� GetSystemsAsync
        Task<List<EquipmentType>> GetEquipmentTypesAsync(int systemId);
    }

    public class MockDataService : IDataService
    {
        public Task<List<Organization>> GetOrganizationsAsync()
        {
            var organizations = new List<Organization>
            {
                new Organization { Id = 1, FullName = "��� ���� � ������", ShortName = "����" },
                new Organization { Id = 2, FullName = "��� ������", ShortName = "������" }
            };
            return Task.FromResult(organizations);
        }

        public Task<List<Facility>> GetFacilitiesAsync(int organizationId)
        {
            var facilities = new List<Facility>
            {
                new Facility { Id = 1, OrganizationId = organizationId, Name = "����� �1" },
                new Facility { Id = 2, OrganizationId = organizationId, Name = "����� �2" }
            };
            return Task.FromResult(facilities);
        }

        public Task<List<FacilitySystem>> GetSystemsAsync(int facilityId) // GetSystemsAsync
        {
            var systems = new List<FacilitySystem>
            {
                new FacilitySystem { Id = 1, FacilityId = facilityId, Name = "������� ����������" },
                new FacilitySystem { Id = 2, FacilityId = facilityId, Name = "�������������" }
            };
            return Task.FromResult(systems);
        }

        public Task<List<EquipmentType>> GetEquipmentTypesAsync(int systemId)
        {
            var equipment = new List<EquipmentType>
            {
                new EquipmentType { Id = 1, TypeName = "���������" },
                new EquipmentType { Id = 2, TypeName = "����������" },
                new EquipmentType { Id = 3, TypeName = "�����" },
                new EquipmentType { Id = 4, TypeName = "�����" }
            };
            return Task.FromResult(equipment);
        }
    }
}
using MauiSync.Core.Models;

namespace MauiSync.Core.Services
{
    public interface IDataService
    {
        Task<List<Organization>> GetOrganizationsAsync();
        Task<List<Facility>> GetFacilitiesAsync(int organizationId);
        Task<List<FacilitySystem>> GetSystemsAsync(int facilityId); // ДОЛЖНО БЫТЬ GetSystemsAsync
        Task<List<EquipmentType>> GetEquipmentTypesAsync(int systemId);
    }

    public class MockDataService : IDataService
    {
        public Task<List<Organization>> GetOrganizationsAsync()
        {
            var organizations = new List<Organization>
            {
                new Organization { Id = 1, FullName = "ООО Рога и копыта", ShortName = "Рога" },
                new Organization { Id = 2, FullName = "ПАО Крылья", ShortName = "Крылья" }
            };
            return Task.FromResult(organizations);
        }

        public Task<List<Facility>> GetFacilitiesAsync(int organizationId)
        {
            var facilities = new List<Facility>
            {
                new Facility { Id = 1, OrganizationId = organizationId, Name = "Завод №1" },
                new Facility { Id = 2, OrganizationId = organizationId, Name = "Завод №2" }
            };
            return Task.FromResult(facilities);
        }

        public Task<List<FacilitySystem>> GetSystemsAsync(int facilityId) // GetSystemsAsync
        {
            var systems = new List<FacilitySystem>
            {
                new FacilitySystem { Id = 1, FacilityId = facilityId, Name = "Система охлаждения" },
                new FacilitySystem { Id = 2, FacilityId = facilityId, Name = "Энергосистема" }
            };
            return Task.FromResult(systems);
        }

        public Task<List<EquipmentType>> GetEquipmentTypesAsync(int systemId)
        {
            var equipment = new List<EquipmentType>
            {
                new EquipmentType { Id = 1, TypeName = "Генератор" },
                new EquipmentType { Id = 2, TypeName = "Компрессор" },
                new EquipmentType { Id = 3, TypeName = "Труба" },
                new EquipmentType { Id = 4, TypeName = "Насос" }
            };
            return Task.FromResult(equipment);
        }
    }
}
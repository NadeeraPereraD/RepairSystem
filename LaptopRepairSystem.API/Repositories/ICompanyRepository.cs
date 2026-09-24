using LaptopRepairSystem.API.Entities;

namespace LaptopRepairSystem.API.Repositories.Company
{
    public interface ICompanyRepository
    {
        Task<Entities.Company?> GetCompanyAsync();

        Task<Entities.Company> CreateCompanyAsync(Entities.Company company);

        Task<Entities.Company?> UpdateCompanyAsync(Entities.Company company);
    }
}
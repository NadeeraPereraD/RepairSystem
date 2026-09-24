using LaptopRepairSystem.API.Data;
using LaptopRepairSystem.API.Entities;
using Microsoft.EntityFrameworkCore;

namespace LaptopRepairSystem.API.Repositories.Company
{
    public class CompanyRepository : ICompanyRepository
    {
        private readonly AppDbContext _context;

        public CompanyRepository(AppDbContext context)
        {
            _context = context;
        }

        public async Task<Entities.Company?> GetCompanyAsync()
        {
            return await _context.Companies
                .AsNoTracking()
                .FirstOrDefaultAsync();
        }

        public async Task<Entities.Company> CreateCompanyAsync(Entities.Company company)
        {
            _context.Companies.Add(company);

            await _context.SaveChangesAsync();

            return company;
        }

        public async Task<Entities.Company?> UpdateCompanyAsync(Entities.Company company)
        {
            var existingCompany = await _context.Companies
                .FirstOrDefaultAsync(x => x.CompanyId == company.CompanyId);

            if (existingCompany == null)
            {
                return null;
            }

            existingCompany.CompanyName = company.CompanyName;

            existingCompany.AddressLine1 = company.AddressLine1;
            existingCompany.AddressLine2 = company.AddressLine2;

            existingCompany.City = company.City;
            existingCompany.PostalCode = company.PostalCode;
            existingCompany.Province = company.Province;

            existingCompany.OwnerFirstName = company.OwnerFirstName;
            existingCompany.OwnerLastName = company.OwnerLastName;

            existingCompany.Email = company.Email;
            existingCompany.Telephone = company.Telephone;
            existingCompany.Mobile = company.Mobile;

            existingCompany.LogoPath = company.LogoPath;

            existingCompany.IsActive = company.IsActive;
            existingCompany.UpdatedDate = DateTime.Now;

            await _context.SaveChangesAsync();

            return existingCompany;
        }
    }
}
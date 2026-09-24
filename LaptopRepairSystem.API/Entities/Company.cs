namespace LaptopRepairSystem.API.Entities
{
    public class Company
    {
        public int CompanyId { get; set; }

        public string CompanyName { get; set; } = string.Empty;

        public string AddressLine1 { get; set; } = string.Empty;
        public string? AddressLine2 { get; set; }

        public string City { get; set; } = string.Empty;
        public string? PostalCode { get; set; }
        public string Province { get; set; } = string.Empty;

        public string OwnerFirstName { get; set; } = string.Empty;
        public string OwnerLastName { get; set; } = string.Empty;

        public string Email { get; set; } = string.Empty;
        public string? Telephone { get; set; }
        public string Mobile { get; set; } = string.Empty;

        public string? LogoPath { get; set; }

        public bool IsActive { get; set; }

        public DateTime CreatedDate { get; set; }
        public DateTime? UpdatedDate { get; set; }
    }
}
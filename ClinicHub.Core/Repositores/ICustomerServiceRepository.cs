using ClinicHub.Core.Entity;

namespace ClinicHub.Core.Repositores
{
    public interface ICustomerServiceRepository
    {
        Task<CustomerService?> GetCustomerServiceByIdAsync(int id);
        Task AddAsync(CustomerService customerService);
        Task<IEnumerable<CustomerService>> GetAllAsync(DateOnly? startDate, DateOnly? endDate, string? PatientName, string? DoctorName);
        Task DeleteAsync(int id);        
    }
}
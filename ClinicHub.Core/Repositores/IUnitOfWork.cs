namespace ClinicHub.Core.Repositores
{
    public interface IUnitOfWork
    {
        IConsultationTypeRepository ConsultationTypes { get; }
        ICustomerServiceRepository CustomerServices { get; }
        IHealthInsuranceRepository HealthInsurances { get; }
        IServiceRepository Services { get; }
        ISpecialtyRepository Specialties { get; }
        IPatientRepository Patients { get; }
        IUserRepository Users { get; }        
        Task<int> CompleteAsync();
    }
}

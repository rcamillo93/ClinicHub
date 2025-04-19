namespace ClinicHub.Core.Enums
{
    public enum PaymentStatusEnum
    {
        None,
        Pending,
        Processing,            
        Authorized,
        Completed,
        Failed,
        Refunded,
        Canceled,
        Chargeback,
        Voided
    }
}

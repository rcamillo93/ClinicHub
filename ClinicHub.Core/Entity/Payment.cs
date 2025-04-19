using ClinicHub.Core.Enums;

namespace ClinicHub.Core.Entity
{
    public class Payment : BaseEntity
    {
        public Payment(PaymentTypeEnum paymentType, decimal amount, DateTime paymentDate, int customerServiceId)
        {
            PaymentType = paymentType;
            Amount = amount;
            PaymentDate = paymentDate;
            CustomerServiceId = customerServiceId;
            PaymentStatus = PaymentStatusEnum.Pending;
        }

        public PaymentTypeEnum PaymentType { get; private set; }
        public decimal Amount { get; private set; }
        public DateTime PaymentDate { get; private set; }
        public int CustomerServiceId { get; private set; }
        public PaymentStatusEnum PaymentStatus { get; private set; }

    }
}

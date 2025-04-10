namespace ClinicHub.Core.Entity
{
    public class BaseEntity
    {
        protected BaseEntity()
        {                
        }

        public int Id { get; private set; }
        public DateTime CreatedAt { get; private set; } = DateTime.UtcNow;
        public DateTime UpdatedAt { get; set; }
        public bool IsDeleted { get; private set; } = false;

    }
}

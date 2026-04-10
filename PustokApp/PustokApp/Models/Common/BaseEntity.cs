namespace PustokApp.Models.Common
{
    public abstract class BaseEntity
    {
        public Guid Id { get; set; }
        protected BaseEntity()
        {
            Id = Guid.NewGuid();
        }
        
    }
    //public class AuditEntity : BaseEntity
    //{
    //    public DateTime CreatedDate { get; set; }
    //    public DateTime? ModifiedDate { get; set; }
    //    public bool IsDeleted { get; set; }
    //}
}

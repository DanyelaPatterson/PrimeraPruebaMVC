namespace PrimeraPruebaMVC.Entities
{
    public class BaseEntity
    {
        public BaseEntity()
        {

        }
        public Guid Id {get; set;}
        public DateTime CreationDate {get; set;}
        public DateTime? UpdatedDate {get; set;}
    }
}
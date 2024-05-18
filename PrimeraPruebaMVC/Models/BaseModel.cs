namespace PrimeraPruebaMVC.Models
{
    public class BaseModel
    {
        public BaseModel()
        {
            
        }
        public Guid Id { get; set; }
        public DateTime FechaCreacion { get; set; }
    }
}
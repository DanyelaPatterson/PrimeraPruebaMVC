namespace PrimeraPruebaMVC.Models
{
    public class EntityModel : BaseModel
    {
        public EntityModel()
        {

        }
        
        public int Matricula { get; set; }
        public string Nombre { get; set; }
        public string Carrera { get; set; }
        public int Edad { get; set; }
        public string Genero { get; set; }
    }
}
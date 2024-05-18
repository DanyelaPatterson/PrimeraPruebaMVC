namespace PrimeraPruebaMVC.Models
{
    public class StudentModel : EntityModel
    {
        public StudentModel()
        {
            Nombre = string.Empty;
            Carrera = string.Empty;
        }
        public string Nombre { get; set; }
        public string Carrera { get; set; }
        public DateTime FechaCreacion { get; set; }
    }
}
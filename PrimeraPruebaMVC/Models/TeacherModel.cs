namespace PrimeraPruebaMVC.Models
{
    public class TeacherModel : EntityModel
    {
        public TeacherModel()
        {

        }
        public string Nombre { get; set; }
        public string Materia { get; set; }
        public DateTime FechaContratacion { get; set; }
    }
}
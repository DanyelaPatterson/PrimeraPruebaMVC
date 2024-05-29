using System.ComponentModel.DataAnnotations;

namespace PrimeraPruebaMVC.Models
{
    public class StudentModel : EntityModel
    {
        public StudentModel()
        {
            
        }

        [Required (ErrorMessage = "El {0} es un campo requerido")]
        [StringLength(maximumLength: 50, MinimumLength = 3, ErrorMessage = "La longitud del campo {0} debe ser entre mínimo {2} y máximo de {1}")]

        public string Matricula { get; set; }
        public string Nombre { get; set; }
        public string Carrera { get; set; }
        public int Edad { get; set; }
        public string Genero { get; set; }
    }
}
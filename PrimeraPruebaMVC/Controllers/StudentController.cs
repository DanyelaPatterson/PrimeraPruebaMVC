using Microsoft.AspNetCore.Mvc;
using PrimeraPruebaMVC.Models;

namespace PrimeraPruebaMVC.Controllers
{
    public class StudentController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public StudentController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult StudentAdd()
        {
            return View();
        }

        [HttpPost]
        public IActionResult StudentAdd(StudentModel student)
        {
            if (!ModelState.IsValid)
            {
                _logger.LogWarning("El modelo no es valido");
                return View();
            }
            //GUARDAR INFORMACIÓN

            _logger.LogInformation("El modelo es valido");

            return Redirect("StudentList");
        }

    public IActionResult StudentList()
        {
            /*SECCIÓN DE LISTADO DE CARRERA*/

        _logger.LogInformation("Esto es un mensaje al cargar los alumnos");

            //CREAR OBJETOS DE CARRERAS
                StudentModel alumno = new StudentModel();
                alumno.Nombre = "Danyela Patterson";
                alumno.Carrera = "Ingeniería en Sistemas Computacionales";
                alumno.Edad = 24;
                alumno.Genero= "Mujer";

                StudentModel alumno1 = new StudentModel();
                alumno1.Nombre = "Ángel Chacon";
                alumno1.Carrera = "Ingeniería en Sistemas Computacionales";
                alumno1.Edad = 23;
                alumno1.Genero= "Hombre";

                StudentModel alumno2 = new StudentModel();
                alumno2.Nombre = "";


            alumno.FechaCreacion = new DateTime(2024, 05, 17);
            alumno1.FechaCreacion = new DateTime(2024, 05, 17);
            //OBJETO DE LISTAS DE CARRERA

            List<StudentModel> list = new List<StudentModel>();
            list.Add(alumno);
            list.Add(alumno1);

                return View(list);
        }

        public IActionResult StudentEdit(Guid Id)
        {
            StudentModel alumno = new StudentModel();
            alumno.Id = Id;
            alumno.Nombre = "Datos del estudiante cargados";
            return View(alumno);
        }

        [HttpPost]
        public IActionResult StudentEdit(StudentModel alumno)
        {
            if (!ModelState.IsValid)
            {
                _logger.LogWarning("El modelo no es valido");
                alumno.Nombre = "Estudiante no valido";
                return View(alumno);
            }
            //GUARDAR INFORMACIÓN

            _logger.LogInformation("Estudiante es valido");
            
            return Redirect("StudentList");
        }


    /*public IActionResult StudentSave()
        {
            //GUARDARLO EN LA BASE DE DATOS
            return Redirect("StudentList");
        }*/

        /*public IActionResult StudentShowAndEdit(Guid Id)
        {
            StudentModel alumno = new StudentModel();
            alumno.Id = Id;
            alumno.Nombre = "Alumno cargado";
            return View(alumno);
        }*/

        public IActionResult StudentShowToDelete(Guid Id)
        {
            //CON EL ID SE BUSCARA EN LA BD EL REGISTRO CORRESPONDIENTE.
            //DESPUÉS SE LE ASIGNA AL OBJETO.

            StudentModel alumno = new StudentModel();
            alumno.Id = Id;
            alumno.Nombre = "Alumno para borrar";
            return View(alumno);
        }

        [HttpPost]
        public IActionResult StudentDelete()
        {
            //BORRARLO EN LA BASE DE DATOS
            return Redirect("StudentList");
        }

    }
}
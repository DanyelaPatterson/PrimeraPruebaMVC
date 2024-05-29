using Microsoft.AspNetCore.Mvc;
using PrimeraPruebaMVC.Models;

namespace PrimeraPruebaMVC.Controllers
{
    public class TeacherController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public TeacherController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult TeacherAdd()
        {
            return View();
        }

        [HttpPost]
        public IActionResult TeacherAdd(TeacherModel teacher)
        {
            if (!ModelState.IsValid)
            {
                _logger.LogWarning("Los datos no son validos");
                return View();
            }
            //GUARDAR INFORMACIÓN

            _logger.LogInformation("Los datos son validos");

            return Redirect("TeacherList");
        }

        public IActionResult TeacherList()
        {
            /*SECCIÓN DE LISTADO DE CARRERA*/

        _logger.LogInformation("Esto es un mensaje al cargar los maestros");

            //CREAR OBJETOS DE CARRERAS
                TeacherModel maestro = new TeacherModel();
                maestro.Nombre = "Ricardo Arturo Elizalde Hernandez";
                maestro.Carrera = "Ingeniería en Sistemas Computacionales";
                maestro.Edad = 36;
                maestro.Genero= "Hombre";

                /*TeacherModel maestro1 = new TeacherModel();
                maestro1.Nombre = "Ángel Chacon";
                maestro1.Carrera = "Ingeniería en Sistemas Computacionales";
                maestro1.Edad = 23;
                maestro1.Genero= "Mujer";

                TeacherModel maestro2 = new TeacherModel();
                maestro2.Nombre = "";*/


            maestro.FechaCreacion = new DateTime(2024, 05, 17);
            //maestro1.FechaCreacion = new DateTime(2024, 05, 17);
            //OBJETO DE LISTAS DE CARRERA

            List<TeacherModel> ListTeacher = new List<TeacherModel>();
            ListTeacher.Add(maestro);
            //ListTeacher.Add(maestro1);

                return View(ListTeacher);
        }

        public IActionResult TeacherEdit(Guid Id)
        {
            TeacherModel maestro = new TeacherModel();
            maestro.Id = Id;
            maestro.Nombre = "Maestro Listo";
            return View(maestro);
        }

        [HttpPost]
        public IActionResult TeacherEdit(TeacherModel teacher)
        {
            if (!ModelState.IsValid)
            {
                _logger.LogWarning("El modelo no es valido");
                teacher.Nombre = "Maestro no valido";
                return View(teacher);
            }
            //GUARDAR INFORMACIÓN

            _logger.LogInformation("Maestro es valido");
            
            return Redirect("TeacherList");
        }


    public IActionResult TeacherSave()
        {
            //GUARDARLO EN LA BASE DE DATOS
            return Redirect("TeacherList");
        }

        public IActionResult TeacherShowAndEdit(Guid Id)
        {
            TeacherModel maestro = new TeacherModel();
            maestro.Id = Id;
            maestro.Nombre = "Maestro cargado";
            return View(maestro);
        }

        public IActionResult TeacherShowToDelete(Guid Id)
        {
            //CON EL ID SE BUSCARA EN LA BD EL REGISTRO CORRESPONDIENTE.
            //DESPUÉS SE LE ASIGNA AL OBJETO.

            TeacherModel maestro = new TeacherModel();
            maestro.Id = Id;
            maestro.Nombre = "maestro para borrar";
            return View(maestro);
        }

        [HttpPost]
        public IActionResult TeacherDelete()
        {
            //BORRARLO EN LA BASE DE DATOS
            return Redirect("TeacherList");
        }

    }
}
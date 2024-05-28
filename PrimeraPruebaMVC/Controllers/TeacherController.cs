using Microsoft.AspNetCore.Mvc;
using PrimeraPruebaMVC.Models;

namespace PrimeraPruebaMVC.Controllers
{
    public class TeacherController : Controller
    {
        public TeacherController()
        {

        }
        public IActionResult TeacherList()
        {
            TeacherModel maestro = new TeacherModel();
            maestro.Nombre = "Teresa Escobar";
            maestro.Carrera = "Licenciatura en Tecnologías de la Información";

            return View(maestro);
        }

        public IActionResult TeacherAdd()
        {
            return View();
        }

    }
}
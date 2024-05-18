using System.ComponentModel.Design;
using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using PrimeraPruebaMVC.Models;

namespace PrimeraPruebaMVC.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    public IActionResult Index()
    {
        return View();
    }

    public IActionResult Privacy()
    {
        return View();
    }

    public IActionResult StudentList()
    {
        StudentModel alumno = new StudentModel();
        alumno.Nombre = "Danyela Patterson";
        alumno.Carrera = "Ingeniería en Sistemas Computacionales";

        alumno.FechaCreacion = new DateTime(2024, 05, 17);
        return View(alumno);
    }

    public IActionResult TeacherList()
    {
        TeacherModel maestro = new TeacherModel();
        maestro.Nombre = "Teresa Escobar";
        maestro.Carrera = "Licenciatura en Tecnologías de la Información";

        maestro.FechaCreacion = new DateTime(2024, 05, 17);

            return View(maestro);
    }

    public IActionResult DegreeList()
        {
            DegreeModel degree = new DegreeModel();
            {
                degree.Nombre = "Ingeniería en Sistemas Computacionales";
            }

            return View(degree);
        }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}

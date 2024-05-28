using Microsoft.AspNetCore.Mvc;
using PrimeraPruebaMVC.Models;

namespace PrimeraPruebaMVC.Controllers
{
    public class DegreeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public DegreeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        [HttpPost]
        public IActionResult DegreeAdd()
        {
            return View();
        }

            [HttpPost]
        public IActionResult DegreeAdd(DegreeModel degree)
        {
            if (!ModelState.IsValid)
            {
                _logger.LogWarning("El modelo no es valido");
                return View();
            }
            //GUARDAR INFORMACIÓN

            _logger.LogInformation("El modelo es valido");

            return Redirect("DegreeList");
        }

        public IActionResult DegreeList()
        {
            /*SECCIÓN DE LISTADO DE CARRERA*/

        _logger.LogInformation("Esto es un mensaje al cargar las carreras");

            //CREAR OBJETOS DE CARRERAS
                DegreeModel carrera = new DegreeModel();
                carrera.Nombre = "Ingeniero en Tecnologías de Información";

                DegreeModel carrera2 = new DegreeModel();
                carrera2.Nombre = "Licenciado en Administración de Empresas";

                DegreeModel carrera3 = new DegreeModel();
                carrera3.Nombre = "Licenciado en Banca y Finanzas";

            //OBJETO DE LISTAS DE CARRERA

            List<DegreeModel> list = new List<DegreeModel>();
                list.Add(carrera);
                list.Add(carrera2);
                list.Add(carrera3);

                return View(list);
            

        }

        public IActionResult DegreeEdit(Guid Id)
        {
            DegreeModel carrera = new DegreeModel();
            carrera.Id = Id;
            carrera.Nombre = "Carrera cargada";
            return View(carrera);
        }

        [HttpPost]
        public IActionResult DegreeEdit(DegreeModel carrera)
        {
            if (!ModelState.IsValid)
            {
                _logger.LogWarning("El modelo no es valido");
                carrera.Nombre = "Carrera no valida";
                return View(carrera);
            }
            //GUARDAR INFORMACIÓN

            _logger.LogInformation("El modelo es valido");
            
            return Redirect("DegreeList");
        }

        public IActionResult DegreeShowToDelete(Guid Id)
        {
            //CON EL ID SE BUSCARA EN LA BD EL REGISTRO CORRESPONDIENTE.
            //DESPUÉS SE LE ASIGNA AL OBJETO.

            DegreeModel carrera = new DegreeModel();
            carrera.Id = Id;
            carrera.Nombre = "Carrera para borrar";
            return View(carrera);
        }

        [HttpPost]
        public IActionResult DegreeDelete()
        {
            //BORRA EL REGISTRO

            return Redirect("DegreeList");
        }
    }
}
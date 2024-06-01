using Microsoft.AspNetCore.Mvc;
using PrimeraPruebaMVC.Models;
using PrimeraPruebaMVC.Entities;

namespace PrimeraPruebaMVC.Controllers
{
    public class DegreeController : Controller
    {
        private readonly ILogger<DegreeController> _logger;
        private readonly ApplicationDbContext _context;

        public DegreeController(ApplicationDbContext context, ILogger<DegreeController> logger)
        {
            _logger = logger;
            _context = context;
        }

        public IActionResult DegreeAdd()
        {
            return View();
        }

            [HttpPost]
        public IActionResult DegreeAdd(DegreeModel carrera)
        {
            if (!ModelState.IsValid)
            {
                _logger.LogWarning(carrera.Nombre);
                _logger.LogWarning("El modelo no es valido");
                return View();
            }
            //GUARDAR INFORMACIÓN

            _logger.LogInformation("El modelo es valido");

            Degree degreeDB = new Degree();
            degreeDB.Id = new Guid();
            degreeDB.Name = carrera.Nombre;
            degreeDB.CreationDate = DateTime.Today;

            _context.Degrees.Add(degreeDB);
            _context.SaveChanges();

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
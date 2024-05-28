using Microsoft.AspNetCore.Mvc;
using PrimeraPruebaMVC.Models;

namespace PrimeraPruebaMVC.Controllers
{
    public class StudentController : Controller
    {
        public StudentController()
        {

        }
        public IActionResult StudentAdd()
        {
            return View();
        }
    public IActionResult StudentList()
    {
        StudentModel alumno = new StudentModel();
        alumno.Nombre = "Danyela Patterson";
        alumno.Carrera = "Ingeniería en Sistemas Computacionales";

        alumno.FechaCreacion = new DateTime(2024, 05, 17);

        List<StudentModel> ListStudents = new List<StudentModel>();
        ListStudents.Add(alumno);

        ListStudents.Add
        (
            new StudentModel()
            {
                Nombre= "Ángel Chacon"
            }
        );

        return View(ListStudents);
    }

    public IActionResult StudentSave()
        {
            //GUARDARLO EN LA BASE DE DATOS
            return Redirect("StudentList");
        }

        public IActionResult StudentShowAndEdit(Guid Id)
        {
            StudentModel alumno = new StudentModel();
            alumno.Id = Id;
            alumno.Nombre = "Alumno cargado";
            return View(alumno);
        }

        public IActionResult StudentShowToDelete(Guid Id)
        {
            //CON EL ID SE BUSCARA EN LA BD EL REGISTRO CORRESPONDIENTE.
            //DESPUÉS SE LE ASIGNA AL OBJETO.

            StudentModel alumno = new StudentModel();
            alumno.Id = Id;
            alumno.Nombre = "Alumno para borrar";
            return View(alumno);
        }

        public IActionResult StudentEdit()
        {
            //EDITARLO EN LA BASE DE DATOS
            return Redirect("StudentList");
        }

        public IActionResult StudentDelete()
        {
            //BORRARLO EN LA BASE DE DATOS
            return Redirect("StudentList");
        }

    }
}
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MarisolWeb.Controllers
{
    public class EnfermerosController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }

    public IActionResult CrearEnfermero(string nombre, string apellido, string cedula, string ocupacion, string lugarTrabajo, string horario)
    {
        var restulado = "";
        ViewBag.Enfermero = restulado;
        return View();
    }
}

}

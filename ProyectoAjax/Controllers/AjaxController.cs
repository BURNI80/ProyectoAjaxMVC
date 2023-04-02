using Microsoft.AspNetCore.Mvc;
using System.Security.Cryptography.X509Certificates;

namespace ProyectoAjax.Controllers
{
    public class AjaxController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public int GetDoble(int numero)
        {
            var doble = numero * 2;
            return doble;
        }

        public string LoadDartos()
        {
            string texto = "Esto es una peticion con ajax!!!";
            return texto;
        }

        public IActionResult PostAjax()
        {
            return View();
        }

        public IActionResult GetAjax()
        {
            return View();
        }


    }
}

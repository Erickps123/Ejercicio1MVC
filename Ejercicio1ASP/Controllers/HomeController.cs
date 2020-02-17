using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Ejercicio1ASP.Models;
using System.Text.Encodings.Web;

namespace Ejercicio1ASP.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
          
            
        }
        public IActionResult Index(Numero numero)
        {
            if (ModelState.IsValid)
            {
                int _numero = numero.number;
                string numeroInvertido = "";
                if (_numero > 10) { 
                    for(int i=_numero.ToString().Length-1; i >= 0; i--)
                    {
                        numeroInvertido += _numero.ToString()[i];
                    }
                }
                else
                {
                    numeroInvertido += "0" +_numero.ToString()[0];
                }
                ViewData["NumeroInver"] = numeroInvertido;
                //string _numeroI = digitos.ToString();
            }
            return View("Index");

        }
        public IActionResult Privacy(string n)
        {
          
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}

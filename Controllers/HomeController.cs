using MeuApp.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MeuApp.Controllers
{
    public class HomeController:Controller
    {
        public IActionResult Index()
        {
            ViewData["Hora"] = DateTime.Now.Hour.ToString();
            ViewData["Minuto"] = DateTime.Now.Minute.ToString();
            ViewBag.NomeDoClienteLogado = "Gestor";
            //acesso ao banco
            var cliente = new Cliente
            {
                Id = 123,
                Nome = "Luiz",
                SobreNome = "Fernando"
            };

            return View(cliente);
        }

        public IActionResult Sobre()
        {
            return View();
        }
    }
}

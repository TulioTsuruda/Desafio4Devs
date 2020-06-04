using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Desafio4Devs.Models;
using Desafio4Devs.Services.Interface;
using Desafio4Devs.Services;
using Microsoft.AspNetCore.Mvc.Rendering;
using Desafio4Devs.Repository;

namespace Desafio4Devs.Controllers
{
    public class ClienteController : Controller
    {
        private readonly IClienteService _cliService;

        public ClienteController()
        {
            _cliService = new ClienteService();
        }

        public ActionResult Cliente()
        {
            return View();
        }

        public void Create(Cliente newCli)
        {
            _cliService.addCliente(newCli);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}

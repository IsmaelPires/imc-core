using CalculoIMC.Models;
using IMC.Aplicacao.DTO;
using IMC.Aplicacao.Interfaces;
using IMC.Dominio.Entidades;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System.Diagnostics;

namespace IMC.Web.Controllers
{
    public class UsuarioController : ControllerBase<Usuario, UsuarioDTO>
    {
        private readonly ILogger<UsuarioController> _logger;

        public UsuarioController(IUsuarioApp app)
            : base(app)
        { }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Cadastro()
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

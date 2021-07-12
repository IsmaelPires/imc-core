using CalculoIMC.Models;
using IMC.Dominio.Entidades;
using IMC.Dominio.Interfaces.Repositorios;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Diagnostics;

namespace CalculoIMC.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IUsuarioRepositorio _usuarioRepositorio;

        public HomeController(ILogger<HomeController> logger,
            IUsuarioRepositorio usuarioRepositorio)
        {
            _logger = logger;
            _usuarioRepositorio = usuarioRepositorio;
        }

        public IActionResult Index()
        {
            var lista = _usuarioRepositorio.SelecionarTodos();
            return View("Index", lista);
        }

        public IActionResult Cadastro(int? id)
        {
            if (id <= 0 || id == null)
            {
                return View("Cadastro", new Usuario());
            }

            var usuario = _usuarioRepositorio.SelecionarPorId(id.Value);

            return View(usuario);
        }

        public void Editar(Usuario usuario)
        {
            try
            {
                _usuarioRepositorio.Alterar(usuario);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void Cadastrar(Usuario usuario)
        {
            try
            {
                _usuarioRepositorio.Incluir(usuario);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void Excluir(int id)
        {
            try
            {
                _usuarioRepositorio.Excluir(id);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}

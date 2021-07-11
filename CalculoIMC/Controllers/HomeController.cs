﻿using CalculoIMC.Models;
using IMC.Dominio.Entidades;
using IMC.Dominio.Interfaces.Repositorios;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

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
            return View();
        }

        public IActionResult Cadastro()
        {
            return View();
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

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
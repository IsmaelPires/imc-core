using IMC.Dominio.Entidades;
using IMC.Dominio.Interfaces.Repositorios;
using IMC.Infra.Data.Contextos;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
namespace IMC.Infra.Data.Repositorios
{
    public class UsuarioRepositorio : RepositorioBase<Usuario>, IUsuarioRepositorio
    {
        public UsuarioRepositorio(Contexto contexto)
            : base(contexto)
        {
        }
    }
}

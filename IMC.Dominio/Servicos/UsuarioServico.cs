using IMC.Dominio.Entidades;
using IMC.Dominio.Interfaces.Repositorios;
using IMC.Dominio.Interfaces.Servicos;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace IMC.Dominio.Servicos
{
    public class UsuarioServico : ServicoBase<Usuario>, IUsuarioServico
    {
        public UsuarioServico(IUsuarioRepositorio repositorio)
            : base(repositorio)
        {
        }
    }
}

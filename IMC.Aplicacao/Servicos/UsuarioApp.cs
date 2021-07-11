using AutoMapper;
using IMC.Aplicacao.DTO;
using IMC.Aplicacao.Interfaces;
using IMC.Dominio.Entidades;
using IMC.Dominio.Interfaces.Servicos;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace IMC.Aplicacao.Servicos
{
    public class UsuarioApp : ServicoAppBase<Usuario, UsuarioDTO>, IUsuarioApp
    {
        public UsuarioApp(IMapper iMapper, IUsuarioServico servico)
            : base(iMapper, servico)
        {

        }
    }
}
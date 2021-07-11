using AutoMapper;
using IMC.Aplicacao.DTO;
using IMC.Dominio.Entidades;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace IMC.Aplicacao
{
    public class MappingEntidade : Profile
    {
        public MappingEntidade()
        {
            CreateMap<Usuario, UsuarioDTO>();
        }
    }
}

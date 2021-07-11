using System;
using System.Collections.Generic;
using System.Text;

namespace IMC.Aplicacao.DTO
{
    public class UsuarioDTO : BaseDTO
    {
        public string Nome { get; set; }
        public string Peso { get; set; }
        public string Altura { get; set; }
    }
}

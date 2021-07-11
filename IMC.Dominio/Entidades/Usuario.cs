using System;
using System.Collections.Generic;
using System.Text;

namespace IMC.Dominio.Entidades
{
    public class Usuario : EntidadeBase
    {
        public string Nome { get; set; }

        public string Peso { get; set; }

        public string Altura { get; set; }

        public string Imc { get; set; }
    }
}

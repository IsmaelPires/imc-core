using IMC.Aplicacao.DTO;
using IMC.Dominio.Entidades;
using System;
using System.Collections.Generic;
using System.Text;

namespace IMC.Aplicacao.Interfaces
{
    public interface IAppBase<TEntidade, TEntidadeDTO>
        where TEntidade : EntidadeBase
        where TEntidadeDTO : BaseDTO
    {
        int Incluir(TEntidadeDTO entidade);
        void Excluir(int id);
        void Excluir(TEntidadeDTO entidade);
        void Alterar(TEntidadeDTO entidade);
        TEntidadeDTO SelecionarPorId(int id);
        IEnumerable<TEntidadeDTO> SelecionarTodos();
    }
}

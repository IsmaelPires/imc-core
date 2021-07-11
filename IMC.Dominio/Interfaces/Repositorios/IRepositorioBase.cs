using IMC.Dominio.Entidades;
using System.Collections.Generic;

namespace IMC.Dominio.Interfaces.Repositorios
{
    public interface IRepositorioBase<TEntidade>
        where TEntidade : EntidadeBase
    {
        int Incluir(TEntidade entidade);
        void Excluir(int id);
        void Excluir(TEntidade entidade);
        void Alterar(TEntidade entidade);
        TEntidade SelecionarPorId(int id);
        IEnumerable<TEntidade> SelecionarTodos();
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace QuickBuy.Dominio.Contratos
{
    public interface IBaseRepositorio<TEntidy> : IDisposable where TEntidy : class
    {
        void Adicionar(TEntidy entidy);
        TEntidy ObterPorID(int ID);
        IEnumerable<TEntidy> ObterTodos();
        void Atualizar(TEntidy entidy);
        void Remover(TEntidy entidy);

    }
}
